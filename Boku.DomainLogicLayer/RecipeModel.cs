using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using Boku.Interfaces;

namespace Boku.DomainLogicLayer
{
    public class RecipeModel : IModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Recipe Name")]
        public string Name { get; set; }

        [Display(Name ="Origin")]
        public string LandContinent { get; set; }

        [Display(Name = "Recipe Procedure")]
        public string RecipeProcedure { get; set; }

        [Display(Name = "Servings")]
        public int Servings { get; set; }

        [Display(Name = "Total Time in Minutes")]
        public int TotalTimeMinutes { get; set; }

        [Display(Name = "Total Preparation Time in Minutes")]
        public int PrepTimeMinutes { get; set; }

        [Display(Name = "Rating")]
        public int Rating { get; set; }

        [Display(Name = "Ingredients")]
        public ObservableCollection<IngredientModel> Ingredients { get; set; }

        [Display(Name = "Categories")]
        public ObservableCollection<CategoryModel> Categories { get; set; }
    }
}