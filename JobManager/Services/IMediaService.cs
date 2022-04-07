using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace JobManager.Services
{
    public interface IMediaService
    {
        //Related Documentation:
        //https://docs.microsoft.com/en-us/xamarin/xamarin-forms/app-fundamentals/dependency-service/introduction
        //https://github.com/xamarin/xamarin-forms-samples/tree/main/DependencyService

        Task<Image> CapturePhotoAsync(); //camera to take a photo.
        //Task PickPhotoAsync(); //media browser to select a photo.
        //Task PickVideoAsync(); //media browser to select a video.
        //Task CaptureVideoAsync(); //camera to make a video.

    }
}
