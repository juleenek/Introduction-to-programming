using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneClass
{
    public class Phone
    {
        private string owner;

        /// <summary>
        /// Property okreslające właściciela telefonu, read-only
        /// </summary>
        /// <exception cref="ArgumentException">Owner name is empty or null!</exception>
        public string Owner
        {
            get => owner;
            private set
            {
                if (value == null || value == "")
                {
                    throw new ArgumentException("Owner name is empty or null!");
                }
                owner = value;
            }
        }

        private string phoneNumber;

        /// <summary>
        /// Property określające numer telefonu (nie null, dokładnie 9 cyfr), read-only
        /// </summary>
        /// <value>string of 9 digits</value>
        /// <exception cref="ArgumentException">Phone number is empty or null!</exception>
        /// <exception cref="FormatException">Invalid phone number!</exception>
        public string PhoneNumber
        {
            get => phoneNumber;
            private set
            {
                if (value == null)
                {
                    throw new ArgumentException("Phone number is empty or null!");
                }
                else if (value.Length != 9)
                {
                    throw new FormatException("Invalid phone number!");
                }
                phoneNumber = value;
            }
        }


        /// <summary>
        /// Weryfikuje poprawność numeru telefonu: nie null, długości 9, tylko cyfry
        /// </summary>
        /// <param name="number">string opisujący numer telefonu</param>
        /// <returns>true - jeśli numer poprawny, w przeciwnym przypadku false</returns>
        private bool IsCorrectPhoneNumber(string phoneNumber)
        {
            if (phoneNumber != null && phoneNumber.Length == 9)
            {
                foreach (char c in phoneNumber)
                {
                    if (c < '0' || c > '9')
                        return false;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Maksymalny rozmiar ksiażki kontaktowej (read-only)
        /// </summary>
        public readonly int PhoneBookCapacity;

        // Dictionary of <name, number>
        private readonly Dictionary<string, string> phoneBook;


        /// <summary>
        /// Tworzy obiekt typu Phone, w oparciu o podane parametry
        /// </summary>
        /// <param name="owner">właściciel telefonu</param>
        /// <param name="phoneNumber">numer telefonu, dokładnie 9 cyfr</param>
        /// <param name="phoneBookCapacity">pojemnosć książki adresowej</param>
        public Phone(string owner, string phoneNumber, int phoneBookCapacity = 100)
        {
            this.owner = owner;
            this.phoneNumber = phoneNumber;
            this.phoneBook = new Dictionary<string, string>(100);
            this.PhoneBookCapacity = phoneBookCapacity;
        }

        /// <summary>
        /// Zwraca liczbę wpisów do książki kontaktowej telefonu
        /// </summary>        
        public int Count => phoneBook.Count;

        /// <summary>
        /// Dodaje kontakt do ksiażki kontaktowej telefonu
        /// </summary>
        /// <param name="name">nazwa właściciela numeru</param>
        /// <param name="number">numer telefonu</param>
        /// <returns>true - jeśli kontakt został dopisany, false w przeciwnym przypadku</returns>
        /// <exceprion cref="InvalidOperationException">książka adresowa jest pełna</exception>
        public bool AddContact(string name, string number)
        {
            if (phoneBook.Count <= PhoneBookCapacity || phoneBook == null)
            {
                phoneBook.Add(name, number);
                return true;
            }
            else
            {
                throw new InvalidCastException("Książka adresowa jest pełna");
            }

        }

        /// <summary>
        /// Operacja uruchomienia połączenia
        /// </summary>
        /// <param name="name">kontakt, do którego dzwonimy</param>
        /// <returns>tekst komunikatu o formacie "Calling {number} ({name}) ..."</returns>
        /// <exception cref="InvalidOperationException">Osoby nie ma w książce kontaktów</exception>
        public string Call(string name)
        {
            foreach (var item in phoneBook)
            {
                if (name == item.Key)
                {
                    return $"Calling {phoneBook[name]} ({name}) ...";
                }
            }
            throw new InvalidOperationException("Osoby nie ma w książce kontaktów");
        }
    }
}
