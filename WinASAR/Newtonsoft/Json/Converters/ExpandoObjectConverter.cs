using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000198 RID: 408
	[NullableContext(1)]
	[Nullable(0)]
	public class ExpandoObjectConverter : JsonConverter
	{
		// Token: 0x060011F1 RID: 4593 RVA: 0x00002420 File Offset: 0x00000620
		public override void WriteJson(JsonWriter writer, [Nullable(2)] object value, JsonSerializer serializer)
		{
		}

		// Token: 0x060011F2 RID: 4594 RVA: 0x00006AA4 File Offset: 0x00004CA4
		[return: Nullable(2)]
		public override object ReadJson(JsonReader reader, Type objectType, [Nullable(2)] object existingValue, JsonSerializer serializer)
		{
			return this.method_0(reader);
		}

		// Token: 0x060011F3 RID: 4595 RVA: 0x0008EF3C File Offset: 0x0008D13C
		[return: Nullable(2)]
		private object method_0(JsonReader jsonReader_0)
		{
			IL_0061:
			while (jsonReader_0.MoveToContent())
			{
				JsonToken tokenType = jsonReader_0.TokenType;
				while (tokenType != JsonToken.StartObject)
				{
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c != 0)
					{
						goto IL_001F;
					}
					IL_0035:
					switch (num)
					{
					case 0:
						goto IL_00D8;
					case 1:
						IL_001F:
						if (tokenType == JsonToken.StartArray)
						{
							return this.method_1(jsonReader_0);
						}
						num = 6;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a != 0)
						{
							goto IL_0035;
						}
						break;
					case 2:
						goto IL_00A0;
					case 3:
						continue;
					case 4:
						goto IL_0077;
					case 5:
						goto IL_0061;
					case 6:
						break;
					default:
						goto IL_00D8;
					}
					if (!JsonTokenUtils.IsPrimitiveToken(jsonReader_0.TokenType))
					{
						throw JsonSerializationException.Create(jsonReader_0, Class15.smethod_17(564880638 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610).FormatWith(CultureInfo.InvariantCulture, jsonReader_0.TokenType));
					}
					IL_00A0:
					return jsonReader_0.Value;
				}
				goto IL_00D8;
				IL_0077:
				throw JsonSerializationException.Create(jsonReader_0, Class15.smethod_17(1793913850 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a));
				IL_00D8:
				return this.method_2(jsonReader_0);
			}
			goto IL_0077;
		}

		// Token: 0x060011F4 RID: 4596 RVA: 0x0008F028 File Offset: 0x0008D228
		private object method_1(JsonReader jsonReader_0)
		{
			for (;;)
			{
				IL_00AE:
				IList<object> list = new List<object>();
				while (jsonReader_0.Read())
				{
					int num = 9;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 != 0)
					{
						goto IL_0063;
					}
					goto IL_006B;
					IL_003E:
					object obj;
					list.Add(obj);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 == 0)
					{
						continue;
					}
					goto IL_006B;
					IL_0023:
					obj = this.method_0(jsonReader_0);
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c == 0)
					{
						goto IL_003E;
					}
					goto IL_006B;
					IL_001A:
					JsonToken tokenType;
					if (tokenType != JsonToken.EndArray)
					{
						goto IL_0023;
					}
					return list;
					IL_0063:
					if (tokenType != JsonToken.Comment)
					{
						goto IL_001A;
					}
					continue;
					IL_006B:
					switch (num)
					{
					case 1:
						goto IL_003E;
					case 2:
						return list;
					case 3:
					case 9:
						tokenType = jsonReader_0.TokenType;
						goto IL_0063;
					case 4:
						goto IL_0023;
					case 5:
						goto IL_0063;
					case 7:
						goto IL_00AE;
					case 8:
						goto IL_00B7;
					case 10:
						goto IL_001A;
					}
				}
				break;
			}
			IL_00B7:
			throw JsonSerializationException.Create(jsonReader_0, Class15.smethod_17(89029130 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454));
		}

		// Token: 0x060011F5 RID: 4597 RVA: 0x0008F10C File Offset: 0x0008D30C
		private object method_2(JsonReader jsonReader_0)
		{
			IDictionary<string, object> dictionary;
			for (;;)
			{
				IL_0126:
				dictionary = new ExpandoObject();
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb != 0)
				{
					goto IL_00DE;
				}
				JsonToken tokenType;
				do
				{
					IL_00C2:
					tokenType = jsonReader_0.TokenType;
					num = 8;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede != 0);
				for (;;)
				{
					IL_00DE:
					switch (num)
					{
					case 1:
					case 10:
					case 15:
						goto IL_0006;
					case 2:
						goto IL_0126;
					case 3:
						goto IL_0026;
					case 4:
						goto IL_0160;
					case 5:
						goto IL_008B;
					case 7:
						return dictionary;
					case 8:
						while (tokenType != JsonToken.PropertyName)
						{
							num = 11;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 != 0)
							{
								goto IL_00DE;
							}
						}
						goto IL_0062;
					case 9:
						goto IL_0141;
					case 11:
						if (tokenType != JsonToken.Comment)
						{
							goto IL_008B;
						}
						goto IL_0006;
					case 12:
						goto IL_002F;
					case 13:
						goto IL_0062;
					case 14:
						goto IL_0054;
					}
					break;
					IL_0006:
					if (!jsonReader_0.Read())
					{
						goto IL_0160;
					}
					num = 6;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a != 0)
					{
						goto IL_0026;
					}
					continue;
					IL_002F:
					string text;
					object obj;
					dictionary[text] = obj;
					num = 10;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 == 0)
					{
						goto Block_2;
					}
					continue;
					IL_0026:
					obj = this.method_0(jsonReader_0);
					goto IL_002F;
					IL_0054:
					if (jsonReader_0.Read())
					{
						goto IL_0026;
					}
					goto IL_0141;
					IL_0062:
					text = jsonReader_0.Value.ToString();
					num = 8;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 == 0)
					{
						goto IL_0054;
					}
					continue;
					IL_008B:
					if (tokenType == JsonToken.EndObject)
					{
						return dictionary;
					}
					num = 15;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 == 0)
					{
						goto IL_0062;
					}
				}
				goto IL_00C2;
			}
			Block_2:
			return dictionary;
			IL_0141:
			throw JsonSerializationException.Create(jsonReader_0, Class15.smethod_17(1678073350 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a));
			IL_0160:
			throw JsonSerializationException.Create(jsonReader_0, Class15.smethod_17(2048578179 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18));
		}

		// Token: 0x060011F6 RID: 4598 RVA: 0x00006AAD File Offset: 0x00004CAD
		public override bool CanConvert(Type objectType)
		{
			return objectType == typeof(ExpandoObject);
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x060011F7 RID: 4599 RVA: 0x00003453 File Offset: 0x00001653
		public override bool CanWrite
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060011F8 RID: 4600 RVA: 0x0008F298 File Offset: 0x0008D498
		public ExpandoObjectConverter()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e == 0)
			{
				switch (num)
				{
				}
			}
		}
	}
}
