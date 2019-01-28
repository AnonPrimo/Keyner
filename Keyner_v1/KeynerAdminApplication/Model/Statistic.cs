using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeynerAdminApplication.Model
{
    public class Statistic
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Id_User { get; set; }
        public int Id_Test { get; set; }
        public int Time { get; set; }
        public int Mark { get; set; } // 1..3
        public int CountMistakes { get; set; }
        public bool IsPassed { get; set; }
    }
}
