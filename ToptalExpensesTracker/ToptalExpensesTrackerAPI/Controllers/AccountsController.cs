using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Security;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using ToptalExpensesTrackerAPI.Models;

namespace ToptalExpensesTrackerAPI.Controllers
{
    [RoutePrefix("api/accounts")]
    public class AccountsController : BaseApiController
    {
        // GET api/accounts/users
        // Method is responsible to return all the registered users in our system by calling the enumeration
        // "Users" coming from "ApplicationUserManager" class
        [Authorize(Roles = "Admin,User Manager")]
        [Route("users")]
        public IHttpActionResult GetAllUsers()
        {
            return Ok(this.AppUserManager.Users.ToList().Select(u => this.TheModelFactory.Create(u)));
        }

        // GET api/accounts/user/{id:guid}
        // Method is responsible to return single user by providing it is unique identifier and calling the method
        // "FindByIdAsync" coming from "ApplicationUserManager" class
        [Authorize(Roles = "Admin,User Manager")]
        [Route("user/{id:guid}", Name = "GetUserById")]
        public async Task<IHttpActionResult> GetUserById(string Id)
        {
            var user = await this.AppUserManager.FindByIdAsync(Id);

            if (user != null)
            {
                return Ok(this.TheModelFactory.Create(user));
            }

            return NotFound();

        }

        // GET api/accounts/user/{username}
        // Method is responsible to return single user by providing it is username and calling the method
        // "FindByNameAsync" coming from "ApplicationUserManager" class
        [Authorize(Roles = "Admin,User Manager")]
        [Route("user/{username}")]
        public async Task<IHttpActionResult> GetUserByUsername(string username)
        {
            var user = await this.AppUserManager.FindByNameAsync(username);

            if (user != null)
            {
                return Ok(this.TheModelFactory.Create(user));
            }

            return NotFound();

        }

        [AllowAnonymous]
        // POST api/accounts/Register
        [Route("register")]
        public async Task<IHttpActionResult> Register(RegisterBindingModel model)
        {
            // check is model valid, based on the data annotations 
            // we introduced in class “AccountBindingModels”
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // create new instance
            var user = new ApplicationUser()
            {
                UserName = model.Username,
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                EmailConfirmed = true
            };

            
            // checking and creating new user to Users table
            var result = await this.AppUserManager.CreateAsync(user, model.Password);

            if (!result.Succeeded)
            {
                return GetErrorResult(result);
            }
            await this.AppUserManager.AddToRoleAsync(user.Id, "User");
            Uri locationHeader = new Uri(Url.Link("GetUserById", new { id = user.Id }));

            // will return that user is created
            return Created(locationHeader, TheModelFactory.Create(user));
        }

      

        [Authorize]
        // POST api/accounts/ChangePassword
        [Route("ChangePassword")]
        public async Task<IHttpActionResult> ChangePassword(ChangePasswordBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // validating old and new password
            IdentityResult result = await this.AppUserManager.ChangePasswordAsync(
                User.Identity.GetUserId(),
                model.OldPassword,
                model.NewPassword);

            if (!result.Succeeded)
            {
                return GetErrorResult(result);
            }

            return Ok();
        }

        [Authorize]
        // POST api/accounts/SetPassword
        [Route("SetPassword")]
        public async Task<IHttpActionResult> SetPassword(SetPasswordBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // add and validate password while adding
            IdentityResult result = await this.AppUserManager.AddPasswordAsync(
                User.Identity.GetUserId(),
                model.NewPassword);

            if (!result.Succeeded)
            {
                return GetErrorResult(result);
            }

            return Ok();
        }

        // DELETE api/accounts/user/{id:guid}
        [Authorize(Roles = "Admin,User Manager")]
        [Route("user/{id:guid}")]
        public async Task<IHttpActionResult> DeleteUser(string id)
        {

            //Only Admin can delete users 
            var appUser = await this.AppUserManager.FindByIdAsync(id);

            // check does user exist and delete it if does by calling "DeleteAsync" from "ApplicationUserManager" class
            if (appUser != null)
            {
                IdentityResult result = await this.AppUserManager.DeleteAsync(appUser);

                if (!result.Succeeded)
                {
                    return GetErrorResult(result);
                }
                return Ok();
            }
            return NotFound();
        }

        [Authorize(Roles = "Admin")]
        [Route("user/{id:guid}/roles")]
        // POST api/accounts/user/{id:guid}/roles
        public async Task<IHttpActionResult> AssignRolesToUser([FromUri] string id, [FromBody] string[] rolesToAssign)
        {

            var appUser = await this.AppUserManager.FindByIdAsync(id);

            if (appUser == null)
            {
                return NotFound();
            }

            var currentRoles = await this.AppUserManager.GetRolesAsync(appUser.Id);

            var rolesNotExists = rolesToAssign.Except(this.AppRoleManager.Roles.Select(x => x.Name)).ToArray();

            if (rolesNotExists.Count() > 0)
            {

                ModelState.AddModelError("", string.Format("Roles '{0}' does not exixts in the system", string.Join(",", rolesNotExists)));
                return BadRequest(ModelState);
            }

            IdentityResult removeResult = await this.AppUserManager.RemoveFromRolesAsync(appUser.Id, currentRoles.ToArray());

            if (!removeResult.Succeeded)
            {
                ModelState.AddModelError("", "Failed to remove user roles");
                return BadRequest(ModelState);
            }

            IdentityResult addResult = await this.AppUserManager.AddToRolesAsync(appUser.Id, rolesToAssign);

            if (!addResult.Succeeded)
            {
                ModelState.AddModelError("", "Failed to add user roles");
                return BadRequest(ModelState);
            }

            return Ok();
        }
        
    }
}
