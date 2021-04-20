using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateSelling
{
    internal class PotentialBuyer :IPotentialBuyer
    {
        private string _name;
        private double _purchaseThreshold;

        public PotentialBuyer(string name, double purchaseThreshold)
        {
            _name = name;
            _purchaseThreshold = purchaseThreshold;
        }

        public void Update(PropertyForSale propertyForSale, bool priceReduced = true)
        {
            Console.WriteLine("Notified {0} of {1} with id: {2}," + " price was {3} to {4:C}.", _name, propertyForSale.GetType().Name, propertyForSale.Id, (priceReduced ? "reduced":"increased"),propertyForSale.Price);
            if (propertyForSale.Price < _purchaseThreshold)
            {
                Console.WriteLine(_name + " wants to buy the " + propertyForSale.GetType().Name + $" with the id: {propertyForSale.Id}!");
            }
        }
    }
}