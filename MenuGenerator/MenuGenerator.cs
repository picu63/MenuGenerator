using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using MenuGenerator.Core;
using MenuGenerator.Core.Abstraction;

namespace MenuGenerator
{
    public class MenuGenerator : Control
    {
        private readonly MenuParent _menu;

        public MenuGenerator(MenuParent menu)
        {
            _menu = menu;
        }

        public MenuGenerator Create()
        {
            HtmlGenericControl li = new HtmlGenericControl();
            foreach (var submenu in _menu.Submenus)
            {

                HtmlGenericControl line = new HtmlGenericControl("p");
                HtmlGenericControl anchor = new HtmlGenericControl("a");
                line.Controls.Add(anchor);
                anchor.InnerHtml = submenu.Name;
                anchor.Attributes.Add("title", submenu.Description);
                switch (submenu)
                {
                    case MenuLink menuLink:
                        anchor.Attributes.Add("href", menuLink.Url);
                        break;
                }
                li.Controls.Add(line);
            }

            this.Controls.Add(li);
            return this;
        }
    }
}
