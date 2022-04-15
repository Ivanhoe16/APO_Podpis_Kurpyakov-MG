namespace APO_Podpis
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
            this.addFileButton = new System.Windows.Forms.Button();
            this.sendMailButton = new System.Windows.Forms.Button();
            this.cipherFileButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addSignButton = new System.Windows.Forms.Button();
            this.addKeyButton = new System.Windows.Forms.Button();
            this.LoadKeyButton = new System.Windows.Forms.Button();
            this.LoadSignButton = new System.Windows.Forms.Button();
            this.LoadFileButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chekFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addFileButton
            // 
            this.addFileButton.Location = new System.Drawing.Point(130, 58);
            this.addFileButton.Name = "addFileButton";
            this.addFileButton.Size = new System.Drawing.Size(127, 37);
            this.addFileButton.TabIndex = 4;
            this.addFileButton.Text = "Добавить файл к письму";
            this.addFileButton.UseVisualStyleBackColor = true;
            this.addFileButton.Click += new System.EventHandler(this.addFileButton_Click);
            // 
            // sendMailButton
            // 
            this.sendMailButton.Location = new System.Drawing.Point(514, 58);
            this.sendMailButton.Name = "sendMailButton";
            this.sendMailButton.Size = new System.Drawing.Size(149, 37);
            this.sendMailButton.TabIndex = 5;
            this.sendMailButton.Text = "Отправить письмо";
            this.sendMailButton.UseVisualStyleBackColor = true;
            this.sendMailButton.Click += new System.EventHandler(this.sendMailButton_Click);
            // 
            // cipherFileButton
            // 
            this.cipherFileButton.Location = new System.Drawing.Point(149, 12);
            this.cipherFileButton.Name = "cipherFileButton";
            this.cipherFileButton.Size = new System.Drawing.Size(200, 26);
            this.cipherFileButton.TabIndex = 6;
            this.cipherFileButton.Text = "Выбрать файл и зашифровать его";
            this.cipherFileButton.UseVisualStyleBackColor = true;
            this.cipherFileButton.Click += new System.EventHandler(this.cipherFileButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Шифрование и подпись:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Отправка по почте:";
            // 
            // addSignButton
            // 
            this.addSignButton.Location = new System.Drawing.Point(263, 58);
            this.addSignButton.Name = "addSignButton";
            this.addSignButton.Size = new System.Drawing.Size(108, 37);
            this.addSignButton.TabIndex = 9;
            this.addSignButton.Text = "Добавить подпись к письму";
            this.addSignButton.UseVisualStyleBackColor = true;
            this.addSignButton.Click += new System.EventHandler(this.addSignButton_Click);
            // 
            // addKeyButton
            // 
            this.addKeyButton.Location = new System.Drawing.Point(377, 58);
            this.addKeyButton.Name = "addKeyButton";
            this.addKeyButton.Size = new System.Drawing.Size(131, 37);
            this.addKeyButton.TabIndex = 10;
            this.addKeyButton.Text = "Добавить публичный ключ к письму";
            this.addKeyButton.UseVisualStyleBackColor = true;
            this.addKeyButton.Click += new System.EventHandler(this.addKeyButton_Click);
            // 
            // LoadKeyButton
            // 
            this.LoadKeyButton.Location = new System.Drawing.Point(432, 114);
            this.LoadKeyButton.Name = "LoadKeyButton";
            this.LoadKeyButton.Size = new System.Drawing.Size(131, 37);
            this.LoadKeyButton.TabIndex = 14;
            this.LoadKeyButton.Text = "Добавить ключ для проверки";
            this.LoadKeyButton.UseVisualStyleBackColor = true;
            this.LoadKeyButton.Click += new System.EventHandler(this.LoadKeyButton_Click);
            // 
            // LoadSignButton
            // 
            this.LoadSignButton.Location = new System.Drawing.Point(318, 114);
            this.LoadSignButton.Name = "LoadSignButton";
            this.LoadSignButton.Size = new System.Drawing.Size(108, 37);
            this.LoadSignButton.TabIndex = 13;
            this.LoadSignButton.Text = "Добавить подпись для проверки\r\n";
            this.LoadSignButton.UseVisualStyleBackColor = true;
            this.LoadSignButton.Click += new System.EventHandler(this.LoadSignButton_Click);
            // 
            // LoadFileButton
            // 
            this.LoadFileButton.Location = new System.Drawing.Point(185, 114);
            this.LoadFileButton.Name = "LoadFileButton";
            this.LoadFileButton.Size = new System.Drawing.Size(127, 37);
            this.LoadFileButton.TabIndex = 11;
            this.LoadFileButton.Text = "Добавить файл для проверки";
            this.LoadFileButton.UseVisualStyleBackColor = true;
            this.LoadFileButton.Click += new System.EventHandler(this.LoadFileButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Загрузка файлов для проверки:";
            // 
            // chekFileButton
            // 
            this.chekFileButton.Location = new System.Drawing.Point(15, 177);
            this.chekFileButton.Name = "chekFileButton";
            this.chekFileButton.Size = new System.Drawing.Size(263, 37);
            this.chekFileButton.TabIndex = 16;
            this.chekFileButton.Text = "Проверить скачанный файл на подлинность";
            this.chekFileButton.UseVisualStyleBackColor = true;
            this.chekFileButton.Click += new System.EventHandler(this.chekFileButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 289);
            this.Controls.Add(this.chekFileButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LoadKeyButton);
            this.Controls.Add(this.LoadSignButton);
            this.Controls.Add(this.LoadFileButton);
            this.Controls.Add(this.addKeyButton);
            this.Controls.Add(this.addSignButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cipherFileButton);
            this.Controls.Add(this.sendMailButton);
            this.Controls.Add(this.addFileButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addFileButton;
        private System.Windows.Forms.Button sendMailButton;
        private System.Windows.Forms.Button cipherFileButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addSignButton;
        private System.Windows.Forms.Button addKeyButton;
        private System.Windows.Forms.Button LoadKeyButton;
        private System.Windows.Forms.Button LoadSignButton;
        private System.Windows.Forms.Button LoadFileButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button chekFileButton;
    }
}

