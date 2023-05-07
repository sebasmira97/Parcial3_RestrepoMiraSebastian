using WashingCar.DAL.Entities;
using WashingCar.Enums;
using WashingCar.Helpers;

namespace WashingCar.DAL
{
    public class SeederDb
    {
        private readonly DatabaseContext _context;
        private readonly IUserHelper _userHelper;

        public SeederDb(DatabaseContext context, IUserHelper userHelper)
        {
            _context = context;
            _userHelper = userHelper;
        }

        public async Task SeederAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            //await PopulateTicketsAsync();
            await PopulateRolesAsync();
            await PopulateUserAsync("1017246390", "Admin", "Role", "admin-role@yopmail.com",
                "3112003587", UserType.Admin);
            await PopulateUserAsync("10203040", "Client", "Role", "client-role@yopmail.com",
                "3002003587", UserType.Client);
            await _context.SaveChangesAsync();
        }
        private async Task PopulateRolesAsync()
        {
            await _userHelper.CheckRoleAsync(UserType.Admin.ToString());
            await _userHelper.CheckRoleAsync(UserType.Client.ToString());
        }
        private async Task PopulateUserAsync(string document ,string firstName, string lastName,
            string email, string phone, UserType userType)
        {
            User user = await _userHelper.GetUserAsync(email);

            if (user == null)
            {
                user = new User
                {
                    Document = document,
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    UserName = email,
                    PhoneNumber = phone,
                    UserType = userType,
                };

                await _userHelper.AddUserAsync(user, "123456");
                await _userHelper.AddUserToRoleAsync(user, user.UserType.ToString());
            }
        }
    }
}
