using System;
using System.Collections.Generic;
using System.Text;

namespace FileIOPractice
{
    public class Address
    {
        private string street;
        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        private string city;
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        private State state;
        public State State
        {
            get { return state; }
            set { state = value; }
        }
        private int zip;
        public int Zip
        {
            get { return zip; }
            set { zip = value; }
        }
    }
}
