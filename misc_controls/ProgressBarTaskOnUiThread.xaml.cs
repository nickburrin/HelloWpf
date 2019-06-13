using System;
using System.ComponentModel;
using System.Threading;
using System.Windows;

namespace HelloWpf.misc_controls
{
    /// <summary>
    /// Interaction logic for ProgressBarTaskOnUiThread.xaml
    /// </summary>
    public partial class ProgressBarTaskOnUiThread : Window
    {
        public ProgressBarTaskOnUiThread()
        {
            InitializeComponent();
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            var worker = new BackgroundWorker {WorkerReportsProgress = true};
            worker.DoWork += worker_DoWork;
            worker.ProgressChanged += worker_ProgressChanged;

            worker.RunWorkerAsync();
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                (sender as BackgroundWorker).ReportProgress(i);
                Thread.Sleep(100);
            }
        }

        void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbStatus.Value = e.ProgressPercentage;
        }
    }
}
