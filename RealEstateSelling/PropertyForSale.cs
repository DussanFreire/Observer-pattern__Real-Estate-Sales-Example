using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateSelling
{
    public abstract class PropertyForSale
    {
        private double _price;
        private List<IPotentialBuyer> _potentialBuyers= new List<IPotentialBuyer>();

        public long Id { get; set; }
        public PropertyForSale(long id,double price)
        {
            Id = id;
            _price = price;
        }

        protected PropertyForSale(double price)
        {
            Price = price;
        }

        public void Attach(IPotentialBuyer potentialBuyer)
        {
            _potentialBuyers.Add(potentialBuyer);
        }

        public void Detach(IPotentialBuyer potentialBuyer)
        {
            _potentialBuyers.Remove(potentialBuyer);
        }

        public void Notify(bool priceReduced = true)
        {
            foreach (IPotentialBuyer potentialBuyer in _potentialBuyers)
            {
                potentialBuyer.Update(this, priceReduced);
            }

        }

        public double Price
        {
            get { return _price; }
            set
            {
                if (_price != value)
                {
                    bool priceReduced = value < _price ? true : false;
                    _price = value;
                    Notify(priceReduced); 
                }
            }
        }
    }
}
