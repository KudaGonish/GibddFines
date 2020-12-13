using GIBDDFine.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GIBDDFine.Forms.driver
{
    public partial class InfoAboutFine : Form
    {
        List<DriverModel> driverModel = new List<DriverModel>();
        public InfoAboutFine(List<DriverModel> driverModel)
        {
            InitializeComponent();
            this.driverModel = driverModel;
        }

        private void InfoAboutFine_Load(object sender, EventArgs e)
        {
            foreach(var item in driverModel)
            {
                tabelLabel.Text = item.табельныйНомер.ToString();
                gosNumLabel.Text =item.номер;
                markLabel.Text = item.марка;
                dateLabel.Text = item.датаШтрафа.Date.ToShortDateString();
                opisanieBox.Text = item.описание;
                statusLabel.Text = item.статус;
                sumLabel.Text = item.сумма.ToString()+ "₽";
            }
            
        }
        private void payButton_Click(object sender, EventArgs e)
        {
            if(statusLabel.Text == "Оплачено")
                MessageBox.Show("Штраф уже был опачен ранее");
            else if(statusLabel.Text == "Не оплачено")
                QueryForBD.updateFine(driverModel.Find(i => i.номер == i.номер).номерШтрафа);
        }
    }
}
