namespace HomieNano.Version4
{
    public abstract class HomieEntityBase : IHomieEntity
    {
        private readonly string _topicId;
        private readonly IHomieEntity? _parent;

        protected HomieEntityBase(string topicId, IHomieEntity? parent = null) 
        {
            _topicId = topicId;
            _parent = parent;
        }

        public virtual IHomieEntity? Parent => _parent;

        public virtual string TopicId => _topicId;

        public virtual string GetPayload() => string.Empty;

        public virtual string GetTopic()
        {
            if (Parent is null)
            {
                return $"{Constants.RootTopicIdentifier}{Constants.TopicSeparator}{TopicId}";
            }

            return $"{Parent.GetTopic()}{Constants.TopicSeparator}{TopicId}";
        }
    }
}
