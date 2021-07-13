using DnD5eCharacterBuilder.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD5eCharacterBuilder.Models
{
    public class CharacterDetail
    {
        public int CharacterId { get; set; }
        [Display(Name ="Name")]
        public string CharacterName { get; set; }
        [Display(Name ="Sex")]
        public CharacterSex CharacterSex { get; set; }
        [Display(Name ="Race")]
        public CharacterRace CharacterRace { get; set; }
        [Display(Name ="Class")]
        public CharacterClass CharacterClass { get; set; }
        [Display(Name ="Level")]
        public string Level { get; set; }
        public virtual Level EnumLevel { get; set; }
        [Display(Name ="XP")]
        public int Xp { get; set; }
        [Display(Name ="Player")]
        public string PlayerName { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset? Modified { get; set; }

        public Statistic Statistics { get; set; }
    }
}
