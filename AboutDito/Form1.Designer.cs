namespace AboutDito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.Location = new System.Drawing.Point(388, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 34);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "ABOUT ME";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.DimGray;
            this.listBox1.Font = new System.Drawing.Font("Monotype Corsiva", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Items.AddRange(new object[] {
            "Name                          : Fransditho R Emor",
            "Age                             : 20 Tahun",
            "Place, Date Of Birth  :  Samarinda 17 - 06 - 2003",
            "Phone Number           : 0815 2720 5595",
            "Religion                    : Kristen Protestan"});
            this.listBox1.Location = new System.Drawing.Point(272, 101);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(405, 124);
            this.listBox1.TabIndex = 3;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.SystemColors.Info;
            this.listBox2.Font = new System.Drawing.Font("Monotype Corsiva", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.listBox2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 21;
            this.listBox2.Items.AddRange(new object[] {
            "Hello everyone, let me introduce myself. My full name is Fransditho Richardo Emor" +
                ". People usually",
            "call me Dito. I am the first of two brothers in my family. I was born in Samarind" +
                "a on June 17th, 2003.",
            "Currently, I live in Bitung, North Sulawesi.",
            "  I enjoy practicing martial arts, specifically \"Karate\". I started training in K" +
                "arate since I was in",
            "second grade of elementary school and won a bronze medal in the \"Wadokai Open\" co" +
                "mpetition",
            "in Makassar when I was in fifth grade. In sixth grade, I earned my black belt and" +
                " was called \"Senpai\".",
            "However, I stopped practicing Karate due to internal reasons. In junior high scho" +
                "ol, I started",
            "practicing Taekwondo and achieved the red belt. In my third year of high school, " +
                "I stopped",
            "practicing Taekwondo to focus on my studies and prepare for my future."});
            this.listBox2.Location = new System.Drawing.Point(12, 245);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(776, 193);
            this.listBox2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
    }
}

