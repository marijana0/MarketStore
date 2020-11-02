using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore.models
{
    class SilverCard : Card
    {
        public SilverCard(int ownerId, decimal turnover)
        {
            OwnerId = ownerId;
            Turnover = turnover;
            if (turnover > 300)
            {
                DiscountRate = 0.035m;
            }
            else
                DiscountRate = 0.02m;
        }
    }
}
