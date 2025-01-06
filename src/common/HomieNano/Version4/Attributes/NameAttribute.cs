﻿namespace HomieNano.Version4.Attributes
{
    public class NameAttribute : StringAttributeBase
    {
        public NameAttribute(IHomieEntity parent, string name) 
            : base($"{Constants.AttributeIdentifierPrefix}name", parent, name)
        {
        }
    }
}
