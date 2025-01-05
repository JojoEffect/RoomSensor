namespace HomieNano.Version4.Attributes
{
    internal class ImplementationAttribute : StringAttributeBase
    {
        public ImplementationAttribute(string implementation, IHomieEntity parent)
            : base(implementation, $"{Constants.AttributeIdentifierPrefix}implementation", parent)
        { 
        }
    }
}
