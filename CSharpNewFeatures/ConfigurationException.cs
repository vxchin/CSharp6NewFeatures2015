using System;

namespace CSharpNewFeatures
{

    [Serializable]
    public class ConfigurationException : Exception
    {
        public ConfigurationException() { }
        public ConfigurationException(string message, bool isSevere) : base(message) { IsSevere = isSevere; }
        public ConfigurationException(string message, Exception inner) : base(message, inner) { }
        public ConfigurationException(string message, bool isSevere, Exception inner) : base(message, inner) { IsSevere = isSevere; }
        protected ConfigurationException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context)
        { }

        public bool IsSevere { get; }
    }
}
