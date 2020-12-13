using GIBDDFine.Models;
using System.Collections.Generic;
using System.Linq;

namespace GIBDDFine
{
    class QueryForBD
    {
        /// <summary>
        /// Находим юзера в базе данных
        /// 
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>

        public static string getUserRole(string login, string password)
        {
            var user = GibddEntities.GetContext().Пользователи.Where(u => u.Login == login && u.Password == password).ToList();

            try
            {
                UserModel.idUser = user.First().IdUser;
                UserModel.roleUser = user.First().Роли.First().RoleName;

                var role = user.First().Роли.ToList();
                return role.First().RoleName;
            }
            catch
            {
                return "null";
            }
        }
        /// <summary>
        /// Получаем список штрафов для конкретного юзера
        /// </summary>
        /// <returns></returns>
        public static List<DriverModel> getinfoAboutFine()
        {
            var driverModels = new List<DriverModel>();

            var insurance = GibddEntities.GetContext().Страховка.Where(i => i.Owner == UserModel.idUser);

            foreach (var item in insurance)
            {
                var fines = GibddEntities.GetContext().Штрафы.Where(id => id.GosNomer == item.Машины.GosNomer);

                foreach (var info in fines)
                    driverModels.Add(new DriverModel
                    {
                        номер = info.GosNomer,
                        марка = info.MarkaAvto,
                        статус = info.Status,
                        описание = info.OpisanieShtrafa,
                        сумма = info.SumShtrafa,
                        датаШтрафа = info.DateFine,
                        табельныйНомер = info.SotrudnikTabel,
                        номерШтрафа = info.NomerShtrafa
                    });
            }
            return driverModels;
        }
        public static List<DriverModel> finesFilter(string way)
        {
            var driverModels = new List<DriverModel>();

            var insurance = GibddEntities.GetContext().Страховка.Where(i => i.Owner == UserModel.idUser);

            foreach (var item in insurance)
            {
                var fines = GibddEntities.GetContext().Штрафы.Where(id => id.GosNomer == item.Машины.GosNomer && id.Status == way);

                foreach (var info in fines)
                    driverModels.Add(new DriverModel
                    {
                        номер = info.GosNomer,
                        марка = info.MarkaAvto,
                        статус = info.Status,
                        описание = info.OpisanieShtrafa,
                        сумма = info.SumShtrafa,
                        датаШтрафа = info.DateFine,
                        табельныйНомер = info.SotrudnikTabel,
                        номерШтрафа = info.NomerShtrafa
                    });
            }
            return driverModels;
        }
        public static void updateFine(int idFine)
        {
            GibddEntities context = new GibddEntities();
            var insurance = context.Страховка.Where(i => i.Owner == UserModel.idUser);

            foreach (var item in insurance)
            {
                GibddEntities.GetContext().Штрафы.Where(id => id.NomerShtrafa == idFine).First().Status = "Оплачен";
                GibddEntities.GetContext().SaveChanges();
            }

        }
    }
}
