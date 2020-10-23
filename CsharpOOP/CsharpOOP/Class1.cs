using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpOOP
{
    class Person
    {

        public string FirstName {get; set;}

        public string LastName { get; set; }

        private int _age;


        public int Age
        {
            get
            {

                return _age;

            }

            set
            {
                if (value <0)
                {
                    throw new Exception("Age must be greater than or equal to zero ");
                }
                _age = value;
                

            }
        }


        public void Birthday()
        {
            Age += 1;
        }


        public Person()
        {
            FirstName = "John";
            LastName = "Doe";
            Age = 20;
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = 20;
        }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
    }
}
