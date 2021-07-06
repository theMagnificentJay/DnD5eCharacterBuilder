using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD5eCharacterBuilder.Data
{
    public enum CharacterSex { Male, Female, Other }

    public enum CharacterRace { Dragonborn, Dwarf, Elf, Gnome, Half_Elf, Halfling, Half_Orc, Human, Tiefling, Leonin, Satyr, Aarakocra, Genasi, Goliath, Aasimar, Bugbear, Firbolg, Goblin, Hobgoblin, Kenku, Kobold, Lizardfolk, Orc, Tabaxi, Triton, Yuan_ti_Pureblood, Feral_Tiefling, Tortle, Changeling, Kalashtar, Shifter, Warforged, Gith, Centaur, Loxodon, Minotaur, Simic_Hybrid, Vedalken, Verdan, Locathah, Grung, Fairy, Owlfolk, Rabbitfolk }

    public enum CharacterClass { Barbarian, Bard, Cleric, Druid, Fighter, Monk, Paladin, Ranger, Rogue, Sorcerer, Warlock, Wizard, Artificer }

    public enum Level { Level_1 = 1, Level_2, Level_3, Level_4, Level_5, Level_6, Level_7, Level_8, Level_9, Level_10, Level_11, Level_12, Level_13, Level_14, Level_15, Level_16, Level_17, Level_18, Level_19, Level_20 }

    public class Character
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CharacterName { get; set; }
        [Required]
        public CharacterSex CharacterSex { get; set; }
        [Required]
        public CharacterRace CharacterRace { get; set; }
        [Required]
        public CharacterClass CharacterClass { get; set; }
        private Level _level;
        public Level Level
        {
            get { return _level; }
            set
            {
                if (Xp >= 355000)
                {
                    _level = (Level)20;
                }
                else if (Xp >= 305000)
                {
                    _level = (Level)19;
                }
                else if (Xp >= 265000)
                {
                    _level = (Level)18;
                }
                else if (Xp >= 225000)
                {
                    _level = (Level)17;
                }
                else if (Xp >= 195000)
                {
                    _level = (Level)16;
                }
                else if (Xp >= 165000)
                {
                    _level = (Level)15;
                }
                else if (Xp >= 140000)
                {
                    _level = (Level)14;
                }
                else if (Xp >= 120000)
                {
                    _level = (Level)13;
                }
                else if (Xp >= 100000)
                {
                    _level = (Level)12;
                }
                else if (Xp >= 85000)
                {
                    _level = (Level)11;
                }
                else if (Xp >= 64000)
                {
                    _level = (Level)10;
                }
                else if (Xp >= 48000)
                {
                    _level = (Level)9;
                }
                else if (Xp >= 34000)
                {
                    _level = (Level)8;
                }
                else if (Xp >= 23000)
                {
                    _level = (Level)7;
                }
                else if (Xp >= 14000)
                {
                    _level = (Level)6;
                }
                else if (Xp >= 6500)
                {
                    _level = (Level)5;
                }
                else if (Xp >= 2700)
                {
                    _level = (Level)4;
                }
                else if (Xp >= 900)
                {
                    _level = (Level)3;
                }
                else if (Xp >= 300)
                {
                    _level = (Level)2;
                }
                else
                {
                    _level = (Level)1;
                }
            }
        }
        [Required]
        public int Xp { get; set; }
        [Required]
        public string PlayerName { get; set; }
        [Required]
        public Guid OwnerId { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset? Modified { get; set; }

        public virtual ICollection<JoiningTable> JoiningTables { get; set; } = new List<JoiningTable>();
    }
}
