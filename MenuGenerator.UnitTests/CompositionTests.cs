using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MenuGenerator.Core;
using MenuGenerator.Core.Abstraction;
using MenuGenerator.UITests.Models;


namespace MenuGenerator.UnitTests
{
    [TestClass]
    public class CompositionTests
    {
        [TestMethod]
        public void CreationalMenuTesting()
        {
            MenuComponent mainMenu = new MenuParent("Menu główne");

            MenuComponent configMenu = new MenuParent("Menu konfiguracyjne");
            configMenu.AddSubmenu(new MenuLink("https://onet.pl","Przejdź na onet"));
            configMenu.AddSubmenu(new MenuMethod<User>(new User(){Age = 30, FirstName = "Piotr", LastName = "Stokłosa", Male = true},"ToString","MySQL"));
            var dayOff = new MenuParent("Dni wolne");
            dayOff.AddSubmenu(new MenuLink("localhost/offDays/add","Dodaj dzień wolny"));
            dayOff.AddSubmenu(new MenuLink("localhost/offDays/","Lista dni wolnych"));
            dayOff.AddSubmenu(new MenuLink("localhost/offDays/Import","Importuj z centralnej bazy danych"));
            configMenu.AddSubmenu(dayOff);

            MenuComponent usersMenu = new MenuParent("Użytkownicy");
            usersMenu.AddSubmenu(new MenuMethod<User>(new User(){FirstName = "Angelika", LastName = "Nowak"},"SaveToDb","Dodaj użytkownika"));
            usersMenu.AddSubmenu(new MenuLink("localhost/users","Lista użytkowników"));

            mainMenu.AddSubmenu(usersMenu);
            mainMenu.AddSubmenu(configMenu);

        }
    }
}
