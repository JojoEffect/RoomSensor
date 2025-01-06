namespace HomieNano.Version4.Attributes
{
    public class UnitAttribute : StringAttributeBase
    {
        public UnitAttribute(IHomieEntity parent, string unit)
            : base($"{Constants.AttributeIdentifierPrefix}unit", parent, unit)
        {
        }
    }
}
