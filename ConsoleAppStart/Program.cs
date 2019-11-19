using ConsoleAppStart.Logic;
using ConsoleAppStart.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStart
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseLogic baseLogic = new BaseLogic();




            //using (MyAppContext db = new MyAppContext())
            //{
            //    //Client client1 = new Client { FIO = "Иванов Иван Иванович", NameCompany = "Восток", Adres = "Ленина 2-А", City = "Тирасполь", Index = 3300, Tel = 053325687 };
            //    //Client client2 = new Client { FIO = "Петров Антон Дмитриевич", NameCompany = "МирПК", Adres = "Восстания 56", City = "Тирасполь", Index = 3300, Tel = 0533569874 };
            //    //db.Clients.Add(client1);
            //    //db.Clients.Add(client2);
            //    //db.SaveChanges();
            //    var clients = db.Clients;
            //    Console.WriteLine("Список клиентов:");
            //    foreach (Client u in clients)
            //    {
            //        Console.WriteLine(u.FIO, u.NameCompany, u.Adres, u.City, u.Index, u.Tel);
            //    }
            //    //Employee employee1 = new Employee { FIO = "Пименов Иван Анатольевич", Adres = "Гагарина 2", Tel = 055338725, NumberOrder = 1 };
            //    //Employee employee2 = new Employee { FIO = "Агатий Ирина Игоревна", Adres = "25 октября 105", Tel = 07896325, NumberOrder = 2 };
            //    //db.Employees.Add(employee1);
            //    //db.Employees.Add(employee2);
            //    //db.SaveChanges();
            //    var employees = db.Employees;
            //    Console.WriteLine("Список Работников:");
            //    foreach (Employee x in employees)
            //    {
            //        Console.WriteLine(x.FIO, x.Adres, x.Tel, x.NumberOrder);
            //    }
            //    //Orders orders1 = new Orders { }
            //}
            Console.WriteLine("Menu");
            Console.WriteLine("1- посмотреть клиентов");
            Console.WriteLine("2- добавить клиента");

            var key = Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine(" я думаю ...");
            switch (key.Key)
            {
                case ConsoleKey.D1:
                    {
                        foreach (var item in baseLogic.GetClients())
                        {
                            Console.WriteLine(baseLogic.GetClient(item));
                        }
                        break;
                    }
                case ConsoleKey.D2:
                    {
                        baseLogic.AddClient(new Client() { FIO="Ivanov Ivan", NameCompany="Home1"});
                        break;
                    }


                default:
                    break;
            }

            Console.ReadKey();
        }
    }
}
