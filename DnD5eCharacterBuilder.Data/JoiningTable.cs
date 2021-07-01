using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD5eCharacterBuilder.Data
{
    public class JoiningTable
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Character))]
        public int CharacterId { get; set; }
        public virtual Character Character { get; set; }

        [ForeignKey(nameof(Bio))]
        public int BioId { get; set; }
        public virtual Bio Bio { get; set; }

        [ForeignKey(nameof(Expertise))]
        public int ExpertiseId { get; set; }
        public virtual Expertise Expertise { get; set; }

        [ForeignKey(nameof(MiscStat))]
        public int MiscStatId { get; set; }
        public virtual MiscStat MiscStat { get; set; }

        [ForeignKey(nameof(SavingThrow))]
        public int SavingThrowId { get; set; }
        public virtual SavingThrow SavingThrow { get; set; }

        [ForeignKey(nameof(Skill))]
        public int SkillId { get; set; }
        public virtual Skill Skill { get; set; }

        [ForeignKey(nameof(Statistic))]
        public int StatisticId { get; set; }
        public virtual Statistic Statistic { get; set; }
    }
}
