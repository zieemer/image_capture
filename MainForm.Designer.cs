namespace Snapshot_Maker
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            this.videoControl1 = new Snapshot_Maker.VideoControl();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // videoControl1
            // 
            this.videoControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.videoControl1.Location = new System.Drawing.Point(41, 35);
            this.videoControl1.Name = "videoControl1";
            this.videoControl1.Size = new System.Drawing.Size(541, 517);
            this.videoControl1.TabIndex = 0;
            this.videoControl1.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 610);
            this.Controls.Add(this.videoControl1);
            this.MinimumSize = new System.Drawing.Size(535, 440);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snapshot Maker";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private VideoControl videoControl1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

