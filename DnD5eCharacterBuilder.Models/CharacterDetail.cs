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
        [Display(Name ="XP")]
        public int Xp { get; set; }
        [Display(Name ="Player")]
        public string PlayerName { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset? Modified { get; set; }
    }
}
