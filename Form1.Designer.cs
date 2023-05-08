namespace GG1
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
            System.Windows.Forms.Timer timee;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnEasy = new System.Windows.Forms.Button();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnHard = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.picCo = new System.Windows.Forms.PictureBox();
            this.picBom = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRecords = new System.Windows.Forms.TextBox();
            this.lblRecords = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.ckMusic = new System.Windows.Forms.CheckBox();
            this.lblLevel = new System.Windows.Forms.Label();
            timee = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picCo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBom)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timee
            // 
            timee.Enabled = true;
            timee.Interval = 1000;
            timee.Tick += new System.EventHandler(this.time_Tick);
            // 
            // btnEasy
            // 
            this.btnEasy.Location = new System.Drawing.Point(41, 43);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(75, 23);
            this.btnEasy.TabIndex = 1;
            this.btnEasy.Text = "Easy";
            this.btnEasy.UseVisualStyleBackColor = true;
            this.btnEasy.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMedium
            // 
            this.btnMedium.Location = new System.Drawing.Point(41, 72);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(75, 23);
            this.btnMedium.TabIndex = 2;
            this.btnMedium.Text = "Medium";
            this.btnMedium.UseVisualStyleBackColor = true;
            this.btnMedium.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnHard
            // 
            this.btnHard.Location = new System.Drawing.Point(41, 101);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(75, 23);
            this.btnHard.TabIndex = 3;
            this.btnHard.Text = "Hard";
            this.btnHard.UseVisualStyleBackColor = true;
            this.btnHard.Click += new System.EventHandler(this.button3_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "bom.jpg");
            this.imageList1.Images.SetKeyName(1, "co.jpg");
            // 
            // picCo
            // 
            this.picCo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picCo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCo.Image = ((System.Drawing.Image)(resources.GetObject("picCo.Image")));
            this.picCo.Location = new System.Drawing.Point(603, 304);
            this.picCo.Name = "picCo";
            this.picCo.Size = new System.Drawing.Size(48, 50);
            this.picCo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCo.TabIndex = 5;
            this.picCo.TabStop = false;
            this.picCo.Visible = false;
            this.picCo.Click += new System.EventHandler(this.picCo_Click);
            // 
            // picBom
            // 
            this.picBom.Image = ((System.Drawing.Image)(resources.GetObject("picBom.Image")));
            this.picBom.Location = new System.Drawing.Point(603, 360);
            this.picBom.Name = "picBom";
            this.picBom.Size = new System.Drawing.Size(46, 50);
            this.picBom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBom.TabIndex = 6;
            this.picBom.TabStop = false;
            this.picBom.Visible = false;
            this.picBom.Click += new System.EventHandler(this.picBom_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtRecords);
            this.panel1.Controls.Add(this.lblRecords);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.ckMusic);
            this.panel1.Controls.Add(this.lblLevel);
            this.panel1.Controls.Add(this.btnEasy);
            this.panel1.Controls.Add(this.btnMedium);
            this.panel1.Controls.Add(this.btnHard);
            this.panel1.Location = new System.Drawing.Point(424, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 424);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 41);
            this.label1.TabIndex = 10;
            this.label1.Text = "Time :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRecords
            // 
            this.txtRecords.BackColor = System.Drawing.Color.Cyan;
            this.txtRecords.Location = new System.Drawing.Point(29, 242);
            this.txtRecords.Multiline = true;
            this.txtRecords.Name = "txtRecords";
            this.txtRecords.ReadOnly = true;
            this.txtRecords.Size = new System.Drawing.Size(100, 112);
            this.txtRecords.TabIndex = 9;
            this.txtRecords.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRecords
            // 
            this.lblRecords.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(29, 202);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(100, 37);
            this.lblRecords.TabIndex = 8;
            this.lblRecords.Text = "Records :";
            this.lblRecords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(87, 160);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(72, 42);
            this.lblTime.TabIndex = 7;
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // ckMusic
            // 
            this.ckMusic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ckMusic.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckMusic.Location = new System.Drawing.Point(43, 130);
            this.ckMusic.Name = "ckMusic";
            this.ckMusic.Size = new System.Drawing.Size(75, 27);
            this.ckMusic.TabIndex = 6;
            this.ckMusic.Text = "Music";
            this.ckMusic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckMusic.UseVisualStyleBackColor = false;
            this.ckMusic.CheckedChanged += new System.EventHandler(this.ckMusic_CheckedChanged);
            // 
            // lblLevel
            // 
            this.lblLevel.BackColor = System.Drawing.Color.Yellow;
            this.lblLevel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(29, 6);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(100, 23);
            this.lblLevel.TabIndex = 5;
            this.lblLevel.Text = "Level";
            this.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 422);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picBom);
            this.Controls.Add(this.picCo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBom)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Button btnHard;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox picCo;
        private System.Windows.Forms.PictureBox picBom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox ckMusic;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.TextBox txtRecords;
        private System.Windows.Forms.Label label1;
    }
}

