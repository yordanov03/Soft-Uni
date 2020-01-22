using CameraBazaar2.Common.Attributes;
using CameraBazaar2.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CameraBazaar2.Models.Cameras
{
    public class AddCameraViewModel
    {
        [Required]
        public Make Make { get; set; }

        public IEnumerable<KeyValuePair<string, int>> AvailableMakesValues
        {
            get
            {
                string[] names = Enum.GetNames(typeof(Make));
                int[] values = (int[])Enum.GetValues(typeof(Make));

                for (int i = 0; i < names.Length; i++)
                {
                    yield return new KeyValuePair<string, int>(names[i], values[i]);
                }
            }
        }

        [Required]
        public string Model { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "Quantity must be in range 0 - 100.")]
        public int Quantity { get; set; }

        [Required]
        [Range(0, 30, ErrorMessage = "MinShutterSpeed must be in range 0 - 30.")]
        [Display(Name = "Min Shutter Speed")]
        public int MinShutterSpeed { get; set; }

        [Required]
        [Range(2000, 8000, ErrorMessage = "MaxShutterSPeed must be in range 2000 - 8000.")]
        [Display(Name = "Max Shutter Speed")]
        public int MaxShutterSpeed { get; set; }

        [Required(ErrorMessage = "Must be either 50 or 100")]
        public MinIso MinISO { get; set; }

        [Required]
        [DividableBy100(200, 409600, 100, ErrorMessage = "MaxISO must be in range 200 - 409600, dividable by 100")]
        public int MaxISO { get; set; }

        [Required]
        [Display(Name = "Full frame")]
        public bool FullFrame { get; set; }

        [Required]
        [MaxLength(15)]
        [Display(Name = "Video Resolution")]
        public string VideoResolution { get; set; }

        [Required]
        [Display(Name = "Light Metering")]
        public IEnumerable<LightMetering> LightMetering { get; set; } = new List<LightMetering>();

        public IEnumerable<KeyValuePair<string, int>> AvailableMeteringValues
        {
            get
            {
                string[] names = Enum.GetNames(typeof(LightMetering));

                int[] values = (int[])Enum.GetValues(typeof(LightMetering));

                for (int i = 0; i < names.Length; i++)
                {
                    yield return new KeyValuePair<string, int>(names[i], values[i]);
                }
            }
        }

        [Required(ErrorMessage = "The description must be no more than 6000 symbols")]
        public string Description { get; set; }

        [Required(ErrorMessage = "A valid image url must start with http:// or https://")]
        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; }
    }
}
