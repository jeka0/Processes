
namespace Processes
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Memory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfThreads = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ThreadId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThreadPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabThread = new System.Windows.Forms.Label();
            this.LabeProc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ProcessName,
            this.Memory,
            this.Priority,
            this.Username,
            this.NumberOfThreads});
            this.dataGridView1.Location = new System.Drawing.Point(16, 62);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(956, 436);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.Frozen = true;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.Width = 125;
            // 
            // ProcessName
            // 
            this.ProcessName.DataPropertyName = "ProcessName";
            this.ProcessName.Frozen = true;
            this.ProcessName.HeaderText = "название процесса";
            this.ProcessName.MinimumWidth = 6;
            this.ProcessName.Name = "ProcessName";
            this.ProcessName.ReadOnly = true;
            this.ProcessName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProcessName.Width = 125;
            // 
            // Memory
            // 
            this.Memory.DataPropertyName = "Memory";
            this.Memory.Frozen = true;
            this.Memory.HeaderText = "Занимаемая память";
            this.Memory.MinimumWidth = 6;
            this.Memory.Name = "Memory";
            this.Memory.ReadOnly = true;
            this.Memory.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Memory.Width = 125;
            // 
            // Priority
            // 
            this.Priority.DataPropertyName = "Priority";
            this.Priority.Frozen = true;
            this.Priority.HeaderText = "Приоритет";
            this.Priority.MinimumWidth = 6;
            this.Priority.Name = "Priority";
            this.Priority.ReadOnly = true;
            this.Priority.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Priority.Width = 125;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Owner";
            this.Username.Frozen = true;
            this.Username.HeaderText = "Имя пользователя";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Username.Width = 125;
            // 
            // NumberOfThreads
            // 
            this.NumberOfThreads.DataPropertyName = "threadsCount";
            this.NumberOfThreads.Frozen = true;
            this.NumberOfThreads.HeaderText = "Количество потоков";
            this.NumberOfThreads.MinimumWidth = 6;
            this.NumberOfThreads.Name = "NumberOfThreads";
            this.NumberOfThreads.ReadOnly = true;
            this.NumberOfThreads.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NumberOfThreads.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ThreadId,
            this.ThreadPriority});
            this.dataGridView2.Location = new System.Drawing.Point(980, 62);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(339, 436);
            this.dataGridView2.TabIndex = 1;
            // 
            // ThreadId
            // 
            this.ThreadId.HeaderText = "Id";
            this.ThreadId.MinimumWidth = 6;
            this.ThreadId.Name = "ThreadId";
            this.ThreadId.ReadOnly = true;
            this.ThreadId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ThreadId.Width = 125;
            // 
            // ThreadPriority
            // 
            this.ThreadPriority.HeaderText = "приоритет потока ";
            this.ThreadPriority.MinimumWidth = 6;
            this.ThreadPriority.Name = "ThreadPriority";
            this.ThreadPriority.ReadOnly = true;
            this.ThreadPriority.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ThreadPriority.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 505);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(123, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Процессы:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(975, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Потоки прцесса:";
            // 
            // LabThread
            // 
            this.LabThread.AutoSize = true;
            this.LabThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabThread.Location = new System.Drawing.Point(1148, 18);
            this.LabThread.Name = "LabThread";
            this.LabThread.Size = new System.Drawing.Size(23, 25);
            this.LabThread.TabIndex = 5;
            this.LabThread.Text = "0";
            // 
            // LabeProc
            // 
            this.LabeProc.AutoSize = true;
            this.LabeProc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabeProc.Location = new System.Drawing.Point(257, 18);
            this.LabeProc.Name = "LabeProc";
            this.LabeProc.Size = new System.Drawing.Size(23, 25);
            this.LabeProc.TabIndex = 6;
            this.LabeProc.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 554);
            this.Controls.Add(this.LabeProc);
            this.Controls.Add(this.LabThread);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThreadId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThreadPriority;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabThread;
        private System.Windows.Forms.Label LabeProc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Memory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfThreads;
    }
}

