using System;
using System.Collections.Generic;
using System.Text;

namespace OOP02
{
    internal class InternationalShipment : Shipment, ITrackable
    {
        private string destinationCountry;
        private decimal customsFee;

        #region Properties
        public string DestinationCountry
        {
            get { return destinationCountry; }
            set{ destinationCountry = !string.IsNullOrWhiteSpace(value) ? value : "Unknown";
            }
        }

        public decimal CustomsFee
        {
            get { return customsFee; }
            set{customsFee = value >= 0 ? value : 0;}
        }

        public override decimal EstimatedCost
        {
            get{ return DeliveryFee + (decimal)(Weight * 5) + CustomsFee;}
        }
        #endregion

        #region Constructor
        public InternationalShipment(string destinationCountry, decimal customsFee, string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;
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
            Console.WriteLine($"Destination Country: {DestinationCountry}");
            Console.WriteLine($"Customs Fee: {CustomsFee}");
        }

        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine($"Customs Report\n Customs Fee: {CustomsFee}");
        }

        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} has been Delivered.";
        }
        #endregion
    }
}