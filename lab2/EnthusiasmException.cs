namespace lab2
{
    [System.Serializable]
    public class EnthusiasmException : System.Exception
    {
        public EnthusiasmExceptionArgs args;
        
        public EnthusiasmException() { }
        public EnthusiasmException(string message) : base(message) { }
        public EnthusiasmException(string message, EnthusiasmExceptionArgs args) : base(message) 
        { 
            this.args = args;
        }
        public EnthusiasmException(string message, System.Exception inner) : base(message, inner) { }
        protected EnthusiasmException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}