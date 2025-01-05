
namespace HomieNano.Version4.Attributes
{
    internal class StateAttribute : AttributeBase
    {
        private readonly State _value;

        public StateAttribute(State state, IHomieEntity parent)
            : base($"{Constants.AttributeIdentifierPrefix}state", parent)
        {
            _value = state;
        }

        public State Value => _value;

        public override string GetPayload() => Value.ToString().ToLower();
    }
}
