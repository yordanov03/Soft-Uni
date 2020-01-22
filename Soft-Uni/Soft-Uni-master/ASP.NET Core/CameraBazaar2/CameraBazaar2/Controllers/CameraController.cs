using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CameraBazaar2.Models;
using CameraBazaar2.Models.Cameras;
using CameraBazaar2.Services.Infrastructure;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace CameraBazaar2.Controllers
{
    public class CameraController :Controller
    {
         public readonly ICameraService cameraService;
        public readonly UserManager<User> userManager;

        public CameraController(ICameraService cameraService, UserManager<User> userManager)
        {
            this.cameraService = cameraService;
            this.userManager = userManager;
        }

        [HttpGet]
        public IActionResult AddCamera()
        {
            return View(new AddCameraViewModel());
        }

        [HttpPost]
        public IActionResult AddCamera( AddCameraViewModel camModel)
        {
            if (!ModelState.IsValid)
            {
                return View(new AddCameraViewModel());
            }

            this.cameraService.AddCamera(camModel.Model, camModel.Make, camModel.Price, camModel.Quantity, camModel.MinShutterSpeed, camModel.MaxShutterSpeed, camModel.MinISO, camModel.MaxISO,
                camModel.FullFrame, camModel.VideoResolution, camModel.LightMetering.Sum(s=>(int)s) , camModel.Description, camModel.ImageUrl, userManager.GetUserId(User));

            return RedirectToAction(nameof(AllCameras));
        }

        public IActionResult AllCameras()
        {
            return View(this.cameraService.GetAllCamerasDetails());
        }
    }
}
