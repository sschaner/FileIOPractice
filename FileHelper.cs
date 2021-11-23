using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileIOPractice
{
    public static class FileHelper
    {
        public static List<Person> BuildAddressList(string path)
        {
            List<Person> addressList = new List<Person>();
            using (StreamReader reader = new StreamReader(path))
            {
                string lineText;
                while ((lineText = reader.ReadLine()) != null)
                {
                    string[] items = lineText.Split('|');
                    if (items.Length != 6)
                    {
                        continue;
                    }
                    Person person = new Person();
                    person.FirstName = items[0];
                    person.LastName = items[1];
                    person.Street = items[2];
                    person.City = items[3];
                    person.State = (State)Enum.Parse(typeof(State), items[4]);
                    person.Zip = int.Parse(items[5]);
                    addressList.Add(person);
                }
            }
            return addressList;
        }

        public static void AddPersonToFile(string path, Person person)
        {
            StreamWriter writer = new StreamWriter(path, true);
            StringBuilder builder = new StringBuilder();
            builder.Append(person.FirstName);
            builder.Append("|");
            builder.Append(person.LastName);
            builder.Append("|");
            builder.Append(person.Street);
            builder.Append("|");
            builder.Append(person.City);
            builder.Append("|");
            builder.Append(person.State);
            builder.Append("|");
            builder.Append(person.Zip);
            writer.WriteLine(builder.ToString());
            writer.Flush();
            writer.Close();
        }
    }
}
