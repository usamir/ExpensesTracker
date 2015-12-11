using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Routing;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ToptalExpensesTrackerAPI.Models
{
    public class ModelFactory
    {

        #region Field

        private UrlHelper _UrlHelper;
        private ApplicationUserManager _AppUserManager;

        #endregion

        #region Constructor

        public ModelFactory(HttpRequestMessage request, ApplicationUserManager appUserManager)
        {
            _UrlHelper = new UrlHelper(request);
            _AppUserManager = appUserManager;
        }

        #endregion
 
        #region Member functions

        public UserReturnModel Create(ApplicationUser appUser)
        {
            return new UserReturnModel
            {
                Url = _UrlHelper.Link("GetUserById", new { id = appUser.Id }),
                Id = appUser.Id,
                UserName = appUser.UserName,
                FirstName = appUser.FirstName,
                LastName = appUser.LastName,
                Email = appUser.Email,
                Roles = _AppUserManager.GetRolesAsync(appUser.Id).Result
            };
        }

        public RoleReturnModel Create(IdentityRole appRole)
        {

            return new RoleReturnModel
            {
                Url = _UrlHelper.Link("GetRoleById", new { id = appRole.Id }),
                Id = appRole.Id,
                Name = appRole.Name
            };
        }

        public ExpenseModel Create(Expense appExpense)
        {

            return new ExpenseModel
            {
                Id = appExpense.Id,
                DateTime = appExpense.DateTime,
                Amount = appExpense.Amount,
                Comment = appExpense.Comment,
                Description = appExpense.Description,
                UserId = appExpense.UserId
            };
        }

        #endregion
    }

    public class UserReturnModel
    {
        public string Url { get; set; }
        public string Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public IList<string> Roles { get; set; }
    }

    public class RoleReturnModel
    {
        public string Url { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class ExpenseModel
    {
        public int Id { get; set; }

        public DateTime DateTime { get; set; }

        public string Description { get; set; }

        public double Amount { get; set; }

        public string Comment { get; set; }

        public string UserId { get; set; }
    }
}