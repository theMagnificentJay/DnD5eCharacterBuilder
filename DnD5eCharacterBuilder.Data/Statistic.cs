using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD5eCharacterBuilder.Data
{
    // Logic maybe here to get modifier values?
    public class Statistic
    {
        [ForeignKey(nameof(Character))]
        public int StatisticId { get; set; }
        public virtual Character Character { get; set; }
        [Range(1,20)]
        public int Strength { get; set; }
        [Range(1,20)]
        public int Dexterity { get; set; }
        [Range(1,20)]
        public int Constitution { get; set; }
        [Range(1,20)]
        public int Intelligence { get; set; }
        [Range(1,20)]
        public int Wisdom { get; set; }
        [Range(1,20)]
        public int Charisma { get; set; }
    }
}
