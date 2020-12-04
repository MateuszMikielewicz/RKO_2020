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
            this.panel_głowny = new System.Windows.Forms.Panel();
            this.panelMENU = new System.Windows.Forms.Panel();
            this.CZAS_BOX = new System.Windows.Forms.Label();
            this.panelMENU.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel_głowny
            // 
            resources.ApplyResources(this.panel_głowny, "panel_głowny");
            this.panel_głowny.Name = "panel_głowny";
            // 
            // panelMENU
            // 
            this.panelMENU.BackColor = System.Drawing.Color.Green;
            this.panelMENU.Controls.Add(this.CZAS_BOX);
            resources.ApplyResources(this.panelMENU, "panelMENU");
            this.panelMENU.Name = "panelMENU";
            // 
            // CZAS_BOX
            // 
            resources.ApplyResources(this.CZAS_BOX, "CZAS_BOX");
            this.CZAS_BOX.Name = "CZAS_BOX";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMENU);
            this.Controls.Add(this.panel_głowny);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMENU.ResumeLayout(false);
            this.panelMENU.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel_głowny;
        private System.Windows.Forms.Panel panelMENU;
        private System.Windows.Forms.Label CZAS_BOX;
    }
}

