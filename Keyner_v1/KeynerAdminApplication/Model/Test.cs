using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeynerAdminApplication.Model
{
    public class Test
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Text required")]
        public string Text { get; set; }

        [Required(ErrorMessage = "CountMistakes required")]
        public int CountMistakes { get; set; }

        public int BestTime { get; set; }

        public int MaxTime { get; set; }

        public Test()
        {

        }
    }
}
