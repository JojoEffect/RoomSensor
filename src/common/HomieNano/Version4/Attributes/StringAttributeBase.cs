namespace HomieNano.Version4.Attributes
{
    internal abstract class StringAttributeBase : AttributeBase
    {
        private string _value;

        public StringAttributeBase(string value, string topicIdentifier, IHomieEntity parent)
            : base(topicIdentifier, parent)
        {
            _value = value;
        }

        public virtual string Value { get => _value; set => _value = value; }

        public override string GetPayload() => Value;
    }
}
