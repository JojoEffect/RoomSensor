using HomieNano.Version4.Attributes;
using System;

namespace HomieNano.Version4
{
    public class Device : NamedHomieEntityBase
    {
        private readonly object _lock = new();

        private readonly HomieAttribute _homieAttribute;
        private readonly NodesAttribute _nodesAttribute;
        private readonly StateAttribute _stateAttribute;
        private readonly ExtensionsAttribute _extensionsAttribute;
        private readonly ImplementationAttribute _implementationAttribute;

        private Node[] _nodes = new Node[0];

        public Device(string topicId, string name, string[] extensions, string implementation = "")
            : base(topicId, name)
        {
            _homieAttribute = new(this, Constants.Version4);
            _nodesAttribute = new(this, Utils.GetTopicIds(_nodes));
            _stateAttribute = new(this, State.Init);
            _extensionsAttribute = new(this, extensions);
            _implementationAttribute = new(this, implementation);
        }

        public HomieAttribute HomieAttribute => _homieAttribute;

        public NodesAttribute NodesAttribute => _nodesAttribute;

        public StateAttribute StateAttribute => _stateAttribute;

        public ExtensionsAttribute ExtensionsAttribute => _extensionsAttribute;

        public ImplementationAttribute ImplementationAttribute => _implementationAttribute;

        public Node[] Nodes
        {
            get
            {
                lock (_lock) { return _nodes; }
            }
        }

        public void AddNode(Node node)
        {
            lock (_lock)
            {
                // Add the node to the NodesAttribute
                _nodesAttribute.Add(node.TopicId);

                // Create and set a new array with the new node
                Node[] newNodes = new Node[_nodes.Length + 1];
                Array.Copy(_nodes, newNodes, _nodes.Length);
                newNodes[_nodes.Length] = node;
                _nodes = newNodes;
            }
        }
    }
}
