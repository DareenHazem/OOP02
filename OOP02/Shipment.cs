using System;
using System.Collections.Generic;
using System.Text;

namespace OOP02
{
    abstract internal class Shipment
    {
        // Attributes
        string trackingCode;
        string description;
        double weight;
        decimal deliveryFee;

        #region Properties
        public DeliveryAddress Destination
        {
            get; set;
        }

        public string TrackingCode
        {
            get { return trackingCode; }
        }

        public string Description
        {
            get { return description; }
            set { description = !string.IsNullOrWhiteSpace(value) ? value : description; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value > 0 ? value : weight; }
        }
        public decimal DeliveryFee
        {
            get { return deliveryFee; }
            private set { deliveryFee = value; }
        }
        public virtual decimal EstimatedCost
        {
            get { return DeliveryFee + (decimal)(Weight * 5); }
        }
        #endregion

        #region Constructor 
        public Shipment(string trackingCode)
        {
            this.trackingCode = !string.IsNullOrWhiteSpace(trackingCode) ? trackingCode : "Unknown";
            description = "Unknown";
            weight = 1;
            deliveryFee = 50;
            Destination = new DeliveryAddress("Unknown", "Unknown", 0); // or Destination = default;

        }

        public Shipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination)
        {
            this.trackingCode = !string.IsNullOrWhiteSpace(trackingCode) ? trackingCode : "Unknown";
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;
        }

        #endregion

        #region Methods 
        public void UpdateDeliveryFee(decimal newFee)
        {
            DeliveryFee = newFee > 0 ? newFee : DeliveryFee;
        }

        public virtual void PrintShipment()
        {
            Console.WriteLine($"The Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Delivery Fee: {DeliveryFee}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost}");
            Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
        }

        public void UpdateWeight(double weight)
        {
            Weight = weight;
        }

        public void UpdateWeight(double weight, double  packingWeight)
        {
            Weight = weight+ packingWeight;
        }
        #endregion
    }
}