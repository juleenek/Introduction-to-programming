using System;

namespace PhoneClass
{
    class Program
    {
        static void Main(string[] args)
        {
            string owner = "Julia";
            string number = "123456789";
            int phoneBookCapacity = 100;
            Phone p;
            p = new Phone(owner, number, phoneBookCapacity);
            p.AddContact("Ann", "333222111");
            p.Call("Ann");

        }
    }
}
