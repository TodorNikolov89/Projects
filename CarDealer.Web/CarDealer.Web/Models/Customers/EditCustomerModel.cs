namespace CarDealer.Web.Models.Customers
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class EditCustomerModel
    {
        [Required(ErrorMessage = "The Name field is required!")]
        [MaxLength(200)]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDay { get; set; }


        [Display(Name = "Young Driver")]
        public bool IsYoungDriver { get; set; }
    }
}

