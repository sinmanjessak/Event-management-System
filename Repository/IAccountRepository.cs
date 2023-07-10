using BookReading.Event.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace BookReading.Event.Repository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> CreateUserAsync(SignUpViewModel userModel);
        Task<SignInResult> PasswordSignInAsync(LoginViewModel loginModel);
    }
}