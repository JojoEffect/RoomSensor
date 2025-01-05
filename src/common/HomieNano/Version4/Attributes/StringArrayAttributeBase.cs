﻿namespace HomieNano.Version4.Attributes
{
    internal abstract class StringArrayAttributeBase : AttributeBase
    {
        private string[] _value;

        public StringArrayAttributeBase(string[] stringArray, string topicIdentifier, IHomieEntity parent)
            : base(topicIdentifier, parent)
        {
            _value = stringArray;
        }

        public virtual string[] Value { get => _value; protected set => _value = value; }

        public override string GetPayload()
        {
            if (Value == null || Value.Length == 0)
            {
                return string.Empty;
            }

            var payload = new System.Text.StringBuilder();
            for (int i = 0; i < Value.Length; i++)
            {
                if (i > 0)
                {
                    payload.Append(",");
                }
                payload.Append(Value[i]);
            }
            return payload.ToString();
        }
    }
}
