using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class MarketManager:IMarketManager
    {
        public void Add(Market market)
        {
            Console.WriteLine("Item is added to your cart successfully!");
        }
        public void Remove(Market market)
        {
            Console.WriteLine("Item is removed from your cart successfully!");
        }
        public void Update(Market market)
        {
            Console.WriteLine("Your cart is successfully updated!");
        }
    }
}
