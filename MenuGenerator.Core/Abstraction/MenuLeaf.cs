using System;

namespace MenuGenerator.Core.Abstraction
{
    public abstract class MenuLeaf : MenuComponent
    {
        protected MenuLeaf(string name, string description = null) : base(name, description)
        {

        }

        public override MenuParent Parent { get; set; }

        public override void Operation()
        {
            throw new NotImplementedException();
        }

        public override bool IsParentMenu()
        {
            return false;
        }
    }
}
