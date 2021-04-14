using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MenuGenerator.Core;
using MenuGenerator.Core.Abstraction;

namespace MenuGenerator.UITests.Tests
{
    public partial class SimpleNotNested : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MenuParent mainMenu = new MenuParent("Menu główne", "Menu które nie posiada menu nadrzędnego.");
            mainMenu.AddSubmenu(new MenuLink("localhost/oddzialy","Oddziały", "Lista z oddziałami."));
            mainMenu.AddSubmenu(new MenuLink("localhost/zamki","Zamki", "Lista z zamkami"));
            mainMenu.AddSubmenu(new MenuLink("localhost/uzytkownicy","Użytkownicy", "Lista ze wszystkimi użytkownikami"));
            mainMenu.AddSubmenu(new MenuLink("localhost/konfiguracja","Konfiguracja"));
            MenuGenerator menuGenerator = new MenuGenerator(mainMenu);

            menuGenerator.Create();
            dynamicPlaceHolder.Controls.Add(menuGenerator);
        }
    }
}