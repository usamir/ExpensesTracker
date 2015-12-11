using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.Identity;

namespace ToptalExpensesTrackerAPI.Validators
{
    public class AppCustomPassValidator : PasswordValidator
    {

        public override async Task<IdentityResult> ValidateAsync(string password)
        {
            IdentityResult result = await base.ValidateAsync(password);

            if (password.Contains("abcdef") || password.Contains("123456"))
            {
                var errors = result.Errors.ToList();

                errors.Add("Password cannot contain sequences of characters.");

                result = new IdentityResult(errors);
            }

            return result;
        }

    }
}