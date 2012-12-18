using System.ComponentModel.DataAnnotations;

namespace Boku.DomainLogicLayer.DomainModels
{
    public class IngredientModel
    {
        public int Id { get; set; }

        [Display(Name = "Ingredient Name")]
        public string Name { get; set; }
    }
}