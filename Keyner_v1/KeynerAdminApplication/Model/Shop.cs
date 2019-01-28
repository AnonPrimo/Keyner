using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeynerAdminApplication.Model
{
    public class Shop
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Id_Monster { get; set; }
        [Required(ErrorMessage = "Cost required")]
        public int Cost { get; set; }
    }
}
