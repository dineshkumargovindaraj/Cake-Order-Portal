namespace CakeOrderPortal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PaymentInformation")]
    public partial class PaymentInformation
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(256)]
        [Required(ErrorMessage = "The email address is required")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string EmailAddress { get; set; }

        [StringLength(256)]
        [Required(ErrorMessage = "The phone number is required")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "The phone number is not valid US or Canada phone number")]
        public string PhoneNumber { get; set; }

        [Key]
        [Column(Order = 1)]
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
