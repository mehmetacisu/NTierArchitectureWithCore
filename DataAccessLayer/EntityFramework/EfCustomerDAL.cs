using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfCustomerDAL : GenericRepository<Customer>, ICustomerDAL
    {
        public List<Customer> GetCustomersWithJob()
        {
            using (var db = new Context())
            {
                return db.Customers.Include(x => x.Job).ToList();
            }
        }
    }
}
