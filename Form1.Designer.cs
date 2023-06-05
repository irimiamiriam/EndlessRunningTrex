namespace EndlessRunning
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
            this.scoretextBox = new System.Windows.Forms.TextBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.floor = new System.Windows.Forms.PictureBox();
            this.trexpictureBox = new System.Windows.Forms.PictureBox();
            this.obs1pictureBox = new System.Windows.Forms.PictureBox();
            this.obs2pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trexpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obs1pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obs2pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // scoretextBox
            // 
            this.scoretextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.scoretextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scoretextBox.Enabled = false;
            this.scoretextBox.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoretextBox.ForeColor = System.Drawing.Color.White;
            this.scoretextBox.Location = new System.Drawing.Point(16, 12);
            this.scoretextBox.Name = "scoretextBox";
            this.scoretextBox.ReadOnly = true;
            this.scoretextBox.Size = new System.Drawing.Size(507, 27);
            this.scoretextBox.TabIndex = 4;
            this.scoretextBox.Text = "Score: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // floor
            // 
            this.floor.BackColor = System.Drawing.Color.Indigo;
            this.floor.Location = new System.Drawing.Point(-3, 418);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(994, 63);
            this.floor.TabIndex = 1;
            this.floor.TabStop = false;
            // 
            // trexpictureBox
            // 
            this.trexpictureBox.BackColor = System.Drawing.Color.Transparent;
            this.trexpictureBox.ErrorImage = null;
            this.trexpictureBox.Image = global::EndlessRunning.Properties.Resources.running;
            this.trexpictureBox.Location = new System.Drawing.Point(108, 364);
            this.trexpictureBox.Name = "trexpictureBox";
            this.trexpictureBox.Size = new System.Drawing.Size(53, 57);
            this.trexpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trexpictureBox.TabIndex = 0;
            this.trexpictureBox.TabStop = false;
            // 
            // obs1pictureBox
            // 
            this.obs1pictureBox.Image = global::EndlessRunning.Properties.Resources.obs1;
            this.obs1pictureBox.Location = new System.Drawing.Point(486, 364);
            this.obs1pictureBox.Name = "obs1pictureBox";
            this.obs1pictureBox.Size = new System.Drawing.Size(37, 57);
            this.obs1pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obs1pictureBox.TabIndex = 2;
            this.obs1pictureBox.TabStop = false;
            this.obs1pictureBox.Tag = "obstacle";
            // 
            // obs2pictureBox
            // 
            this.obs2pictureBox.Image = global::EndlessRunning.Properties.Resources.obs2;
            this.obs2pictureBox.Location = new System.Drawing.Point(733, 364);
            this.obs2pictureBox.Name = "obs2pictureBox";
            this.obs2pictureBox.Size = new System.Drawing.Size(62, 57);
            this.obs2pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obs2pictureBox.TabIndex = 3;
            this.obs2pictureBox.TabStop = false;
            this.obs2pictureBox.Tag = "obstacle";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(977, 466);
            this.Controls.Add(this.scoretextBox);
            this.Controls.Add(this.floor);
            this.Controls.Add(this.trexpictureBox);
            this.Controls.Add(this.obs1pictureBox);
            this.Controls.Add(this.obs2pictureBox);
            this.Name = "Form1";
            this.Text = "Endless Running T-Rex";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.floor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trexpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obs1pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obs2pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox trexpictureBox;
        private System.Windows.Forms.PictureBox floor;
        private System.Windows.Forms.PictureBox obs1pictureBox;
        private System.Windows.Forms.PictureBox obs2pictureBox;
        private System.Windows.Forms.TextBox scoretextBox;
        private System.Windows.Forms.Timer gameTimer;
    }
}
