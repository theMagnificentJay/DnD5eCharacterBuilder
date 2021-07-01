using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD5eCharacterBuilder.Data
{
    public class MiscStats
    {
        [Key]
        public int Id { get; set; }
        public int SpellCastingMod { get; set; }
        public int DexToHitMod { get; set; }
        public int StrToHitMod { get; set; }
        public int PassiveWisdom { get; set; }
        public string Proficiences { get; set; }
        [Required(ErrorMessage = "Must have at least 1 valid language (Typically this language is 'common').")]
        public string Languages { get; set; }
        public int Initiative { get; set; }
        [Required(ErrorMessage = "Must have valid hit points.")]
        public int HitPoints { get; set; }
        [Required(ErrorMessage = "Must have valid hit dice (e.g 1d10).")]
        public string HitDice { get; set; }
    }
}
