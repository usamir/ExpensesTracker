using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using ToptalExpensesTrackerAPI.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Web.Http;
using System.Web.Http.Description;
using System.Data.Entity.Infrastructure;
using System.Net.Http;

namespace ToptalExpensesTrackerAPI.Controllers
{
    
    [Authorize]
    [RoutePrefix("api/expenses")]
    public class ExpensesController : BaseApiController
    {
        private AppDbContext db;
        private UserManager<ApplicationUser> manager;
        public ExpensesController()
        {
            db = new AppDbContext();
            manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
        }

        // GET Expenses for the logged in user
        // GET api/Expenses?start={start}&end={end}
        [Route("")]
        public IHttpActionResult GetUserExpenses([FromUri]DateTime from, [FromUri]DateTime to)
        {
            var currentUser = manager.FindById(User.Identity.GetUserId());
            return Ok(this.db.Expenses.ToList().
                Where(e => e.UserId == currentUser.Id && e.DateTime >= from && e.DateTime <= to).
                Select(u => this.TheModelFactory.Create(u)));
        }

        // GET: api/Expenses/all
        [Authorize(Roles = "Admin")]
        [Route("all")]
        public IHttpActionResult GetExpenses()
        {
            return Ok(this.db.Expenses.ToList().Select(u => this.TheModelFactory.Create(u)));
        }

        // GET api/Expense/5
        [ResponseType(typeof(Expense))]
        [Route("{id:int}", Name = "GetExpenseById")]
        public async Task<IHttpActionResult> GetExpense(int id)
        {
            var currentUser = await manager.FindByIdAsync(User.Identity.GetUserId());
            if (id == null)
            {
                return BadRequest();
            }

            Expense expense = await db.Expenses.FindAsync(id);
            if (expense == null)
            {
                return NotFound();
            }

            if (expense.UserId != currentUser.Id)
            {
                return StatusCode(HttpStatusCode.Unauthorized);
            }

            return Ok(this.TheModelFactory.Create(expense));
        }

        // POST api/Expense
        [ResponseType(typeof(Expense))]
        [Route("")]
        public async Task<IHttpActionResult> PostExpense(Expense expense)
        {
            // find the current user
            var currentUser = await manager.FindByIdAsync(User.Identity.GetUserId());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            expense.UserId = currentUser.Id;
            db.Expenses.Add(expense);
            await db.SaveChangesAsync();

            Uri locationHeader = new Uri(Url.Link("GetExpenseById", new { id = expense.Id }));

            // will return that user is created
            return Created(locationHeader, TheModelFactory.Create(expense));
        }

        // PUT api/Expense/5
        [Route("{id:int}")]
        public async Task<IHttpActionResult> PutExpense(int id, Expense expense)
        {
            // find the current user
            var currentUser = await manager.FindByIdAsync(User.Identity.GetUserId());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != expense.Id)
            {
                return BadRequest();
            }

            if (expense.UserId != currentUser.Id)
            {
                return StatusCode(HttpStatusCode.Unauthorized);
            }

            db.Entry(expense).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExpenseExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // PUT api/Expense/5
        [Authorize(Roles = "Admin")]
        [Route("{id:int}/admin")]
        public async Task<IHttpActionResult> PutExpenseAdmin(int id, Expense expense)
        {
            // find the current user
            var currentUser = await manager.FindByIdAsync(User.Identity.GetUserId());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != expense.Id)
            {
                return BadRequest();
            }

            db.Entry(expense).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExpenseExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // DELETE api/Expense/5
        [Route("{id:int}")]
        [ResponseType(typeof(Expense))]
        public async Task<IHttpActionResult> DeleteExpense(int id)
        {
            var currentUser = await manager.FindByIdAsync(User.Identity.GetUserId());
            if (id == null)
            {
                return BadRequest();
            }

            Expense expense = await db.Expenses.FindAsync(id);
            if (expense == null)
            {
                return NotFound();
            }

            if (expense.UserId != currentUser.Id)
            {
                return StatusCode(HttpStatusCode.Unauthorized);
            }

            db.Expenses.Remove(expense);
            await db.SaveChangesAsync();

            return Ok(expense);
        }

        // DELETE api/Expense/5
        [Route("{id:int}/admin")]
        [Authorize(Roles = "Admin")]
        [ResponseType(typeof(Expense))]
        public async Task<IHttpActionResult> DeleteAllExpense(int id)
        {
            var currentUser = await manager.FindByIdAsync(User.Identity.GetUserId());
            if (id == null)
            {
                return BadRequest();
            }

            Expense expense = await db.Expenses.FindAsync(id);
            if (expense == null)
            {
                return NotFound();
            }

            db.Expenses.Remove(expense);
            await db.SaveChangesAsync();

            return Ok(expense);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ExpenseExists(int id)
        {
            return db.Expenses.Count(e => e.Id == id) > 0;
        }
    }
}
