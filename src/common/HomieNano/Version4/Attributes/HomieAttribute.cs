﻿namespace HomieNano.Version4.Attributes
{
    public class HomieAttribute : StringAttributeBase
    {
        public HomieAttribute(IHomieEntity parent, string version)
            : base($"{Constants.AttributeIdentifierPrefix}homie", parent, version)
        {
        }
    }
}
