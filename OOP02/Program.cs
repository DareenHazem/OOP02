namespace OOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 : Theoretical Questions

            #region Question 01
            //public struct DeliveryAddress { 
            //      public string City;
            //      public string Street;
            //}
            //public class Customer {
            //      public string Name;
            //}
            // a) What happens when a DeliveryAddress variable is copied into another variable and the copy is modified?
            // b) [What happens when a Customer variable is copied into another variable and one variable modifies the object

            // 1- Struct is a value type so there won't be change in the original value cuz the variable only have copy of the original value not access to it
            // 2- Class is a refernce type and we copy the address so they refere to the same object in heap so any it will change the original value
            #endregion

            #region Question 02
            /*public struct Shipment{
               public string Description; 
               public double Weight; 
               public decimal DeliveryFee;
               } 
             a) Identify at least three problems with this design from an encapsulation perspective.
             b) How can private fields and public properties improve this design?
             */


            // 1-  (1) Anyone can access the fields directly and modify it
            //     (2) There is no validations so it will icrease bugs
            //     (3) Any change in the class code will affect the other files 

            // 2-  (1) Not everyone will have access diectly to the fields so we will protect data
            //     (2) It will reduce the bugs cuz there will be validations
            //     (3) We can change only in the class file without affecting other code so it will reduce errors
            #endregion

            #endregion


            #region Part 02 : Practical

            #region  DeliveryAddress - Quesetion01
            // Create one DeliveryAddress value, copy it into a second variable, modify the copy,
            // and print both values to prove that the original did not change.

            //DeliveryAddress delivery01 = new("Cairo", "5 street", 10);
            //DeliveryAddress delivery02 = delivery01;
            //delivery02.city = "Giza";
            //delivery02.street = "7 street";
            //delivery02.buildingNumber = 3;
            //Console.WriteLine(delivery01.GetFullAddress());
            //Console.WriteLine(delivery02.GetFullAddress()); 
            #endregion



            #endregion


            // Class
            #region Part 01 : Theoretical Questions - Classes

            #region Question 1
            //Answer the following questions:
            //a) What is the difference between a class and a struct?
            //b) Why are classes more suitable than structs for large applications?

            // 1- Struct is value type and Class is reference type, the Struct objects is stored in th stack (short lived and lightweight objects due to memory size)
            // but the Class objects is stored in heap (complex data )
            // Struct doesn't support inhertiance but Class support the 4 pillars (Encapsulation -  Inhertiacne - Polymorphism - Abstraction)


            // 2- Class objects is stored in heap and the object can store a lot of complex data and memory is dynamically allocated
            // but the struct is limited to it's size that can lead to stack overflow

            #endregion

            #region Question 2
            //a) Which class is the parent class?
            //b) Which class is the child class?
            //c) What members are inherited by ExpressShipment?
            //d) Why is inheritance better than duplicating the same code in multiple classes?

            //1- Shipment
            //2- Express Shipment
            //3- TrackingCode
            //4- Avoid code replication - Suitable for Useability 

            #endregion
            #endregion

            #region Indexer Main

            #region Queations a b c d e f g
            ////a
            //DeliveryCenter deliveryCenter = new DeliveryCenter();


            ////-----------------------READ DATA------------------------
            ////b
            //int size = 3;
            //for (int i = 0; i < size; i++)

            //{
            //    Console.Write($"Enter Shipment {i + 1} Data\n");

            //    string TrackC;
            //    do
            //    {
            //        Console.Write("Enter Tracking Code: ");
            //        TrackC = Console.ReadLine();
            //    }
            //    while (string.IsNullOrWhiteSpace(TrackC));

            //    string Desc;
            //    do
            //    {
            //        Console.Write("Enter Description: ");
            //        Desc = Console.ReadLine();
            //    }
            //    while (string.IsNullOrWhiteSpace(Desc));

            //    double w;
            //    bool isparsed;
            //    do
            //    {
            //        Console.Write("Enter Weight: ");
            //        isparsed = double.TryParse(Console.ReadLine(), out w);
            //    }
            //    while (!isparsed);

            //    decimal d;
            //    do
            //    {
            //        Console.Write("Enter Delivery Fee: ");
            //        isparsed = decimal.TryParse(Console.ReadLine(), out d);
            //    }
            //    while (!isparsed);

            //    string ct;
            //    do
            //    {
            //        Console.Write("Enter City: ");
            //        ct = Console.ReadLine();
            //    }
            //    while (string.IsNullOrWhiteSpace(ct));

            //    string st;
            //    do
            //    {
            //        Console.Write("Enter Street: ");
            //        st = Console.ReadLine();
            //    }
            //    while (string.IsNullOrWhiteSpace(st));

            //    int bn;
            //    do
            //    {
            //        Console.Write("Enter Building Number: ");
            //        isparsed = int.TryParse(Console.ReadLine(), out bn);
            //    }
            //    while (!isparsed);

            //    Console.WriteLine();


            //    //c
            //    //-----------------------ADD SHIPMENT------------------------
            //    Shipment ship = new(TrackC, Desc, w, d, new(ct, st, bn));
            //    deliveryCenter.AddShipment(ship);
            //}

            ////-----------------------PRINT------------------------

            ////d
            //Console.Clear();
            //Console.WriteLine($"All Shipments");
            //for (int j = 0; j < size; j++)
            //{
            //    Console.WriteLine($"Shipment Data {j + 1}");
            //    deliveryCenter[j].PrintShipment();
            //    Console.WriteLine();
            //}

            ////-----------------------SEARCH------------------------
            //string TrackCode;
            //do
            //{
            //    Console.WriteLine("Enter a tracking code to search:");
            //    TrackCode = Console.ReadLine();
            //}
            //while (string.IsNullOrWhiteSpace(TrackCode));

            //if (deliveryCenter[TrackCode].Equals(default(Shipment)))
            //{
            //    Console.WriteLine($"Shipment not found {TrackCode}");
            //}
            //else
            //{
            //    Console.WriteLine("found");
            //}

            #endregion

            #region Demonstrate the DeliveryAddress struct copy behavior
            //Console.WriteLine("--- Struct Copy Test ---");
            //DeliveryAddress delivery01 = new("Cairo", "Tahrir Street", 15);
            //DeliveryAddress delivery02 = delivery01;
            //delivery02.street = "Makram Ebeid Street";
            //delivery02.buildingNumber = 20;
            //Console.WriteLine($"Original Address: { delivery01.GetFullAddress()}");
            //Console.WriteLine($"Copied Address: {delivery02.GetFullAddress()}");
            #endregion

            #endregion

            // After Converting into Class - Adding Classes
            #region Demonstrate Class Relationships
            //StandardShipment SS = new("WDERS", "Order 1", 57.5, 8557, new("Cairo", "Street 1", 5));
            //ExpressShipment ES = new(895,"WDERS", "Order 1", 57.5, 8557, new("Cairo", "Street 1", 5));
            //InternationalShipment IS = new("Egypt",809,"WDERS", "Order 1", 57.5, 8557, new("Cairo", "Street 1", 5));
            #endregion

            #region Class Main
            //// 1- Create a DeliveryCenter.
            //DeliveryCenter deliveryCenter = new DeliveryCenter();

            ////2- Read the center name from the user.
            //string centerName;
            //do
            //{
            //    Console.Write("Enter center Name: ");
            //    centerName = Console.ReadLine();
            //}
            //while (string.IsNullOrWhiteSpace(centerName));


            ////3- Create one StandardShipment.
            //StandardShipment SS;

            ////4- Create one ExpressShipment.
            //ExpressShipment ES;

            ////5- Create one InternationalShipment.
            //InternationalShipment IS;

            ////6- Read all shipment data from the user.
            ////7-Add the shipments to the delivery center.
            //#region StandardShipment
            //Console.WriteLine("\nEnter Standard Shipment Data");
            //string TrackC;
            //do
            //{
            //    Console.Write("Enter Tracking Code: ");
            //    TrackC = Console.ReadLine();
            //}
            //while (string.IsNullOrWhiteSpace(TrackC));

            //string Desc;
            //do
            //{
            //    Console.Write("Enter Description: ");
            //    Desc = Console.ReadLine();
            //}
            //while (string.IsNullOrWhiteSpace(Desc));

            //double w;
            //bool isParsed;
            //do
            //{
            //    Console.Write("Enter Weight: ");
            //    isParsed = double.TryParse(Console.ReadLine(), out w);
            //}
            //while (!isParsed);

            //decimal d;
            //do
            //{
            //    Console.Write("Enter Delivery Fee: ");
            //    isParsed = decimal.TryParse(Console.ReadLine(), out d);
            //}
            //while (!isParsed);

            //StandardShipment standardShipment = new StandardShipment(TrackC, Desc, w, d, new DeliveryAddress(centerName, "Street 7", 5));
            //deliveryCenter.AddShipment(standardShipment);
            //#endregion

            //#region ExpressShipment
            //Console.WriteLine("\nEnter Express Shipment Data");

            //do
            //{
            //    Console.Write("Enter Tracking Code: ");
            //    TrackC = Console.ReadLine();
            //}
            //while (string.IsNullOrWhiteSpace(TrackC));

            //do
            //{
            //    Console.Write("Enter Description: ");
            //    Desc = Console.ReadLine();
            //}
            //while (string.IsNullOrWhiteSpace(Desc));

            //do
            //{
            //    Console.Write("Enter Weight: ");
            //    isParsed = double.TryParse(Console.ReadLine(), out w);
            //}
            //while (!isParsed);

            //do
            //{
            //    Console.Write("Enter Delivery Fee: ");
            //    isParsed = decimal.TryParse(Console.ReadLine(), out d);
            //}
            //while (!isParsed);

            //decimal Extrafee;
            //do
            //{
            //    Console.Write("Enter Extrafee: ");
            //    isParsed = decimal.TryParse(Console.ReadLine(), out Extrafee);
            //}
            //while (!isParsed);


            //ExpressShipment expressShipment = new ExpressShipment(Extrafee, TrackC, Desc, w, d, new DeliveryAddress(centerName, "Street 988", 1));
            //deliveryCenter.AddShipment(expressShipment);

            //#endregion

            //#region InternationalShipment
            //Console.WriteLine("\nEnter International Shipment Data");
            //do
            //{
            //    Console.Write("Enter Tracking Code: ");
            //    TrackC = Console.ReadLine();
            //}
            //while (string.IsNullOrWhiteSpace(TrackC));

            //do
            //{
            //    Console.Write("Enter Description: ");
            //    Desc = Console.ReadLine();
            //}
            //while (string.IsNullOrWhiteSpace(Desc));

            //do
            //{
            //    Console.Write("Enter Weight: ");
            //    isParsed = double.TryParse(Console.ReadLine(), out w);
            //}
            //while (!isParsed);

            //do
            //{
            //    Console.Write("Enter Delivery Fee: ");
            //    isParsed = decimal.TryParse(Console.ReadLine(), out d);
            //}
            //while (!isParsed);

            //string destinationCountry;
            //do
            //{
            //    Console.Write("Enter Destination Country: ");
            //    destinationCountry = Console.ReadLine();
            //}
            //while (string.IsNullOrWhiteSpace(destinationCountry));

            //decimal customsFee;
            //do
            //{
            //    Console.Write("Enter Customs Fee: ");
            //    isParsed = decimal.TryParse(Console.ReadLine(), out customsFee);
            //}
            //while (!isParsed);

            //InternationalShipment internationalShipment = new InternationalShipment(destinationCountry, customsFee, TrackC, Desc, w, d, new DeliveryAddress(centerName, "Street 413", 123));
            //deliveryCenter.AddShipment(internationalShipment);

            //#endregion

            //// 8- Print all shipments.
            //   Console.Clear();
            //   deliveryCenter.PrintAllShipments();

            ////9- 
            //do
            //{
            //    Console.WriteLine("\nEnter a tracking code to search:");
            //    TrackC = Console.ReadLine();
            //}
            //while (string.IsNullOrWhiteSpace(TrackC));

            //if (deliveryCenter[TrackC]== default)
            //{
            //    Console.WriteLine($"Shipment not found {TrackC}");
            //}
            //else
            //{
            //    Console.WriteLine("found");
            //}

            ////10 - Remove one shipment using its tracking code.
            //Console.WriteLine("\nEnter Tracking Code to Remove");
            //do
            //{
            //    Console.Write("Enter Tracking Code: ");
            //    TrackC = Console.ReadLine();
            //}
            //while (string.IsNullOrWhiteSpace(TrackC));

            //if (deliveryCenter.RemoveShipment(TrackC))
            //{
            //    Console.WriteLine("Shipment Removed Successfully.");
            //}
            //else
            //{
            //    Console.WriteLine("Shipment not found.");
            //}

            ////11- Print the remaining shipments.
            //Console.WriteLine("\nRemaining Shipments");
            //deliveryCenter.PrintAllShipments();

            #endregion

            #region Assignment 3 

            #region Part 01 — Theoretical Questions

            #region Question 01
            //Q1 Overloading, Overriding, and Binding
            //a) What is the difference between Method Overloading and Method Overriding?
            //b) What is the difference between Static Binding and Dynamic Binding?

            // 1- Overloading is multiple methods with the same name but (different paramters - datatypes - order)
            // Overriding allows the child class to have a specific implemantion of a method that is already in the parent class

            // 2- Static binding is resolved in the compile time the compiler decided by the reference type by using(new or nothig)
            // Dynamic Binding is resolved in the run time the runtime decided by the object type by using(virtual and override)
            #endregion

            #region Question 02
            //Q2 Sealed Classes and Methods
            //a) What is the purpose of the sealed keyword when applied to a class?
            //b) What is the difference between a sealed class and a sealed method?
            //c) Can a sealed method be overridden? Why?

            //1- To prevent inheritance to other classes 
            //2- Sealed class means that class prevent inheritance to other classes but sealed method to prevent further overriding
            //3- No, cuz it prevent further overriding meaning no child classes will have a specific implemantion of the Method
            #endregion

            #endregion
            #endregion


        }
    }
}