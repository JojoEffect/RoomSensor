﻿namespace HomieNano.Version4.Attributes
{
    public class RetainedAttribute : BoolAttributeBase
    {
        public RetainedAttribute(IHomieEntity parent, bool initialValue = true) 
            : base($"{Constants.AttributeIdentifierPrefix}retained", parent, initialValue)
        {
        }
    }
}
