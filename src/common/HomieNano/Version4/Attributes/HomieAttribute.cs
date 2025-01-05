namespace HomieNano.Version4.Attributes
{
    internal class HomieAttribute : StringAttributeBase
    {
        public HomieAttribute(string version, IHomieEntity parent)
            : base(version, $"{Constants.AttributeIdentifierPrefix}homie", parent)
        {
        }
    }
}
