
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Memory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfThreads = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThreadId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThreadPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(776, 240);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
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
            this.dataGridView2.Location = new System.Drawing.Point(12, 258);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(776, 146);
            this.dataGridView2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Id
            // 
            this.Id.Frozen = true;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ProcessName
            // 
            this.ProcessName.Frozen = true;
            this.ProcessName.HeaderText = "название процесса";
            this.ProcessName.Name = "ProcessName";
            this.ProcessName.ReadOnly = true;
            this.ProcessName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Memory
            // 
            this.Memory.Frozen = true;
            this.Memory.HeaderText = "Занимаемая память";
            this.Memory.Name = "Memory";
            this.Memory.ReadOnly = true;
            this.Memory.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Priority
            // 
            this.Priority.Frozen = true;
            this.Priority.HeaderText = "Приоритет";
            this.Priority.Name = "Priority";
            this.Priority.ReadOnly = true;
            this.Priority.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Username
            // 
            this.Username.Frozen = true;
            this.Username.HeaderText = "Имя пользователя";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // NumberOfThreads
            // 
            this.NumberOfThreads.Frozen = true;
            this.NumberOfThreads.HeaderText = "Количество потоков";
            this.NumberOfThreads.Name = "NumberOfThreads";
            this.NumberOfThreads.ReadOnly = true;
            this.NumberOfThreads.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ThreadId
            // 
            this.ThreadId.HeaderText = "Id";
            this.ThreadId.Name = "ThreadId";
            this.ThreadId.ReadOnly = true;
            this.ThreadId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ThreadPriority
            // 
            this.ThreadPriority.HeaderText = "приоритет потока ";
            this.ThreadPriority.Name = "ThreadPriority";
            this.ThreadPriority.ReadOnly = true;
            this.ThreadPriority.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(161, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Memory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfThreads;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThreadId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThreadPriority;
        private System.Windows.Forms.Button button2;
    }
}

