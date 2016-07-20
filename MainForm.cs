// Snapshot Maker sample application
// AForge.NET Framework
// http://www.aforgenet.com/framework/
//
// Copyright © AForge.NET, 2009-2011
// contacts@aforgenet.com
//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using AForge.Video;
using AForge.Video.DirectShow;

namespace Snapshot_Maker
{
    public partial class MainForm : Form
    {

       public MainForm()
        {
            InitializeComponent();
            InitWorker();

        }

        private void InitWorker()
        {
            if (backgroundWorker1 != null)
            {
                backgroundWorker1.Dispose();
            }

            backgroundWorker1 = new BackgroundWorker
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };
            backgroundWorker1.DoWork += DoWork;
            backgroundWorker1.RunWorkerCompleted += RunWorkerCompleted;
            backgroundWorker1.ProgressChanged += ProgressChanged;
            backgroundWorker1.RunWorkerAsync();
        }

        private void ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
        }

        private void RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                // Display some message to the user that task has been
                // cancelled
            }
            else if (e.Error != null)
            {
                // Do something with the error
            }
        }

        private void DoWork(object sender, DoWorkEventArgs e)
        {
            videoControl1.Visible = !videoControl1.Visible;
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
           
                videoControl1.Visible = !videoControl1.Visible;
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            videoControl1.Visible = !videoControl1.Visible;
        }
    }
}
