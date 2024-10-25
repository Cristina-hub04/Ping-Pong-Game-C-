namespace pingpong
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.scor1 = new System.Windows.Forms.Label();
            this.scor2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.jucator1 = new System.Windows.Forms.PictureBox();
            this.jucator2 = new System.Windows.Forms.PictureBox();
            this.minge = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.jucator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jucator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minge)).BeginInit();
            this.SuspendLayout();
            // 
            // scor1
            // 
            this.scor1.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scor1.Location = new System.Drawing.Point(417, 47);
            this.scor1.Name = "scor1";
            this.scor1.Size = new System.Drawing.Size(38, 47);
            this.scor1.TabIndex = 3;
            this.scor1.Text = "0";
            // 
            // scor2
            // 
            this.scor2.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scor2.Location = new System.Drawing.Point(805, 47);
            this.scor2.Name = "scor2";
            this.scor2.Size = new System.Drawing.Size(38, 47);
            this.scor2.TabIndex = 4;
            this.scor2.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // jucator1
            // 
            this.jucator1.BackColor = System.Drawing.Color.DodgerBlue;
            this.jucator1.Location = new System.Drawing.Point(12, 226);
            this.jucator1.Name = "jucator1";
            this.jucator1.Size = new System.Drawing.Size(18, 171);
            this.jucator1.TabIndex = 5;
            this.jucator1.TabStop = false;
            // 
            // jucator2
            // 
            this.jucator2.BackColor = System.Drawing.Color.DarkOrange;
            this.jucator2.Location = new System.Drawing.Point(1215, 226);
            this.jucator2.Name = "jucator2";
            this.jucator2.Size = new System.Drawing.Size(18, 171);
            this.jucator2.TabIndex = 6;
            this.jucator2.TabStop = false;
            // 
            // minge
            // 
            this.minge.BackColor = System.Drawing.Color.Red;
            this.minge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minge.Location = new System.Drawing.Point(611, 278);
            this.minge.Name = "minge";
            this.minge.Size = new System.Drawing.Size(31, 29);
            this.minge.TabIndex = 7;
            this.minge.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1245, 695);
            this.Controls.Add(this.minge);
            this.Controls.Add(this.jucator2);
            this.Controls.Add(this.jucator1);
            this.Controls.Add(this.scor1);
            this.Controls.Add(this.scor2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "PINGPONG GAME";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.jucator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jucator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Label scor1;
        private Label scor2;
        private PictureBox jucator1;
        private PictureBox jucator2;
        public PictureBox minge;
        public System.Windows.Forms.Timer timer1;
    }
}