using System;
using System.Threading;
using System.Windows.Forms;

namespace GIBDDFine
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (loginBox.Text != null && passwordBox.Text != null)
            {
                string role = QueryForBD.getUserRole(loginBox.Text, passwordBox.Text);
                switch (role)
                {
                    case "Водитель":
                        Thread openDriverForm = new Thread(delegate ()
                        {
                            Application.Run(new DriverForm());
                        });
                        Close();
                        openDriverForm.SetApartmentState(ApartmentState.STA);
                        openDriverForm.Start();
                        break;

                    case "Сотрудник":
                        Thread openEmployeeForm = new Thread(delegate ()
                        {
                            Application.Run(new EmployeeForm());
                        });
                        Close();
                        openEmployeeForm.SetApartmentState(ApartmentState.STA);
                        openEmployeeForm.Start();
                        break;

                    default:
                        MessageBox.Show("Ошибка входа, повторите попытку");
                        break;

                }

            }
        }

        private void passwordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                enterButton_Click(sender, new EventArgs());
            }
        }
    }
}
