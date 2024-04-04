using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FileProject
{
    public static class Gn
    {
        public static void Males(List<string> males)
        {
            Console.WriteLine("Male Records:");
            foreach (string maleLine in males)
            {
                string[] values = maleLine.Split(",");
                string id = values[0];
                string firstName = values[1];
                string lastName = values[2];
                string email = values[3];
                string gender = values[4];

                Console.WriteLine($"ID: {id}, FirstName: {firstName}, LastName: {lastName}, Email: {email}, Gender: {gender}");
            }
        }

        public static void Feales(List<string> females)
        {
            Console.WriteLine("Female Records:");
            foreach (string maleLine in females)
            {
                string[] values = maleLine.Split(",");
                string id = values[0];
                string firstName = values[1];
                string lastName = values[2];
                string email = values[3];
                string gender = values[4];

                Console.WriteLine($"ID: {id}, FirstName: {firstName}, LastName: {lastName}, Email: {email}, Gender: {gender}");
            }
        }

        public static void Others(List<string> Others)
        {
            Console.WriteLine("Other-gender Records:");
            foreach (string maleLine in Others)
            {
                string[] values = maleLine.Split(",");
                string id = values[0];
                string firstName = values[1];
                string lastName = values[2];
                string email = values[3];
                string gender = values[4];

                Console.WriteLine($"ID: {id}, FirstName: {firstName}, LastName: {lastName}, Email: {email}, Gender: {gender}");
            }
        }
    }
}
