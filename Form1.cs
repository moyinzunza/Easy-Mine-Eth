using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace LatinmineWin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ProcessStartInfo cmdStartInfo = new ProcessStartInfo("cmd.exe");
            cmdStartInfo.CreateNoWindow = true;
            cmdStartInfo.RedirectStandardInput = true;
            cmdStartInfo.RedirectStandardOutput = true;
            cmdStartInfo.RedirectStandardError = true;
            cmdStartInfo.UseShellExecute = false;
            cmdStartInfo.WindowStyle = ProcessWindowStyle.Hidden;

            _cmd = new Process();
            _cmd.StartInfo = cmdStartInfo;

            if (_cmd.Start() == true)
            {
                _cmd.OutputDataReceived += new DataReceivedEventHandler(_cmd_OutputDataReceived);
                _cmd.ErrorDataReceived += new DataReceivedEventHandler(_cmd_ErrorDataReceived);
                _cmd.Exited += new EventHandler(_cmd_Exited);

                _cmd.BeginOutputReadLine();
                _cmd.BeginErrorReadLine();
            }
            else
            {
                _cmd = null;
            }
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.FormClosing += Form1_FormClosing;
            ExecuteCommand("phoenix\\PhoenixMiner.exe -pool stratum+tcp://us.latinmine.com:4444 -wal "+textbox_wallet.Text);
        }

        private void button_to_worker_Click(object sender, EventArgs e)
        {
                ProcessStartInfo psInfo = new ProcessStartInfo
                {
                    FileName = "http://latinmine.com/#/account/" + textbox_wallet.Text,
                    UseShellExecute = true
                };
            Process.Start(psInfo);
        }

        Process _cmd;
        private void ExecuteCommand(string _Command)
        {
            _cmd.StandardInput.WriteLine(_Command);
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            if ((_cmd != null) &&
                (_cmd.HasExited != true))
            {
                _cmd.CancelErrorRead();
                _cmd.CancelOutputRead();
                _cmd.Close();
                _cmd.WaitForExit();
            }
        }

        void _cmd_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            UpdateConsole(e.Data);
        }

        void _cmd_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            UpdateConsole(e.Data);
        }

        void _cmd_Exited(object sender, EventArgs e)
        {
            _cmd.OutputDataReceived -= new DataReceivedEventHandler(_cmd_OutputDataReceived);
            _cmd.Exited -= new EventHandler(_cmd_Exited);
        }



        private void UpdateConsole(string text)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(UpdateConsole), new object[] { text });
                return;
            }
            textboxLog.AppendText(Environment.NewLine);
            text = textboxLog.Text + "\n" + text;
            this.textboxLog.Text = text;
            textboxLog.SelectionStart = textboxLog.TextLength;
            textboxLog.ScrollToCaret();
        }

        private void closePhoenix()
        {
            foreach (var process in Process.GetProcessesByName("PhoenixMiner"))
            {
                process.Kill();
            }
            
        }

        private void Form1_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            closePhoenix();
            e.Cancel = true;
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            closePhoenix();
            UpdateConsole("Mining Stopped...");
        }
    }
}
