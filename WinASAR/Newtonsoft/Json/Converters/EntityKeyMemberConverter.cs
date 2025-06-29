using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000197 RID: 407
	[NullableContext(1)]
	[Nullable(0)]
	public class EntityKeyMemberConverter : JsonConverter
	{
		// Token: 0x060011E8 RID: 4584 RVA: 0x0008E8D4 File Offset: 0x0008CAD4
		public override void WriteJson(JsonWriter writer, [Nullable(2)] object value, JsonSerializer serializer)
		{
			IL_02B7:
			while (value != null)
			{
				for (;;)
				{
					IL_0292:
					EntityKeyMemberConverter.smethod_1(value.GetType());
					int num = 14;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 == 0)
					{
						goto IL_0130;
					}
					DefaultContractResolver defaultContractResolver;
					string text;
					for (;;)
					{
						IL_0223:
						switch (num)
						{
						case 1:
							goto IL_00C2;
						case 2:
							return;
						case 3:
							goto IL_0107;
						case 4:
						case 24:
							goto IL_0006;
						case 5:
							goto IL_0035;
						case 6:
						case 7:
						case 8:
							goto IL_02CC;
						case 9:
							goto IL_0070;
						case 10:
							return;
						case 11:
							goto IL_01DF;
						case 12:
							goto IL_02D3;
						case 13:
							goto IL_021D;
						case 14:
							defaultContractResolver = serializer.ContractResolver as DefaultContractResolver;
							goto IL_01DF;
						case 15:
							goto IL_005A;
						case 16:
							goto IL_01AB;
						case 17:
							goto IL_0292;
						case 18:
							goto IL_02B7;
						case 19:
							goto IL_00CA;
						case 20:
							goto IL_02C3;
						case 21:
							goto IL_018C;
						case 22:
							goto IL_006A;
						case 23:
							goto IL_0028;
						}
						break;
						IL_01DF:
						text = (string)EntityKeyMemberConverter.reflectionObject_0.GetValue(value, Class15.smethod_17(432124933 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2));
						num = 16;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 == 0)
						{
							goto Block_10;
						}
					}
					goto IL_0130;
					IL_021D:
					Type type = null;
					goto IL_0068;
					IL_01AB:
					object value2 = EntityKeyMemberConverter.reflectionObject_0.GetValue(value, Class15.smethod_17(1176453774 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af));
					goto IL_005A;
					IL_0006:
					writer.WriteValue(value2);
					num = 8;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 != 0)
					{
						break;
					}
					goto IL_0223;
					IL_0035:
					Type type2;
					string text2;
					if (JsonSerializerInternalWriter.TryConvertToString(value2, type2, out text2))
					{
						goto IL_018C;
					}
					num = 24;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 != 0)
					{
						goto IL_005A;
					}
					goto IL_0223;
					IL_0028:
					if (type2 != null)
					{
						goto IL_0035;
					}
					goto IL_02C3;
					IL_0130:
					writer.WritePropertyName((defaultContractResolver == null) ? Class15.smethod_17(974447947 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f) : defaultContractResolver.GetResolvedPropertyName(Class15.smethod_17(1788629898 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1)));
					goto IL_0028;
					IL_0070:
					writer.WritePropertyName((defaultContractResolver == null) ? Class15.smethod_17(1760312143 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039) : defaultContractResolver.GetResolvedPropertyName(Class15.smethod_17(299953015 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e)));
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 == 0)
					{
						goto IL_00C2;
					}
					goto IL_0223;
					IL_006A:
					writer.WriteStartObject();
					goto IL_0070;
					IL_0068:
					type2 = type;
					goto IL_006A;
					IL_005A:
					if (value2 != null)
					{
						type = value2.GetType();
						goto IL_0068;
					}
					num = 13;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 != 0)
					{
						goto IL_0006;
					}
					goto IL_0223;
					IL_0107:
					writer.WriteValue((type2 != null) ? type2.FullName : null);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 == 0)
					{
						goto IL_0130;
					}
					goto IL_0223;
					IL_00CA:
					writer.WritePropertyName((defaultContractResolver != null) ? defaultContractResolver.GetResolvedPropertyName(Class15.smethod_17(2048529965 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18)) : Class15.smethod_17(649967108 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff));
					goto IL_0107;
					IL_00C2:
					writer.WriteValue(text);
					goto IL_00CA;
					IL_018C:
					writer.WriteValue(text2);
					num = 6;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 != 0)
					{
						break;
					}
					goto IL_0223;
				}
				Block_10:
				goto IL_02CC;
				IL_02C3:
				writer.WriteNull();
				IL_02CC:
				writer.WriteEndObject();
				return;
			}
			IL_02D3:
			writer.WriteNull();
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x0008EBBC File Offset: 0x0008CDBC
		private static void smethod_0(JsonReader jsonReader_0, string string_0)
		{
			for (;;)
			{
				IL_0070:
				jsonReader_0.ReadAndAssert();
				int num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 == 0)
				{
					goto IL_0024;
				}
				for (;;)
				{
					IL_0054:
					string text;
					switch (num)
					{
					case 1:
					{
						object value = jsonReader_0.Value;
						if (value != null)
						{
							text = value.ToString();
							goto IL_0004;
						}
						goto IL_0003;
					}
					case 2:
						goto IL_0024;
					case 3:
						goto IL_0070;
					case 4:
						goto IL_0003;
					}
					goto Block_6;
					IL_0004:
					if (string.Equals(text, string_0, StringComparison.OrdinalIgnoreCase))
					{
						return;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 == 0)
					{
						goto Block_2;
					}
					continue;
					IL_0003:
					text = null;
					goto IL_0004;
				}
				IL_0024:
				if (jsonReader_0.TokenType != JsonToken.PropertyName)
				{
					break;
				}
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 != 0)
				{
					break;
				}
				goto IL_0054;
			}
			Block_2:
			Block_6:
			throw new JsonSerializationException(Class15.smethod_17(768757920 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7).FormatWith(CultureInfo.InvariantCulture, string_0));
		}

		// Token: 0x060011EA RID: 4586 RVA: 0x0008EC80 File Offset: 0x0008CE80
		[return: Nullable(2)]
		public override object ReadJson(JsonReader reader, Type objectType, [Nullable(2)] object existingValue, JsonSerializer serializer)
		{
			object obj;
			for (;;)
			{
				IL_01B4:
				EntityKeyMemberConverter.smethod_1(objectType);
				int num = 9;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 != 0)
				{
					goto IL_00A0;
				}
				for (;;)
				{
					IL_0171:
					switch (num)
					{
					case 0:
						goto IL_0098;
					case 1:
						goto IL_01D1;
					case 2:
						goto IL_0058;
					case 3:
						goto IL_0154;
					case 4:
						return obj;
					case 5:
					{
						ReflectionObject reflectionObject = EntityKeyMemberConverter.reflectionObject_0;
						object obj2 = obj;
						string text = Class15.smethod_17(1760312143 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039);
						object value = reader.Value;
						reflectionObject.SetValue(obj2, text, (value != null) ? value.ToString() : null);
						goto IL_0154;
					}
					case 6:
						goto IL_00FA;
					case 7:
						goto IL_00B7;
					case 8:
						goto IL_0107;
					case 9:
						goto IL_00D7;
					case 10:
						goto IL_00A0;
					case 11:
						goto IL_01B4;
					case 12:
						IL_0026:
						EntityKeyMemberConverter.smethod_0(reader, Class15.smethod_17(974447947 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f));
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 != 0)
						{
							goto IL_0098;
						}
						continue;
					case 13:
						goto IL_0006;
					default:
						goto IL_0098;
					}
					IL_00FB:
					string text2;
					Type type = Type.GetType(text2);
					goto IL_0026;
					IL_00D7:
					object value2 = reader.Value;
					if (value2 != null)
					{
						text2 = value2.ToString();
						goto IL_00FB;
					}
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9bd9937edf9d4ad8bd673dfcb5a5e3cb == 0)
					{
						goto IL_00FA;
					}
					continue;
					IL_0058:
					EntityKeyMemberConverter.reflectionObject_0.SetValue(obj, Class15.smethod_17(1176453774 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af), serializer.Deserialize(reader, type));
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 != 0)
					{
						continue;
					}
					IL_0098:
					reader.ReadAndAssert();
					goto IL_0058;
					IL_0107:
					reader.ReadAndAssert();
					num = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 == 0)
					{
						goto IL_00D7;
					}
					continue;
					IL_0154:
					EntityKeyMemberConverter.smethod_0(reader, Class15.smethod_17(2008558979 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb));
					goto IL_0107;
					IL_00FA:
					text2 = null;
					goto IL_00FB;
				}
				IL_0006:
				reader.ReadAndAssert();
				num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba == 0)
				{
					break;
				}
				goto IL_0171;
				IL_00B7:
				EntityKeyMemberConverter.smethod_0(reader, Class15.smethod_17(2071396918 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808));
				goto IL_0006;
				IL_00A0:
				obj = EntityKeyMemberConverter.reflectionObject_0.Creator(new object[0]);
				goto IL_00B7;
			}
			return obj;
			IL_01D1:
			reader.ReadAndAssert();
			return obj;
		}

		// Token: 0x060011EB RID: 4587 RVA: 0x0008EE6C File Offset: 0x0008D06C
		private static void smethod_1(Type type_0)
		{
			for (;;)
			{
				if (EntityKeyMemberConverter.reflectionObject_0 == null)
				{
					goto IL_0003;
				}
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 != 0)
				{
					goto IL_0003;
				}
				IL_0055:
				switch (num)
				{
				case 1:
				case 3:
					return;
				case 2:
					continue;
				}
				IL_0003:
				EntityKeyMemberConverter.reflectionObject_0 = ReflectionObject.Create(type_0, new string[]
				{
					Class15.smethod_17(89038090 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454),
					Class15.smethod_17(594365674 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b)
				});
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 != 0)
				{
					goto IL_0055;
				}
				break;
			}
		}

		// Token: 0x060011EC RID: 4588 RVA: 0x00006A86 File Offset: 0x00004C86
		public override bool CanConvert(Type objectType)
		{
			return objectType.AssignableToTypeName(Class15.smethod_17(1571007911 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406), false);
		}

		// Token: 0x060011ED RID: 4589 RVA: 0x0008EF08 File Offset: 0x0008D108
		public EntityKeyMemberConverter()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 == 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x04000804 RID: 2052
		[Nullable(2)]
		private static ReflectionObject reflectionObject_0;
	}
}
