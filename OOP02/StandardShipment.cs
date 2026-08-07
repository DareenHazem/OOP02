using System;
using System.Collections.Generic;
using System.Text;

namespace OOP02
{
    internal class StandardShipment:Shipment
    {

        #region Constructors
        public StandardShipment(string trackingCode) :base(trackingCode)
        {

        }

        public StandardShipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination) : base(trackingCode, description , weight, deliveryFee, destination)
        {

        }
        #endregion

        #region Methods
        public override void PrintShipment()
        {
            base.PrintShipment();
        }
        #endregion
    }
}
