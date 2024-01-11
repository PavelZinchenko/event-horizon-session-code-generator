namespace CodeGenerator.Utils
{
    public class Context
    {
        public Context(Schema.DataSchema schema)
        {
            Schema = schema;
        }

        public Schema.DataSchema Schema { get; }
    }
}
