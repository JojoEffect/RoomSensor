using HomieNano.Version4.Attributes;

namespace HomieNano.Version4
{
    public class Property : NamedHomieEntityBase
    {
        private readonly DataTypeAttribute _dataTypeAttribute;
        private readonly FormatAttribute _formatAttribute;
        private readonly SettableAttribute _settableAttribute;
        private readonly RetainedAttribute _retainedAttribute;
        private readonly UnitAttribute _unitAttribute;

        public Property(string topicId, string name, Node parent, DataType dataType, string format = "", bool settable = false, bool retained = true, string unit = "") 
            : base(topicId, name, parent)
        {
            _dataTypeAttribute = new(this, dataType);
            _formatAttribute = new(this, format);
            _settableAttribute = new(this, settable);
            _retainedAttribute = new(this, retained);
            _unitAttribute = new(this, unit);
        }

        public DataTypeAttribute DataTypeAttribute => _dataTypeAttribute;
        
        public FormatAttribute FormatAttribute => _formatAttribute;
        
        public SettableAttribute SettableAttribute => _settableAttribute;
        
        public RetainedAttribute RetainedAttribute => _retainedAttribute;
        
        public UnitAttribute Unit => _unitAttribute;
    }
}
