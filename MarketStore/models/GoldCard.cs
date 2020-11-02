using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore.models
{
    class GoldCard : Card
    {
        public GoldCard(int ownerId, decimal turnover)
        {
            OwnerId = ownerId;
            Turnover = turnover;
            if (turnover < 100)
            {
                DiscountRate = 0.02m;
            }
            else if (turnover > 10)
            {
                DiscountRate = 0.1m;
            }
            else
                DiscountRate = 0.02m + (Math.Truncate(turnover / 100)) * 0.01m;
        }
    }
}
