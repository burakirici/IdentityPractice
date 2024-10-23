using IdentityPractice.Context;
using IdentityPractice.Dtos;
using IdentityPractice.Entities;
using IdentityPractice.Services;
using IdentityPractice.Types;

namespace IdentityPractice.Managers
{
    public class UserManager : IUserService
    {
        private readonly CustomIdentityDbContext _db;
        public UserManager(CustomIdentityDbContext db)
        {
            _db = db;
        }
        public async Task<ServiceMessage> AddUser(AddUserDto user)
        {
            var newUser = new UserEntity
            {
                Email = user.Email,
                Password = user.Password,
            };

            _db.Users.Add(newUser);
            _db.SaveChanges();

            return new ServiceMessage
            {
                IsSucceed = true,
                Message = "Kayıt Başarıyla oluşturuldu!"
            };
        }
    }
}
