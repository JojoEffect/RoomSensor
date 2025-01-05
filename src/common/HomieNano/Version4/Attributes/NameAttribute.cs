namespace HomieNano.Version4.Attributes
{
    internal class NameAttribute : StringAttributeBase
    {
        public NameAttribute(string name, IHomieEntity parent) 
            : base(name, $"{Constants.AttributeIdentifierPrefix}name", parent)
        {
        }
    }
}
