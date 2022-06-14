using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_CollectionView.Models
{
    public class StockCard
    {

        public StockCard()
        {
            Name = RandomString(10);
            Price = RandomPrice(5);
        }

        public string Name { get; set; }

        public string Price { get; set; }


        private Random random = new Random();

        public string RandomString(int length)
        {
            try
            {
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                return new string(Enumerable.Repeat(chars, length)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string RandomPrice(int length)
        {
            try
            {
                const string chars = "123456789";
                return new string(Enumerable.Repeat(chars, length)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
