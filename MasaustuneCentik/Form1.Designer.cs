namespace MasaustuneCentik
{
    partial class frmCentik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCentik));
            this.lblSaat = new System.Windows.Forms.Label();
            this.tmrSaat = new System.Windows.Forms.Timer(this.components);
            this.tmrIndir = new System.Windows.Forms.Timer(this.components);
            this.tmrKaldir = new System.Windows.Forms.Timer(this.components);
            this.lblHaber = new System.Windows.Forms.Label();
            this.tmrHaber = new System.Windows.Forms.Timer(this.components);
            this.pnlInternet = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblSaat
            // 
            this.lblSaat.BackColor = System.Drawing.Color.Transparent;
            this.lblSaat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSaat.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSaat.Location = new System.Drawing.Point(0, 51);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(360, 39);
            this.lblSaat.TabIndex = 0;
            this.lblSaat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSaat.MouseHover += new System.EventHandler(this.lblSaat_MouseHover);
            // 
            // tmrSaat
            // 
            this.tmrSaat.Interval = 1000;
            this.tmrSaat.Tick += new System.EventHandler(this.tmrSaat_Tick);
            // 
            // tmrIndir
            // 
            this.tmrIndir.Interval = 1;
            this.tmrIndir.Tick += new System.EventHandler(this.tmrIndir_Tick);
            // 
            // tmrKaldir
            // 
            this.tmrKaldir.Interval = 1;
            this.tmrKaldir.Tick += new System.EventHandler(this.tmrKaldir_Tick);
            // 
            // lblHaber
            // 
            this.lblHaber.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHaber.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHaber.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHaber.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHaber.Location = new System.Drawing.Point(0, 0);
            this.lblHaber.Name = "lblHaber";
            this.lblHaber.Size = new System.Drawing.Size(360, 51);
            this.lblHaber.TabIndex = 1;
            this.lblHaber.MouseLeave += new System.EventHandler(this.lblHaber_MouseLeave);
            // 
            // tmrHaber
            // 
            this.tmrHaber.Interval = 400;
            this.tmrHaber.Tick += new System.EventHandler(this.tmrHaber_Tick);
            // 
            // pnlInternet
            // 
            this.pnlInternet.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlInternet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlInternet.Location = new System.Drawing.Point(315, 63);
            this.pnlInternet.Name = "pnlInternet";
            this.pnlInternet.Size = new System.Drawing.Size(15, 15);
            this.pnlInternet.TabIndex = 2;
            // 
            // frmCentik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(360, 90);
            this.Controls.Add(this.pnlInternet);
            this.Controls.Add(this.lblHaber);
            this.Controls.Add(this.lblSaat);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCentik";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Çentik";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.AppWorkspace;
            this.Load += new System.EventHandler(this.frmCentik_Load);
            this.MouseLeave += new System.EventHandler(this.frmCentik_MouseLeave);
            this.MouseHover += new System.EventHandler(this.frmCentik_MouseHover);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Timer tmrSaat;
        private System.Windows.Forms.Timer tmrIndir;
        private System.Windows.Forms.Timer tmrKaldir;
        private System.Windows.Forms.Label lblHaber;
        private System.Windows.Forms.Timer tmrHaber;
        private System.Windows.Forms.Panel pnlInternet;
    }
}

