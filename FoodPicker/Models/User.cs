using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodPicker.Models
{
    public class User
    {
        public int UserID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(65)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public virtual ICollection<Favourite> Favourites { get; set; }

        public virtual ICollection<Rating> Ratings { get; set; }

        public virtual Restaurant Restaurant { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return  FirstName + " " + LastName;
            }
        }

    }
}