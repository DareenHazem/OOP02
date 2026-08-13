using System;
using System.Collections.Generic;
using System.Text;

namespace OOP02
{
    internal sealed class CompletedShipment:Shipment
    {
        #region Constructors
        public CompletedShipment(string trackingCode) : base(trackingCode)
        {

        }

        public CompletedShipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination)
        {

        }

        public override decimal EstimatedCost => throw new NotImplementedException();

        public override void PrintShipment()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
