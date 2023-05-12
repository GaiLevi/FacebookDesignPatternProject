
namespace BasicFacebookFeatures
{
    partial class FormEditPicture
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
            this.panelEditPicture = new System.Windows.Forms.Panel();
            this.buttonColor = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.buttonSavePicture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEditPicture
            // 
            this.panelEditPicture.Location = new System.Drawing.Point(12, 51);
            this.panelEditPicture.Name = "panelEditPicture";
            this.panelEditPicture.Size = new System.Drawing.Size(500, 500);
            this.panelEditPicture.TabIndex = 0;
            this.panelEditPicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelEditPicture_MouseDown);
            this.panelEditPicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelEditPicture_MouseMove);
            this.panelEditPicture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelEditPicture_MouseUp);
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(437, 13);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(75, 23);
            this.buttonColor.TabIndex = 1;
            this.buttonColor.Text = "Color";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(243, 0);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(188, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Value = 5;
            // 
            // buttonSavePicture
            // 
            this.buttonSavePicture.Location = new System.Drawing.Point(13, 13);
            this.buttonSavePicture.Name = "buttonSavePicture";
            this.buttonSavePicture.Size = new System.Drawing.Size(75, 23);
            this.buttonSavePicture.TabIndex = 3;
            this.buttonSavePicture.Text = "Save";
            this.buttonSavePicture.UseVisualStyleBackColor = true;
            this.buttonSavePicture.Click += new System.EventHandler(this.buttonSavePicture_Click);
            // 
            // FormEditPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 562);
            this.Controls.Add(this.buttonSavePicture);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.panelEditPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormEditPicture";
            this.Text = "FormEditPicture";
            this.Load += new System.EventHandler(this.formEditPicture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelEditPicture;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button buttonSavePicture;
    }
}