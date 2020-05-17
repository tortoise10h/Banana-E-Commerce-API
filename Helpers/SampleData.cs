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

            /** admin 1 */
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

            /** admin 1 */
            var existedAdmin2 = context.Users.SingleOrDefault(u => u.Email == "minhminionadmin@gmail.com");
            Admin admin2 = new Admin
            {
                Name = "Minhminion Admin",
                Phone = "0112233444",
                Gender = Gender.Male
            };
            User adminUser2 = new User
            {
                Email = "minhminionadmin@gmail.com"
            };

            if (existedAdmin2 == null)
            {
                await adminService.CreateAsync(adminUser2, admin2, "12345678");
            }

            /** admin 3 */
            var existedAdmin3 = context.Users.SingleOrDefault(u => u.Email == "khoaadmin@gmail.com");
            Admin admin3 = new Admin
            {
                Name = "Khoa Admin",
                Phone = "0112233443",
                Gender = Gender.Male
            };
            User adminUser3 = new User
            {
                Email = "khoaadmin@gmail.com"
            };

            if (existedAdmin3 == null)
            {
                await adminService.CreateAsync(adminUser3, admin3, "12345678");
            }

            /** admin 1 */
            var existedAdmin4 = context.Users.SingleOrDefault(u => u.Email == "linhjavadmin@gmail.com");
            Admin admin4 = new Admin
            {
                Name = "Linh Jav Admin",
                Phone = "0112233442",
                Gender = Gender.Female
            };
            User adminUser4 = new User
            {
                Email = "linhjavadmin@gmail.com"
            };

            if (existedAdmin4 == null)
            {
                await adminService.CreateAsync(adminUser4, admin4, "12345678");
            }


        }
    }
}