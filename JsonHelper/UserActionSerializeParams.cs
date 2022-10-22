using Newtonsoft.Json.Converters;

namespace JsonHelper
{
    public class UserActionSerializeParams
    {
        public string ElementId { get; set; }

        [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
        public ESearchElementMethod SearchType { get; set; }

        public string TextValue { get; set; }

        [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
        public EUserAction UserActionType { get; set; }

    }
}
