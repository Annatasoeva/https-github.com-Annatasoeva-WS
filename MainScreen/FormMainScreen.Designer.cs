namespace MainScreen
{
    partial class FormMainScreen
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainScreen));
            this.panelInfo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelButton = new System.Windows.Forms.Panel();
            this.labelWelcom = new System.Windows.Forms.Label();
            this.labelManagement = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.panelFoto = new System.Windows.Forms.Panel();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.pictureBoxFoto1 = new System.Windows.Forms.PictureBox();
            this.pictureFoto2 = new System.Windows.Forms.PictureBox();
            this.pictureFoto3 = new System.Windows.Forms.PictureBox();
            this.panelInfo.SuspendLayout();
            this.panelButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelFoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFoto2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFoto3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.panelInfo.Controls.Add(this.label1);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelInfo.Location = new System.Drawing.Point(0, 403);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(828, 51);
            this.panelInfo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.CausesValidation = false;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(207, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "«The current season is 2016–2017, and the NBA already has a history of 71 years»." +
    "";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panelButton
            // 
            this.panelButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelButton.Controls.Add(this.labelWelcom);
            this.panelButton.Controls.Add(this.labelManagement);
            this.panelButton.Controls.Add(this.pictureBox1);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButton.Location = new System.Drawing.Point(0, 0);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(828, 130);
            this.panelButton.TabIndex = 2;
            // 
            // labelWelcom
            // 
            this.labelWelcom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelWelcom.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWelcom.Location = new System.Drawing.Point(100, 66);
            this.labelWelcom.Name = "labelWelcom";
            this.labelWelcom.Size = new System.Drawing.Size(728, 64);
            this.labelWelcom.TabIndex = 2;
            this.labelWelcom.Text = "Welcome to use this NBA Management system, you can redirect to different pages ac" +
    "cording to your role by clicking the buttons bellow.";
            this.labelWelcom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelManagement
            // 
            this.labelManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelManagement.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelManagement.Location = new System.Drawing.Point(100, 0);
            this.labelManagement.Name = "labelManagement";
            this.labelManagement.Size = new System.Drawing.Size(728, 66);
            this.labelManagement.TabIndex = 1;
            this.labelManagement.Text = "NBA Management System";
            this.labelManagement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 130);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(828, 86);
            this.panelTitle.TabIndex = 3;
            // 
            // panelFoto
            // 
            this.panelFoto.Controls.Add(this.pictureFoto3);
            this.panelFoto.Controls.Add(this.pictureFoto2);
            this.panelFoto.Controls.Add(this.pictureBoxFoto1);
            this.panelFoto.Controls.Add(this.buttonRight);
            this.panelFoto.Controls.Add(this.buttonLeft);
            this.panelFoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFoto.Location = new System.Drawing.Point(0, 216);
            this.panelFoto.Name = "panelFoto";
            this.panelFoto.Size = new System.Drawing.Size(828, 187);
            this.panelFoto.TabIndex = 4;
            // 
            // buttonLeft
            // 
            this.buttonLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLeft.Location = new System.Drawing.Point(0, 0);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(75, 187);
            this.buttonLeft.TabIndex = 0;
            this.buttonLeft.Text = "<";
            this.buttonLeft.UseVisualStyleBackColor = true;
            // 
            // buttonRight
            // 
            this.buttonRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRight.Location = new System.Drawing.Point(753, 0);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(75, 187);
            this.buttonRight.TabIndex = 1;
            this.buttonRight.Text = ">";
            this.buttonRight.UseVisualStyleBackColor = true;
            // 
            // pictureBoxFoto1
            // 
            this.pictureBoxFoto1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxFoto1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBoxFoto1.Location = new System.Drawing.Point(140, 79);
            this.pictureBoxFoto1.Name = "pictureBoxFoto1";
            this.pictureBoxFoto1.Padding = new System.Windows.Forms.Padding(10);
            this.pictureBoxFoto1.Size = new System.Drawing.Size(150, 78);
            this.pictureBoxFoto1.TabIndex = 2;
            this.pictureBoxFoto1.TabStop = false;
            // 
            // pictureFoto2
            // 
            this.pictureFoto2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureFoto2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureFoto2.Location = new System.Drawing.Point(339, 79);
            this.pictureFoto2.Name = "pictureFoto2";
            this.pictureFoto2.Padding = new System.Windows.Forms.Padding(10);
            this.pictureFoto2.Size = new System.Drawing.Size(148, 78);
            this.pictureFoto2.TabIndex = 3;
            this.pictureFoto2.TabStop = false;
            // 
            // pictureFoto3
            // 
            this.pictureFoto3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureFoto3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pictureFoto3.Location = new System.Drawing.Point(531, 79);
            this.pictureFoto3.Name = "pictureFoto3";
            this.pictureFoto3.Padding = new System.Windows.Forms.Padding(10);
            this.pictureFoto3.Size = new System.Drawing.Size(152, 78);
            this.pictureFoto3.TabIndex = 4;
            this.pictureFoto3.TabStop = false;
            // 
            // FormMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 454);
            this.Controls.Add(this.panelFoto);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelButton);
            this.Controls.Add(this.panelInfo);
            this.Name = "FormMainScreen";
            this.Text = "Main Screen";
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelFoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFoto2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFoto3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelWelcom;
        private System.Windows.Forms.Label labelManagement;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelFoto;
        private System.Windows.Forms.PictureBox pictureFoto3;
        private System.Windows.Forms.PictureBox pictureFoto2;
        private System.Windows.Forms.PictureBox pictureBoxFoto1;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonLeft;
    }
}

