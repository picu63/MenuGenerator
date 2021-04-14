using MenuGenerator.Core.Abstraction;

namespace MenuGenerator.Core
{
    public class MenuMethod<T> : MenuLeaf
    {
        private readonly T _object;
        private readonly string _methodName;

        public MenuMethod(T @object,string methodName,string name, string description = null) : base(name, description)
        {
            this._object = @object;
            _methodName = methodName;
        }
    }
}