namespace Aogami.SMTV.GameData
{
    public class SMTVAlignment
    {
        private readonly SMTVAlignmentAttribute1 _attribute1;
        private readonly SMTVAlignmentAttribute2 _attribute2;

        public byte Attribute1 => (byte)_attribute1;
        public byte Attribute2 => (byte)_attribute2;

        public SMTVAlignment(byte attribute1, byte attribute2)
        {
            _attribute1 = (SMTVAlignmentAttribute1)attribute1;
            _attribute2 = (SMTVAlignmentAttribute2)attribute2;
        }
        
        public override string ToString()
        {
            return $"{_attribute1}-{_attribute2.ToString().ToLower()}";
        }
    }
}
