using MenuGenerator.Core.Abstraction;

namespace MenuGenerator.Core
{
    public class MenuTypeGenerator<T> : MenuLeaf
    {
        public MenuTypeGenerator(string name, string description = null) : base(name, description)
        {

        }
    }
}