using FIT5032_Week06B.Util;
using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace FIT5032_Week06B.Models
{
    public class CarPlateViewModel
    {
        public State State { get; set; }

        [Required]
        [MaxLength(10)]
        [Remote("CheckCarPlate", "CarPlate",
            AdditionalFields = "State",
            HttpMethod = "POST", 
            ErrorMessage = "Invalid Car Plate")]
        public String CarPlate { get; set; }
    }
}