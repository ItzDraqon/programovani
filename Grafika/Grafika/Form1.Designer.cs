namespace Grafika
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
            this.buttonEllipseForm = new System.Windows.Forms.Button();
            this.buttonColor = new System.Windows.Forms.Button();
            this.buttonZapsani = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.elipsaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreslitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.souborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEllipseForm
            // 
            this.buttonEllipseForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.buttonEllipseForm.Location = new System.Drawing.Point(27, 45);
            this.buttonEllipseForm.Name = "buttonEllipseForm";
            this.buttonEllipseForm.Size = new System.Drawing.Size(222, 75);
            this.buttonEllipseForm.TabIndex = 0;
            this.buttonEllipseForm.Text = "Elipsa";
            this.buttonEllipseForm.UseVisualStyleBackColor = true;
            this.buttonEllipseForm.Click += new System.EventHandler(this.buttonEllipseForm_Click);
            // 
            // buttonColor
            // 
            this.buttonColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.buttonColor.Location = new System.Drawing.Point(27, 126);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(222, 74);
            this.buttonColor.TabIndex = 1;
            this.buttonColor.Text = "Kreslit";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonZapsani
            // 
            this.buttonZapsani.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.buttonZapsani.Location = new System.Drawing.Point(27, 206);
            this.buttonZapsani.Name = "buttonZapsani";
            this.buttonZapsani.Size = new System.Drawing.Size(222, 74);
            this.buttonZapsani.TabIndex = 2;
            this.buttonZapsani.Text = "Soubor";
            this.buttonZapsani.UseVisualStyleBackColor = true;
            this.buttonZapsani.Click += new System.EventHandler(this.buttonZapsani_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(277, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 429);
            this.panel1.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(27, 328);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(105, 38);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(27, 372);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(105, 43);
            this.buttonStop.TabIndex = 5;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(596, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.elipsaToolStripMenuItem,
            this.kreslitToolStripMenuItem,
            this.souborToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(896, 24);
            this.menuStrip2.TabIndex = 6;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // elipsaToolStripMenuItem
            // 
            this.elipsaToolStripMenuItem.Name = "elipsaToolStripMenuItem";
            this.elipsaToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.elipsaToolStripMenuItem.Text = "Elipsa";
            this.elipsaToolStripMenuItem.Click += new System.EventHandler(this.elipsaToolStripMenuItem_Click);
            // 
            // kreslitToolStripMenuItem
            // 
            this.kreslitToolStripMenuItem.Name = "kreslitToolStripMenuItem";
            this.kreslitToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.kreslitToolStripMenuItem.Text = "Kreslit";
            this.kreslitToolStripMenuItem.Click += new System.EventHandler(this.kreslitToolStripMenuItem_Click);
            // 
            // souborToolStripMenuItem
            // 
            this.souborToolStripMenuItem.Name = "souborToolStripMenuItem";
            this.souborToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.souborToolStripMenuItem.Text = "Soubor";
            this.souborToolStripMenuItem.Click += new System.EventHandler(this.souborToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 491);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonZapsani);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.buttonEllipseForm);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEllipseForm;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Button buttonZapsani;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem elipsaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreslitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem souborToolStripMenuItem;
    }
}

