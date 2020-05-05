using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Brehns_Maintance_App.Models
{
    public class Project
    {
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Priorty { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public double Amount { get; set; }

        public bool Complete { get; set; } 

    }
}
