using System;
using CodeGenerator.GameCode.Templates;
using CodeGenerator.Schema;
using CodeGenerator.Utils;

namespace CodeGenerator.GameCode
{
    public class Builder
    {
        public Builder(DataSchema schema, CodeWriter codeWriter)
        {
            _schema = schema;
            _codeWriter = codeWriter;
        }

        public void Build()
        {
            _codeWriter.DeleteGeneratedFiles();

            GenerateTypes();

			//foreach (var item in _schema.Enums)
			//    GenerateEnum(item);

			//foreach (var item in _schema.Expressions)
			//    GenerateExpression(item);

			foreach (var item in _schema.Objects)
			{
				GenerateDataClass(item);
			}

			foreach (var item in _schema.Structs)
			{
				GenerateStruct(item);
			}

			//foreach (var item in _schema.Structs)
			//{
			//    GenerateSerializableClass(item, ObjectType.Struct);
			//    GenerateDataClass(item, ObjectType.Struct);
			//}

			//foreach (var item in _schema.Configurations)
			//{
			//    GenerateSerializableClass(item, ObjectType.Configuration);
			//    GenerateDataClass(item, ObjectType.Configuration);
			//}
		}

		private void GenerateTypes()
        {
            //_codeWriter.Write(Utils.SerializableNamespace, "SerializableItem", new SerializableItemTemplate().TransformText());
        }

        private void GenerateDataClass(XmlClassItem item)
        {
            string data = new ObjectTemplate(item, _schema).TransformText();

			_codeWriter.Write(Utils.ClassesNamespace, item.name, data);
		}

		private void GenerateStruct(XmlClassItem item)
		{
			string data = new StructTemplate(item, _schema).TransformText();

			_codeWriter.Write(Utils.ClassesNamespace, item.name, data);
		}

		private readonly CodeWriter _codeWriter;
        private readonly DataSchema _schema;
    }

    public static class StringExtensions
    {
        public static bool ContainsKey(this string source, string key)
        {
            var position = -1;
            while (true)
            {
                position = source.IndexOf(key, position + 1, StringComparison.OrdinalIgnoreCase);
                if (position < 0) return false;
                if (position > 0 && !char.IsLetterOrDigit(key[position])) continue;
                if (position + key.Length < source.Length && !char.IsLetterOrDigit(key[position + key.Length])) continue;
                return true;
            }
        }
    }
}
