using DnD5eCharacterBuilder.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD5eCharacterBuilder.Models
{
    public class StatisticDetail
    {
        public int CharacterStatisticId { get; set; }
        public int Strength
        { 
            get 
            {
                if (Character.CharacterRace.Equals(CharacterRace.Half_Orc))
                {
                    return Strength += 2;
                }
                else if (Character.CharacterRace.Equals(CharacterRace.Human))
                {
                    return Strength += 1;
                }
                else
                return (Strength);
            }
            set { }
        }
        public int Dexterity
        {
            get
            {
                if (Character.CharacterRace.Equals(CharacterRace.Human))
                {
                    return Dexterity += 1;
                }
                else
                return (Dexterity);
            }
            set { }
        }
        public int Constitution
        {
            get
            {
                if (Character.CharacterRace.Equals(CharacterRace.Half_Orc))
                {
                    return Constitution += 1;
                }
                else if (Character.CharacterRace.Equals(CharacterRace.Human))
                {
                    return Constitution += 1;
                }
                else
                return (Constitution);
            }
            set { }
        }
        public int Intelligence
        {
            get
            {
                if (Character.CharacterRace.Equals(CharacterRace.Human))
                {
                    return Intelligence += 1;
                }
                else
                return (Intelligence);
            }
            set { }
        }
        public int Wisdom
        {
            get
            {
                if (Character.CharacterRace.Equals(CharacterRace.Human))
                {
                    return Wisdom += 1;
                }
                else
                return (Wisdom);
            }
            set { }
        }
        public int Charisma
        {
            get
            {
                if (Character.CharacterRace.Equals(CharacterRace.Human))
                {
                    return Charisma += 1;
                }
                else
                return (Charisma);
            }
            set { }
        }
        public virtual Character Character { get; set; }
    }
}
