using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD5eCharacterBuilder.Data
{
    // Logic maybe here to get modifier values?
    public class Statistic
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Missing stat value.")]
        public int Strength { get; set; }
        [Required(ErrorMessage = "Missing stat value.")]
        public int Dexterity { get; set; }
        [Required(ErrorMessage = "Missing stat value.")]
        public int Constitution { get; set; }
        [Required(ErrorMessage = "Missing stat value.")]
        public int Intelligence { get; set; }
        [Required(ErrorMessage = "Missing stat value.")]
        public int Wisdom { get; set; }
        [Required(ErrorMessage = "Missing stat value.")]
        public int Charisma { get; set; }

        public virtual ICollection<JoiningTable> JoiningTables { get; set; } = new List<JoiningTable>();
    }
}
