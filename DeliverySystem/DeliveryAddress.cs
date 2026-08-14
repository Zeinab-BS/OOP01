using System;
using System.Collections.Generic;
using System.Text;

namespace ASS1_OOP
{
    internal struct DeliveryAddress
    {
        public string City;
        public string Street;
        public int BuildingNumber;

        public DeliveryAddress(string _city, string _street, int _bNum)

        {

            City = _city;
            Street = _street;
            BuildingNumber = _bNum;



        }

        public string GetFullAddress()
        {
            return $"Destination:{BuildingNumber}{Street},{City}";
        }








    }
}
