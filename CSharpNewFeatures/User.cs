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

        // public string SalaryText => "\{Salary : C}";                     // Visual Studio 2015 Preview
        public string SalaryText => $"{Salary : C}";                        // Visual Studio 2015 RC / CTP 5

        // public override string ToString() => "Id: \{Id} Name: \{Name}";     // Visual Studio 2015 Preview
        public override string ToString() => $"Id: {Id} Name: {Name}";     // Visual Studio 2015 RC / CTP 5

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
