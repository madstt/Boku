using System.ComponentModel.DataAnnotations;
using Boku.Interfaces;

namespace Boku.DomainLogicLayer
{
    public class User : IModel
    {
        [Required]
        public int Id { get; set; }

        public string UserName { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


    }
}