namespace RKO_2020
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelMENU = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Poziom_Życia = new System.Windows.Forms.Label();
            this.CZAS_BOX = new System.Windows.Forms.Label();
            this.panel_głowny = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer_sprawdzający = new System.Windows.Forms.Timer(this.components);
            this.panelMENU.SuspendLayout();
            this.panel_głowny.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelMENU
            // 
            this.panelMENU.BackColor = System.Drawing.Color.Green;
            this.panelMENU.Controls.Add(this.label1);
            this.panelMENU.Controls.Add(this.Poziom_Życia);
            this.panelMENU.Controls.Add(this.CZAS_BOX);
            resources.ApplyResources(this.panelMENU, "panelMENU");
            this.panelMENU.Name = "panelMENU";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // Poziom_Życia
            // 
            resources.ApplyResources(this.Poziom_Życia, "Poziom_Życia");
            this.Poziom_Życia.Name = "Poziom_Życia";
            // 
            // CZAS_BOX
            // 
            resources.ApplyResources(this.CZAS_BOX, "CZAS_BOX");
            this.CZAS_BOX.Name = "CZAS_BOX";
            // 
            // panel_głowny
            // 
            this.panel_głowny.BackgroundImage = global::RKO_2020.Properties.Resources.tło_gra_rko;
            resources.ApplyResources(this.panel_głowny, "panel_głowny");
            this.panel_głowny.Controls.Add(this.pictureBox1);
            this.panel_głowny.Name = "panel_głowny";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::RKO_2020.Properties.Resources.gotowy_do_ucisku;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // timer_sprawdzający
            // 
            this.timer_sprawdzający.Enabled = true;
            this.timer_sprawdzający.Interval = 40;
            this.timer_sprawdzający.Tick += new System.EventHandler(this.timer_sprawdzający_Tick);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMENU);
            this.Controls.Add(this.panel_głowny);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panelMENU.ResumeLayout(false);
            this.panelMENU.PerformLayout();
            this.panel_głowny.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel_głowny;
        private System.Windows.Forms.Panel panelMENU;
        private System.Windows.Forms.Label CZAS_BOX;
        private System.Windows.Forms.Label Poziom_Życia;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer_sprawdzający;
        public System.Windows.Forms.Label label1;
    }
}

