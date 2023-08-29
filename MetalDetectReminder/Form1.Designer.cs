namespace MetalDetectReminder
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mainText = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.mainPicture = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxBottom = new System.Windows.Forms.PictureBox();
            this.pictureBoxTop = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTop)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // mainText
            // 
            this.mainText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainText.AutoSize = true;
            this.mainText.BackColor = System.Drawing.Color.Transparent;
            this.mainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 44.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainText.ForeColor = System.Drawing.Color.Red;
            this.mainText.Location = new System.Drawing.Point(31, 684);
            this.mainText.Name = "mainText";
            this.mainText.Size = new System.Drawing.Size(1120, 85);
            this.mainText.TabIndex = 2;
            this.mainText.Text = "Please check the metal detector";
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonOK.BackColor = System.Drawing.Color.Khaki;
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.Location = new System.Drawing.Point(371, 799);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(520, 119);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // mainPicture
            // 
            this.mainPicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainPicture.BackColor = System.Drawing.Color.Transparent;
            this.mainPicture.Image = global::MetalDetectReminder.Properties.Resources.noun_metal_detector;
            this.mainPicture.Location = new System.Drawing.Point(333, 59);
            this.mainPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainPicture.Name = "mainPicture";
            this.mainPicture.Size = new System.Drawing.Size(595, 576);
            this.mainPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.mainPicture.TabIndex = 4;
            this.mainPicture.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 700;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBoxBottom
            // 
            this.pictureBoxBottom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxBottom.BackColor = System.Drawing.Color.Red;
            this.pictureBoxBottom.Location = new System.Drawing.Point(11, 955);
            this.pictureBoxBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxBottom.Name = "pictureBoxBottom";
            this.pictureBoxBottom.Size = new System.Drawing.Size(1240, 10);
            this.pictureBoxBottom.TabIndex = 9;
            this.pictureBoxBottom.TabStop = false;
            // 
            // pictureBoxTop
            // 
            this.pictureBoxTop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxTop.BackColor = System.Drawing.Color.Red;
            this.pictureBoxTop.Location = new System.Drawing.Point(11, 12);
            this.pictureBoxTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxTop.Name = "pictureBoxTop";
            this.pictureBoxTop.Size = new System.Drawing.Size(1240, 10);
            this.pictureBoxTop.TabIndex = 10;
            this.pictureBoxTop.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MetalDetectReminder.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1261, 977);
            this.Controls.Add(this.pictureBoxTop);
            this.Controls.Add(this.pictureBoxBottom);
            this.Controls.Add(this.mainPicture);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.mainText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label mainText;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.PictureBox mainPicture;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBoxBottom;
        private System.Windows.Forms.PictureBox pictureBoxTop;
    }
}

