namespace CakeOrderPortal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Web.Mvc;

    public partial class CakeOrderDetail
    {
        public CakeOrderDetail()
        {
            this.Country = "Canada";
        }

        [Key]
        public int OrderId { get; set; }

        [StringLength(256)]
        [Required(ErrorMessage = "Please choose a cake")]
        public string CakeName { get; set; }

        
        [StringLength(256)]
        [Required(ErrorMessage = "The cake type is required")]
        public string CakeType { get; set; }


        [StringLength(50)]
        [Required(ErrorMessage = "The weight of the cake is required")]
        public string Weight { get; set; }

        //[DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date, ErrorMessage = "Please enter a valid date!")]
        [Required(ErrorMessage = "Please enter a valid date!")]
        public DateTime DeliveryDate { get; set; }


        [DataType(DataType.Time, ErrorMessage = "Please enter a valid time!")]
        public TimeSpan DeliveryTime { get; set; }

        [StringLength(256)]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Invalid first name!")]
        [Required(ErrorMessage = "The first name is required")]
        public string FirstName { get; set; }

       
        [StringLength(256)]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Invalid last name!")]
        [Required(ErrorMessage = "The last name is required")]
        public string LastName { get; set; }

        
        [StringLength(50)]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Must be a number!")]
        [Required(ErrorMessage = "The street number is required")]
        public string StreetNumber { get; set; }

        [StringLength(256)]
        [Required(ErrorMessage = "The address is required")]
        public string Address { get; set; }

        [StringLength(256)]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Invalid city name!")]
        [Required(ErrorMessage = "The city is required")]
        public string City { get; set; }

        [StringLength(256)]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Invalid province name!")]
        [Required(ErrorMessage = "The province is required")]
        public string Province { get; set; }

        [StringLength(256)]
        [Required(ErrorMessage = "The country is required")]
        public string Country { get; set; }

        [StringLength(256)]
        [RegularExpression(@"(^\d{5}(-\d{4})?$)|(^[ABCEGHJKLMNPRSTVXYabceghjklmnprstvxy]{1}\d{1}[ABCEGHJKLMNPRSTVWXYZabceghjklmnprstv‌​xy]{1} *\d{1}[ABCEGHJKLMNPRSTVWXYZabceghjklmnprstvxy]{1}\d{1}$)", ErrorMessage = "That postal code is not a valid US or Canadian postal code.")]
        [Required(ErrorMessage = "The postal code is required")]
        public string PostalCode { get; set; }

        //This hold value for selection of countries
        public IEnumerable<SelectListItem>  countries { get; set; }
    }
}
