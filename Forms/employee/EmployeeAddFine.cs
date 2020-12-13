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

namespace GIBDDFine.employeeFormsAndComponents
{
    public partial class EmployeeAddFine : UserControl
    {
        public EmployeeAddFine()
        {
            InitializeComponent();
            refreshButton.Click += refreshButton_Click;
        }

        private void EmployeeAddFine_Load(object sender, EventArgs e)
        {
            //string nameQuery = String.Format("Select FIO from СотрудникиГИБДД where TabelNum = '{0}'", UserModel.idUser);

            //DataSet fioDataSet = await BDConnect.Select(nameQuery);

            //fioLabel.Text = fioDataSet.Tables[0].Rows[0][0].ToString();




            //string infoAboutFineQuery = String.Format("select * " +
            //                                   "from Штрафы " +
            //                                   "where SotrudnikTabel = '{0}'", UserModel.idUser);
            //DataSet fineDataSet = await BDConnect.Select(infoAboutFineQuery);
            //clearData();
            //loadData(fineDataSet);
        }

        private void loadData(DataSet dataSet)
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dataSet.Tables[0];
            dataGridView1.Columns["SotrudnikTabel"].Visible = false;
            dataGridView1.Columns["Status"].Visible = false;
            dataGridView1.Columns["OpisanieShtrafa"].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.DefaultCellStyle.Font = new Font("Century Gothic", 14);
        }
        private void clearData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
        }
        private void refreshButton_Click(object sender, EventArgs e)
        {
            //string infoAboutFineQuery = String.Format("select * " +
            //                                   "from Штрафы " +
            //                                   "where SotrudnikTabel = '{0}'", UserModel.idUser);
            //DataSet fineDataSet = await BDConnect.Select(infoAboutFineQuery);
            //clearData();
            //loadData(fineDataSet);
        }

        private void AddFineButton_Click(object sender, EventArgs e)
        {
            //string AboutDriverQuery = String.Format("select * " +
            //                                   "from Штрафы " +
            //                                   "where SotrudnikTabel = '{0}'", UserModel.idUser);
            //DataSet fineDataSet = await BDConnect.Select(AboutDriverQuery);

            //new AddFine()
            //{
            //    dataSet = fineDataSet
            //}.Show();
        }
    }
}
