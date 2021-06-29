using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD5eCharacterBuilder.Data
{
    public enum Sex { Male, Female, Other }

    public enum Race { Dragonborn, Dwarf, Elf, Gnome, Half_Elf, Halfling, Half_Orc, Human, Tiefling, Leonin, Satyr, Aarakocra, Genasi, Goliath, Aasimar, Bugbear, Firbolg, Goblin, Hobgoblin, Kenku, Kobold, Lizardfolk, Orc, Tabaxi, Triton, Yuan_ti_Pureblood, Feral_Tiefling, Tortle, Changeling, Kalashtar, Shifter, Warforged, Gith, Centaur, Loxodon, Minotaur, Simic_Hybrid, Vedalken, Verdan, Locathah, Grung, Fairy, Owlfolk, Rabbitfolk }

    public enum CharacterClass { Barbarian, Bard, Cleric, Druid, Fighter, Monk, Paladin, Ranger, Rogue, Sorcerer, Warlock, Wizard, Artificer }

    public enum Level { Level_1, Level_2, Level_3, Level_4, Level_5, Level_6, Level_7, Level_8, Level_9, Level_10, Level_11, Level_12, Level_13, Level_14, Level_15, Level_16, Level_17, Level_18, Level_19, Level_20 }

    public class Character
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CharacterName { get; set; }
        [Required]
        public Sex CharacterSex { get; set; }
        [Required]
        public Race Race { get; set; }
        [Required]
        public CharacterClass CharacterClass { get; set; }
        [Required]
        public Level Level { get; set; }
        public int Xp { get; set; } // Build logic here to automatically set level prop also this should not be required upon creation so nullable? RESEARCH
        [Required]
        public string PlayerName { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset? Modified { get; set; }
    }
}
