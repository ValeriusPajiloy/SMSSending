using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SendingSMS
{
    public partial class Form1 : Form
    {
        
        string message;
        public Form1()
        {
            InitializeComponent();
        }
     
        bool isNumber(string text)
        {
            if (text[0] == '+')
            {
                for(int i=1;i<text.Length;i++)
                {
                    if (text[i] < '0' || text[i] > '9') return false;
                }
                return true;
            }
            else return false;
            
        }

        private void Send_Button_Click(object sender, EventArgs e)
        {
            string myApiKey = Api_ID.Text;
            int emptyAPI = String.Compare(myApiKey, "");
            if (emptyAPI != 0)
            {
                string textmessage = TextMessage.Text;
                string numberphone = "";
                message = "";
                int N = Numbers.Rows.Count;
                int emptymessage = String.Compare(textmessage, "");
                if (emptymessage != 0)
                {
                    for (int i = 0; i < N - 1; ++i)
                    {
                        numberphone = Numbers[0, i].Value.ToString();
                        if (isNumber(numberphone))
                        {

                            SmsRu.SmsRu sms = new SmsRu.SmsRu(myApiKey);
                            var response = sms.Send(numberphone, textmessage);
                            int result = response.Status;

                            if (result == 100)
                            {
                                message = String.Concat(message, numberphone);
                                message = String.Concat(message, ": Сообщение отправленно: ");
                                message = String.Concat(message, textmessage);
                                message = String.Concat(message, "\n");
                            }
                            else
                            {
                                message = String.Concat(message, numberphone);
                                message = String.Concat(message, ": внутренняя ошибка, сообщение не отправлено\n");
                            }
                        }
                        else
                        {
                            message = String.Concat(message, numberphone);
                            message = String.Concat(message, ": неправильный номер, сообщение не отправлено\n");
                        }
                    }
                }
                else
                {
                    message = String.Concat(message, "Пустое сообщение, сообщения не отправлены\n");
                }
            }
            else
            {
                message = String.Concat(message, "Введите Api_ID\n");
            }

            MessageBox.Show(
                message,
                "Результат",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var column1 = new DataGridViewColumn();
            column1.HeaderText = "Номер телефона"; //текст в шапке
            column1.Width = 200; //ширина колонки
            column1.Name = "Number"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
            column1.Frozen = true; //флаг, что данная колонка всегда отображается на своем месте
            column1.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки
            Numbers.Columns.Add(column1);
        }

        private void Numbers_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int index = e.RowIndex;
            string indexStr = (index + 1).ToString();
            object header = this.Numbers.Rows[index].HeaderCell.Value;
            if (header == null || !header.Equals(indexStr))
                this.Numbers.Rows[index].HeaderCell.Value = indexStr;
        }

        private void Help_Click(object sender, EventArgs e)
        {
            string mes = "";
            mes = String.Concat(mes, "Приложение разработано Лебедевым В.В в учебных целях\n");
            mes = String.Concat(mes, "Программа использует API сервиса SMS.RU\n");
            mes = String.Concat(mes, "Для работы требуется Api_ID, который можно получить после регистрации на SMS.RU\n");
            mes = String.Concat(mes, "При отпраке сообщений списываются деньги со счета на SMS.RU\n");
            mes = String.Concat(mes, "Приятного использования\n");
            MessageBox.Show(
               mes,
               "Справка",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information,
               MessageBoxDefaultButton.Button1,
               MessageBoxOptions.DefaultDesktopOnly);
        }
        
    }
}
