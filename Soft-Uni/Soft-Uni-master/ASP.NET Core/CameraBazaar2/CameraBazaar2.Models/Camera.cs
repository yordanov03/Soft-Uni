using CameraBazaar2.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CameraBazaar2.Models
{
    public class Camera
    {
        public int CameraId { get; set; }
        public Make Make { get; set; }


        [RegularExpression("^[A-Z-0-9]+$", ErrorMessage = "The {0} can contain only uppercase letters, digits and dash ('-'). Cannot be empty")]
        public string Model { get; set; }
        [RegularExpression(@"^\d+\.\d{0,2}$")]

        public decimal Price { get; set; }


        [Range(0,100, ErrorMessage = "Quantity must be between 0 and 100!")]
        public int Quantity { get; set; }

        [Range(1,30)]
        public double MinShutterSpeed { get; set; }


        [Range(2000,8000, ErrorMessage = "Must be between 2000 and 8000!")]
        [RegularExpression("\\d+00$", ErrorMessage = "The {0} must be dividable by 100.")]
        public double MaxShutterSpeed { get; set; }


        public MinIso MinISO { get; set; }
        [Range(200, 409600, ErrorMessage = "The {0} must be in range {1}-{2}.")]
        [RegularExpression("\\d+00$", ErrorMessage = "The {0} must be dividable by 100.")]
        public int MaxIso { get; set; }

        public bool IsFullFrame { get; set; }
        [MaxLength(15)]
        public string VideoResolution { get; set; }

        public int LightMetering { get; set; }
        [MaxLength(6000)]
        public string Description { get; set; }
        [RegularExpression(@"^(http:\/\/|https:\/\/).+", ErrorMessage = "The {0} must start with 'http://' or 'https://'.")]
        public string ImageURL { get; set; }

        public User User { get; set; }
        public string UserId { get; set; }
    }
}
