using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class UserInfo
    {
        private string firstName;
        private string lastName;
        private string email;
        private string password;
        private string password2;
        
        private string offers;
        private string userName;
        private string birthDate;

        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        public string FirstName { get => firstName; set => firstName = value; }
        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        public string LastName { get => lastName; set => lastName = value; }
        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        public string Email { get => email; set => email = value; }
        [Required]
        [MinLength(8)]
        [MaxLength(20)]
        public string Password { get => password; set => password = value; }
        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        public string Password2 { get => password2; set => password2 = value; }
        [Required]
        public string Offers { get => offers; set => offers = value; }
        
        public string UserName { get => userName; set => userName = value; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public string BirthDate { get => birthDate; set => birthDate = value; }
    }
}
