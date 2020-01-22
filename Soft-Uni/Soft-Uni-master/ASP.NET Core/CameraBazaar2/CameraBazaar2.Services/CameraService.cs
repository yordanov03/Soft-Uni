using CameraBazaar2.Data;
using CameraBazaar2.Models;
using CameraBazaar2.Models.Enums;
using CameraBazaar2.Services.Infrastructure;
using CameraBazaar2.Services.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace CameraBazaar2.Services
{
    public class CameraService : ICameraService
    {
        private readonly CameraBazaarDbContext context;

        public CameraService(CameraBazaarDbContext context)
        {
            this.context = context;
        }

        public void AddCamera(string model, Make make, decimal price, int quantity, double minShutterSpeed, double maxShutterSpeed, MinIso minIso, int maxIso, bool fullFrame,
            string videoResolution, int lightMetering, string description, string imageURL, string userId)
        {
            var camera = new Camera()
            {
                Model = model,
                Make = make,
                Price = price,
                Quantity = quantity,
                MinShutterSpeed = minShutterSpeed,
                MaxShutterSpeed = maxShutterSpeed,
                MinISO = minIso,
                MaxIso = maxIso,
                IsFullFrame = fullFrame,
                LightMetering = lightMetering,
                VideoResolution = videoResolution,
                Description = description,
                ImageURL = imageURL,
                UserId = userId
            };
            context.Cameras.Add(camera);
            context.SaveChanges();
        }

        public void CamerasByUser(string userId)
        {

        }

        public void DeleteCamera(int cameraId)
        {
            var camera = GetCamera(cameraId);
            context.Cameras.Remove(camera);
            context.SaveChanges();
        }

        public void EditCamera(int cameraId)
        {
            var camera = GetCamera(cameraId);
        }
        public IEnumerable<CameraShortDetailsModel> GetAllCamerasDetails()
        {
            var cameras = this.context.Cameras
                .Select(c => new CameraShortDetailsModel()
                {
                    Make = c.Make,
                    Model = c.Model,
                    Price = c.Price,
                    ImageUrl = c.ImageURL,
                    CameraId = c.CameraId,
                    InStock = c.Quantity > 0,
                    SellerId = c.UserId
                }).ToList();

            return cameras;
        }
        internal Camera GetCamera(int cameraId)
        {
            return context.Cameras.Where(c => c.CameraId == cameraId).FirstOrDefault();
        }
    }
}
