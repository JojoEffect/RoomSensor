using HomieNano.Version4.Attributes;

namespace HomieNano.Version4
{
    internal class Node : HomieEntityBase
    {
        private readonly PropertiesAttribute _propertiesAttribute;
        private readonly TypeAttribute _typeAttribute;
        private readonly Property[] _properties;

        public Node(string topicId, string name, Device parent, string type, Property[] properties)
            : base(topicId, name, parent)
        {
            _typeAttribute = new TypeAttribute(type, this);
            _propertiesAttribute = new(Utils.GetTopicIds(properties), this);

            _properties = properties;
        }

        public TypeAttribute TypeAttribute => _typeAttribute;

        public PropertiesAttribute PropertiesAttribute => _propertiesAttribute;

        public Property[] Properties => _properties;
    }
}
