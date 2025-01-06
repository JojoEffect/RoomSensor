using HomieNano.Version4.Attributes;

namespace HomieNano.Version4
{
    public class Device : NamedHomieEntityBase
    {
        private readonly HomieAttribute _homieAttribute;
        private readonly NodesAttribute _nodesAttribute;
        private readonly StateAttribute _stateAttribute;
        private readonly ExtensionsAttribute _extensionsAttribute;
        private readonly ImplementationAttribute? _implementationAttribute;
        private readonly Node[] _nodes;

        public Device(string topicId, string name, Node[] nodes, string[] extensions, string? implementation = "") 
            : base(topicId, name)
        {
            _homieAttribute = new(this, Constants.Version4);
            _nodesAttribute = new(this, Utils.GetTopicIds(nodes));         
            _stateAttribute = new(this, State.Init);
            _extensionsAttribute = new(this, extensions);
            _implementationAttribute = implementation is not null ? new(this, implementation) : null;

            _nodes = nodes;
        }

        public HomieAttribute HomieAttribute => _homieAttribute;

        public NodesAttribute NodesAttribute => _nodesAttribute;

        public StateAttribute StateAttribute => _stateAttribute;

        public ExtensionsAttribute ExtensionsAttribute => _extensionsAttribute;

        public ImplementationAttribute? ImplementationAttribute => _implementationAttribute;

        public Node[] Nodes => _nodes;
    }
}
