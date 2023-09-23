using Microsoft.EntityFrameworkCore;

namespace NWindMVC.Models
{
   
        public class RepositoryCustomer
        {
            private NorthwindContext _context;
            public RepositoryCustomer(NorthwindContext context)
            {
                _context = context;
            }
            public List<string> GetAllCustomerId()
            {
                List<string> CustomerIDs = (from c in _context.Customers select c.CustomerId).ToList();
              
                return CustomerIDs;
            }
            public Customer FindCustomerById(int id)
            {
            Customer customer = _context.Customers.Find(id);

            return customer;
            }
            public List<Order> GetCustomerOrders(String id)
            {
            List<Order> Customerorders = (from c in _context.Orders where c.CustomerId==id select c).ToList();
            return null;
            }
        }

}
