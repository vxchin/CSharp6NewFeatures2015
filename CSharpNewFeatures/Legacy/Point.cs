namespace CSharpNewFeatures.Legacy
{
    using Newtonsoft.Json.Linq;
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public class Point : INotifyPropertyChanged
    {
        public Point(double x, double y)
        {
            _x = x;
            _y = y;
        }

        private double _x, _y;

        public double X
        {
            get { return _x; }
            set { if (_x != value) { _x = value; NotifyPropertyChanged(); } }
        }
        public double Y
        {
            get { return _y; }
            set { if (_y != value) { _y = value; NotifyPropertyChanged(); } }
        }

        public double Distance
        {
            get
            {
                return Math.Sqrt(X * X + Y * Y);
            }
        }

        public static Point FromJson(JObject json)
        {
            if (json != null &&
                json["x"] != null &&
                json["x"].Type == JTokenType.Integer &&
                json["y"] != null &&
                json["y"].Type == JTokenType.Integer)
            {
                return new Point((int)json["x"], (int)json["y"]);
            }
            return null;
        }

        public JObject ToJson()
        {
            return new JObject { { "x", X }, { "y", Y } };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged([CallerMemberName]string propertyName = "")
        {
            var propertyChanged = PropertyChanged;
            if (propertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
