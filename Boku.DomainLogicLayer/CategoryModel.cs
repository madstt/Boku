using Boku.Interfaces;

namespace Boku.DomainLogicLayer
{
    public class CategoryModel : IModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}