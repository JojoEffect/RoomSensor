using HomieNano.Version4.Attributes;

namespace HomieNano.Version4
{
    internal class Device : HomieEntityBase
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
            _homieAttribute = new(Constants.Version4, this);
            _nodesAttribute = new(Utils.GetTopicIds(nodes), this);
            _stateAttribute = new(State.Init, this);
            _extensionsAttribute = new(extensions, this);
            _implementationAttribute = implementation is not null ? new(implementation, this) : null;

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
