using Newtonsoft.Json;

namespace CSharpDay3
{
    public class JsonUtils<T>
    {
        public string toJson(T indices)
        {
            return JsonConvert.SerializeObject(indices);
        }
        
        public T toObj(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}