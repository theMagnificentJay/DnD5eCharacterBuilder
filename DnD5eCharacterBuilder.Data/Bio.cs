using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD5eCharacterBuilder.Data
{
    public class Bio
    {
        [Key]
        public int Id { get; set; }
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
}
