namespace HomieNano.Version4.Attributes
{
    public class DataTypeAttribute : AttributeBase
    {
        private readonly DataType _value;

        public DataTypeAttribute(IHomieEntity parent, DataType dataType)
            : base($"{Constants.AttributeIdentifierPrefix}datatype", parent)
        {
            _value = dataType;
        }

        public DataType Value => _value;

        public override string GetPayload() => Value.ToString().ToLower();
    }
}
