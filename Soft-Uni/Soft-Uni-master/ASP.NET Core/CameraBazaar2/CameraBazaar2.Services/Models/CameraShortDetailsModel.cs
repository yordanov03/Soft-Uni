using CameraBazaar2.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CameraBazaar2.Services.Models
{
    public class CameraShortDetailsModel
    {
        public int CameraId { get; set; }

        public Make Make { get; set; }

        public string Model { get; set; }

        public decimal Price { get; set; }

        public bool InStock { get; set; }

        public string ImageUrl { get; set; }

        public string SellerId { get; set; }
    }
}
