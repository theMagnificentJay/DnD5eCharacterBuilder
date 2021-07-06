using DnD5eCharacterBuilder.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD5eCharacterBuilder.Models
{
    public class CharacterListItem
    {
        [Display(Name="Id")]
        public int CharacterID { get; set; }
        [Display(Name="Character Name")]
        public string CharacterName { get; set; }
        [Display(Name="Race")]
        public Race Race { get; set; }
        [Display(Name="Class")]
        public CharacterClass CharacterClass { get; set; }
        [Display(Name = "Level")]
        public Level Level { get; set; }
        [Display(Name="Created")]
        public DateTimeOffset Created { get; set; }


    }
}
