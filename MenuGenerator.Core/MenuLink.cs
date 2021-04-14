using System;
using MenuGenerator.Core.Abstraction;

namespace MenuGenerator.Core
{
    public class MenuLink : MenuLeaf
    {
        public string Url { get; }

        public MenuLink(string url, string name, string description = null) : base(name, description)
        {
            Url = url;
        }

        public override MenuType GetMenuType()
        {
            return MenuType.Link;
        }

        public override void Operation()
        {
            throw new NotImplementedException();
        }
    }
}
