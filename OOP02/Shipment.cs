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
        // Static Field
        public static int TotalShipmentsCreated = 0;
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
        public abstract decimal EstimatedCost { get; }

        #endregion

        #region Constructor 
        public Shipment(string trackingCode)
        {
            this.trackingCode = !string.IsNullOrWhiteSpace(trackingCode) ? trackingCode : "Unknown";
            description = "Unknown";
            weight = 1;
            deliveryFee = 50;
            Destination = new DeliveryAddress("Unknown", "Unknown", 0); // or Destination = default;
            TotalShipmentsCreated++;
        }

        public Shipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination)
        {
            this.trackingCode = !string.IsNullOrWhiteSpace(trackingCode) ? trackingCode : "Unknown";
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;
            TotalShipmentsCreated++;
        }

        #endregion

        #region Methods 
        public void UpdateDeliveryFee(decimal newFee)
        {
            DeliveryFee = newFee > 0 ? newFee : DeliveryFee;
        }

        public abstract void PrintShipment();
        

        public void UpdateWeight(double weight)
        {
            Weight = weight;
        }

        public void UpdateWeight(double weight, double  packingWeight)
        {
            Weight = weight+ packingWeight;
        }
        public Shipment CopyShipment()
        {
            return (Shipment)this.MemberwiseClone();
        }

        public Shipment ShallowCopy()
        {
            return (Shipment)this.MemberwiseClone();
        }

        public Shipment DeepCopy()
        {
            Shipment copy = (Shipment)MemberwiseClone();
            copy.Destination = Destination is null?new DeliveryAddress("Unknown", "Unknown",0) : new DeliveryAddress(Destination.city, Destination.street, Destination.buildingNumber);
            return copy;
        }
        #endregion
    }
}