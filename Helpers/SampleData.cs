using Banana_E_Commerce_API.Services;
using Banana_E_Commerce_API.Entities;
using Banana_E_Commerce_API.Enums;
using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace Banana_E_Commerce_API.Helpers
{
    public class SampleData
    {
        public static async Task Intitialize(IServiceScope serviceScope)
        {
            var context = serviceScope.ServiceProvider.GetService<DataContext>();
            var adminService = serviceScope.ServiceProvider.GetService<IAdminService>();
            var existedAdmin1 = context.Users.SingleOrDefault(u => u.Email == "tortoiseadmin@gmail.com");

            Admin admin1 = new Admin
            {
                Name = "Tortoise Admin",
                Phone = "0112233445",
                Gender = Gender.Male
            };
            User adminUser1 = new User
            {
                Email = "tortoiseadmin@gmail.com"
            };

            if (existedAdmin1 == null)
            {
                await adminService.CreateAsync(adminUser1, admin1, "12345678");
            }


        }
    }
}