using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TerrariaCN.IL;

namespace TerrariaCN.WPF
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        CIL cil = new CIL();
        private void UpdateTextRight()
        {
            //TerrariaCN.IL.CIL.ReadAM();
            //throw new NotImplementedException();
        }

        System.ComponentModel.BackgroundWorker bw;

        private void button_Click(object sender, RoutedEventArgs e)
        {
            CNbutton.Visibility = Visibility.Hidden;
            bw = new System.ComponentModel.BackgroundWorker();
            bw.DoWork += Bw_DoWork;
            bw.ProgressChanged += Bw_ProgressChanged;
            bw.RunWorkerCompleted += Bw_RunWorkerCompleted;
            bw.WorkerReportsProgress = true;
            bw.RunWorkerAsync();
            //ThreadPool.
            //Thread thread = new Thread(UpdateTextRight);
            ////thread.s
            //thread.Start();
        }

        private void Bw_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            messageBlock.Text = e.UserState.ToString();
            //throw new NotImplementedException();
        }

        private void Bw_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            CNbutton.Visibility = Visibility.Visible;
            //throw new NotImplementedException();
        }

        private void Bw_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            cil.OnProgressChanged += Cil_OnProgressChanged;
            cil.ReadAM();
        }

        private void Cil_OnProgressChanged(object sender, CIL.ProgressChangedEventArgs Args)
        {
            bw.ReportProgress(Args.ProgressPer, Args.Message);
            //throw new NotImplementedException();
        }

    }
}
