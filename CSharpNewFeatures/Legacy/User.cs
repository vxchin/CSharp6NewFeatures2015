using System;

namespace CSharpNewFeatures.Legacy
{
    public class User
    {
        public User(int id)
        {
            _id = id;
        }

        private readonly int _id;

        public int Id
        {
            get { return _id; }
        }

        public string Name { get; set; }

        public decimal Salary { get; set; }

        public string SalaryText
        {
            get
            {
                return string.Format("{0:C}", Salary);
            }
        }

        public override string ToString()
        {
            return string.Format("Id: {0} Name: {1}", Id, Name);
        }

        private bool _isEnabled = true;

        public bool IsEnabled
        {
            get { return _isEnabled; }
            set { _isEnabled = value; }
        }

        public void AddToRole(Role role)
        {
            if (role == null)
                throw new ArgumentNullException("role");
            // ...
        }
    }
}
