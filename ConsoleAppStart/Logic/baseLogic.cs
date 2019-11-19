using ConsoleAppStart.model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStart.Logic
{
    class BaseLogic
    {
        MyAppContext db;
        public BaseLogic()
        {
            db = new MyAppContext();
        }
        /// <summary>
        /// Получить список клиентов
        /// </summary>
        /// <param name="Name">Имя компании</param>
        /// <returns></returns>
        public List<Client> GetClients(string Name = "")
        {
            if (Name == "")
            {
                return db.Clients.ToList<Client>();
            }
            else
            {
                return db.Clients.Where(item => item.NameCompany.IndexOf(Name) > -1).ToList<Client>();
            }
        }
        public string GetClient(Client client)
        {
            return $"Имя компании:{client.NameCompany}\tИмя клиента:{client.FIO}";
        }
        /// <summary>
        /// Добавить клиента в базу данных
        /// </summary>
        /// <param name="client">Клиент</param>
        public void AddClient(Client client)
        {
            //проверка 
            db.Clients.Add(client);
            db.SaveChanges();
        }
    }
}
