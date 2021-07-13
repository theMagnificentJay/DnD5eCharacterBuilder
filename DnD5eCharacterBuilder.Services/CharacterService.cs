using DnD5eCharacterBuilder.Data;
using DnD5eCharacterBuilder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD5eCharacterBuilder.Services
{
    public class CharacterService
    {
        private readonly Guid _userId;

        public CharacterService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateCharacter(CharacterCreate model)
        {
            var entity =
                new Character()
                {
                    OwnerId = _userId,
                    CharacterName = model.CharacterName,
                    CharacterSex = model.CharacterSex,
                    CharacterRace = model.CharacterRace,
                    CharacterClass = model.CharacterClass,
                    Xp = model.Xp,
                    PlayerName = model.PlayerName,
                    Created = DateTimeOffset.Now
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Characters.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<CharacterListItem> GetCharacters()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Characters
                    .Where(e => e.OwnerId == _userId)
                    .Select(
                        e =>
                        new CharacterListItem
                        {
                            CharacterID = e.Id,
                            CharacterName = e.CharacterName,
                            CharacterRace = e.CharacterRace,
                            CharacterClass = e.CharacterClass,
                            Level = e.Level.ToString().Replace("Level_", ""),
                            Created = e.Created
                        }
                        );

                return query.ToArray();
            }
        }

        public CharacterDetail GetCharacterById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Characters
                    .Single(e => e.Id == id && e.OwnerId == _userId);
                return
                    new CharacterDetail
                    {
                        CharacterId = entity.Id,
                        CharacterName = entity.CharacterName,
                        CharacterSex = entity.CharacterSex,
                        CharacterRace = entity.CharacterRace,
                        CharacterClass = entity.CharacterClass,
                        Level = entity.Level.ToString().Replace("Level_", ""),
                        Xp = entity.Xp,
                        PlayerName = entity.PlayerName,
                        Created = entity.Created,
                        Modified = entity.Modified,
                        Statistics = entity.Statistics
                    };
            }
        }

        public bool UpdateCharacter(CharacterEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Characters
                    .Single(e => e.Id == model.CharacterId && e.OwnerId == _userId);

                entity.CharacterName = model.CharacterName;
                entity.CharacterSex = model.CharacterSex;
                entity.CharacterRace = model.CharacterRace;
                entity.CharacterClass = model.CharacterClass;
                entity.Xp = model.Xp;
                entity.PlayerName = model.PlayerName;
                entity.Modified = DateTimeOffset.Now;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteCharacter(int characterId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var stat =
                    ctx
                    .Statistics
                    .Single(e => e.StatisticId == characterId && e.Character.OwnerId == _userId);

                var entity =
                    ctx
                    .Characters
                    .Single(e => e.Id == characterId && e.OwnerId == _userId);

                ctx.Statistics.Remove(stat);
                ctx.Characters.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
