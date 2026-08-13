using System;
using System.Collections.Generic;
using System.Text;

namespace OOP02
{
    internal class ExpressShipment : Shipment, ITrackable, IInsurable
    {
        private decimal extraFee;


        #region property
        public decimal ExtraFee
        {
            get { return extraFee; }
            set { extraFee = value >= 0 ? value : 0; }
        }

        public override decimal EstimatedCost
        {
            get { return DeliveryFee + ExtraFee + (decimal)(Weight * 5) ; }
        }
        #endregion

        #region Consrtuctor
        public ExpressShipment(decimal extraFee, string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extraFee;
        }
        #endregion

        #region Methods
        public override void PrintShipment()
        {
            Console.WriteLine($"The Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Delivery Fee: {DeliveryFee}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost}");
            Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
            Console.WriteLine($"Extra Fee: {ExtraFee}");
        }

        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is Out for Delivery.";
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.08m;
        }

        #endregion
    }
}
