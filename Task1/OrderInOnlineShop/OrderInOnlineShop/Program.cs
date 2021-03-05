using System;
using System.Collections.Generic;

namespace OrderInOnlineShop
{
    class Order
    {
        public List<float> shopitems { get; set; }
        public List<float> discounts { get; set; }

        public float[] orderitem = { 100.0f, 112.2f, 301.1f };
        public float[] discountitem = { 10.0f, 0.0f, 0.0f };

        public Order(List<float> shopitems, List<float> discounts)
        {
            this.shopitems = shopitems;
            this.discounts = discounts;
        }

        public float CalculateSum()
        {
            float sum = 0;
            float temp;
            float price;
            
            for(int i=0; i<orderitem.Length; i++)
            {
                temp = discountitem[i] / 100;
                temp *= orderitem[i];
                price = orderitem[i] - temp;

                sum += price;
            }

            return sum;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order(new List<float>(), new List<float>());
            float sum = order.CalculateSum();
            Console.WriteLine(sum);
        }
    }
}
