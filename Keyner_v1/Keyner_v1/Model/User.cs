using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyner_v1.Model
{
    [Table("Users")]
    class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public int Id_Group { get; set; }

        public int Id_Monster { get; set; }

        public int Money { get; set; }

        public User()
        {

        }
    }
}
