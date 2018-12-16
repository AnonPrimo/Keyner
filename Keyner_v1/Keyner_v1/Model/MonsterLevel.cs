using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyner_v1.Model
{
    public class MonsterLevel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int Id_Monster { get; set; }

        public byte[] HappyImage { get; set; }
        public byte[] SadImage { get; set; }
        public byte[] NeutralImage { get; set; }
        public byte[] ReadyImage { get; set; }

    }
}
