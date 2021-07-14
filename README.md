
# DnD5eCharacterBuilder

DnD5eCharacterBuilder is a n-tiered mvc that stores created character information and statistics to online database tied to an individuals user account. Incorporates full CRUD for characters.

## Structure
Index table *Characters*

Details table *Characters/Details/{id}*

Edit table(s) *Characters/Details/Edit/{id}* & *Statistics/Edit/{fk_id}*

Delete table *Characters/Delete/{id}*

#### Tables

<details>
<summary>Click to Expand</summary>

#### Bio.cs

Here we have biographical information is stored. A characters backstory, height, weight, age, etc.

<details>
<summary>Click to Expand</summary>

```(c#)
public class Bio
    {
        [Key]
        public int BioId { get; set; }
        public virtual Character Character { get; set; }
        public string Backstory { get; set; }
        public string Notes { get; set; }
        [Required(ErrorMessage = "Missing valid age.")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Missing valid height.")]
        public int Height { get; set; }
        [Required(ErrorMessage = "Missing valid weight.")]
        public int Weight { get; set; }
        [Required(ErrorMessage = "Missing valid eye color.")]
        public string EyeColor { get; set; }
        [Required(ErrorMessage = "Missing valid skin color.")]
        public string SkinColor { get; set; }
        public string HairColor { get; set; }
        public string MiscAppearanceDetails { get; set; }
    }
```

</details>

#### Character.cs

This is our main table, everything gets tied to this with foreign keys. Think of this as a characters base, hence the name "Character".

<details>
<summary>Click to Expand</summary>

```(c#)
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
               // xp to level logic here [ONLY HIDDEN IN README TO CONSERVE SPACE]
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

        // VIRTUALS BELOW
        public virtual Statistic Statistics { get; set; }
        public virtual Expertise Expertises { get; set; }
        public virtual MiscStat MiscStats { get; set; }
        public virtual SavingThrow SavingThrows { get; set; }
        public virtual Skill Skills { get; set; }
```

</details>

#### Expertise.cs

Here is where the expertise of a skill is stored with a boolean, as it is a true or false statement logic can be built out further so if a skills expertise is true - add character profiency.

<details>
<summary>Click to Expand</summary>

```(c#)
public class Expertise
    {
        [Key]
        public int ExpertiseId { get; set; }
        public virtual Character Character { get; set; }
        public bool Acrobatics { get; set; }
        public bool AnimalHandling { get; set; }
        public bool Arcana { get; set; }
        public bool Athletics { get; set; }
        public bool Deception { get; set; }
        public bool History { get; set; }
        public bool Insight { get; set; }
        public bool Intimidation { get; set; }
        public bool Investigation { get; set; }
        public bool Medicine { get; set; }
        public bool Nature { get; set; }
        public bool Perception { get; set; }
        public bool Performance { get; set; }
        public bool Persuasion { get; set; }
        public bool Religion { get; set; }
        public bool SleightOfHand { get; set; }
        public bool Stealth { get; set; }
        public bool Survival { get; set; }
    }
```

</details>

#### MiscStats.cs

These are our misc stats, while they are "misc" they are still important as a lot of the combat information is stored here.

<details>
<summary>Click to Expand</summary>

```(c#)
public class MiscStat
    {
        [Key]
        public int MiscStatId { get; set; }
        public virtual Character Character { get; set; }
        public int SpellCastingMod { get; set; }
        public int DexToHitMod { get; set; }
        public int StrToHitMod { get; set; }
        public int PassiveWisdom { get; set; }
        public string Proficiences { get; set; }
        [Required(ErrorMessage = "Must have at least 1 valid language (Typically this language is 'common').")]
        public string Languages { get; set; }
        public int Initiative { get; set; }
        [Required(ErrorMessage = "Must have valid hit points.")]
        public int HitPoints { get; set; }
        [Required(ErrorMessage = "Must have valid hit dice (e.g 1d10).")]
        public string HitDice { get; set; }
    }
```

</details>

#### SavingThrow.cs

Here is our saving throws, like with expertise they are booleans.

<details>
<summary>Click to Expand</summary>

```(c#)
public class SavingThrow
    {
        [Key]
        public int SavingThrowId { get; set; }
        public virtual Character Character { get; set; }
        public bool StrengthSave { get; set; }
        public bool DexteritySave { get; set; }
        public bool ConstitutionSave { get; set; }
        public bool IntelligenceSave { get; set; }
        public bool WisdomSave { get; set; }
        public bool CharismaSave { get; set; }
    }
```

</details>

#### Skill.cs

Here is our skills, they are booleans, when true logic will add proficiency bonus to the values on the webpage.

<details>
<summary>Click to Expand</summary>

```(c#)
public class Skill
    {
        [Key]
        public int SkillId { get; set; }
        public virtual Character Character { get; set; }
        public bool Acrobatics { get; set; }
        public bool AnimalHandling { get; set; }
        public bool Arcana { get; set; }
        public bool Athletics { get; set; }
        public bool Deception { get; set; }
        public bool History { get; set; }
        public bool Insight { get; set; }
        public bool Intimidation { get; set; }
        public bool Investigation { get; set; }
        public bool Medicine { get; set; }
        public bool Nature { get; set; }
        public bool Perception { get; set; }
        public bool Performance { get; set; }
        public bool Persuasion { get; set; }
        public bool Religion { get; set; }
        public bool SleightOfHand { get; set; }
        public bool Stealth { get; set; }
        public bool Survival { get; set; }
    }
```

</details>

#### Statistic.cs

This is our meat and bones, all our character statistic values are based on these numbers, this is the second most important table in the project.

<details>
<summary>Click to Expand</summary>

```(c#)
public class Statistic
    {
        [ForeignKey(nameof(Character))]
        public int StatisticId { get; set; }
        public virtual Character Character { get; set; }
        [Range(1,20)]
        public int Strength { get; set; }
        [Range(1,20)]
        public int Dexterity { get; set; }
        [Range(1,20)]
        public int Constitution { get; set; }
        [Range(1,20)]
        public int Intelligence { get; set; }
        [Range(1,20)]
        public int Wisdom { get; set; }
        [Range(1,20)]
        public int Charisma { get; set; }
    }
```

</details>

</details>


## Website

This site is deployed through azure to an azure website that can be found [HERE!](https://dnd5echaractersheetbuilder.azurewebsites.net/)

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

## Credit
Thanks to [Wizard to the Coast](https://dnd.wizards.com/) for an awesome rpg ruleset.
