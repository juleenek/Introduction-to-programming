using System;
using System.Linq;

namespace PersonChild
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Test: tworzenie obiektu Child
   modyfikacja danych */
            try
            {
                Person o = new Person(familyName: "Molenda", firstName: "Krzysztof", age: 30);
                Person m = new Person(familyName: "Molenda", firstName: "Ewa", age: 29);
                Child d = new Child(familyName: "Molenda", firstName: "Anna", age: 14,
                                    mother: m, father: o);
                d.modifyFirstName("Aneta");
                Console.WriteLine(d);
                d.modifyFirstName("Kolenda");
                Console.WriteLine(d);
                d.modifyAge(18);
                Console.WriteLine(d);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    public class Person
    {
        private string firstName;
        private string familyName;
        private int age;

        public string FirstName
        {
            get => firstName;
            protected set => firstName = correctNames(value);
        }
        public string FamilyName
        {
            get => familyName;
            protected set => familyName = correctNames(value);
        }
        public int Age
        {
            get => age;
            protected set
            {
                if (value < 0) throw new ArgumentException("Age must be positive!");
                else age = value;
            }
        }
        private string correctNames(string name)
        {
            string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
            bool containsInt = name.Any(char.IsDigit);
            if (containsInt == true || string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Wrong name!");
            }
            foreach (var item in specialChar)
            {
                if (name.Contains(item))
                {
                    throw new ArgumentException("Wrong name!");
                }
            }
            name = name.Trim();
            name = name.Replace(" ", "");
            string afterName = char.ToUpper(name.First()) + name.Substring(1).ToLower();
            return afterName;
        }

        public Person(string firstName, string familyName, int age)
        {
            FirstName = firstName;
            FamilyName = familyName;
            Age = age;
        }

        public void modifyFirstName(string name) => FirstName = name;
        public void modifyFamilyName(string name) => FamilyName = name;
        public void modifyAge(int age) => Age = age;

        public override string ToString() => $"{FirstName} {FamilyName} ({Age})";
    }
    public class Child : Person
    {
        private int age;
        public new int Age
        {
            get => age;
            protected set
            {
                if (value > 15) throw new ArgumentException("Child’s age must be less than 15!"); 
                else if (value < 0) throw new ArgumentException("Age must be positive!"); 
                else  age = value;
            }
        }
        public Person Mother { get; private set; }
        public Person Father { get; private set; }
        public Child(string familyName, string firstName, int age, Person mother = null, Person father = null) : base(firstName, familyName, age)
        {
            Age = age;
            Mother = mother;
            Father = father;
        }
        public new void modifyAge(int age) => Age = age;
        public override string ToString()
        {
            return $"{FirstName} {FamilyName} ({age})\n" + $"mother: {Mother?.ToString() ?? "No data"}\n" + $"father: {Father?.ToString() ?? "No data"}";
        }
    }
}
