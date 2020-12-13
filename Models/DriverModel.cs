using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIBDDFine.Models
{
    public class DriverModel
    {
        public string номер {get;set; }
        public string марка { get; set; }
        public string описание {get;set; }
        public int сумма {get;set; }
        public string статус { get; set; }
        public DateTime датаШтрафа { get; set; }
        public int табельныйНомер { get; set; }
        public int номерШтрафа { get; set; }
    }
}
