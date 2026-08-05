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


            #endregion




        }
    }
}