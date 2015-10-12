﻿using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Nest.Resolvers;
using Elasticsearch.Net.Serialization;

namespace Nest
{
	internal class FeaturesJsonConverter : JsonConverter
	{
		public override bool CanConvert(Type objectType) => typeof(Features) == objectType;

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			var marker = value as Features;
			if (marker == null)
			{
				writer.WriteNull();
				return;
			}
			var contract = serializer.ContractResolver as SettingsContractResolver;
			if (contract == null || contract.ConnectionSettings == null)
				throw new Exception("If you use a custom contract resolver be sure to subclass from ElasticResolver");
			((IUrlParameter)marker).GetString(contract.ConnectionSettings);
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			if (reader.TokenType == JsonToken.String)
			{
				string indices = reader.Value.ToString();
				return (Features)indices;
			}
			return null;
		}

	}
}
