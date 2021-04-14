using System.Collections.Generic;
using MenuGenerator.Core.Abstraction;

namespace MenuGenerator.Core
{
    public class MenuParent : MenuComponent
    {
        public List<MenuComponent> Submenus { get; private set; } = new List<MenuComponent>();

        public MenuParent(string name, string description = null): base(name, description)
        {

        }

        public override MenuParent Parent { get; set; }

        public override MenuType GetMenuType()
        {
            return MenuType.Submenu;
        }

        public override void Operation()
        {
            foreach (var submenu in Submenus)
            {
                submenu.Operation();
            }
        }

        public override void AddSubmenu(MenuComponent menuComponent)
        {
            menuComponent.Parent = this;
            this.Submenus.Add(menuComponent);
        }

        public override void RemoveSubmenu(MenuComponent menuComponent)
        {
            this.Submenus.Remove(menuComponent);
        }
    }
}
