using IdentityPractice.Dtos;
using IdentityPractice.Types;

namespace IdentityPractice.Services
{
    public interface IUserService
    {
        Task<ServiceMessage> AddUser(AddUserDto user);
    }
}
