using HomieNano.Version4.Attributes;
using System;

namespace HomieNano.Version4
{
    public class Node : NamedHomieEntityBase
    {
        private readonly object _lock = new();

        private readonly PropertiesAttribute _propertiesAttribute;
        private readonly TypeAttribute _typeAttribute;
        private Property[] _properties = new Property[0];

        public Node(string topicId, string name, Device parent, string type)
            : base(topicId, name, parent)
        {
            _typeAttribute = new TypeAttribute(this, type);
            _propertiesAttribute = new(this, Utils.GetTopicIds(_properties));
        }

        public TypeAttribute TypeAttribute => _typeAttribute;

        public PropertiesAttribute PropertiesAttribute => _propertiesAttribute;

        public Property[] Properties => _properties;

        public void AddProperty(Property property)
        {
            lock (_lock)
            {
                // Add the node to the NodesAttribute
                _propertiesAttribute.Add(property.TopicId);

                // Create and set a new array with the new node
                Property[] newProperties = new Property[_properties.Length + 1];
                Array.Copy(_properties, newProperties, _properties.Length);
                newProperties[_properties.Length] = property;
                _properties = newProperties;
            }

        }
    }
}
