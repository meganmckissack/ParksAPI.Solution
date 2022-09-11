using System;
using System.Linq;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace ParksAPI.Models {
  public class Park
  {
    public int ParkId { get; set; }

    [Required]
    public string ParkName { get; set; }

    [StringRange(AllowableValues = new[] { "state", "national" }, ErrorMessage = "Type must be either 'state' or 'national'.")]
    public string Type { get; set; }
    
    public string City { get; set; }
    public string State { get; set; }
    public string Feature { get; set; }
  }

  public class StringRangeAttribute : ValidationAttribute
    {
        public string[] AllowableValues { get; set; }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            if (AllowableValues?.Contains(value?.ToString()) == true)
            {
              return ValidationResult.Success;
            }

            var msg = $"Please enter one of the allowable values: {string.Join(", ", (AllowableValues ?? new string[] { "No allowable values found" }))}.";
            return new ValidationResult(msg);
        }
    }
}