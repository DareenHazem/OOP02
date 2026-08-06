using System;
using System.Collections.Generic;
using System.Text;

namespace OOP02
{
    internal class DeliveryCenter
    {
        Shipment[] array ;

        #region Properties 
        public Shipment this[int index] {
            get
            {
                if(array!=null && array.Length > index)
                {
                    return array[index];
                }
                return default;
            }
            set
            {
                if (array != null && array.Length > index)
                {  
                    array[index] = value;
                }       
            }

        }

        public Shipment this[String Code] {
            get
            {
                if (array != null)
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i].TrackingCode  == Code)
                            return array[i];
                    }
                }
                return default;
            }
        }

        public Boolean AddShipment(Shipment ship)
        {
            if(array != null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (string.IsNullOrEmpty(array[i].TrackingCode))
                    {
                        array[i] = ship;
                        return true;
                    }
                }
            }
            
            return false;
        }

        #endregion

        public DeliveryCenter()
        {
            array = new Shipment[10];
        }
    }
}