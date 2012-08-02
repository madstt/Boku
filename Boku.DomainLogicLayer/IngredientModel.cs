using System.ComponentModel.DataAnnotations;
using Boku.Interfaces;

namespace Boku.DomainLogicLayer
{
    public class IngredientModel : IModel
    {
        public int Id { get; set; }

        [Display(Name = "Ingredient Name")]
        public string Name { get; set; }
    }
}