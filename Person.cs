﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FileIOPractice
{
    public class Person : Address
    {
        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
    }
}
