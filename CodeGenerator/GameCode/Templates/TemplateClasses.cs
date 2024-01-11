using CodeGenerator.Schema;

namespace CodeGenerator.GameCode.Templates
{
    public partial class ObjectTemplate
    {
        public ObjectTemplate(XmlClassItem objectData, DataSchema schema) { ObjectData = objectData; Schema = schema; }
        protected XmlClassItem ObjectData { get; }
        protected DataSchema Schema { get; }
    }

	public partial class StructTemplate
	{
		public StructTemplate(XmlClassItem objectData, DataSchema schema) { ObjectData = objectData; Schema = schema; }
		protected XmlClassItem ObjectData { get; }
		protected DataSchema Schema { get; }
	}
}
