namespace CSharpNewFeatures.Legacy
{
    public class Role
    {
        private readonly string _name;

        public string Name { get { return _name; } }

        public Role(string name)
        {
            _name = name;
        }
    }
}
