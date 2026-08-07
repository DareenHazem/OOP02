using System;
using System.Collections.Generic;
using System.Text;

namespace OOP02
{
    internal class InternationalShipment : Shipment
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
    }
}