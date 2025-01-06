﻿namespace HomieNano.Version4.Attributes
{
    public class PropertiesAttribute : StringArrayAttributeBase
    {
        public PropertiesAttribute(IHomieEntity parent, string[] properties)
            : base($"{Constants.AttributeIdentifierPrefix}properties", parent, properties)
        { }
    }
}
