using System;
using System.Collections.Generic;
using System.Text;

namespace OOP02
{
    internal class StandardShipment:Shipment, ITrackable, IInsurable
    {

        #region Constructors
        public StandardShipment(string trackingCode) :base(trackingCode)
        {

        }

        public StandardShipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination) : base(trackingCode, description , weight, deliveryFee, destination)
        {

        }
        #endregion
        public override decimal EstimatedCost => DeliveryFee + (decimal) (Weight* 5);

      

        #region Methods
        public override void PrintShipment()
        {
            Console.WriteLine($"The Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Delivery Fee: {DeliveryFee}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost}");
            Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.05m;
        }

        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is Ready.";
        }
        #endregion
    }
}
