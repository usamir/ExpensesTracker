using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExpensesTrackerClient.Models
{
    public class Expense
    {
        public int Id { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public double Amount { get; set; }

        public string Comment { get; set; }

        // foreign key
        public string UserId { get; set; }

        //public Expense()
        //{
        //    if (this.Amount == 0)
        //    {
        //        throw new System.ArgumentException("Parameter cannot be null", "Amount");
        //    }

        //    if (this.Description == "")
        //    {
        //        throw new System.ArgumentException("Parameter cannot be null", "Description");
        //    }
        //}

    }
}