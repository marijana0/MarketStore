using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore.models
{
    public abstract class Card
    {
        private int _ownerId;
        private decimal _turnover;
        private decimal _discountRate;
        public int OwnerId
        {
            get => _ownerId;
            set
            {
                try
                {
                    _ownerId = value;
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("Exception caught: {0}"+ e.Message);
                }
            }
        }
        public decimal Turnover
        {
            get => _turnover;
            set
            {
                try
                {
                    _turnover = value;
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("Exception caught: {0}" + e.Message);
                }
            }
        }
        public decimal DiscountRate
        {
            get => _discountRate;
            set
            {
                try
                {
                    _discountRate = value;
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("Exception caught: {0}" + e.Message);
                }
            }
        }
        public void CurrentPurchase(decimal purchaseValue)
        {
            Console.WriteLine("Purchase value: $" + purchaseValue.ToString());
            Console.WriteLine("Discount rate:{0} %", (DiscountRate * 100).ToString("0.00"));
            Console.WriteLine("Discount: $" + (purchaseValue * DiscountRate).ToString("0.00"));
            Console.WriteLine("Total: $" + (purchaseValue - DiscountRate * purchaseValue).ToString("0.00"));
        }

    }
}
