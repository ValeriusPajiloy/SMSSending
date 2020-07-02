namespace SendingSMS
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
            this.Send_Button = new System.Windows.Forms.Button();
            this.Text_Label = new System.Windows.Forms.Label();
            this.PanelTextMessage = new System.Windows.Forms.Panel();
            this.TextMessage = new System.Windows.Forms.TextBox();
            this.Text1 = new System.Windows.Forms.Label();
            this.PanelSetNumbers = new System.Windows.Forms.Panel();
            this.Numbers = new System.Windows.Forms.DataGridView();
            this.Text2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Api_ID = new System.Windows.Forms.TextBox();
            this.Help = new System.Windows.Forms.Button();
            this.PanelTextMessage.SuspendLayout();
            this.PanelSetNumbers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numbers)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Send_Button
            // 
            this.Send_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Send_Button.Location = new System.Drawing.Point(239, 300);
            this.Send_Button.Name = "Send_Button";
            this.Send_Button.Size = new System.Drawing.Size(222, 49);
            this.Send_Button.TabIndex = 4;
            this.Send_Button.Text = "Отправить";
            this.Send_Button.UseVisualStyleBackColor = true;
            this.Send_Button.Click += new System.EventHandler(this.Send_Button_Click);
            // 
            // Text_Label
            // 
            this.Text_Label.AutoSize = true;
            this.Text_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_Label.Location = new System.Drawing.Point(9, 64);
            this.Text_Label.Name = "Text_Label";
            this.Text_Label.Size = new System.Drawing.Size(460, 34);
            this.Text_Label.TabIndex = 1;
            this.Text_Label.Text = "Введите текст сообщения, укажите номера телефонов, кому нужно \r\nотправить сообщен" +
    "ие, и нажмите кнопку отправить";
            this.Text_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PanelTextMessage
            // 
            this.PanelTextMessage.Controls.Add(this.TextMessage);
            this.PanelTextMessage.Controls.Add(this.Text1);
            this.PanelTextMessage.Location = new System.Drawing.Point(12, 101);
            this.PanelTextMessage.Name = "PanelTextMessage";
            this.PanelTextMessage.Size = new System.Drawing.Size(221, 248);
            this.PanelTextMessage.TabIndex = 2;
            // 
            // TextMessage
            // 
            this.TextMessage.Location = new System.Drawing.Point(17, 30);
            this.TextMessage.Multiline = true;
            this.TextMessage.Name = "TextMessage";
            this.TextMessage.Size = new System.Drawing.Size(187, 204);
            this.TextMessage.TabIndex = 2;
            // 
            // Text1
            // 
            this.Text1.AutoSize = true;
            this.Text1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text1.Location = new System.Drawing.Point(14, 9);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(190, 18);
            this.Text1.TabIndex = 0;
            this.Text1.Text = "Введите текст сообщения";
            this.Text1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PanelSetNumbers
            // 
            this.PanelSetNumbers.Controls.Add(this.Numbers);
            this.PanelSetNumbers.Controls.Add(this.Text2);
            this.PanelSetNumbers.Location = new System.Drawing.Point(239, 101);
            this.PanelSetNumbers.Name = "PanelSetNumbers";
            this.PanelSetNumbers.Size = new System.Drawing.Size(222, 193);
            this.PanelSetNumbers.TabIndex = 3;
            // 
            // Numbers
            // 
            this.Numbers.AllowUserToResizeColumns = false;
            this.Numbers.AllowUserToResizeRows = false;
            this.Numbers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Numbers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Numbers.GridColor = System.Drawing.SystemColors.ControlLight;
            this.Numbers.Location = new System.Drawing.Point(3, 30);
            this.Numbers.Name = "Numbers";
            this.Numbers.Size = new System.Drawing.Size(216, 160);
            this.Numbers.TabIndex = 3;
            this.Numbers.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.Numbers_RowPrePaint);
            // 
            // Text2
            // 
            this.Text2.AutoSize = true;
            this.Text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text2.Location = new System.Drawing.Point(3, 9);
            this.Text2.Name = "Text2";
            this.Text2.Size = new System.Drawing.Size(217, 18);
            this.Text2.TabIndex = 0;
            this.Text2.Text = "Укажите номера получателей";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Help);
            this.panel1.Controls.Add(this.Api_ID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 61);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите ваш api_id";
            // 
            // Api_ID
            // 
            this.Api_ID.Location = new System.Drawing.Point(29, 29);
            this.Api_ID.Name = "Api_ID";
            this.Api_ID.Size = new System.Drawing.Size(239, 20);
            this.Api_ID.TabIndex = 1;
            // 
            // Help
            // 
            this.Help.Location = new System.Drawing.Point(453, 3);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(23, 23);
            this.Help.TabIndex = 2;
            this.Help.Text = "?";
            this.Help.UseVisualStyleBackColor = true;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 359);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelSetNumbers);
            this.Controls.Add(this.PanelTextMessage);
            this.Controls.Add(this.Text_Label);
            this.Controls.Add(this.Send_Button);
            this.Name = "Form1";
            this.Text = "SendingSMS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelTextMessage.ResumeLayout(false);
            this.PanelTextMessage.PerformLayout();
            this.PanelSetNumbers.ResumeLayout(false);
            this.PanelSetNumbers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numbers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Send_Button;
        private System.Windows.Forms.Label Text_Label;
        private System.Windows.Forms.Panel PanelTextMessage;
        private System.Windows.Forms.Label Text1;
        private System.Windows.Forms.Panel PanelSetNumbers;
        private System.Windows.Forms.Label Text2;
        private System.Windows.Forms.TextBox TextMessage;
        private System.Windows.Forms.DataGridView Numbers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Api_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Help;
    }
}

