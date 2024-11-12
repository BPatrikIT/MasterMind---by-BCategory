namespace MasterMind
{
    partial class mastermind
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mastermind));
            this.start = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Transparent;
            this.start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.start.Location = new System.Drawing.Point(435, 192);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(138, 75);
            this.start.TabIndex = 0;
            this.start.TabStop = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Location = new System.Drawing.Point(448, 418);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(112, 69);
            this.exit.TabIndex = 1;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // mastermind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.start);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 720);
            this.MinimumSize = new System.Drawing.Size(1024, 720);
            this.Name = "mastermind";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MasterMind - by BCategory";
            ((System.ComponentModel.ISupportInitialize)(this.start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox start;
        private System.Windows.Forms.PictureBox exit;
    }
}

