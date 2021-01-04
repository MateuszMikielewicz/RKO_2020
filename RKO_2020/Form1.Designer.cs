using System.Windows.Forms;

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
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Poziom_Życia = new System.Windows.Forms.Label();
            this.CZAS_BOX = new System.Windows.Forms.Label();
            this.timer_sprawdzający = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_głowny = new System.Windows.Forms.Panel();
            this.panel_wyboru3 = new System.Windows.Forms.Panel();
            this.opcja2_label_3 = new System.Windows.Forms.Label();
            this.opcja1_label_3 = new System.Windows.Forms.Label();
            this.opcja1_3 = new System.Windows.Forms.Button();
            this.opcja2_3 = new System.Windows.Forms.Button();
            this.panel_wyboru2 = new System.Windows.Forms.Panel();
            this.opcja2_label_2 = new System.Windows.Forms.Label();
            this.opcja1_label_2 = new System.Windows.Forms.Label();
            this.opcja1_2 = new System.Windows.Forms.Button();
            this.opcja2_2 = new System.Windows.Forms.Button();
            this.obserwator_pictureBox = new System.Windows.Forms.PictureBox();
            this.glowa_pictureBox = new System.Windows.Forms.PictureBox();
            this.tułow_pictureBox = new System.Windows.Forms.PictureBox();
            this.głowne_postaci_pictureBox = new System.Windows.Forms.PictureBox();
            this.panel_wyboru1 = new System.Windows.Forms.Panel();
            this.opcja3_label_1 = new System.Windows.Forms.Label();
            this.opcja2_label_1 = new System.Windows.Forms.Label();
            this.opcja1_label_1 = new System.Windows.Forms.Label();
            this.opcja1 = new System.Windows.Forms.Button();
            this.opcja2 = new System.Windows.Forms.Button();
            this.opcja3 = new System.Windows.Forms.Button();
            this.dymek_1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dymek_2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dymek_3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.panelMENU.SuspendLayout();
            this.panel_głowny.SuspendLayout();
            this.panel_wyboru3.SuspendLayout();
            this.panel_wyboru2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.obserwator_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glowa_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tułow_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.głowne_postaci_pictureBox)).BeginInit();
            this.panel_wyboru1.SuspendLayout();
            this.dymek_1.SuspendLayout();
            this.dymek_2.SuspendLayout();
            this.dymek_3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.panelMENU.BackColor = System.Drawing.Color.SteelBlue;
            this.panelMENU.Controls.Add(this.button4);
            this.panelMENU.Controls.Add(this.label1);
            this.panelMENU.Controls.Add(this.button3);
            this.panelMENU.Controls.Add(this.Poziom_Życia);
            this.panelMENU.Controls.Add(this.CZAS_BOX);
            resources.ApplyResources(this.panelMENU, "panelMENU");
            this.panelMENU.Name = "panelMENU";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Firebrick;
            resources.ApplyResources(this.button3, "button3");
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Name = "button3";
            this.button3.TabStop = false;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Firebrick;
            resources.ApplyResources(this.button4, "button4");
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Name = "button4";
            this.button4.TabStop = false;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Name = "label1";
            // 
            // Poziom_Życia
            // 
            resources.ApplyResources(this.Poziom_Życia, "Poziom_Życia");
            this.Poziom_Życia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Poziom_Życia.Name = "Poziom_Życia";
            // 
            // CZAS_BOX
            // 
            resources.ApplyResources(this.CZAS_BOX, "CZAS_BOX");
            this.CZAS_BOX.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CZAS_BOX.Name = "CZAS_BOX";
            // 
            // timer_sprawdzający
            // 
            this.timer_sprawdzający.Enabled = true;
            this.timer_sprawdzający.Interval = 40;
            this.timer_sprawdzający.Tick += new System.EventHandler(this.timer_sprawdzający_Tick);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Name = "label3";
            // 
            // panel_głowny
            // 
            this.panel_głowny.BackgroundImage = global::RKO_2020.Properties.Resources.tło_gra_rko;
            resources.ApplyResources(this.panel_głowny, "panel_głowny");
            this.panel_głowny.Controls.Add(this.panel_wyboru3);
            this.panel_głowny.Controls.Add(this.obserwator_pictureBox);
            this.panel_głowny.Controls.Add(this.panel_wyboru2);
            this.panel_głowny.Controls.Add(this.glowa_pictureBox);
            this.panel_głowny.Controls.Add(this.tułow_pictureBox);
            this.panel_głowny.Controls.Add(this.głowne_postaci_pictureBox);
            this.panel_głowny.Controls.Add(this.panel_wyboru1);
            this.panel_głowny.Name = "panel_głowny";
            this.panel_głowny.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_głowny_MouseMove);
            // 
            // panel_wyboru3
            // 
            resources.ApplyResources(this.panel_wyboru3, "panel_wyboru3");
            this.panel_wyboru3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel_wyboru3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_wyboru3.Controls.Add(this.opcja2_label_3);
            this.panel_wyboru3.Controls.Add(this.opcja1_label_3);
            this.panel_wyboru3.Controls.Add(this.opcja1_3);
            this.panel_wyboru3.Controls.Add(this.opcja2_3);
            this.panel_wyboru3.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel_wyboru3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel_wyboru3.Name = "panel_wyboru3";
            // 
            // opcja2_label_3
            // 
            resources.ApplyResources(this.opcja2_label_3, "opcja2_label_3");
            this.opcja2_label_3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.opcja2_label_3.Name = "opcja2_label_3";
            // 
            // opcja1_label_3
            // 
            resources.ApplyResources(this.opcja1_label_3, "opcja1_label_3");
            this.opcja1_label_3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.opcja1_label_3.Name = "opcja1_label_3";
            // 
            // opcja1_3
            // 
            this.opcja1_3.BackColor = System.Drawing.Color.Firebrick;
            resources.ApplyResources(this.opcja1_3, "opcja1_3");
            this.opcja1_3.ForeColor = System.Drawing.Color.White;
            this.opcja1_3.Name = "opcja1_3";
            this.opcja1_3.TabStop = false;
            this.opcja1_3.UseVisualStyleBackColor = false;
            this.opcja1_3.Click += new System.EventHandler(this.opcja1_Click);
            // 
            // opcja2_3
            // 
            this.opcja2_3.BackColor = System.Drawing.Color.Firebrick;
            resources.ApplyResources(this.opcja2_3, "opcja2_3");
            this.opcja2_3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.opcja2_3.Name = "opcja2_3";
            this.opcja2_3.TabStop = false;
            this.opcja2_3.UseVisualStyleBackColor = false;
            this.opcja2_3.Click += new System.EventHandler(this.opcja2_Click);
            // 
            // panel_wyboru2
            // 
            resources.ApplyResources(this.panel_wyboru2, "panel_wyboru2");
            this.panel_wyboru2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel_wyboru2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_wyboru2.Controls.Add(this.opcja2_label_2);
            this.panel_wyboru2.Controls.Add(this.opcja1_label_2);
            this.panel_wyboru2.Controls.Add(this.opcja1_2);
            this.panel_wyboru2.Controls.Add(this.opcja2_2);
            this.panel_wyboru2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel_wyboru2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel_wyboru2.Name = "panel_wyboru2";
            // 
            // opcja2_label_2
            // 
            resources.ApplyResources(this.opcja2_label_2, "opcja2_label_2");
            this.opcja2_label_2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.opcja2_label_2.Name = "opcja2_label_2";
            // 
            // opcja1_label_2
            // 
            resources.ApplyResources(this.opcja1_label_2, "opcja1_label_2");
            this.opcja1_label_2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.opcja1_label_2.Name = "opcja1_label_2";
            // 
            // opcja1_2
            // 
            this.opcja1_2.BackColor = System.Drawing.Color.Firebrick;
            resources.ApplyResources(this.opcja1_2, "opcja1_2");
            this.opcja1_2.ForeColor = System.Drawing.Color.White;
            this.opcja1_2.Name = "opcja1_2";
            this.opcja1_2.TabStop = false;
            this.opcja1_2.UseVisualStyleBackColor = false;
            this.opcja1_2.Click += new System.EventHandler(this.opcja1_Click);
            // 
            // opcja2_2
            // 
            this.opcja2_2.BackColor = System.Drawing.Color.Firebrick;
            resources.ApplyResources(this.opcja2_2, "opcja2_2");
            this.opcja2_2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.opcja2_2.Name = "opcja2_2";
            this.opcja2_2.TabStop = false;
            this.opcja2_2.UseVisualStyleBackColor = false;
            this.opcja2_2.Click += new System.EventHandler(this.opcja2_Click);
            // 
            // obserwator_pictureBox
            // 
            this.obserwator_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.obserwator_pictureBox.Image = global::RKO_2020.Properties.Resources.obserwator;
            resources.ApplyResources(this.obserwator_pictureBox, "obserwator_pictureBox");
            this.obserwator_pictureBox.Name = "obserwator_pictureBox";
            this.obserwator_pictureBox.TabStop = false;
            this.obserwator_pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.obserwator_pictureBox_MouseClick);
            this.obserwator_pictureBox.MouseEnter += new System.EventHandler(this.obserwator_pictureBox_MouseEnter);
            this.obserwator_pictureBox.MouseLeave += new System.EventHandler(this.obserwator_pictureBox_MouseLeave);
            // 
            // glowa_pictureBox
            // 
            this.glowa_pictureBox.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.glowa_pictureBox, "glowa_pictureBox");
            this.glowa_pictureBox.Name = "glowa_pictureBox";
            this.glowa_pictureBox.TabStop = false;
            this.glowa_pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.glowa_pictureBox_MouseClick);
            this.glowa_pictureBox.MouseEnter += new System.EventHandler(this.glowa_pictureBox_MouseEnter);
            this.glowa_pictureBox.MouseLeave += new System.EventHandler(this.glowa_pictureBox_MouseLeave);
            // 
            // tułow_pictureBox
            // 
            this.tułow_pictureBox.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.tułow_pictureBox, "tułow_pictureBox");
            this.tułow_pictureBox.Name = "tułow_pictureBox";
            this.tułow_pictureBox.TabStop = false;
            this.tułow_pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tułow_pictureBox_MouseClick);
            this.tułow_pictureBox.MouseEnter += new System.EventHandler(this.tułow_pictureBox_MouseEnter);
            this.tułow_pictureBox.MouseLeave += new System.EventHandler(this.tułow_pictureBox_MouseLeave);
            // 
            // głowne_postaci_pictureBox
            // 
            this.głowne_postaci_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.głowne_postaci_pictureBox.Image = global::RKO_2020.Properties.Resources.pozycja_startowa;
            resources.ApplyResources(this.głowne_postaci_pictureBox, "głowne_postaci_pictureBox");
            this.głowne_postaci_pictureBox.Name = "głowne_postaci_pictureBox";
            this.głowne_postaci_pictureBox.TabStop = false;
            // 
            // panel_wyboru1
            // 
            resources.ApplyResources(this.panel_wyboru1, "panel_wyboru1");
            this.panel_wyboru1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel_wyboru1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_wyboru1.Controls.Add(this.opcja3_label_1);
            this.panel_wyboru1.Controls.Add(this.opcja2_label_1);
            this.panel_wyboru1.Controls.Add(this.opcja1_label_1);
            this.panel_wyboru1.Controls.Add(this.opcja1);
            this.panel_wyboru1.Controls.Add(this.opcja2);
            this.panel_wyboru1.Controls.Add(this.opcja3);
            this.panel_wyboru1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel_wyboru1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel_wyboru1.Name = "panel_wyboru1";
            // 
            // opcja3_label_1
            // 
            resources.ApplyResources(this.opcja3_label_1, "opcja3_label_1");
            this.opcja3_label_1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.opcja3_label_1.Name = "opcja3_label_1";
            // 
            // opcja2_label_1
            // 
            resources.ApplyResources(this.opcja2_label_1, "opcja2_label_1");
            this.opcja2_label_1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.opcja2_label_1.Name = "opcja2_label_1";
            // 
            // opcja1_label_1
            // 
            resources.ApplyResources(this.opcja1_label_1, "opcja1_label_1");
            this.opcja1_label_1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.opcja1_label_1.Name = "opcja1_label_1";
            // 
            // opcja1
            // 
            this.opcja1.BackColor = System.Drawing.Color.Firebrick;
            resources.ApplyResources(this.opcja1, "opcja1");
            this.opcja1.ForeColor = System.Drawing.Color.White;
            this.opcja1.Name = "opcja1";
            this.opcja1.TabStop = false;
            this.opcja1.UseVisualStyleBackColor = false;
            this.opcja1.Click += new System.EventHandler(this.opcja1_Click);
            // 
            // opcja2
            // 
            this.opcja2.BackColor = System.Drawing.Color.Firebrick;
            resources.ApplyResources(this.opcja2, "opcja2");
            this.opcja2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.opcja2.Name = "opcja2";
            this.opcja2.TabStop = false;
            this.opcja2.UseVisualStyleBackColor = false;
            this.opcja2.Click += new System.EventHandler(this.opcja2_Click);
            // 
            // opcja3
            // 
            this.opcja3.BackColor = System.Drawing.Color.Firebrick;
            resources.ApplyResources(this.opcja3, "opcja3");
            this.opcja3.ForeColor = System.Drawing.SystemColors.Control;
            this.opcja3.Name = "opcja3";
            this.opcja3.TabStop = false;
            this.opcja3.UseVisualStyleBackColor = false;
            this.opcja3.Click += new System.EventHandler(this.opcja3_Click);
            // 
            // dymek_1
            // 
            this.dymek_1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.dymek_1.Controls.Add(this.label4);
            resources.ApplyResources(this.dymek_1, "dymek_1");
            this.dymek_1.Name = "dymek_1";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // dymek_2
            // 
            this.dymek_2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.dymek_2.Controls.Add(this.label5);
            resources.ApplyResources(this.dymek_2, "dymek_2");
            this.dymek_2.Name = "dymek_2";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // dymek_3
            // 
            this.dymek_3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.dymek_3.Controls.Add(this.label6);
            resources.ApplyResources(this.dymek_3, "dymek_3");
            this.dymek_3.Name = "dymek_3";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Name = "panel1";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Name = "label7";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Name = "label9";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Name = "button1";
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Firebrick;
            resources.ApplyResources(this.button2, "button2");
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Name = "button2";
            this.button2.TabStop = false;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Name = "panel2";
            // 
            // radioButton2
            // 
            resources.ApplyResources(this.radioButton2, "radioButton2");
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            resources.ApplyResources(this.radioButton1, "radioButton1");
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Name = "label11";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Firebrick;
            resources.ApplyResources(this.button7, "button7");
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Name = "button7";
            this.button7.TabStop = false;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Name = "label8";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.ForeColor = System.Drawing.Color.LimeGreen;
            this.label10.Name = "label10";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Firebrick;
            resources.ApplyResources(this.button5, "button5");
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Name = "button5";
            this.button5.TabStop = false;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Firebrick;
            resources.ApplyResources(this.button6, "button6");
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Name = "button6";
            this.button6.TabStop = false;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.radioButton3);
            this.panel3.Controls.Add(this.radioButton4);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.button9);
            this.panel3.Controls.Add(this.button10);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Name = "panel3";
            // 
            // radioButton3
            // 
            resources.ApplyResources(this.radioButton3, "radioButton3");
            this.radioButton3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            resources.ApplyResources(this.radioButton4, "radioButton4");
            this.radioButton4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.TabStop = true;
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Name = "label12";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Firebrick;
            resources.ApplyResources(this.button8, "button8");
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Name = "button8";
            this.button8.TabStop = false;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Name = "label13";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.ForeColor = System.Drawing.Color.LimeGreen;
            this.label14.Name = "label14";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Firebrick;
            resources.ApplyResources(this.button9, "button9");
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Name = "button9";
            this.button9.TabStop = false;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Firebrick;
            resources.ApplyResources(this.button10, "button10");
            this.button10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button10.Name = "button10";
            this.button10.TabStop = false;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dymek_3);
            this.Controls.Add(this.dymek_2);
            this.Controls.Add(this.dymek_1);
            this.Controls.Add(this.panelMENU);
            this.Controls.Add(this.panel_głowny);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panelMENU.ResumeLayout(false);
            this.panelMENU.PerformLayout();
            this.panel_głowny.ResumeLayout(false);
            this.panel_wyboru3.ResumeLayout(false);
            this.panel_wyboru3.PerformLayout();
            this.panel_wyboru2.ResumeLayout(false);
            this.panel_wyboru2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.obserwator_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glowa_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tułow_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.głowne_postaci_pictureBox)).EndInit();
            this.panel_wyboru1.ResumeLayout(false);
            this.panel_wyboru1.PerformLayout();
            this.dymek_1.ResumeLayout(false);
            this.dymek_1.PerformLayout();
            this.dymek_2.ResumeLayout(false);
            this.dymek_2.PerformLayout();
            this.dymek_3.ResumeLayout(false);
            this.dymek_3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel_głowny;
        private System.Windows.Forms.Panel panelMENU;
        private System.Windows.Forms.Label CZAS_BOX;
        private System.Windows.Forms.Label Poziom_Życia;
        private System.Windows.Forms.Timer timer_sprawdzający;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button opcja3;
        private System.Windows.Forms.Button opcja2;
        private System.Windows.Forms.PictureBox głowne_postaci_pictureBox;
        private System.Windows.Forms.PictureBox tułow_pictureBox;
        private System.Windows.Forms.PictureBox glowa_pictureBox;
        private System.Windows.Forms.PictureBox obserwator_pictureBox;
        public System.Windows.Forms.Panel panel_wyboru1;
        private System.Windows.Forms.Label opcja3_label_1;
        private System.Windows.Forms.Label opcja2_label_1;
        private System.Windows.Forms.Label opcja1_label_1;
        private System.Windows.Forms.Button opcja1;
        private System.Windows.Forms.Panel panel_wyboru2;
        private System.Windows.Forms.Label opcja2_label_2;
        private System.Windows.Forms.Label opcja1_label_2;
        private System.Windows.Forms.Button opcja1_2;
        private System.Windows.Forms.Button opcja2_2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_wyboru3;
        private System.Windows.Forms.Label opcja2_label_3;
        private System.Windows.Forms.Label opcja1_label_3;
        private System.Windows.Forms.Button opcja1_3;
        private System.Windows.Forms.Button opcja2_3;
        private System.Windows.Forms.Panel dymek_1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel dymek_2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel dymek_3;
        private System.Windows.Forms.Label label6;
        private Button button4;
        public Panel panel1;
        private Label label9;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label7;
        public Panel panel2;
        private Label label11;
        private Button button7;
        private Label label8;
        private Label label10;
        private Button button5;
        private Button button6;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        public Panel panel3;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Label label12;
        private Button button8;
        private Label label13;
        private Label label14;
        private Button button9;
        private Button button10;
    }
}

