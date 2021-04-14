using System;

namespace MenuGenerator.Core.Abstraction
{
    public abstract class MenuComponent
    {
        public string Name { get; }
        public string Description { get; }

        public virtual MenuType GetMenuType()
        {
            return MenuType.Unknown;
        }

        public abstract MenuParent Parent { get; set; }

        protected MenuComponent(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }
        public abstract void Operation();

        public virtual void AddSubmenu(MenuComponent menuComponent)
        {
            throw new NotImplementedException();
        }

        public virtual void RemoveSubmenu(MenuComponent menuComponent)
        {
            throw new NotImplementedException();
        }

        public virtual bool IsParentMenu()
        {
            return true;
        }
    }
}
