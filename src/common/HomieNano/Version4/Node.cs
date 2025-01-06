using HomieNano.Version4.Attributes;

namespace HomieNano.Version4
{
    public class Node : NamedHomieEntityBase
    {
        private readonly PropertiesAttribute _propertiesAttribute;
        private readonly TypeAttribute _typeAttribute;
        private readonly Property[] _properties;

        public Node(string topicId, string name, Device parent, string type, Property[] properties)
            : base(topicId, name, parent)
        {
            _typeAttribute = new TypeAttribute(this, type);
            _propertiesAttribute = new(this, Utils.GetTopicIds(properties));

            _properties = properties;
        }

        public TypeAttribute TypeAttribute => _typeAttribute;

        public PropertiesAttribute PropertiesAttribute => _propertiesAttribute;

        public Property[] Properties => _properties;
    }
}
