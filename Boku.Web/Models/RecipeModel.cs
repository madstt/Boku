using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Boku.Web.Models
{
    public class RecipeModel
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Opskrift navn:")]
        public string Name { get; set; }

        public List<Ingredient> Ingredients { get; set; }
    }
}