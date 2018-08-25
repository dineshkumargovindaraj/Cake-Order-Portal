using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CakeOrderPortal.Models
{
    public class MultipleView
    {
        public MultipleView()
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
        public IEnumerable<SelectListItem> countries { get; set; }

        [StringLength(256)]
        [Required(ErrorMessage = "The email address is required")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string EmailAddress { get; set; }

        [StringLength(256)]
        [Required(ErrorMessage = "The phone number is required")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "The phone number is not valid US or Canada phone number")]
        public string PhoneNumber { get; set; }

        [StringLength(256)]
        [Required(ErrorMessage = "Please select a Credit Card Type")]
        public string CreditCardType { get; set; }

        [StringLength(256)]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Invalid name on Card!")]
        [Required(ErrorMessage = "The name on card is required")]
        [Display(Name = "Name on Card")]
        public string Name { get; set; }

        [StringLength(256)]
        [Required(ErrorMessage = "Please enter the Credit Card Number")]
        [RegularExpression(@"^(4[0-9]{15}|5[1-5][0-9]{14}|3[47][0-9]{13})$", ErrorMessage = "The credit card number is not valid MasterCard or Visa or American Express credit card number")]
        public string CreditCardNumber { get; set; }

        [Required(ErrorMessage = "Please select the Expiration Date")]
        public DateTime? ExpirationDate { get; set; }

    }
}