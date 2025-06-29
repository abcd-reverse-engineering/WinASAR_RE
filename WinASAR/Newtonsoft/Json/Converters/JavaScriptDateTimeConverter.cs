using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x0200019A RID: 410
	[NullableContext(1)]
	[Nullable(0)]
	public class JavaScriptDateTimeConverter : DateTimeConverterBase
	{
		// Token: 0x06001208 RID: 4616 RVA: 0x0008F998 File Offset: 0x0008DB98
		public override void WriteJson(JsonWriter writer, [Nullable(2)] object value, JsonSerializer serializer)
		{
			long num2;
			for (;;)
			{
				if (!(value is DateTime))
				{
					goto IL_0092;
				}
				int num = 7;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 != 0)
				{
					goto IL_001D;
				}
				IL_0059:
				DateTime dateTime;
				switch (num)
				{
				default:
					IL_0092:
					if (!(value is DateTimeOffset))
					{
						goto IL_0112;
					}
					num = 7;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb == 0)
					{
						goto Block_1;
					}
					goto IL_0059;
				case 1:
					break;
				case 2:
					return;
				case 3:
					goto IL_00D6;
				case 4:
				case 12:
					goto IL_00E7;
				case 5:
					goto IL_0102;
				case 6:
					goto IL_010A;
				case 7:
					goto IL_00C5;
				case 8:
					goto IL_00CD;
				case 9:
					goto IL_0112;
				case 10:
					IL_001D:
					dateTime = (DateTime)value;
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 != 0)
					{
						goto IL_0059;
					}
					break;
				case 11:
					continue;
				}
				num2 = DateTimeUtils.ConvertDateTimeToJavaScriptTicks(dateTime.ToUniversalTime());
				num = 12;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a == 0)
				{
					goto IL_0059;
				}
				break;
			}
			Block_1:
			goto IL_00E7;
			IL_00C5:
			DateTimeOffset dateTimeOffset = (DateTimeOffset)value;
			IL_00CD:
			DateTimeOffset dateTimeOffset2 = dateTimeOffset.ToUniversalTime();
			IL_00D6:
			num2 = DateTimeUtils.ConvertDateTimeToJavaScriptTicks(dateTimeOffset2.UtcDateTime);
			IL_00E7:
			writer.WriteStartConstructor(Class15.smethod_17(1985297674 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba));
			IL_0102:
			writer.WriteValue(num2);
			IL_010A:
			writer.WriteEndConstructor();
			return;
			IL_0112:
			throw new JsonSerializationException(Class15.smethod_17(926385411 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296));
		}

		// Token: 0x06001209 RID: 4617 RVA: 0x0008FAD4 File Offset: 0x0008DCD4
		[return: Nullable(2)]
		public override object ReadJson(JsonReader reader, Type objectType, [Nullable(2)] object existingValue, JsonSerializer serializer)
		{
			DateTime dateTime;
			string text2;
			for (;;)
			{
				int num;
				if (reader.TokenType == JsonToken.Null)
				{
					num = 6;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 == 0)
					{
						goto IL_002C;
					}
				}
				else
				{
					if (reader.TokenType != JsonToken.StartConstructor)
					{
						goto IL_01B9;
					}
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 == 0)
					{
						goto IL_00E6;
					}
				}
				IL_010B:
				Type type;
				string text;
				switch (num)
				{
				case 1:
					goto IL_01B9;
				case 2:
					goto IL_0179;
				case 3:
					IL_0098:
					if (ReflectionUtils.IsNullableType(objectType))
					{
						type = Nullable.GetUnderlyingType(objectType);
						goto IL_00BB;
					}
					num = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e != 0)
					{
						goto IL_00B2;
					}
					goto IL_010B;
				case 4:
					goto IL_01F0;
				case 5:
				{
					IL_00E6:
					object value = reader.Value;
					if (value != null)
					{
						text = value.ToString();
						goto IL_0052;
					}
					num = 8;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 != 0)
					{
						goto IL_010B;
					}
					break;
				}
				case 6:
					goto IL_00B2;
				case 7:
					goto IL_0171;
				case 8:
					text = null;
					goto IL_0052;
				case 9:
					goto IL_0186;
				case 10:
					IL_002C:
					if (ReflectionUtils.IsNullable(objectType))
					{
						num = 4;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 == 0)
						{
							goto Block_4;
						}
						goto IL_010B;
					}
					break;
				case 11:
					continue;
				}
				goto Block_11;
				IL_0052:
				if (!string.Equals(text, Class15.smethod_17(676715040 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b), StringComparison.Ordinal))
				{
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 == 0)
					{
						goto Block_6;
					}
					goto IL_010B;
				}
				else
				{
					if (JavaScriptUtils.TryGetDateFromConstructorJson(reader, out dateTime, out text2))
					{
						goto IL_0098;
					}
					goto IL_0186;
				}
				IL_00BB:
				if (type == typeof(DateTimeOffset))
				{
					goto IL_0179;
				}
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c == 0)
				{
					goto Block_9;
				}
				goto IL_010B;
				IL_00B2:
				type = objectType;
				goto IL_00BB;
			}
			Block_4:
			goto IL_01F0;
			Block_6:
			goto IL_0192;
			Block_9:
			goto IL_0171;
			Block_11:
			goto IL_0192;
			IL_0171:
			return dateTime;
			IL_0179:
			return new DateTimeOffset(dateTime);
			IL_0186:
			throw JsonSerializationException.Create(reader, text2);
			IL_0192:
			throw JsonSerializationException.Create(reader, Class15.smethod_17(1176476398 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af).FormatWith(CultureInfo.InvariantCulture, objectType));
			IL_01B9:
			throw JsonSerializationException.Create(reader, Class15.smethod_17(89029670 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454).FormatWith(CultureInfo.InvariantCulture, reader.TokenType, reader.Value));
			IL_01F0:
			return null;
		}

		// Token: 0x0600120A RID: 4618 RVA: 0x0008FCD4 File Offset: 0x0008DED4
		public JavaScriptDateTimeConverter()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 == 0)
			{
				switch (num)
				{
				}
			}
		}
	}
}
