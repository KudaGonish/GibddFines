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
using GIBDDFine.Forms.driver;

namespace GIBDDFine
{
    public partial class DriverViewFine : UserControl
    {
        public DriverViewFine()
        {
            InitializeComponent();
        }

        private void DriverViewFine_Load(object sender, EventArgs e)
        {
            clearData();
            loadData(QueryForBD.getinfoAboutFine());
        }
        private void refreshButton_Click(object sender, EventArgs e)
        {
            clearData();
            loadData(QueryForBD.getinfoAboutFine());
        }
        private void filterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (filterBox.SelectedItem)
            {
                case "Все":
                    clearData();
                    loadData(QueryForBD.getinfoAboutFine());
                    break;
                case "Оплачено":
                    clearData();
                    loadData(QueryForBD.finesFilter("Оплачено"));
                    break;
                case "Не оплачено":
                    clearData();
                    loadData(QueryForBD.finesFilter("Не оплачено"));
                    break;
            }
        }
        private void moreInffoButton_Click(object sender, EventArgs e)
        {
            
            var model = QueryForBD.getinfoAboutFine();
            int valueCell = Convert.ToInt32(finesGridView["номерШтрафа", finesGridView.CurrentRow.Index].Value);

            new InfoAboutFine(model.Where(n => n.номерШтрафа == valueCell).ToList()).ShowDialog();
        }

        private void finesGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < finesGridView.RowCount; i++)
                switch (finesGridView["статус", i].Value.ToString())
                {
                    case "Оплачено":
                        finesGridView["статус", i].Style.ForeColor = Color.Chartreuse;
                        break;
                    case "Не оплачено":
                        finesGridView["статус", i].Style.ForeColor = Color.Crimson;
                        break;
                }
        }

        private void loadData(List<DriverModel> dataList)
        {
            
            finesGridView.AutoGenerateColumns = true;
            finesGridView.DataSource = dataList;
            finesGridView.Columns["датаШтрафа"].Visible = false;
            finesGridView.Columns["табельныйНомер"].Visible = false;
            finesGridView.Columns["номерШтрафа"].Visible = false;

        }
        private void clearData()
        {
            finesGridView.DataSource = null;
            finesGridView.Rows.Clear();
        }


    }
}
