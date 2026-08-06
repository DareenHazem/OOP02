using System;
using System.Collections.Generic;
using System.Text;

namespace OOP02
{
    internal class DeliveryCenter
    {
        Shipment[] array ;
        String CenterName;

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
                        if (array[i] != null && array[i].TrackingCode  == Code)
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
                    if (array[i] == null)
                    {
                        array[i] = ship;
                        return true;
                    }
                }
            }
            
            return false;
        }

        public bool RemoveShipment(string trackingCode)
        {
            if ( (array == null) || this[trackingCode] == null ) 
            {
                return false;
            }
            else
            {
                int index = Array.IndexOf(array, this[trackingCode]);
                for (int i = index; i < array.Length - 1; i++)
                {
                    array[i] = array[i + 1];
                }
                array[array.Length-1] = null; 
                return true;
            }

        }

        public void PrintAllShipments()
        {
            foreach (Shipment shipment in array)
            {
                if (shipment != null)
                {
                    shipment.PrintShipment();
                    Console.WriteLine();
                }
                    
            }
        }


        #endregion

        public DeliveryCenter()
        {
            array = new Shipment[20];
        }
    }
}