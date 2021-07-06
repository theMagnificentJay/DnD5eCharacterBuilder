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
                    Created = DateTimeOffset.Now,
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
                            Level = e.Level,
                            Created = e.Created
                        }
                        );

                return query.ToArray();
            }
        }
    }
}
