using System.Collections.Concurrent;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ASS1_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question1

            /*
             public struct DeliveryAddress

            {
                public string City;
                public string Street;
            }


            public class Customer
            {
               public string Name;
            }

            
           a) What happens when a DeliveryAddress variable is copied into another variable and the copy is modified?

            becuase struct is a value type taking a copy means copying  the values only and changes in one variable doesnot affect on anthor variable.



           b) What happens when a Customer variable is copied into another variable and one variable modifies the object?

             becuase class is a refernce type taking a copy means refering to the same address and changes on one variable affects on anthor variable.
       
            */

            #endregion


            #region Question2

            /*

          public class Shipment

          {
              public string Description;
              public double Weight;
              public decimal DeliveryFee;
          }

       a.  Identify at least three problems with this design from an encapsulation perspective.

           public access modifier is aproblem that violates principle of encapsulation 
           through that any one can
          - access  and change data 
          - bypass my ruels 
          - put invalide data which can cuase bugs in the program


         b) How can private fields and public properties improve this design?

            private fields prevent direct access to data and public properties 
            allow controll access and allow validation this prevent invalid data
            enforec class rules 

          */


            #endregion


            #region Question3 

            #region DeliverySystem

            DeliveryCenter center = new DeliveryCenter();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"EnterShipment{i + 1}Data");
                Console.Write("TrackingCode: ");
                string t = Console.ReadLine();
                Console.Write("Description: ");
                string d = Console.ReadLine();

                Console.Write("Weight: ");
                decimal w = decimal.Parse(Console.ReadLine());

                Console.Write("DeliveryFee: ");
                decimal df = decimal.Parse(Console.ReadLine());


                Console.Write("City: ");
                string c = Console.ReadLine();


                Console.Write("Street: ");
                string st = Console.ReadLine();

                Console.Write("Building Number: ");
                int BuildingNumber = int.Parse(Console.ReadLine());
                DeliveryAddress D3 = new DeliveryAddress(c, st, BuildingNumber);

                Shipment s1 = new Shipment(t, d, w, df, D3);
                center.AddShipment(s1);
                Console.WriteLine("Shipment Added Successfully !");

            }

            Console.WriteLine("---AllShipments--");

            for (int i = 0; i < 3; i++)
            {

                center[i].PrintShipment();
                Console.WriteLine();
            }

            Console.Write("Enter a tracking code to search:");
            string tc = Console.ReadLine();

            Shipment foundCode = center[tc];
            if (foundCode != null)
            {
                Console.WriteLine($"Shipment found: {foundCode.TrackingCode} {foundCode.Description}");
            }

            else
            {
                Console.WriteLine("Shipment not found");
            }


            #endregion


            #region StructCopyTest

            Console.WriteLine("---StructCopyTest---");
            DeliveryAddress D1 = new DeliveryAddress("Cairo", "Tahrir Street", 15);
            DeliveryAddress D2 = D1;
            D2.City = "Giza";
            D2.Street = "Nile Street";
            D2.BuildingNumber = 5;
            Console.WriteLine($"Original Address:{D1.GetFullAddress()}");// origin var doesnot change 
            Console.WriteLine($"Copied Address:{D2.GetFullAddress()}");
            #endregion 
            #endregion
        }
    }
}
