using CameraBazaar2.Models.Enums;
using CameraBazaar2.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CameraBazaar2.Services.Infrastructure
{
    public interface ICameraService
    {
        void AddCamera(string model, Make make, decimal price, int quantity, double minShutterSpeed, double maxShutterSpeed, MinIso minIso, int maxIso, bool fullFrame, 
            string videoResolution, int lightMetering, string description, string imageURL, string userId);
        void CamerasByUser(string userId);
        void EditCamera(int cameraId);
        void DeleteCamera(int cameraId);
        IEnumerable<CameraShortDetailsModel> GetAllCamerasDetails();
    }
}
