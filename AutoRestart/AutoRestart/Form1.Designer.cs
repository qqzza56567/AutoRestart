namespace AutoRestart
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lalHistory = new System.Windows.Forms.Label();
            this.lstProcessList = new System.Windows.Forms.ListBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.lalProcessList = new System.Windows.Forms.Label();
            this.lstHistory = new System.Windows.Forms.ListBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(249, 163);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(104, 31);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // lalHistory
            // 
            this.lalHistory.AutoSize = true;
            this.lalHistory.Location = new System.Drawing.Point(12, 182);
            this.lalHistory.Name = "lalHistory";
            this.lalHistory.Size = new System.Drawing.Size(49, 15);
            this.lalHistory.TabIndex = 2;
            this.lalHistory.Text = "History";
            // 
            // lstProcessList
            // 
            this.lstProcessList.FormattingEnabled = true;
            this.lstProcessList.HorizontalExtent = 500;
            this.lstProcessList.HorizontalScrollbar = true;
            this.lstProcessList.ItemHeight = 15;
            this.lstProcessList.Location = new System.Drawing.Point(15, 52);
            this.lstProcessList.Name = "lstProcessList";
            this.lstProcessList.ScrollAlwaysVisible = true;
            this.lstProcessList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstProcessList.Size = new System.Drawing.Size(459, 79);
            this.lstProcessList.TabIndex = 4;
            this.lstProcessList.TabStop = false;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(370, 15);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(104, 31);
            this.btnSelectFile.TabIndex = 5;
            this.btnSelectFile.Text = "SelectFile";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // lalProcessList
            // 
            this.lalProcessList.AutoSize = true;
            this.lalProcessList.Location = new System.Drawing.Point(12, 34);
            this.lalProcessList.Name = "lalProcessList";
            this.lalProcessList.Size = new System.Drawing.Size(71, 15);
            this.lalProcessList.TabIndex = 6;
            this.lalProcessList.Text = "ProcessList";
            // 
            // lstHistory
            // 
            this.lstHistory.FormattingEnabled = true;
            this.lstHistory.HorizontalExtent = 500;
            this.lstHistory.HorizontalScrollbar = true;
            this.lstHistory.ItemHeight = 15;
            this.lstHistory.Location = new System.Drawing.Point(12, 200);
            this.lstHistory.Name = "lstHistory";
            this.lstHistory.ScrollAlwaysVisible = true;
            this.lstHistory.Size = new System.Drawing.Size(462, 124);
            this.lstHistory.TabIndex = 7;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(370, 163);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(104, 31);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "Stop";
            this.btnStop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(249, 15);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(104, 31);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 342);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lstHistory);
            this.Controls.Add(this.lalProcessList);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.lstProcessList);
            this.Controls.Add(this.lalHistory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Name = "MainForm";
            this.Text = "AutoRestart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lalHistory;
        private System.Windows.Forms.ListBox lstProcessList;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Label lalProcessList;
        private System.Windows.Forms.ListBox lstHistory;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnRemove;
    }
}

