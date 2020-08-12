using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace finSales.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(150)")]
        public String Name { get; set; }

        [DataType(DataType.MultilineText)]
        [Column(TypeName = "nvarchar(300)")]
        public string Address { get; set; }

        [DataType(DataType.Url)]
        [Column(TypeName = "nvarchar(2000)")]
        public string URL { get; set; }

    }
}
