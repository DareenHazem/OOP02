using System;
using System.Collections.Generic;
using System.Text;

namespace OOP02
{
    internal class PriorityInternationalShipment : InternationalShipment
    {
        #region Constructors
        public PriorityInternationalShipment(string destinationCountry, decimal customsFee, string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination) : base(destinationCountry, customsFee, trackingCode, description, weight, deliveryFee, destination)
        {

        }
        #endregion

        #region Methods
        public sealed override void GenerateCustomsReport()
        {
            Console.WriteLine("Class Priority International Shipment ");
            Console.WriteLine($"Customs Report\n Customs Fee: {CustomsFee}");
        }
        #endregion
    }
}
