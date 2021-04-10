namespace htemurtas
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
            this.pBox1 = new System.Windows.Forms.PictureBox();
            this.pBox2 = new System.Windows.Forms.PictureBox();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pBox1
            // 
            this.pBox1.Location = new System.Drawing.Point(26, 42);
            this.pBox1.Name = "pBox1";
            this.pBox1.Size = new System.Drawing.Size(480, 270);
            this.pBox1.TabIndex = 0;
            this.pBox1.TabStop = false;
            this.pBox1.MouseLeave += new System.EventHandler(this.PBox1_MouseLeave);
            this.pBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PBox1_MouseMove);
            // 
            // pBox2
            // 
            this.pBox2.BackColor = System.Drawing.Color.Pink;
            this.pBox2.Location = new System.Drawing.Point(522, 27);
            this.pBox2.Name = "pBox2";
            this.pBox2.Size = new System.Drawing.Size(300, 300);
            this.pBox2.TabIndex = 0;
            this.pBox2.TabStop = false;
            // 
            // tmr
            // 
            this.tmr.Tick += new System.EventHandler(this.Tmr_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(849, 355);
            this.Controls.Add(this.pBox2);
            this.Controls.Add(this.pBox1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "H a s a n     T E M U R T A Ş";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pBox1;
        private System.Windows.Forms.PictureBox pBox2;
        private System.Windows.Forms.Timer tmr;
    }
}

