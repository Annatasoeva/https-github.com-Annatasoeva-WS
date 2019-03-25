namespace MainScreen
{
    partial class VisitorMenu
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
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelNBA = new System.Windows.Forms.Label();
            this.labelVisitorMenu = new System.Windows.Forms.Label();
            this.labelBack = new System.Windows.Forms.Button();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.labelInfo = new System.Windows.Forms.Label();
            this.panelthreebutton = new System.Windows.Forms.Panel();
            this.buttonPlayers = new System.Windows.Forms.Button();
            this.buttonTeams = new System.Windows.Forms.Button();
            this.buttonMatchups = new System.Windows.Forms.Button();
            this.buttonPhotos = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelInfo.SuspendLayout();
            this.panelthreebutton.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelBack);
            this.panel1.Controls.Add(this.labelVisitorMenu);
            this.panel1.Controls.Add(this.labelNBA);
            this.panel1.Controls.Add(this.pictureBoxLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxLogo.Image = global::MainScreen.Properties.Resources.logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(100, 98);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelNBA
            // 
            this.labelNBA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelNBA.AutoSize = true;
            this.labelNBA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNBA.Location = new System.Drawing.Point(106, 40);
            this.labelNBA.Name = "labelNBA";
            this.labelNBA.Size = new System.Drawing.Size(166, 16);
            this.labelNBA.TabIndex = 1;
            this.labelNBA.Text = "NBA Management System";
            // 
            // labelVisitorMenu
            // 
            this.labelVisitorMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelVisitorMenu.AutoSize = true;
            this.labelVisitorMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVisitorMenu.Location = new System.Drawing.Point(387, 38);
            this.labelVisitorMenu.Name = "labelVisitorMenu";
            this.labelVisitorMenu.Size = new System.Drawing.Size(90, 18);
            this.labelVisitorMenu.TabIndex = 2;
            this.labelVisitorMenu.Text = "Visitor Menu";
            // 
            // labelBack
            // 
            this.labelBack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBack.Location = new System.Drawing.Point(701, 37);
            this.labelBack.Name = "labelBack";
            this.labelBack.Size = new System.Drawing.Size(75, 23);
            this.labelBack.TabIndex = 3;
            this.labelBack.Text = "Back";
            this.labelBack.UseVisualStyleBackColor = true;
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.panelInfo.Controls.Add(this.labelInfo);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelInfo.Location = new System.Drawing.Point(0, 399);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(800, 51);
            this.panelInfo.TabIndex = 1;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.CausesValidation = false;
            this.labelInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelInfo.Location = new System.Drawing.Point(207, 19);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(401, 13);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = "«The current season is 2016–2017, and the NBA already has a history of 71 years»." +
    "";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panelthreebutton
            // 
            this.panelthreebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelthreebutton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelthreebutton.Controls.Add(this.buttonPhotos);
            this.panelthreebutton.Controls.Add(this.buttonMatchups);
            this.panelthreebutton.Controls.Add(this.buttonPlayers);
            this.panelthreebutton.Controls.Add(this.buttonTeams);
            this.panelthreebutton.Location = new System.Drawing.Point(54, 126);
            this.panelthreebutton.Name = "panelthreebutton";
            this.panelthreebutton.Size = new System.Drawing.Size(704, 243);
            this.panelthreebutton.TabIndex = 2;
            this.panelthreebutton.Paint += new System.Windows.Forms.PaintEventHandler(this.panelthreebutton_Paint);
            // 
            // buttonPlayers
            // 
            this.buttonPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.buttonPlayers.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonPlayers.Location = new System.Drawing.Point(394, 41);
            this.buttonPlayers.Name = "buttonPlayers";
            this.buttonPlayers.Size = new System.Drawing.Size(159, 46);
            this.buttonPlayers.TabIndex = 1;
            this.buttonPlayers.Text = "Players";
            this.buttonPlayers.UseVisualStyleBackColor = false;
            // 
            // buttonTeams
            // 
            this.buttonTeams.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTeams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.buttonTeams.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonTeams.Location = new System.Drawing.Point(119, 41);
            this.buttonTeams.Name = "buttonTeams";
            this.buttonTeams.Size = new System.Drawing.Size(159, 46);
            this.buttonTeams.TabIndex = 0;
            this.buttonTeams.Text = "Teams";
            this.buttonTeams.UseVisualStyleBackColor = false;
            // 
            // buttonMatchups
            // 
            this.buttonMatchups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMatchups.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.buttonMatchups.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonMatchups.Location = new System.Drawing.Point(119, 143);
            this.buttonMatchups.Name = "buttonMatchups";
            this.buttonMatchups.Size = new System.Drawing.Size(159, 46);
            this.buttonMatchups.TabIndex = 2;
            this.buttonMatchups.Text = "Matchups";
            this.buttonMatchups.UseVisualStyleBackColor = false;
            // 
            // buttonPhotos
            // 
            this.buttonPhotos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.buttonPhotos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPhotos.Location = new System.Drawing.Point(394, 143);
            this.buttonPhotos.Name = "buttonPhotos";
            this.buttonPhotos.Size = new System.Drawing.Size(159, 46);
            this.buttonPhotos.TabIndex = 3;
            this.buttonPhotos.Text = "Photos";
            this.buttonPhotos.UseVisualStyleBackColor = false;
            // 
            // VisitorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelthreebutton);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panel1);
            this.Name = "VisitorMenu";
            this.Text = "VisitorMenu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelthreebutton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelNBA;
        private System.Windows.Forms.Label labelVisitorMenu;
        private System.Windows.Forms.Button labelBack;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Panel panelthreebutton;
        private System.Windows.Forms.Button buttonPhotos;
        private System.Windows.Forms.Button buttonMatchups;
        private System.Windows.Forms.Button buttonPlayers;
        private System.Windows.Forms.Button buttonTeams;
    }
}