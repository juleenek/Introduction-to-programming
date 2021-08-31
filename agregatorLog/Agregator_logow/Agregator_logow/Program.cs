using System;
using System.Collections.Generic;

namespace Agregator_logow
{
    class Program
    {
        public class OneLog
        {
            private string name;
            private string log;
            private int duration;

            public string Name { get => name; set => name = value; }
            public string Log { get => log; set => log = value; }
            public int Duration { get => duration; set => duration = value; }

            public OneLog(string name, string log, int duration)
            {
                name = Name;
                log = Log;
                duration = Duration;
            }
        }
        static void Main(string[] args)
        {
            int testsCount = Convert.ToInt32(Console.ReadLine());
            

            for (int i = 0; i < testsCount; i++)
            {
                
                int test = Convert.ToInt32(Console.ReadLine());

            }
        }
    }
}
