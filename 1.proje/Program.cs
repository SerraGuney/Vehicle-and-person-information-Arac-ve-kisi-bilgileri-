using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static _1.proje.Program;

namespace _1.proje
{
    internal class Program
    {
        public class Information
        {
            public string name { get; set; }
            public string surname { get; set; }
            public string birthYear { get; set; }
            public long TC { get; set; }
            public string vehicleType { get; set; }
            public string vehicleModel { get; set; }
            public int vehicleYear { get; set; }
            public string vehicleBrand { get; set; }
            public long vehiclePrice { get; set; }

            public char[] vehicleİD = new char[17];
            public void offerInformation()
            {
                Console.WriteLine("name:" + name + "  " + "surname:" + surname + "  " + "birth year:" + birthYear + "  " + "TC:" + TC);
                Console.WriteLine("\n");
                Console.WriteLine("vehicleType:" + vehicleType + "  " + "vehicleModel:" + vehicleModel + "  " + "vehicleYear:" + vehicleYear + "   " + "vehicleBrand:" + vehicleBrand + "   " + "vehiclePrice:" + vehiclePrice);
                Console.Write("vehicleİD:");
                for (int i = 0; i < 9; i++)
                {
                    if (i != 3 && i != 8)
                    {

                        vehicleİD[i] = '*';

                    }
                    Console.Write(vehicleİD[i]);
                }               
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("how many vehicles do you have?:");
            int vehicleNumber = Convert.ToInt32(Console.ReadLine());
            List<Information> persons = new List<Information>();
            while (true)
            {
                Console.Write("Informations of person and vehicle=0,offer of information=1,exit=2 ***chose:");
                int choose;
                choose = Convert.ToInt32(Console.ReadLine());
                if (choose == 2)
                {
                    break;
                }
                switch (choose)
                {
                    case 0:
                        for (int a = 0; a < vehicleNumber; a++)
                        {
                            Information person = new Information();
                            Console.Write("Name: ");
                            person.name = Console.ReadLine();
                            Console.Write("Surname: ");
                            person.surname = Console.ReadLine();
                            Console.Write("year of birth:");
                            person.birthYear = Console.ReadLine();
                            Console.Write("TC:");
                            person.TC = Convert.ToInt64(Console.ReadLine());
                            Console.Write("type of vehicle:");
                            person.vehicleType = Console.ReadLine();
                            Console.Write("model of vehicle :");
                            person.vehicleModel = Console.ReadLine();
                            Console.Write("year of vehicle:");
                            person.vehicleYear = Convert.ToInt32(Console.ReadLine());
                            Console.Write("brand of vehicle:");
                            person.vehicleBrand = Console.ReadLine();
                            Console.Write("price of vehicle:");
                            person.vehiclePrice = Convert.ToInt64(Console.ReadLine());
                            Console.Write("İD of vehicle:");
                            for (int i = 0; i < 9; i++)
                            {
                                person.vehicleİD[i] = Convert.ToChar(Console.ReadLine());
                            }
                            persons.Add(person);
                        }
                        break;
                    case 1:
                        foreach (var person1 in persons)
                        {
                            person1.offerInformation();
                            Console.WriteLine("\n");
                        }
                        break;
                }
            }
        }
    }
}

