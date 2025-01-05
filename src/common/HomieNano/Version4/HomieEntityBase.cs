using HomieNano.Version4.Attributes;

namespace HomieNano.Version4
{
    internal abstract class HomieEntityBase : IHomieEntity
    {
        private readonly string _topicId;
        private readonly IHomieEntity? _parent;
        private readonly NameAttribute _nameAttribute;

        protected HomieEntityBase(string topicId, string name, IHomieEntity? parent = null) 
        {
            _topicId = topicId;
            _nameAttribute = new(name, this);
            _parent = parent;
        }

        public virtual IHomieEntity? Parent => _parent;
        public virtual string TopicId => _topicId;

        public virtual NameAttribute NameAttribute => _nameAttribute;

        public virtual string GetPayload() => string.Empty;

        public virtual string GetTopic()
        {
            if (Parent is null)
            {
                return TopicId;
            }

            return $"{Parent.GetTopic()}{Constants.TopicSeparator}{TopicId}";
        }
    }
}
