using Mapster;
using PizzaManagement.Application.Entities.AddressFolder;
using PizzaManagement.Application.Repositories;
using PizzaManagement.Domain.Entity;

namespace PizzaManagement.Infrastructure.Repository
{
    public class AddressRepository : IAddressRepository
    {
        #region PrivateField
        List<Address> _addresses = new List<Address>
        {
            new Address { Id = 1, UserId = 1, City = "Kutaisi", Country = "Georgia", Region = "Imereti", Description = "Home address" },
            new Address { Id = 2, UserId = 1, City = "Tbilisi", Country = "Georgia", Region = "Qartli", Description = "Work address" },
            new Address { Id = 3, UserId = 2, City = "Kutaisi", Country = "Georgia", Region = "Imereti", Description = "Villa" },
            new Address { Id = 4, UserId = 2, City = "Kobleti", Country = "Georgia", Region = "Adjara", Description = "Vacation" },
        };
        #endregion

        public async Task Create(Address Address)
        {
            _addresses.Add(Address);
        }

        public async Task Delete(int id)
        {
            var Address = await Get(id);
            _addresses.Remove(Address);
        }

        public async Task<bool> Exists(int id)
        {
            return await Task.FromResult(_addresses.Any(Address => Address.Id == id));
        }

        public async Task<Address> Get(int id)
        {
            return await Task.FromResult(_addresses.Single(Addresss => Addresss.Id == id));
        }

        public async Task<List<Address>> GetMany(params int[] id)
        {
            List<Address> Addresss = new List<Address>();
            foreach (int i in id)
            {
                Addresss.Add(await Get(i));
            }
            return Addresss;
        }

        public async Task Update(Address Address)
        {
            _addresses[Address.Id - 1] = Address;
        }

        public async Task<int> Length()
        {
            return _addresses.Count;
        }

        public async Task<List<Address>> GetAll()
        {
            return _addresses;
        }
    }
}
