using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToptalExpensesTrackerAPI.Models
{
    public class Expense
    {
        public int Id { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [Range(0.01, Double.MaxValue)]
        public double Amount { get; set; }

        public string Comment { get; set; }

        // foreign key
        public string UserId { get; set; }

    }
}