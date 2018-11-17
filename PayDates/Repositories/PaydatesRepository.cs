using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PayDates.Models;

namespace PayDates.Repositories
{
    public class PaydatesRepository
    {
        public List<DateTime> GetAllDates()
        {
            return new List<DateTime>();
        }

        public Paydate GetProductPaydate(int productId)
        {
            return new Paydate();
        }

        public void UpdateProductPaydate(Paydate paydate)
        {
        }
    }
}
