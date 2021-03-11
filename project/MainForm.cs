using System;
using System.Windows.Forms;
using System.Drawing;

namespace cafe
{
    class MainForm : Form
    {
        TextBox textBoxName = new TextBox();
        TextBox textBoxSurname = new TextBox();
        TextBox textBoxCheck = new TextBox();
        TextBox textBoxName2 = new TextBox();
        TextBox textBoxSurname2 = new TextBox();
        TextBox textBoxSalary = new TextBox();
        TextBox textBoxName3 = new TextBox();
        TextBox textBoxId = new TextBox();
        TextBox textBoxPrice = new TextBox();
        DateTimePicker datePicker = new DateTimePicker();
        DateTimePicker datePicker2 = new DateTimePicker();
        ListBox listBox = new ListBox();
        ListBox listBox2 = new ListBox();
        ListBox listBox3 = new ListBox();
        ListBox listBox4 = new ListBox();
        ListBox listBox5 = new ListBox();
        Label labelMsg = new Label();
        Label labelMsg2 = new Label();
        Label labelMsg3 = new Label();
        TextBox spot = new TextBox();
        public MainForm(string title, int height, int width) : base()
        {
            Text = title;
            Height = height;
            Width = width;
            FormBorderStyle = FormBorderStyle.Fixed3D;

            this.MaximizeBox = false;

            labelMsg.Text = "Добавить клиента" + Environment.NewLine + "Имя | Фамилия | Счет";
            labelMsg.Location = new Point(10, 10);
            labelMsg.Width = 450;
            labelMsg.Height = 35;
            labelMsg.TextAlign = ContentAlignment.MiddleLeft;
            labelMsg.BorderStyle = BorderStyle.Fixed3D;
            labelMsg.Font = new Font("Times New Roman", 11, FontStyle.Regular);
            this.Controls.Add(labelMsg);

            textBoxName.Left = labelMsg.Left;
            textBoxName.Top = labelMsg.Bottom;
            textBoxName.Width = labelMsg.Width / 3 - 5;
            textBoxName.Height = labelMsg.Height;
            this.Controls.Add(textBoxName);
            textBoxSurname.Left = textBoxName.Right + 5;
            textBoxSurname.Top = labelMsg.Bottom;
            textBoxSurname.Width = labelMsg.Width / 3 - 5;
            textBoxSurname.Height = labelMsg.Height;
            this.Controls.Add(textBoxSurname);
            textBoxCheck.Left = textBoxSurname.Right + 5;
            textBoxCheck.Top = labelMsg.Bottom;
            textBoxCheck.Width = labelMsg.Width / 3;
            textBoxCheck.Height = labelMsg.Height;
            this.Controls.Add(textBoxCheck);

            datePicker.Left = labelMsg.Left;
            datePicker.Top = textBoxName.Bottom;
            datePicker.Height = labelMsg.Height;
            datePicker.Width = labelMsg.Width;
            datePicker.Format = DateTimePickerFormat.Short;
            this.Controls.Add(datePicker);

            Button buttonName = new Button();
            buttonName.Text = "Сохранить";
            buttonName.Height = labelMsg.Height;
            buttonName.Width = labelMsg.Width;
            buttonName.Left = labelMsg.Left;
            buttonName.Top = datePicker.Bottom;
            buttonName.MouseClick += buttonClickClient;
            this.Controls.Add(buttonName);


            labelMsg2.Text = "Добавить сотрудника" + Environment.NewLine + "Имя | Фамилия | Зарплата";
            labelMsg2.Left = buttonName.Left;
            labelMsg2.Top = buttonName.Bottom + 10;
            labelMsg2.Width = 450;
            labelMsg2.Height = 35;
            labelMsg2.TextAlign = ContentAlignment.MiddleLeft;
            labelMsg2.BorderStyle = BorderStyle.Fixed3D;
            labelMsg2.Font = new Font("Times New Roman", 11, FontStyle.Regular);
            this.Controls.Add(labelMsg2);

            textBoxName2.Left = labelMsg2.Left;
            textBoxName2.Top = labelMsg2.Bottom;
            textBoxName2.Width = labelMsg2.Width / 3 - 5;
            textBoxName2.Height = labelMsg2.Height;
            this.Controls.Add(textBoxName2);
            textBoxSurname2.Left = textBoxName2.Right + 5;
            textBoxSurname2.Top = labelMsg2.Bottom;
            textBoxSurname2.Width = labelMsg2.Width / 3 - 5;
            textBoxSurname2.Height = labelMsg2.Height;
            this.Controls.Add(textBoxSurname2);
            textBoxSalary.Left = textBoxSurname2.Right + 5;
            textBoxSalary.Top = labelMsg2.Bottom;
            textBoxSalary.Width = labelMsg2.Width / 3;
            textBoxSalary.Height = labelMsg2.Height;
            this.Controls.Add(textBoxSalary);

            datePicker2.Left = labelMsg2.Left;
            datePicker2.Top = textBoxName2.Bottom;
            datePicker2.Height = labelMsg2.Height;
            datePicker2.Width = labelMsg2.Width;
            datePicker2.Format = DateTimePickerFormat.Short;
            this.Controls.Add(datePicker2);

            listBox3.Left = labelMsg2.Left;
            listBox3.Top = datePicker2.Bottom;
            listBox3.Height = 50;
            listBox3.Width = labelMsg2.Width / 2 - 5;
            string[] education = { "Среднее образование", "Бакалавр", "Специалист", "Магистр" };
            listBox3.Items.AddRange(education);
            this.Controls.Add(listBox3);

            listBox4.Left = listBox3.Right + 10;
            listBox4.Top = datePicker2.Bottom;
            listBox4.Height = 50;
            listBox4.Width = labelMsg2.Width / 2 - 5;
            string[] functions = { "Охранник", "Повар", "Курьер", "Менеджер", "Кассир" };
            listBox4.Items.AddRange(functions);
            this.Controls.Add(listBox4);

            Button buttonName2 = new Button();
            buttonName2.Text = "Сохранить";
            buttonName2.Height = labelMsg2.Height;
            buttonName2.Width = labelMsg2.Width;
            buttonName2.Left = labelMsg2.Left;
            buttonName2.Top = listBox4.Bottom;
            buttonName2.MouseClick += buttonClickEmployee;
            this.Controls.Add(buttonName2);


            labelMsg3.Text = "Добавить товар" + Environment.NewLine + "Название | Id | Цена";
            labelMsg3.Left = buttonName2.Left;
            labelMsg3.Top = buttonName2.Bottom + 10;
            labelMsg3.Width = 450;
            labelMsg3.Height = 35;
            labelMsg3.TextAlign = ContentAlignment.MiddleLeft;
            labelMsg3.BorderStyle = BorderStyle.Fixed3D;
            labelMsg3.Font = new Font("Times New Roman", 11, FontStyle.Regular);
            this.Controls.Add(labelMsg3);

            textBoxName3.Left = labelMsg3.Left;
            textBoxName3.Top = labelMsg3.Bottom;
            textBoxName3.Width = labelMsg3.Width / 3 - 5;
            textBoxName3.Height = labelMsg3.Height;
            this.Controls.Add(textBoxName3);
            textBoxId.Left = textBoxName3.Right + 5;
            textBoxId.Top = labelMsg3.Bottom;
            textBoxId.Width = labelMsg3.Width / 3 - 5;
            textBoxId.Height = labelMsg3.Height;
            this.Controls.Add(textBoxId);
            textBoxPrice.Left = textBoxId.Right + 5;
            textBoxPrice.Top = labelMsg3.Bottom;
            textBoxPrice.Width = labelMsg3.Width / 3;
            textBoxPrice.Height = labelMsg3.Height;
            this.Controls.Add(textBoxPrice);

            listBox5.Left = labelMsg3.Left;
            listBox5.Top = textBoxPrice.Bottom;
            listBox5.Height = 100;
            listBox5.Width = labelMsg3.Width / 2 - 5;
            string[] clasification = { "Салаты", "Первое", "Второе", "Гарниры", "Напитки", "Прочее" };
            listBox5.Items.AddRange(clasification);
            this.Controls.Add(listBox5);

            Button buttonName3 = new Button();
            buttonName3.Text = "Сохранить";
            buttonName3.Height = labelMsg3.Height;
            buttonName3.Width = labelMsg3.Width;
            buttonName3.Left = labelMsg3.Left;
            buttonName3.Top = listBox5.Bottom;
            buttonName3.MouseClick += buttonClickProduct;
            this.Controls.Add(buttonName3);


            spot.Left = buttonName3.Left;
            spot.Top = buttonName3.Bottom + 10;
            spot.Multiline = true;
            spot.ScrollBars = ScrollBars.Vertical;
            spot.Width = 450;
            spot.Height = 165;
            spot.BorderStyle = BorderStyle.Fixed3D;
            spot.Font = new Font("Times New Roman", 11, FontStyle.Regular);
            this.Controls.Add(spot);
        }

        private void buttonClickClient(object obj, EventArgs ea)
        {
            double check = Convert.ToDouble(textBoxCheck.Text);
            Client clientNew = new Client(textBoxName.Text, textBoxSurname.Text, datePicker.Value, check);
            spot.Text = spot.Text + Environment.NewLine + "Новый клиент: " + clientNew.ToString();
        }
        private void buttonClickEmployee(object obj, EventArgs ea)
        {
            double salary = Convert.ToDouble(textBoxSalary.Text);
            Education education = (Education)listBox3.SelectedIndex;
            Function function = (Function)listBox4.SelectedIndex;
            Employee employeeNew = new Employee(textBoxName2.Text, textBoxSurname2.Text, datePicker2.Value, salary, education, function);
            spot.Text = spot.Text + Environment.NewLine + "Новый работник: " + employeeNew.ToString();
        }
        private void buttonClickProduct(object obj, EventArgs ea)
        {
            double price = Convert.ToDouble(textBoxPrice.Text);
            int id = Convert.ToInt32(textBoxId.Text);
            Clasification clasification = (Clasification)listBox5.SelectedIndex;
            Product employeeNew = new Product(textBoxName3.Text, id, price, clasification);
            spot.Text = spot.Text + Environment.NewLine + "Новый товар: " + employeeNew.ToString();
        }
    }
}
