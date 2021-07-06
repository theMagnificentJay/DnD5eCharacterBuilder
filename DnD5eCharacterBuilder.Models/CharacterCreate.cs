using DnD5eCharacterBuilder.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DnD5eCharacterBuilder.Models
{
    public class CharacterCreate
    {
        [Required]
        [Display(Name ="Name")]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]
        [MaxLength(20, ErrorMessage = "Please enter less than 20 characters.")]
        public string CharacterName { get; set; }
        [Required]
        [Display(Name = "Sex")]
        public Sex Sex { get; set; }
        [Display(Name = "Sex")]
        public List<SelectList> CharacterSex { get; set; } = new List<SelectList>
        {
            new SelectList(Sex.Female.ToString(), ((int)Sex.Female).ToString()),
            new SelectList(Sex.Male.ToString(), ((int)Sex.Male).ToString()),
            new SelectList(Sex.Other.ToString(), ((int)Sex.Other).ToString()),
        };
        [Required]
        [Display(Name ="Race")]
        public Race Race { get; set; }
        [Display(Name ="Race")]
        public List<SelectList> CharacterRace { get; set; } = new List<SelectList>
        {
            new SelectList(Race.Aarakocra.ToString(), ((int)Race.Aarakocra).ToString()),
            new SelectList(Race.Aasimar.ToString(), ((int)Race.Aasimar).ToString()),
            new SelectList(Race.Bugbear.ToString(), ((int)Race.Bugbear).ToString()),
            new SelectList(Race.Centaur.ToString(), ((int)Race.Centaur).ToString()),
            new SelectList(Race.Changeling.ToString(), ((int)Race.Changeling).ToString()),
            new SelectList(Race.Dragonborn.ToString(), ((int)Race.Dragonborn).ToString()),
            new SelectList(Race.Dwarf.ToString(), ((int)Race.Dwarf).ToString()),
            new SelectList(Race.Elf.ToString(), ((int)Race.Elf).ToString()),
            new SelectList(Race.Fairy.ToString(), ((int)Race.Fairy).ToString()),
            new SelectList(Race.Feral_Tiefling.ToString(), ((int)Race.Feral_Tiefling).ToString()),
            new SelectList(Race.Firbolg.ToString(), ((int)Race.Firbolg).ToString()),
            new SelectList(Race.Genasi.ToString(), ((int)Race.Genasi).ToString()),
            new SelectList(Race.Gith.ToString(), ((int)Race.Gith).ToString()),
            new SelectList(Race.Gnome.ToString(), ((int)Race.Gnome).ToString()),
            new SelectList(Race.Goblin.ToString(), ((int)Race.Goblin).ToString()),
            new SelectList(Race.Goliath.ToString(), ((int)Race.Goliath).ToString()),
            new SelectList(Race.Grung.ToString(), ((int)Race.Grung).ToString()),
            new SelectList(Race.Halfling.ToString(), ((int)Race.Halfling).ToString()),
            new SelectList(Race.Half_Elf.ToString(), ((int)Race.Half_Elf).ToString()),
            new SelectList(Race.Half_Orc.ToString(), ((int)Race.Half_Orc).ToString()),
            new SelectList(Race.Hobgoblin.ToString(), ((int)Race.Hobgoblin).ToString()),
            new SelectList(Race.Human.ToString(), ((int)Race.Human).ToString()),
            new SelectList(Race.Kalashtar.ToString(), ((int)Race.Kalashtar).ToString()),
            new SelectList(Race.Kenku.ToString(), ((int)Race.Kenku).ToString()),
            new SelectList(Race.Kobold.ToString(), ((int)Race.Kobold).ToString()),
            new SelectList(Race.Leonin.ToString(), ((int)Race.Leonin).ToString()),
            new SelectList(Race.Lizardfolk.ToString(), ((int)Race.Lizardfolk).ToString()),
            new SelectList(Race.Locathah.ToString(), ((int)Race.Locathah).ToString()),
            new SelectList(Race.Loxodon.ToString(), ((int)Race.Loxodon).ToString()),
            new SelectList(Race.Minotaur.ToString(), ((int)Race.Minotaur).ToString()),
            new SelectList(Race.Orc.ToString(), ((int)Race.Orc).ToString()),
            new SelectList(Race.Owlfolk.ToString(), ((int)Race.Owlfolk).ToString()),
            new SelectList(Race.Rabbitfolk.ToString(), ((int)Race.Rabbitfolk).ToString()),
            new SelectList(Race.Satyr.ToString(), ((int)Race.Satyr).ToString()),
            new SelectList(Race.Shifter.ToString(), ((int)Race.Shifter).ToString()),
            new SelectList(Race.Simic_Hybrid.ToString(), ((int)Race.Simic_Hybrid).ToString()),
            new SelectList(Race.Tabaxi.ToString(), ((int)Race.Tabaxi).ToString()),
            new SelectList(Race.Tiefling.ToString(), ((int)Race.Tiefling).ToString()),
            new SelectList(Race.Tortle.ToString(), ((int)Race.Tortle).ToString()),
            new SelectList(Race.Triton.ToString(), ((int)Race.Triton).ToString()),
            new SelectList(Race.Vedalken.ToString(), ((int)Race.Vedalken).ToString()),
            new SelectList(Race.Verdan.ToString(), ((int)Race.Verdan).ToString()),
            new SelectList(Race.Warforged.ToString(), ((int)Race.Warforged).ToString()),
            new SelectList(Race.Yuan_ti_Pureblood.ToString(), ((int)Race.Yuan_ti_Pureblood).ToString())
        };
        [Required]
        [Display(Name ="Class")]
        public CharacterClass CharacterClass { get; set; }
        [Required]
        [Display(Name ="Level")]
        public Level Level { get; set; }
        public int Xp { get; set; } // Build logic here to automatically set level prop also this should not be required upon creation so nullable? RESEARCH
        [Required]
        [Display(Name ="Player Name")]
        public string PlayerName { get; set; }
    }
}
