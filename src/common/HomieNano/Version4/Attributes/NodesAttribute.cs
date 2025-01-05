using System;

namespace HomieNano.Version4.Attributes
{
    internal class NodesAttribute : StringArrayAttributeBase
    {
        public NodesAttribute(string[] nodes, IHomieEntity parent) 
            : base(nodes, $"{Constants.AttributeIdentifierPrefix}nodes", parent)
        {
        }
    }
}
