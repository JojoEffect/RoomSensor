namespace HomieNano.Version4.Attributes
{
    public class ImplementationAttribute : StringAttributeBase
    {
        public ImplementationAttribute(IHomieEntity parent, string implementation)
            : base($"{Constants.AttributeIdentifierPrefix}implementation", parent, implementation)
        { 
        }
    }
}
