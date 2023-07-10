using BookReading.Event.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 
// buisness - data ,repo

// model - foundation

namespace BookReading.Event.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly UserManager<IdentityUser> _userManager; //create a field
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountRepository(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager) //create a constructor for usermanager and signin manager
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        //signup
        public async Task<IdentityResult> CreateUserAsync(SignUpViewModel userModel)
        {
            var user = new ApplicationUser()
            {
                Email = userModel.Email,
                UserName = userModel.UserName
            };
            var result = await _userManager.CreateAsync(user, userModel.Password);    //await keyword for async method
            return result;
        }

        //signin
        public async Task<SignInResult> PasswordSignInAsync(LoginViewModel loginModel)
        {
            var result = await _signInManager.PasswordSignInAsync(loginModel.UserName, loginModel.Password,true, false);
            return result;
        }
    }
}
