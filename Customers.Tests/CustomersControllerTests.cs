using System.Linq;
using System.Threading.Tasks;
using GroceryStoreAPI.Controllers;
using GroceryStoreAPI.Models;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace Tests
{
    public class CustomersControllerTest
    {
        protected DbContextOptions<CustomerContext> ContextOptions;
        #region Seeding

        private void SeedOptions()
        {
            ContextOptions = new DbContextOptionsBuilder<CustomerContext>()
                .UseInMemoryDatabase(databaseName: "CustomersDataBase")
                .Options;
        }
        #endregion

        #region CanGetCustomers
        [Fact]
        public async Task Can_get_Customers()
        {
            SeedOptions();

            using (var context = new CustomerContext(ContextOptions))
            {
                var controller = new CustomersController(context);

                var customers = await controller.GetCustomers();

                Assert.NotNull(customers);              
            }
        }
        #endregion

        [Fact]
        public void Can_get_Customer()
        {
            SeedOptions();

            using (var context = new CustomerContext(ContextOptions))
            {
                var controller = new CustomersController(context);

                var result = controller.GetCustomer(1);

                Assert.Equal(1, result.Id);
            }
        }

        #region CanAddCustomer
        [Fact]
        public void Can_add_Customer()
        {
            SeedOptions();

            using (var context = new CustomerContext(ContextOptions))
            {
                var controller = new CustomersController(context);

                var result = controller.PostCustomer(new Customer() { Id = 6, Name = "larry" });

                Assert.Equal("larry", result.Result.Value.Name);
                Assert.Equal(6, result.Result.Value.Id);
            }
        }
        #endregion

        #region CanUpdateCustomer
        [Fact]
        public void Can_add_tag_when_already_existing_tag()
        {
            SeedOptions();

            using (var context = new CustomerContext(ContextOptions))
            {
                var controller = new CustomersController(context);

                var result = controller.PutCustomer(5, context.Customers.Single(p => p.Id == 3));

                Assert.NotNull(result);
            }
        }
        #endregion

        #region DeleteCustomer
        [Fact]
        public void Can_remove_Customer_and_all_associated_tags()
        {
            SeedOptions();

            using (var context = new CustomerContext(ContextOptions))
            {
                var controller = new CustomersController(context);

                var result = controller.DeleteCustomer(2);

                Assert.Equal(2, result.Result.Value.Id);
            }
        }
        #endregion
    }
}
