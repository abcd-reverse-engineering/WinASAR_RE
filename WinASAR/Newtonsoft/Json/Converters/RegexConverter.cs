using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Bson;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x0200019C RID: 412
	[Nullable(0)]
	[NullableContext(1)]
	public class RegexConverter : JsonConverter
	{
		// Token: 0x06001216 RID: 4630 RVA: 0x00090354 File Offset: 0x0008E554
		public override void WriteJson(JsonWriter writer, [Nullable(2)] object value, JsonSerializer serializer)
		{
			IL_009B:
			while (value != null)
			{
				int num = 7;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 == 0)
				{
					goto IL_0034;
				}
				BsonWriter bsonWriter;
				Regex regex;
				for (;;)
				{
					IL_006F:
					switch (num)
					{
					case 1:
						goto IL_0034;
					case 2:
						return;
					case 3:
						goto IL_0054;
					case 4:
						return;
					case 5:
						return;
					case 6:
						if (bsonWriter != null)
						{
							goto IL_0054;
						}
						goto IL_00A6;
					case 7:
						regex = (Regex)value;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a != 0)
						{
							goto IL_0034;
						}
						continue;
					case 8:
						goto IL_009B;
					}
					break;
					IL_0054:
					this.method_1(bsonWriter, regex);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 != 0)
					{
						return;
					}
				}
				break;
				IL_00A6:
				this.method_2(writer, regex, serializer);
				return;
				IL_0034:
				bsonWriter = writer as BsonWriter;
				num = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f == 0)
				{
					break;
				}
				goto IL_006F;
			}
			writer.WriteNull();
		}

		// Token: 0x06001217 RID: 4631 RVA: 0x00004FC2 File Offset: 0x000031C2
		private bool method_0(RegexOptions regexOptions_0, RegexOptions regexOptions_1)
		{
			return (regexOptions_0 & regexOptions_1) == regexOptions_1;
		}

		// Token: 0x06001218 RID: 4632 RVA: 0x0009041C File Offset: 0x0008E61C
		private void method_1(BsonWriter bsonWriter_0, Regex regex_0)
		{
			string text;
			for (;;)
			{
				text = null;
				int num = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede != 0)
				{
					goto IL_003E;
				}
				IL_00D2:
				switch (num)
				{
				case 1:
					goto IL_007D;
				case 2:
					goto IL_00BC;
				case 3:
					goto IL_0170;
				case 4:
					goto IL_008C;
				case 5:
					goto IL_004D;
				case 6:
					IL_003E:
					if (this.method_0(regex_0.Options, RegexOptions.IgnoreCase))
					{
						goto IL_004D;
					}
					goto IL_007D;
				case 7:
					continue;
				case 8:
					goto IL_0143;
				case 9:
					goto IL_0152;
				case 10:
					goto IL_0006;
				case 11:
					return;
				}
				break;
				IL_0006:
				text += Class15.smethod_17(2008573889 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 == 0)
				{
					break;
				}
				goto IL_00D2;
				IL_00BC:
				if (this.method_0(regex_0.Options, RegexOptions.Singleline))
				{
					goto IL_0006;
				}
				break;
				IL_007D:
				if (this.method_0(regex_0.Options, RegexOptions.Multiline))
				{
					goto IL_008C;
				}
				goto IL_00BC;
				IL_004D:
				text += Class15.smethod_17(613130061 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 != 0)
				{
					goto IL_007D;
				}
				goto IL_00D2;
				IL_008C:
				text += Class15.smethod_17(89030414 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f == 0)
				{
					goto IL_00BC;
				}
				goto IL_00D2;
			}
			text += Class15.smethod_17(89030452 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454);
			IL_0143:
			if (!this.method_0(regex_0.Options, RegexOptions.ExplicitCapture))
			{
				goto IL_0170;
			}
			IL_0152:
			text += Class15.smethod_17(2008607773 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb);
			IL_0170:
			bsonWriter_0.WriteRegex(regex_0.ToString(), text);
		}

		// Token: 0x06001219 RID: 4633 RVA: 0x000905A8 File Offset: 0x0008E7A8
		private void method_2(JsonWriter jsonWriter_0, Regex regex_0, JsonSerializer jsonSerializer_0)
		{
			for (;;)
			{
				IL_010A:
				DefaultContractResolver defaultContractResolver = jsonSerializer_0.ContractResolver as DefaultContractResolver;
				for (;;)
				{
					IL_00FF:
					jsonWriter_0.WriteStartObject();
					for (;;)
					{
						IL_0006:
						jsonWriter_0.WritePropertyName((defaultContractResolver != null) ? defaultContractResolver.GetResolvedPropertyName(Class15.smethod_17(2021147540 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8)) : Class15.smethod_17(124784284 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719));
						for (;;)
						{
							IL_00CD:
							jsonWriter_0.WriteValue(regex_0.ToString());
							for (;;)
							{
								jsonWriter_0.WritePropertyName((defaultContractResolver != null) ? defaultContractResolver.GetResolvedPropertyName(Class15.smethod_17(1603850556 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c)) : Class15.smethod_17(635787041 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2));
								int num = 1;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a == 0)
								{
									goto IL_005E;
								}
								IL_0084:
								switch (num)
								{
								case 1:
									IL_005E:
									jsonSerializer_0.Serialize(jsonWriter_0, regex_0.Options);
									num = 0;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 == 0)
									{
										goto IL_0084;
									}
									break;
								case 2:
									continue;
								case 3:
									return;
								case 4:
									goto IL_0006;
								case 5:
									goto IL_00CD;
								case 6:
									goto IL_00FF;
								case 7:
									goto IL_010A;
								}
								goto Block_3;
							}
						}
					}
				}
			}
			Block_3:
			jsonWriter_0.WriteEndObject();
		}

		// Token: 0x0600121A RID: 4634 RVA: 0x000906D8 File Offset: 0x0008E8D8
		[return: Nullable(2)]
		public override object ReadJson(JsonReader reader, Type objectType, [Nullable(2)] object existingValue, JsonSerializer serializer)
		{
			for (;;)
			{
				JsonToken tokenType = reader.TokenType;
				int num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 == 0)
				{
					goto IL_003B;
				}
				goto IL_0043;
				IL_0032:
				while (tokenType != JsonToken.Null)
				{
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_253407eb812c4aefb734fa1e267fe779 == 0)
					{
						goto IL_0043;
					}
				}
				goto IL_00A5;
				IL_0043:
				switch (num)
				{
				case 1:
					goto IL_0032;
				case 2:
					goto IL_007F;
				case 3:
					IL_003B:
					if (tokenType != JsonToken.StartObject)
					{
						goto IL_0003;
					}
					break;
				case 4:
					continue;
				case 5:
					goto IL_0003;
				}
				break;
				IL_0003:
				if (tokenType == JsonToken.String)
				{
					goto IL_00A7;
				}
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 == 0)
				{
					goto IL_0032;
				}
				goto IL_0043;
			}
			goto IL_009B;
			IL_007F:
			throw JsonSerializationException.Create(reader, Class15.smethod_17(299895097 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e));
			IL_009B:
			return this.method_4(reader, serializer);
			IL_00A5:
			return null;
			IL_00A7:
			return this.method_3(reader);
		}

		// Token: 0x0600121B RID: 4635 RVA: 0x00090794 File Offset: 0x0008E994
		private object method_3(JsonReader jsonReader_0)
		{
			string text;
			int num2;
			for (;;)
			{
				text = (string)jsonReader_0.Value;
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9bd9937edf9d4ad8bd673dfcb5a5e3cb == 0)
				{
					goto IL_002C;
				}
				IL_0039:
				switch (num)
				{
				case 0:
					goto IL_002C;
				case 1:
					continue;
				case 2:
					goto IL_007E;
				case 3:
					goto IL_009F;
				case 4:
					break;
				case 5:
					goto IL_0003;
				case 6:
					goto IL_0083;
				default:
					goto IL_002C;
				}
				IL_000F:
				num2 = text.LastIndexOf('/');
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 == 0)
				{
					goto IL_002C;
				}
				goto IL_0039;
				IL_0003:
				if (text[0] == '/')
				{
					goto IL_000F;
				}
				break;
				IL_002C:
				if (text.Length <= 0)
				{
					break;
				}
				goto IL_0003;
			}
			goto IL_0083;
			IL_007E:
			if (num2 > 0)
			{
				goto IL_009F;
			}
			IL_0083:
			throw JsonSerializationException.Create(jsonReader_0, Class15.smethod_17(1396518712 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7));
			IL_009F:
			string text2 = text.Substring(1, num2 - 1);
			RegexOptions regexOptions = MiscellaneousUtils.GetRegexOptions(text.Substring(num2 + 1));
			return new Regex(text2, regexOptions);
		}

		// Token: 0x0600121C RID: 4636 RVA: 0x00090868 File Offset: 0x0008EA68
		private Regex method_4(JsonReader jsonReader_0, JsonSerializer jsonSerializer_0)
		{
			string text;
			RegexOptions? regexOptions;
			for (;;)
			{
				IL_01D8:
				text = null;
				for (;;)
				{
					IL_01B6:
					regexOptions = null;
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 == 0)
					{
						goto IL_0074;
					}
					string text2;
					for (;;)
					{
						IL_0146:
						switch (num)
						{
						case 0:
						case 19:
							goto IL_00B6;
						case 1:
						case 4:
						case 5:
						case 12:
						case 13:
							goto IL_0074;
						case 2:
						case 22:
							break;
						case 3:
							goto IL_0051;
						case 6:
							goto IL_01E1;
						case 7:
							goto IL_0235;
						case 8:
							goto IL_01B6;
						case 9:
							goto IL_01D8;
						case 10:
						case 21:
							goto IL_0032;
						case 11:
							goto IL_0122;
						case 14:
							goto IL_006B;
						case 15:
							goto IL_01DD;
						case 16:
							if (!jsonReader_0.Read())
							{
								goto IL_0219;
							}
							if (string.Equals(text2, Class15.smethod_17(649951104 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff), StringComparison.OrdinalIgnoreCase))
							{
								goto IL_0122;
							}
							break;
						case 17:
							goto IL_00D0;
						case 18:
							goto IL_000E;
						case 20:
							goto IL_01FD;
						case 23:
							goto IL_0006;
						case 24:
							goto IL_0219;
						default:
							goto IL_00B6;
						}
						if (string.Equals(text2, Class15.smethod_17(1396518874 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7), StringComparison.OrdinalIgnoreCase))
						{
							goto IL_00D0;
						}
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 != 0)
						{
							continue;
						}
						IL_00B6:
						jsonReader_0.Skip();
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 != 0)
						{
							goto Block_6;
						}
						continue;
						IL_00D0:
						regexOptions = new RegexOptions?(jsonSerializer_0.Deserialize<RegexOptions>(jsonReader_0));
						num = 12;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 != 0)
						{
							break;
						}
						continue;
						IL_0122:
						text = (string)jsonReader_0.Value;
						num = 6;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 != 0)
						{
							goto Block_9;
						}
					}
					continue;
					Block_6:
					Block_9:
					goto IL_0074;
					IL_000E:
					text2 = jsonReader_0.Value.ToString();
					num = 16;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f == 0)
					{
						goto IL_0074;
					}
					goto IL_0146;
					IL_0006:
					JsonToken tokenType;
					if (tokenType == JsonToken.PropertyName)
					{
						goto IL_000E;
					}
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 == 0)
					{
						goto IL_0051;
					}
					goto IL_0146;
					IL_0032:
					tokenType = jsonReader_0.TokenType;
					goto IL_0006;
					IL_0074:
					if (jsonReader_0.Read())
					{
						goto IL_0032;
					}
					goto IL_01FD;
					IL_0051:
					if (tokenType == JsonToken.Comment)
					{
						goto IL_0074;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 == 0)
					{
						goto IL_0146;
					}
					IL_006B:
					if (tokenType != JsonToken.EndObject)
					{
						goto IL_0074;
					}
					goto IL_01DD;
				}
			}
			IL_01DD:
			if (text != null)
			{
				goto IL_0235;
			}
			IL_01E1:
			throw JsonSerializationException.Create(jsonReader_0, Class15.smethod_17(277650312 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98));
			IL_01FD:
			throw JsonSerializationException.Create(jsonReader_0, Class15.smethod_17(926385927 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296));
			IL_0219:
			throw JsonSerializationException.Create(jsonReader_0, Class15.smethod_17(1270959672 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112));
			IL_0235:
			return new Regex(text, regexOptions.GetValueOrDefault());
		}

		// Token: 0x0600121D RID: 4637 RVA: 0x00090AB8 File Offset: 0x0008ECB8
		public override bool CanConvert(Type objectType)
		{
			while (!(objectType.Name == Class15.smethod_17(698947168 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a)))
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e != 0)
				{
					switch (num)
					{
					case 1:
						continue;
					case 2:
						goto IL_0050;
					}
				}
				return false;
			}
			IL_0050:
			return this.method_5(objectType);
		}

		// Token: 0x0600121E RID: 4638 RVA: 0x00006AC7 File Offset: 0x00004CC7
		private bool method_5(Type type_0)
		{
			return type_0 == typeof(Regex);
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x00090B1C File Offset: 0x0008ED1C
		public RegexConverter()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 != 0)
			{
				switch (num)
				{
				}
			}
		}
	}
}
