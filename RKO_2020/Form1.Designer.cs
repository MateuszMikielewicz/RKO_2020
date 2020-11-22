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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanelMENU = new System.Windows.Forms.FlowLayoutPanel();
            this.Czas_box = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelMENU.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 711);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanelMENU
            // 
            this.flowLayoutPanelMENU.BackColor = System.Drawing.Color.Blue;
            this.flowLayoutPanelMENU.Controls.Add(this.Czas_box);
            this.flowLayoutPanelMENU.Location = new System.Drawing.Point(1, 593);
            this.flowLayoutPanelMENU.Name = "flowLayoutPanelMENU";
            this.flowLayoutPanelMENU.Size = new System.Drawing.Size(1021, 119);
            this.flowLayoutPanelMENU.TabIndex = 0;
            // 
            // Czas_box
            // 
            this.Czas_box.Location = new System.Drawing.Point(3, 3);
            this.Czas_box.Multiline = true;
            this.Czas_box.Name = "Czas_box";
            this.Czas_box.Size = new System.Drawing.Size(129, 30);
            this.Czas_box.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 712);
            this.Controls.Add(this.flowLayoutPanelMENU);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanelMENU.ResumeLayout(false);
            this.flowLayoutPanelMENU.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMENU;
        private System.Windows.Forms.TextBox Czas_box;
    }
}

