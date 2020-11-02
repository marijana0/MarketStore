using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore.models
{
    class BronzeCard : Card
    {
        public BronzeCard(int ownerId, decimal turnover)
        {
            OwnerId = ownerId;
            Turnover = turnover;
            if (turnover < 100)
            {
                DiscountRate = 0;
            }
            else if (turnover >= 100 && turnover <= 300)
            {
                DiscountRate = 0.01m;
            }
            else
                DiscountRate = 0.025m;
        }
    }
}
