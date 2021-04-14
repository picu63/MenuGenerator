using System;
using MenuGenerator.Core.Abstraction;

namespace MenuGenerator.Core
{
    public class MenuTypeGenerator : MenuLeaf
    {
        public Type Type { get; }

        public MenuTypeGenerator(Type type, string name, string description = null) : base(name, description)
        {
            Type = type;
        }
    }
}