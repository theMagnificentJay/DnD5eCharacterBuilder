using DnD5eCharacterBuilder.Data;
using DnD5eCharacterBuilder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD5eCharacterBuilder.Services
{
    public class StatisticService
    {
        private readonly Guid _userId;

        public StatisticService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateStatistic(StatisticCreate model, int characterId)
        {
            var entity =
                new Statistic()
                {
                    StatisticId = characterId,
                    Strength = model.Strength,
                    Dexterity = model.Dexterity,
                    Constitution = model.Constitution,
                    Intelligence = model.Intelligence,
                    Wisdom = model.Wisdom,
                    Charisma = model.Charisma
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Statistics.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<StatisticListItem> GetStatistics()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Statistics
                    .Where(e => e.Character.OwnerId == _userId)
                    .Select(
                        e =>
                        new StatisticListItem
                        {
                            CharacterStatisticId = e.StatisticId,
                            Strength = e.Strength,
                            Dexterity = e.Dexterity,
                            Constitution = e.Constitution,
                            Intelligence = e.Intelligence,
                            Wisdom = e.Wisdom,
                            Charisma = e.Charisma
                        }
                        );

                return query.ToArray();
            }
        }

        public StatisticDetail GetStatisticById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Statistics
                    .Single(e => e.StatisticId == id && e.Character.OwnerId == _userId);
                return
                    new StatisticDetail
                    {
                        CharacterStatisticId = entity.StatisticId,
                        Strength = entity.Strength,
                        Dexterity = entity.Dexterity,
                        Constitution = entity.Constitution,
                        Intelligence = entity.Intelligence,
                        Wisdom = entity.Wisdom,
                        Charisma = entity.Charisma
                    };
            }
        }

        public bool UpdateStatistic(StatisticEdit model)
        {
            using (var ctx  = new ApplicationDbContext()){
                var entity =
                    ctx
                    .Statistics
                    .Single(e => e.StatisticId == model.CharacterStatisticId && e.Character.OwnerId == _userId);

                entity.Strength = model.Strength;
                entity.Dexterity = model.Dexterity;
                entity.Constitution = model.Constitution;
                entity.Intelligence = model.Intelligence;
                entity.Wisdom = model.Wisdom;
                entity.Charisma = model.Charisma;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteStatistic(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Statistics
                    .Single(e => e.StatisticId == id && e.Character.OwnerId == _userId);

                ctx.Statistics.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
