using System;

namespace CSharpNewFeatures
{

    public class User
    {
        public User(int id)
        {
            Id = id;
        }

        public int Id { get; }

        public string Name { get; set; }

        public decimal Salary { get; set; }

        public string SalaryText => "\{Salary : C}";

        public override string ToString() => "Id: \{Id} Name: \{Name}";

        // VS 2015 正式版将会引入 $"" 语法：
        // public override string ToString() => $"Id: {Id} Name: {Name}"; 

        private bool _isEnabled = true;

        public bool IsEnabled
        {
            get { return _isEnabled; }
            set { _isEnabled = value; }
        }

        public void AddToRole(Role role)
        {
            if (role == null)
                throw new ArgumentNullException(nameof(role));
            // ...
        }
    }
}
