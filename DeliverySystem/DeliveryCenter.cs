using System;
using System.Collections.Generic;
using System.Text;

namespace ASS1_OOP
{
    internal class DeliveryCenter
    {


        private Shipment[] shipment;

        public DeliveryCenter()
        {
            shipment = new Shipment[10];

        }

        #region indexres
        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < shipment.Length)
                {
                    return shipment[index];

                }

                return null;

            }

            set
            {
                if (index >= 0 && index < shipment.Length)
                {
                    shipment[index] = value;

                }


            }

        }

        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < shipment.Length; i++)
                {
                    if (shipment[i] != null && shipment[i].TrackingCode == trackingCode)
                    {
                        return shipment[i];
                    }

                }
                return null;

            }

        }










        #endregion



        #region AddShipment


        public bool AddShipment(Shipment s)
        {
            for (int i = 0; i < shipment.Length; i++)
            {
                if (shipment[i] == null)
                {
                    shipment[i] = s;
                    return true;
                }

            }

            return false;
        }






        #endregion




    }
}
