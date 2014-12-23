using System;

namespace CSharpNewFeatures.Legacy
{

    [Serializable]
    public class ConfigurationException : Exception
    {
        public ConfigurationException() { }
        public ConfigurationException(string message, bool isSevere) : base(message) { _isSevere = isSevere; }
        public ConfigurationException(string message, Exception inner) : base(message, inner) { }
        public ConfigurationException(string message, bool isSevere, Exception inner) : base(message, inner) { _isSevere = isSevere; }
        protected ConfigurationException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context)
        { }

        private readonly bool _isSevere;
        public bool IsSevere { get { return _isSevere; } }
    }
}
