namespace BestTime.Library
{

    public class Serializer<t>
    {
        public string Serialize(t value)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(value, Newtonsoft.Json.Formatting.Indented);
        }
        public t DeSerialize(string value)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<t>(value);
        }
    }
}
