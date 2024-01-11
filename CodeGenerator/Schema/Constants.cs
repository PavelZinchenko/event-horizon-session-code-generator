namespace CodeGenerator.Schema
{
    public static class Constants
    {
		public const string TypeInt = "int";
		public const string TypeLong = "long";
		public const string TypeShort = "short";
		public const string TypeByte = "byte";
		public const string TypeSbyte = "sbyte";
		public const string TypeFloat = "single";
        public const string TypeBool = "bool";
        public const string TypeEnum = "enum";
        public const string TypeString = "string";
        public const string TypeObject = "object";
		public const string TypeStruct = "struct";
		public const string TypeSet = "set";
		public const string TypeMap = "map";
		public const string TypeList = "list";

		public const string OptionEncrypted = "encrypted";

        public static readonly char[] ValueSeparators = { ',','|',';',' ','\n','\r' };
    }
}
