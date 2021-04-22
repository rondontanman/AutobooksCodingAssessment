using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GroceryStoreAPI.Models
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> _options) 
            : base(_options) 
        {         
        }
        
        public DbSet<Customer> Customers { get; set; }
        public List<Customer> SeedData()
        {
            var customers = new List<Customer>();
            using (StreamReader r = new StreamReader(@"database.json"))
            {
                string json = r.ReadToEnd();
                customers = JsonConvert.DeserializeObject<List<Customer>>(json);
            }

            return customers;
        }

        public void UpdateJSON()
        {
            var jsonData = JsonConvert.SerializeObject(Customers);
            File.WriteAllText(@"database.json", jsonData);
        }
        
    }
}
