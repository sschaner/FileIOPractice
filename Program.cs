using System;
using System.Collections.Generic;

namespace FileIOPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string addressPath = @"C:\Users\schan\Documents\Web Development\Education\Grand Circus\Full Stack C# .NET Bootcamp\Notes Code\FileIOPractice\addressList.txt";
            FileHelper.BuildAddressList(addressPath);

            Person personOne = new Person
            {
                FirstName = "John",
                LastName = "Doe",
                Street = "123 Main St.",
                City = "Anywhere",
                State = State.MI,
                Zip = 12345
            };

            FileHelper.AddPersonToFile(addressPath, personOne);

            Console.ReadKey();
        }
    }
}
