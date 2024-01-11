using CodeGenerator.Schema;
using System.Xml.Linq;

namespace CodeGenerator.GameCode
{
    public static class Utils
    {
        public static string SerializableClassName(string name) => name + "Serializable";
        public static string PropertyName(string name) => char.ToUpper(name[0]) + name.Substring(1);
        public static string ObjectGetterName(string name) => "Get" + name;
        public static string ObjectSetterName(string name) => "Add" + name;
        public static string ObjectListPropertyName(string name) => name + "List";
        public static string DelegateName(string name) => name + "Delegate";
		public static string LocalVariableName(string name) => char.ToLower(name[0]) + name.Substring(1);
		public static string PrivateMemberName(string name) => "_" + LocalVariableName(name);

		public const string FactoryMethodName = "Create";
        public const string DatabaseClassName = "Database";

        public const string ImageType = "IImageData";
        public const string AudioClipType = "IAudioClipData";
        public const string EmptyImage = "ImageData.Empty";
        public const string EmptyAudioClip = "AudioClipData.Empty";
        public const string VectorType = "UnityEngine.Vector2";

		public const string CallbackInterface = "IDataChangedCallback";
		public const string CallbackMethod = "OnDataChanged";

		public const string WriterInterface = "IWriterStream";
		public const string ReaderInterface = "IReaderStream";

		public const string ListType = "ObservableList";
		public const string MapType = "ObservableMap";
		public const string SetType = "ObservableSet";

		public const string RootNamespace = "GameSession";
		public const string ClassesNamespace = "Content";
		public const string UtilsNamespace = "Utils";
	}
}
