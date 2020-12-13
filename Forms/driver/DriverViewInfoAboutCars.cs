using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GIBDDFine.Models;

namespace GIBDDFine
{
    public partial class DriverViewInfoAboutCars : UserControl
    {
        public DriverViewInfoAboutCars()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void DriverViewInfoAboutCars_Load(object sender, EventArgs e)
        {
            //string nameQuery = String.Format("Select FIO from Водители where NomerPrav = '{0}'", UserModel.idUser);

            //DataSet fioDataSet = await BDConnect.Select(nameQuery);

            //fioLabel.Text = fioDataSet.Tables[0].Rows[0][0].ToString();


            //string infoAboutCarQuery = String.Format("select s.StrahovoiNomer,m.GosNomer, m.MarkaAvto " +
            //                                  "from Машины m, Страховка s " +
            //                                  "where s.Owner = '{0}' and s.Avto = m.GosNomer", UserModel.idUser);
            //DataSet fineDataSet = await BDConnect.Select(infoAboutCarQuery);
            
            //loadData(fineDataSet);
        }
        private void loadData(DataSet dataSet)
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dataSet.Tables[0];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.DefaultCellStyle.Font = new Font("Century Gothic", 14);
        }

        private  void refreshButton_Click(object sender, EventArgs e)
        {
            //string infoAboutCarQuery = String.Format("select s.StrahovoiNomer,m.GosNomer, m.MarkaAvto " +
            //                                   "from Машины m, Страховка s " +
            //                                   "where s.Owner = '{0}' and s.Avto = m.GosNomer", UserModel.idUser);
            //DataSet fineDataSet = await BDConnect.Select(infoAboutCarQuery);
            //dataGridView1.DataSource = null;
            //dataGridView1.Rows.Clear();
            //loadData(fineDataSet);
        }
    }
}
