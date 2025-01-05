namespace HomieNano.Version4.Attributes
{
    internal class PropertiesAttribute : StringArrayAttributeBase
    {
        public PropertiesAttribute(string[] properties, IHomieEntity parent)
            : base(properties, $"{Constants.AttributeIdentifierPrefix}properties", parent)
        { }
    }
}
