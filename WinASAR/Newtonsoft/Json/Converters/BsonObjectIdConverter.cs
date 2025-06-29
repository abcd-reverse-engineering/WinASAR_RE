using System;
using System.Globalization;
using Newtonsoft.Json.Bson;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x0200018D RID: 397
	[Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
	public class BsonObjectIdConverter : JsonConverter
	{
		// Token: 0x060011AA RID: 4522 RVA: 0x0008CAB0 File Offset: 0x0008ACB0
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			BsonObjectId bsonObjectId;
			for (;;)
			{
				IL_0069:
				bsonObjectId = (BsonObjectId)value;
				for (;;)
				{
					IL_005F:
					BsonWriter bsonWriter = writer as BsonWriter;
					for (;;)
					{
						if (bsonWriter != null)
						{
							goto IL_0003;
						}
						int num = 6;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 == 0)
						{
							continue;
						}
						IL_0022:
						switch (num)
						{
						case 1:
							IL_0003:
							bsonWriter.WriteObjectId(bsonObjectId.Value);
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b != 0)
							{
								goto IL_0022;
							}
							break;
						case 2:
							goto IL_005F;
						case 3:
							goto IL_0069;
						case 4:
							continue;
						case 5:
							return;
						case 6:
							goto IL_0073;
						}
						goto Block_1;
					}
				}
			}
			Block_1:
			return;
			IL_0073:
			writer.WriteValue(bsonObjectId.Value);
		}

		// Token: 0x060011AB RID: 4523 RVA: 0x0008CB40 File Offset: 0x0008AD40
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			while (reader.TokenType != JsonToken.Bytes)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa != 0)
				{
					switch (num)
					{
					case 1:
						continue;
					}
				}
				throw new JsonSerializationException(Class15.smethod_17(1743158422 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8).FormatWith(CultureInfo.InvariantCulture, reader.TokenType));
			}
			return new BsonObjectId((byte[])reader.Value);
		}

		// Token: 0x060011AC RID: 4524 RVA: 0x000069E8 File Offset: 0x00004BE8
		public override bool CanConvert(Type objectType)
		{
			return objectType == typeof(BsonObjectId);
		}

		// Token: 0x060011AD RID: 4525 RVA: 0x0008CBC0 File Offset: 0x0008ADC0
		public BsonObjectIdConverter()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a != 0)
			{
				switch (num)
				{
				}
			}
		}
	}
}
