using WinAppDemo.DI.Contracts;

namespace WinAppDemo.DI
{
    class NewFancySecurityCamera : ICamera
    {
        public string CapturePicture()
        {
            return ("Camera captured picture.");
        }

        public string ConfigureCamera()
        {
            return ("Camera is now configured.");
        }
    }
}
