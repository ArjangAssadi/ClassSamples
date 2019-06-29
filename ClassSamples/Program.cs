using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSamples
{
    partial class Program
    {
        static void Main(string[] args)
        {

            Person student1 = new Person();
            student1.FirstName = "John"; 
            student1.LastName = "Smith";
            student1.DOB = new DateTime(1900, 10, 1);

            Address address1 = new Address();
            address1.Line1 = "Line 1";
            address1.Line2 = "Line 2";
            address1.City = "canberra";
            address1.State_Province = "ACT";
            address1.Country = "Australia";

            Information si1 = new Information();
            si1.Title = "Student Information";
            si1.Person = student1;
            si1.Address = address1;



            Console.WriteLine( "{0}" , si1.Title );
            Console.WriteLine("{0}|{1}|{2}|{3}", si1.Person.FirstName, si1.Person.LastName, si1.Address.Line1 , si1.Address.Line2  );




            Console.ReadLine();

        }


    }
    }
