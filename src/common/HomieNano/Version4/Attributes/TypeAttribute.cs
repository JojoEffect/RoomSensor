namespace HomieNano.Version4.Attributes
{
    internal class TypeAttribute : StringAttributeBase
    {
        public TypeAttribute(string type, IHomieEntity parent)
            : base(type, $"{Constants.AttributeIdentifierPrefix}type", parent)
        { }
    }
}
