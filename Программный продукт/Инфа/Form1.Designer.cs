namespace Инфа
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Название = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Модель = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IPaddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.Юзер = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ОС = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Процессор = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Видеокарта = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Оперативка = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ЖД = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IPHost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublicIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Юзер,
            this.ОС,
            this.Процессор,
            this.Видеокарта,
            this.Оперативка,
            this.ЖД,
            this.IP,
            this.IPHost,
            this.PublicIP});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1162, 143);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Получить информацию о своем ПК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Название,
            this.Модель,
            this.IPaddress});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 143);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1162, 210);
            this.dataGridView2.TabIndex = 2;
            // 
            // Название
            // 
            this.Название.HeaderText = "Имя устройства";
            this.Название.Name = "Название";
            // 
            // Модель
            // 
            this.Модель.HeaderText = "ID";
            this.Модель.Name = "Модель";
            // 
            // IPaddress
            // 
            this.IPaddress.HeaderText = "Число подключений";
            this.IPaddress.Name = "IPaddress";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(341, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Получить информацию о устройствах в сети";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Юзер
            // 
            this.Юзер.HeaderText = "Пользователь";
            this.Юзер.Name = "Юзер";
            // 
            // ОС
            // 
            this.ОС.HeaderText = "Операционная система";
            this.ОС.Name = "ОС";
            this.ОС.Width = 200;
            // 
            // Процессор
            // 
            this.Процессор.HeaderText = "Процессор";
            this.Процессор.Name = "Процессор";
            this.Процессор.Width = 200;
            // 
            // Видеокарта
            // 
            this.Видеокарта.HeaderText = "Видеокарта";
            this.Видеокарта.Name = "Видеокарта";
            this.Видеокарта.Width = 200;
            // 
            // Оперативка
            // 
            this.Оперативка.HeaderText = "Размер оперативной памяти";
            this.Оперативка.Name = "Оперативка";
            // 
            // ЖД
            // 
            this.ЖД.HeaderText = "Жёсткий диск";
            this.ЖД.Name = "ЖД";
            this.ЖД.Width = 200;
            // 
            // IP
            // 
            this.IP.HeaderText = "Локальный IP";
            this.IP.Name = "IP";
            // 
            // IPHost
            // 
            this.IPHost.HeaderText = "Хост";
            this.IPHost.Name = "IPHost";
            // 
            // PublicIP
            // 
            this.PublicIP.HeaderText = "Публичный IP";
            this.PublicIP.Name = "PublicIP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 353);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Название;
        private System.Windows.Forms.DataGridViewTextBoxColumn Модель;
        private System.Windows.Forms.DataGridViewTextBoxColumn IPaddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Юзер;
        private System.Windows.Forms.DataGridViewTextBoxColumn ОС;
        private System.Windows.Forms.DataGridViewTextBoxColumn Процессор;
        private System.Windows.Forms.DataGridViewTextBoxColumn Видеокарта;
        private System.Windows.Forms.DataGridViewTextBoxColumn Оперативка;
        private System.Windows.Forms.DataGridViewTextBoxColumn ЖД;
        private System.Windows.Forms.DataGridViewTextBoxColumn IP;
        private System.Windows.Forms.DataGridViewTextBoxColumn IPHost;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublicIP;
    }
}

