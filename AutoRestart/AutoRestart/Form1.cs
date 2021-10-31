using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace AutoRestart
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        System.Timers.Timer tmr = new System.Timers.Timer();
        private void btnStart_Click(object sender, EventArgs e)
        {
            tmr.Interval = 8000;
            tmr.Elapsed += tmr_Elapsed;
            tmr.SynchronizingObject = this;
            tmr.Start();        
            
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmr.Stop();
            tmr.Dispose();
        }

        private void tmr_Elapsed(object sender, EventArgs e)
        {
            Restart();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            string fileName = GetSelectedFileName();
            fileName = fileName;
            lstProcessList.Items.Add(fileName);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private string GetSelectedFileName()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;//該值確定是否可以選擇多個檔案
            dialog.Title = "請選擇資料夾";
            dialog.Filter = "所有檔案(*.*)|*.*";
            string file = "";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                file = dialog.FileName;
            }
            return file;
        }

        private void Restart()
        {
            foreach (string process in lstProcessList.Items)
            {
                if (IsProcessExit(process) == false)
                {
                    StartProcess(process);
                    lstHistory.Items.Add("The process: " + process + " has beed started at " + DateTime.Now.ToString() + ".");
                }

                if (CheckTime("23", "59"))
                {
                    CloseProcess(process);
                    lstHistory.Items.Add("The process: " + process + " has been closed at " + DateTime.Now.ToString() + ".");
                }
            }
        }

        private bool IsProcessExit(string process)
        {
            process = Path.GetFileNameWithoutExtension(process);
            Process[] processes = Process.GetProcessesByName(process);

            if (processes.Length == 0)
                return false;
                
            else
                return true;
        }

        private void StartProcess(string processName)
        {
            Process process = new Process();
            process.StartInfo.FileName = processName;
            process.Start();
        }

        private void CloseProcess(string processName)
        {
            Process[] processes = Process.GetProcessesByName(processName);
            foreach (Process p in processes)
            {
                // 關閉目前程序前先等待 1000 毫秒
                p.WaitForExit(1000);
                p.CloseMainWindow();
            }
        }

        private bool CheckTime(string hour, string minute)
        {
            DateTime dateTime = DateTime.Now;
            if(dateTime.Hour.ToString() == hour && dateTime.Minute.ToString() == minute)
            {
                lstHistory.Items.Add("Restart");
                return true;
            }
            return false;
            
        }

        
    }
}
