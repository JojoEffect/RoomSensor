using HomieNano.Version4;

namespace HomieNano
{
    public class HomieDeviceBuilder
    {
        private Device? _device;
        private readonly string _topicId;
        private readonly string _name;
        private readonly string[] _extensions;

        public HomieDeviceBuilder(string topicId, string name, string[]? extensions = null)
        {
            _topicId = topicId;
            _name = name;
            _extensions = extensions is null ? new string[1] : extensions;
        }

        public Device BuildDevice()
        {
            if (_device is null)
            {
                return new Device(_topicId, _name, _extensions);
            }

            return _device;
        }

        public HomieDeviceBuilder WithImplementation(string implementation)
        {
            if (_device is null)
            {
                _device = new Device(_topicId, _name, _extensions, implementation);
            }
            else
            {
                _device.ImplementationAttribute.Value = implementation;
            }

            return this;
        }

        public HomieNodeBuilder AddNode(string topicId, string name, string type)
        {
            _device ??= new Device(_topicId, _name, _extensions);
            return new HomieNodeBuilder(this, _device, topicId, name, type);
        }
    }

    public class HomieNodeBuilder
    {
        private readonly HomieDeviceBuilder _deviceBuilder;
        private readonly Device _parent;

        private Node? _node;

        private readonly string _topicId;
        private readonly string _name;
        private readonly string _type;

        internal HomieNodeBuilder(HomieDeviceBuilder deviceBuilder, Device parent, string topicId, string name, string type)
        {
            _deviceBuilder = deviceBuilder;
            _parent = parent;
            _topicId = topicId;
            _name = name;
            _type = type;
        }

        public HomieDeviceBuilder BuildNode()
        {
            _node ??= new Node(_topicId, _name, _parent, _type);
            _parent.AddNode(_node);

            return _deviceBuilder;
        }

        public HomiePropertyBuilder AddProperty(string topicId, string name, DataType dataType)
        {
            _node ??= new Node(_topicId, _name, _parent, _type);
            return new HomiePropertyBuilder(this, _node, topicId, name, dataType);
        }
    }

    public class HomiePropertyBuilder
    {
        private readonly HomieNodeBuilder _nodeBuilder;
        private readonly Node _parent;
        private readonly string _topicId;
        private readonly string _name;
        private readonly DataType _dataType;

        private Property? _property;

        internal HomiePropertyBuilder(HomieNodeBuilder nodeBuilder, Node parent, string topicId, string name, DataType dataType)
        {
            _nodeBuilder = nodeBuilder;
            _parent = parent;
            _topicId = topicId;
            _name = name;
            _dataType = dataType;
        }

        public HomieNodeBuilder BuildProperty()
        {
            _property ??= new Property(_topicId, _name, _parent, _dataType);
            _parent.AddProperty(_property);

            return _nodeBuilder;
        }

        public HomiePropertyBuilder WithFormat(string format)
        {
            if (_property is null)
            {
                _property = new Property(_topicId, _name, _parent, _dataType);
            }
            else
            {
                _property.FormatAttribute.Value = format;
            }

            return this;
        }

        public HomiePropertyBuilder WithSettable(bool settable)
        {
            if (_property is null)
            {
                _property = new Property(_topicId, _name, _parent, _dataType);
            }
            else
            {
                _property.SettableAttribute.Value = settable;
            }
            return this;
        }

        public HomiePropertyBuilder WithRetained(bool retained)
        {
            if (_property is null)
            {
                _property = new Property(_topicId, _name, _parent, _dataType);
            }
            else
            {
                _property.RetainedAttribute.Value = retained;
            }
            return this;
        }

        public HomiePropertyBuilder WithUnit(string unit)
        {
            if (_property is null)
            {
                _property = new Property(_topicId, _name, _parent, _dataType);
            }
            else
            {
                _property.Unit.Value = unit;
            }
            return this;
        }
    }

}
