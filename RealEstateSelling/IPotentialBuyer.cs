using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateSelling
{
    public interface IPotentialBuyer
    {
        void Update(PropertyForSale propertyForSale, bool priceReduced = true);
    }
}