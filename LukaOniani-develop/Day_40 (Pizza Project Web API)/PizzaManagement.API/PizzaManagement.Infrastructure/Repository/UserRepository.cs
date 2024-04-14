using PizzaManagement.Application.Repositories;
using PizzaManagement.Domain.Entity;

namespace UserManagement.Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        #region PrivateField
        List<User> _users = new List<User>
        {
            new User { Id = 1, FirstName = "Luka", LastName = "Oniani", Email = "oniani.luka@kiu.edu.ge", PhoneNumber = "568400222", Addresses = new List<Address> { new Address { Id = 1, UserId = 1, City = "Kutaisi", Country = "Georgia", Region = "Imereti", Description = "Baratashvili street" }, new Address { Id = 2, UserId = 1, City = "Tbilisi", Country = "Georgia", Region = "Qartli", Description = "Work address" } } },
            new User { Id = 2, FirstName = "John", LastName = "Doe", Email = "johndoe@edu.ge", PhoneNumber = "555123123", Addresses = new List<Address> { new Address { Id = 3, UserId = 2, City = "Kobuleti", Country = "Georgia", Region = "Adjara", Description = "Vacation" } } },
        };
        #endregion

        public async Task Create(User user)
        {
            _users.Add(user);
        }

        public async Task Delete(int id)
        {
            var user = await Get(id);
            _users.Remove(user);
        }

        public async Task<bool> Exists(int id)
        {
            return await Task.FromResult(_users.Any(user => user.Id == id));
        }

        public async Task<User> Get(int id)
        {
            return await Task.FromResult(_users.Single(users => users.Id == id));
        }

        public async Task<List<User>> GetMany(params int[] id)
        {
            List<User> users = new List<User>();
            foreach (int i in id)
            {
                users.Add(await Get(i));
            }
            return users;
        }

        public async Task Update(User User)
        {
            _users[User.Id - 1] = User;

        }

        public async Task<int> Length()
        {
            return _users.Count;
        }

        public async Task<List<User>> GetAll()
        {
            return _users;
        }
    }
}
