using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Voodoo.Live.Offers
{
	public abstract class JsonCreationConverter<T> : JsonConverter
	{
		public override bool CanWrite => false;

		protected virtual T Create(Type objectType, JObject jObject)
		{
			return default(T);
		}

		public abstract T GetTargetInstance(string type);

		public override bool CanConvert(Type objectType)
		{
			return false;
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}
	}
}
