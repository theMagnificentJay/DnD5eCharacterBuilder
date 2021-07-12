using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD5eCharacterBuilder.Data
{
    public enum CharacterSex { Male, Female, Other }

    public enum CharacterRace { Aarakocra, Aasimar, Bugbear, Centaur, Changeling, Dragonborn, Dwarf, Elf, Fairy, Feral_Tiefling, Firbolg, Genasi, Gith, Gnome, Goblin, Goliath, Grung, Half_Elf, Half_Orc, Halfling, Hobgoblin, Human, Kalashtar, Kenku, Kobold, Leonin, Lizardfolk, Locathah, Loxodon, Minotaur, Orc, Owlfolk, Rabbitfolk, Satyr, Shifter, Simic_Hybrid, Tabaxi, Tiefling, Tortle, Triton, Vedalken, Verdan, Warforged, Yuan_ti_Pureblood }

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
        public Level Level
        {
            get
            {
                if (Xp >= 355000)
                {
                    return (Level)20;
                }
                else if (Xp >= 305000)
                {
                    return (Level)19;
                }
                else if (Xp >= 265000)
                {
                    return (Level)18;
                }
                else if (Xp >= 225000)
                {
                    return (Level)17;
                }
                else if (Xp >= 195000)
                {
                    return (Level)16;
                }
                else if (Xp >= 165000)
                {
                    return (Level)15;
                }
                else if (Xp >= 140000)
                {
                    return (Level)14;
                }
                else if (Xp >= 120000)
                {
                    return (Level)13;
                }
                else if (Xp >= 100000)
                {
                    return (Level)12;
                }
                else if (Xp >= 85000)
                {
                    return (Level)11;
                }
                else if (Xp >= 64000)
                {
                    return (Level)10;
                }
                else if (Xp >= 48000)
                {
                    return (Level)9;
                }
                else if (Xp >= 34000)
                {
                    return (Level)8;
                }
                else if (Xp >= 23000)
                {
                    return (Level)7;
                }
                else if (Xp >= 14000)
                {
                    return (Level)6;
                }
                else if (Xp >= 6500)
                {
                    return (Level)5;
                }
                else if (Xp >= 2700)
                {
                    return (Level)4;
                }
                else if (Xp >= 900)
                {
                    return (Level)3;
                }
                else if (Xp >= 300)
                {
                    return (Level)2;
                }
                else
                {
                    return (Level)1;
                }
            }
            set { }
        }
        [Required]
        public int Xp { get; set; }
        [Required]
        public string PlayerName { get; set; }
        [Required]
        public Guid OwnerId { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset? Modified { get; set; }

        public virtual Statistic Statistics { get; set; }
    }
}
