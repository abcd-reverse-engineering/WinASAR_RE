using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x0200019E RID: 414
	[Nullable(0)]
	[NullableContext(1)]
	public class UnixDateTimeConverter : DateTimeConverterBase
	{
		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06001235 RID: 4661 RVA: 0x00006AE9 File Offset: 0x00004CE9
		// (set) Token: 0x06001236 RID: 4662 RVA: 0x0009135C File Offset: 0x0008F55C
		public bool AllowPreEpoch
		{
			[CompilerGenerated]
			get
			{
				return this.bool_0;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.bool_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 != 0)
					{
						switch (num)
						{
						case 1:
							continue;
						}
						break;
					}
					break;
				}
			}
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x00091394 File Offset: 0x0008F594
		public UnixDateTimeConverter()
			: this(false)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x000913C8 File Offset: 0x0008F5C8
		public UnixDateTimeConverter(bool allowPreEpoch)
		{
			int num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 == 0)
			{
				goto IL_0032;
			}
			IL_001A:
			this.AllowPreEpoch = allowPreEpoch;
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 == 0)
			{
				return;
			}
			IL_0032:
			switch (num)
			{
			case 1:
				goto IL_001A;
			}
		}

		// Token: 0x06001239 RID: 4665 RVA: 0x00091418 File Offset: 0x0008F618
		public override void WriteJson(JsonWriter writer, [Nullable(2)] object value, JsonSerializer serializer)
		{
			long num2;
			for (;;)
			{
				if (!(value is DateTime))
				{
					goto IL_007B;
				}
				goto IL_00EB;
				IL_00A2:
				int num;
				DateTime dateTime;
				switch (num)
				{
				default:
					IL_00EB:
					dateTime = (DateTime)value;
					num = 11;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 == 0)
					{
						goto IL_00A2;
					}
					break;
				case 1:
				case 10:
					IL_007B:
					if (value is DateTimeOffset)
					{
						goto IL_0086;
					}
					goto IL_0118;
				case 2:
					goto IL_0086;
				case 3:
				case 4:
					goto IL_0035;
				case 5:
					goto IL_006F;
				case 6:
					goto IL_015E;
				case 7:
					goto IL_0143;
				case 8:
					return;
				case 9:
					goto IL_002B;
				case 11:
					continue;
				case 12:
					goto IL_0136;
				case 13:
				case 15:
					goto IL_0118;
				case 14:
					goto IL_0057;
				case 16:
					break;
				}
				TimeSpan timeSpan = dateTime.ToUniversalTime() - UnixDateTimeConverter.UnixEpoch;
				num = 9;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6 != 0)
				{
					goto IL_002B;
				}
				goto IL_00A2;
				IL_0035:
				if (!this.AllowPreEpoch)
				{
					goto IL_0136;
				}
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c != 0)
				{
					break;
				}
				goto IL_00A2;
				IL_006F:
				num2 = (long)timeSpan.TotalSeconds;
				goto IL_0035;
				IL_0057:
				DateTimeOffset dateTimeOffset;
				timeSpan = dateTimeOffset.ToUniversalTime() - UnixDateTimeConverter.UnixEpoch;
				goto IL_006F;
				IL_002B:
				num2 = (long)timeSpan.TotalSeconds;
				goto IL_0035;
				IL_0086:
				dateTimeOffset = (DateTimeOffset)value;
				num = 13;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 != 0)
				{
					goto IL_0057;
				}
				goto IL_00A2;
			}
			goto IL_015E;
			IL_0118:
			throw new JsonSerializationException(Class15.smethod_17(1760353193 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039));
			IL_0136:
			if (num2 >= 0L)
			{
				goto IL_015E;
			}
			IL_0143:
			throw new JsonSerializationException(Class15.smethod_17(197533127 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81));
			IL_015E:
			writer.WriteValue(num2);
		}

		// Token: 0x0600123A RID: 4666 RVA: 0x0009158C File Offset: 0x0008F78C
		[return: Nullable(2)]
		public override object ReadJson(JsonReader reader, Type objectType, [Nullable(2)] object existingValue, JsonSerializer serializer)
		{
			bool flag;
			DateTime dateTime;
			for (;;)
			{
				IL_015E:
				flag = ReflectionUtils.IsNullable(objectType);
				int num = 8;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c != 0)
				{
					goto IL_0074;
				}
				for (;;)
				{
					IL_010F:
					switch (num)
					{
					case 0:
						goto IL_0033;
					case 1:
						goto IL_0074;
					case 2:
						goto IL_00F2;
					case 3:
						break;
					case 4:
						goto IL_0203;
					case 5:
						goto IL_00C1;
					case 6:
						goto IL_00D3;
					case 7:
						goto IL_017D;
					case 8:
						if (reader.TokenType == JsonToken.Null)
						{
							goto Block_5;
						}
						if (reader.TokenType == JsonToken.Integer)
						{
							goto IL_00C1;
						}
						goto IL_00D3;
					case 9:
						goto IL_015E;
					case 10:
						goto IL_003A;
					case 11:
					case 15:
						goto IL_0006;
					case 12:
						goto IL_01B4;
					case 13:
						goto IL_0232;
					case 14:
						goto IL_005B;
					case 16:
						goto IL_020B;
					default:
						goto IL_0033;
					}
					IL_000E:
					long num2;
					if (num2 < 0L)
					{
						goto IL_01DB;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af == 0)
					{
						goto IL_0033;
					}
					continue;
					IL_0006:
					if (!this.AllowPreEpoch)
					{
						goto IL_000E;
					}
					goto IL_0033;
					IL_00C1:
					num2 = (long)reader.Value;
					goto IL_0006;
					IL_003A:
					DateTime unixEpoch;
					dateTime = unixEpoch.AddSeconds((double)num2);
					num = 11;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 != 0)
					{
						goto IL_005B;
					}
					continue;
					IL_0033:
					unixEpoch = UnixDateTimeConverter.UnixEpoch;
					goto IL_003A;
					IL_005B:
					if (flag)
					{
						break;
					}
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 == 0)
					{
						goto IL_0074;
					}
					continue;
					IL_00D3:
					if (reader.TokenType != JsonToken.String)
					{
						goto IL_0183;
					}
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 != 0)
					{
						continue;
					}
					IL_00F2:
					if (long.TryParse((string)reader.Value, out num2))
					{
						goto IL_0006;
					}
					goto IL_020B;
				}
				Type type = Nullable.GetUnderlyingType(objectType);
				IL_007D:
				if (type == typeof(DateTimeOffset))
				{
					goto IL_0232;
				}
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 == 0)
				{
					break;
				}
				goto IL_010F;
				IL_0074:
				type = objectType;
				goto IL_007D;
			}
			goto IL_0203;
			Block_5:
			IL_017D:
			if (flag)
			{
				return null;
			}
			goto IL_01B4;
			IL_0183:
			throw JsonSerializationException.Create(reader, Class15.smethod_17(124781002 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719).FormatWith(CultureInfo.InvariantCulture, reader.TokenType));
			IL_01B4:
			throw JsonSerializationException.Create(reader, Class15.smethod_17(197536233 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81).FormatWith(CultureInfo.InvariantCulture, objectType));
			IL_01DB:
			throw JsonSerializationException.Create(reader, Class15.smethod_17(1788657246 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1).FormatWith(CultureInfo.InvariantCulture, objectType));
			IL_0203:
			return dateTime;
			IL_020B:
			throw JsonSerializationException.Create(reader, Class15.smethod_17(635787385 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2).FormatWith(CultureInfo.InvariantCulture, objectType));
			IL_0232:
			return new DateTimeOffset(dateTime, TimeSpan.Zero);
		}

		// Token: 0x0600123B RID: 4667 RVA: 0x000917DC File Offset: 0x0008F9DC
		static UnixDateTimeConverter()
		{
			for (;;)
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 != 0)
				{
					goto IL_0003;
				}
				IL_0015:
				switch (num)
				{
				case 1:
					IL_0003:
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b == 0)
					{
						goto IL_0015;
					}
					break;
				case 2:
					continue;
				case 3:
					return;
				}
				break;
			}
			UnixDateTimeConverter.UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
		}

		// Token: 0x04000812 RID: 2066
		internal static readonly DateTime UnixEpoch;

		// Token: 0x04000813 RID: 2067
		[CompilerGenerated]
		private bool bool_0;
	}
}
