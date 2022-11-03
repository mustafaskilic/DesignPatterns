using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralLibrary
{

    public interface IJson
    {
        string Serialize(object obj);
    }

    public class NewtonSoftJson : IJson
    {
        public string Serialize(object obj)
        {
            return "Serialized";
        }
    }

    public class CustomJson {

        public int Serializer(object obj)
        {
            return (int)CustomJsonSerializeStatus.Serialized;
        }
    }

    public class CustomJsonAdapter : IJson
    {
        private CustomJson _customJson;

        public CustomJsonAdapter()
        {
            _customJson = new CustomJson();
        }

        public string Serialize(object obj)
        {
            if (_customJson.Serializer(obj) == (int)CustomJsonSerializeStatus.Serialized)
            {
                return obj.ToString() + " Serialized";
            }
            else return "Unserialized";
        }
    }

    public class JSonOperation
    {
        private IJson _json;

        public JSonOperation(IJson json)
        {
            _json = json;
        }

        public string Serialize(object obj)
        {
            return _json.Serialize(obj);
        }

    }

    public enum CustomJsonSerializeStatus
    {
        Unserialized = 0,
        Serialized = 1
    }

}
