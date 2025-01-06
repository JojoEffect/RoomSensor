namespace HomieNano.Version4.Attributes
{
    public abstract class BoolAttributeBase : AttributeBase
    {
        private bool _value;

        public BoolAttributeBase(string topicId, IHomieEntity parent, bool initialValue)
            : base(topicId, parent)
        {
            _value = initialValue;
        }

        public virtual bool Value { get => _value; set => _value = value; }

    }
}
