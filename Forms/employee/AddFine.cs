using GIBDDFine.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIBDDFine.employeeFormsAndComponents
{
    public partial class AddFine : Form
    {
        public AddFine()
        {
            InitializeComponent();
        }
        public DataSet dataSet { get; set; }

        private void AddFine_Load(object sender, EventArgs e)
        {
            //tabelLabel.Text = UserModel.idUser;
        }

        private void addFineButton_Click(object sender, EventArgs e)
        {
            if (gosNomerBox.Text != null && brandBox.Text != null && costBox.Text != null)
            {
                //try
                //{
                //    string query = String.Format("insert into Штрафы" +
                //                             "values(" + null + ",'{0}','{1}','{2}','{3}','Не оплачено',{5}) ", brandBox.Text, gosNomerBox.Text, infoBox.Text, costBox.Text, UserModel.idUser);
                //    BDConnect.Insert(query);
                //}
                //catch (SqlException ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}

            }
        }


    }
}
