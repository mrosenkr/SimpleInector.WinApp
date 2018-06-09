using System;
using System.Windows.Forms;
using WinAppDemo.DI.Contracts;

namespace WinAppDemo.DI
{
    public partial class Form1 : Form
    {
        private readonly ICamera camera;

        // Constructure Injection.  Fetch an instance of camera from the IoC Container when the form is requested
        public Form1(ICamera camera)
        {
            this.camera = camera;

            InitializeComponent();
        }

        private void btnCameraConfigure_Click(object sender, EventArgs e)
        {
            string result = camera.ConfigureCamera();

            lblOutput.Text = result;
        }

        private void btnCameraCapture_Click(object sender, EventArgs e)
        {
            string result = camera.CapturePicture();

            lblOutput.Text = result;
        }
    }
}
