namespace HomieNano.Version4.Attributes
{
    internal class ExtensionsAttribute : StringArrayAttributeBase
    {
        public ExtensionsAttribute(string[] extensions, IHomieEntity parent)
            : base(extensions, $"{Constants.AttributeIdentifierPrefix}extensions", parent)
        {
        }
    }
}
