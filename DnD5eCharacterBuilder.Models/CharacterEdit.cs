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
    public class CharacterEdit
    {
        public int CharacterId { get; set; }
        [Required]
        [Display(Name = "Name")]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]
        [MaxLength(20, ErrorMessage = "Please enter less than 20 characters.")]
        public string CharacterName { get; set; }
        [Required]
        [Display(Name = "Sex")]
        public CharacterSex CharacterSex { get; set; }
        [Display(Name = "Sex")]
        public List<SelectList> CSex { get; set; } = new List<SelectList>
        {
            new SelectList(CharacterSex.Female.ToString(), ((int)CharacterSex.Female).ToString()),
            new SelectList(CharacterSex.Male.ToString(), ((int)CharacterSex.Male).ToString()),
            new SelectList(CharacterSex.Other.ToString(), ((int)CharacterSex.Other).ToString()),
        };
        [Required]
        [Display(Name = "Race")]
        public CharacterRace CharacterRace { get; set; }
        [Display(Name = "Race")]
        public List<SelectList> CRace { get; set; } = new List<SelectList>
        {
            new SelectList(CharacterRace.Aarakocra.ToString(), ((int)CharacterRace.Aarakocra).ToString()),
            new SelectList(CharacterRace.Aasimar.ToString(), ((int)CharacterRace.Aasimar).ToString()),
            new SelectList(CharacterRace.Bugbear.ToString(), ((int)CharacterRace.Bugbear).ToString()),
            new SelectList(CharacterRace.Centaur.ToString(), ((int)CharacterRace.Centaur).ToString()),
            new SelectList(CharacterRace.Changeling.ToString(), ((int)CharacterRace.Changeling).ToString()),
            new SelectList(CharacterRace.Dragonborn.ToString(), ((int)CharacterRace.Dragonborn).ToString()),
            new SelectList(CharacterRace.Dwarf.ToString(), ((int)CharacterRace.Dwarf).ToString()),
            new SelectList(CharacterRace.Elf.ToString(), ((int)CharacterRace.Elf).ToString()),
            new SelectList(CharacterRace.Fairy.ToString(), ((int)CharacterRace.Fairy).ToString()),
            new SelectList(CharacterRace.Feral_Tiefling.ToString(), ((int)CharacterRace.Feral_Tiefling).ToString()),
            new SelectList(CharacterRace.Firbolg.ToString(), ((int)CharacterRace.Firbolg).ToString()),
            new SelectList(CharacterRace.Genasi.ToString(), ((int)CharacterRace.Genasi).ToString()),
            new SelectList(CharacterRace.Gith.ToString(), ((int)CharacterRace.Gith).ToString()),
            new SelectList(CharacterRace.Gnome.ToString(), ((int)CharacterRace.Gnome).ToString()),
            new SelectList(CharacterRace.Goblin.ToString(), ((int)CharacterRace.Goblin).ToString()),
            new SelectList(CharacterRace.Goliath.ToString(), ((int)CharacterRace.Goliath).ToString()),
            new SelectList(CharacterRace.Grung.ToString(), ((int)CharacterRace.Grung).ToString()),
            new SelectList(CharacterRace.Halfling.ToString(), ((int)CharacterRace.Halfling).ToString()),
            new SelectList(CharacterRace.Half_Elf.ToString(), ((int)CharacterRace.Half_Elf).ToString()),
            new SelectList(CharacterRace.Half_Orc.ToString(), ((int)CharacterRace.Half_Orc).ToString()),
            new SelectList(CharacterRace.Hobgoblin.ToString(), ((int)CharacterRace.Hobgoblin).ToString()),
            new SelectList(CharacterRace.Human.ToString(), ((int)CharacterRace.Human).ToString()),
            new SelectList(CharacterRace.Kalashtar.ToString(), ((int)CharacterRace.Kalashtar).ToString()),
            new SelectList(CharacterRace.Kenku.ToString(), ((int)CharacterRace.Kenku).ToString()),
            new SelectList(CharacterRace.Kobold.ToString(), ((int)CharacterRace.Kobold).ToString()),
            new SelectList(CharacterRace.Leonin.ToString(), ((int)CharacterRace.Leonin).ToString()),
            new SelectList(CharacterRace.Lizardfolk.ToString(), ((int)CharacterRace.Lizardfolk).ToString()),
            new SelectList(CharacterRace.Locathah.ToString(), ((int)CharacterRace.Locathah).ToString()),
            new SelectList(CharacterRace.Loxodon.ToString(), ((int)CharacterRace.Loxodon).ToString()),
            new SelectList(CharacterRace.Minotaur.ToString(), ((int)CharacterRace.Minotaur).ToString()),
            new SelectList(CharacterRace.Orc.ToString(), ((int)CharacterRace.Orc).ToString()),
            new SelectList(CharacterRace.Owlfolk.ToString(), ((int)CharacterRace.Owlfolk).ToString()),
            new SelectList(CharacterRace.Rabbitfolk.ToString(), ((int)CharacterRace.Rabbitfolk).ToString()),
            new SelectList(CharacterRace.Satyr.ToString(), ((int)CharacterRace.Satyr).ToString()),
            new SelectList(CharacterRace.Shifter.ToString(), ((int)CharacterRace.Shifter).ToString()),
            new SelectList(CharacterRace.Simic_Hybrid.ToString(), ((int)CharacterRace.Simic_Hybrid).ToString()),
            new SelectList(CharacterRace.Tabaxi.ToString(), ((int)CharacterRace.Tabaxi).ToString()),
            new SelectList(CharacterRace.Tiefling.ToString(), ((int)CharacterRace.Tiefling).ToString()),
            new SelectList(CharacterRace.Tortle.ToString(), ((int)CharacterRace.Tortle).ToString()),
            new SelectList(CharacterRace.Triton.ToString(), ((int)CharacterRace.Triton).ToString()),
            new SelectList(CharacterRace.Vedalken.ToString(), ((int)CharacterRace.Vedalken).ToString()),
            new SelectList(CharacterRace.Verdan.ToString(), ((int)CharacterRace.Verdan).ToString()),
            new SelectList(CharacterRace.Warforged.ToString(), ((int)CharacterRace.Warforged).ToString()),
            new SelectList(CharacterRace.Yuan_ti_Pureblood.ToString(), ((int)CharacterRace.Yuan_ti_Pureblood).ToString())
        };
        [Required]
        [Display(Name = "Class")]
        public CharacterClass CharacterClass { get; set; }
        [Display(Name = "Class")]
        public List<SelectList> CClass { get; set; } = new List<SelectList>
        {
            new SelectList(CharacterClass.Artificer.ToString(), ((int)CharacterClass.Artificer).ToString()),
            new SelectList(CharacterClass.Barbarian.ToString(), ((int)CharacterClass.Barbarian).ToString()),
            new SelectList(CharacterClass.Bard.ToString(), ((int)CharacterClass.Bard).ToString()),
            new SelectList(CharacterClass.Cleric.ToString(), ((int)CharacterClass.Cleric).ToString()),
            new SelectList(CharacterClass.Druid.ToString(), ((int)CharacterClass.Druid).ToString()),
            new SelectList(CharacterClass.Fighter.ToString(), ((int)CharacterClass.Fighter).ToString()),
            new SelectList(CharacterClass.Monk.ToString(), ((int)CharacterClass.Monk).ToString()),
            new SelectList(CharacterClass.Paladin.ToString(), ((int)CharacterClass.Paladin).ToString()),
            new SelectList(CharacterClass.Ranger.ToString(), ((int)CharacterClass.Ranger).ToString()),
            new SelectList(CharacterClass.Rogue.ToString(), ((int)CharacterClass.Rogue).ToString()),
            new SelectList(CharacterClass.Sorcerer.ToString(), ((int)CharacterClass.Sorcerer).ToString()),
            new SelectList(CharacterClass.Warlock.ToString(), ((int)CharacterClass.Warlock).ToString()),
            new SelectList(CharacterClass.Wizard.ToString(), ((int)CharacterClass.Wizard).ToString()),
        };
        [Required]
        [Display(Name = "Xp")]
        public int Xp { get; set; }
        [Required]
        [Display(Name = "Player Name")]
        public string PlayerName { get; set; }
    }
}
