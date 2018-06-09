namespace WinAppDemo.DI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCameraOptions = new System.Windows.Forms.Label();
            this.btnCameraCapture = new System.Windows.Forms.Button();
            this.btnCameraConfigure = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCameraOptions);
            this.panel1.Controls.Add(this.btnCameraCapture);
            this.panel1.Controls.Add(this.btnCameraConfigure);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 100);
            this.panel1.TabIndex = 3;
            // 
            // lblCameraOptions
            // 
            this.lblCameraOptions.AutoSize = true;
            this.lblCameraOptions.Location = new System.Drawing.Point(167, 21);
            this.lblCameraOptions.Name = "lblCameraOptions";
            this.lblCameraOptions.Size = new System.Drawing.Size(82, 13);
            this.lblCameraOptions.TabIndex = 5;
            this.lblCameraOptions.Text = "Camera Options";
            // 
            // btnCameraCapture
            // 
            this.btnCameraCapture.Location = new System.Drawing.Point(265, 57);
            this.btnCameraCapture.Name = "btnCameraCapture";
            this.btnCameraCapture.Size = new System.Drawing.Size(75, 23);
            this.btnCameraCapture.TabIndex = 4;
            this.btnCameraCapture.Text = "Capture";
            this.btnCameraCapture.UseVisualStyleBackColor = true;
            this.btnCameraCapture.Click += new System.EventHandler(this.btnCameraCapture_Click);
            // 
            // btnCameraConfigure
            // 
            this.btnCameraConfigure.Location = new System.Drawing.Point(54, 57);
            this.btnCameraConfigure.Name = "btnCameraConfigure";
            this.btnCameraConfigure.Size = new System.Drawing.Size(75, 23);
            this.btnCameraConfigure.TabIndex = 3;
            this.btnCameraConfigure.Text = "Configure";
            this.btnCameraConfigure.UseVisualStyleBackColor = true;
            this.btnCameraConfigure.Click += new System.EventHandler(this.btnCameraConfigure_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(13, 119);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(77, 13);
            this.lblOutput.TabIndex = 4;
            this.lblOutput.Text = "Camera Ready";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 184);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCameraOptions;
        private System.Windows.Forms.Button btnCameraCapture;
        private System.Windows.Forms.Button btnCameraConfigure;
        private System.Windows.Forms.Label lblOutput;
    }
}

