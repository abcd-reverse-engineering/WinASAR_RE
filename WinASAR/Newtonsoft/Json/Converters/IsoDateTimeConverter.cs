using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x02000199 RID: 409
	[Nullable(0)]
	[NullableContext(1)]
	public class IsoDateTimeConverter : DateTimeConverterBase
	{
		// Token: 0x1700027E RID: 638
		// (get) Token: 0x060011FC RID: 4604 RVA: 0x00006ABF File Offset: 0x00004CBF
		// (set) Token: 0x060011FD RID: 4605 RVA: 0x0008F2CC File Offset: 0x0008D4CC
		public DateTimeStyles DateTimeStyles
		{
			get
			{
				return this.dateTimeStyles_0;
			}
			set
			{
				for (;;)
				{
					this.dateTimeStyles_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 != 0)
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

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x060011FE RID: 4606 RVA: 0x0008F304 File Offset: 0x0008D504
		// (set) Token: 0x060011FF RID: 4607 RVA: 0x0008F344 File Offset: 0x0008D544
		[Nullable(2)]
		public string DateTimeFormat
		{
			[NullableContext(2)]
			get
			{
				string empty;
				while ((empty = this.string_0) == null)
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 != 0)
					{
						switch (num)
						{
						case 1:
							continue;
						}
					}
					empty = string.Empty;
					break;
				}
				return empty;
			}
			[NullableContext(2)]
			set
			{
				for (;;)
				{
					this.string_0 = ((!StringUtils.IsNullOrEmpty(value)) ? value : null);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a != 0)
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

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06001200 RID: 4608 RVA: 0x0008F388 File Offset: 0x0008D588
		// (set) Token: 0x06001201 RID: 4609 RVA: 0x0008F3C8 File Offset: 0x0008D5C8
		public CultureInfo Culture
		{
			get
			{
				CultureInfo currentCulture;
				while ((currentCulture = this.cultureInfo_0) == null)
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 != 0)
					{
						switch (num)
						{
						case 1:
							continue;
						}
					}
					currentCulture = CultureInfo.CurrentCulture;
					break;
				}
				return currentCulture;
			}
			set
			{
				for (;;)
				{
					this.cultureInfo_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 != 0)
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

		// Token: 0x06001202 RID: 4610 RVA: 0x0008F400 File Offset: 0x0008D600
		public override void WriteJson(JsonWriter writer, [Nullable(2)] object value, JsonSerializer serializer)
		{
			for (;;)
			{
				if (!(value is DateTime))
				{
					goto IL_0006;
				}
				goto IL_0198;
				IL_0148:
				int num;
				DateTime dateTime;
				switch (num)
				{
				case 1:
					goto IL_0127;
				case 2:
					goto IL_0107;
				case 3:
					goto IL_0030;
				case 4:
				case 16:
					IL_0006:
					if (value is DateTimeOffset)
					{
						goto IL_0028;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 == 0)
					{
						goto IL_0148;
					}
					break;
				case 5:
					continue;
				case 6:
					goto IL_0028;
				case 7:
					goto IL_003D;
				case 8:
					goto IL_0068;
				case 9:
					goto IL_005F;
				case 10:
				case 11:
					goto IL_0096;
				case 12:
					IL_0198:
					dateTime = (DateTime)value;
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 == 0)
					{
						goto IL_0127;
					}
					goto IL_0148;
				case 13:
					goto IL_00FA;
				case 15:
					goto IL_00B8;
				case 17:
					return;
				}
				break;
				IL_003D:
				if ((this.dateTimeStyles_0 & DateTimeStyles.AssumeUniversal) != DateTimeStyles.AssumeUniversal)
				{
					goto IL_0068;
				}
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 == 0)
				{
					goto IL_005F;
				}
				goto IL_0148;
				IL_0030:
				if ((this.dateTimeStyles_0 & DateTimeStyles.AdjustToUniversal) != DateTimeStyles.AdjustToUniversal)
				{
					goto IL_003D;
				}
				goto IL_005F;
				IL_0028:
				DateTimeOffset dateTimeOffset = (DateTimeOffset)value;
				goto IL_0030;
				IL_0096:
				string text;
				writer.WriteValue(text);
				num = 7;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 == 0)
				{
					goto Block_5;
				}
				goto IL_0148;
				IL_0068:
				text = dateTimeOffset.ToString(this.string_0 ?? Class15.smethod_17(543247582 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89), this.Culture);
				goto IL_0096;
				IL_005F:
				dateTimeOffset = dateTimeOffset.ToUniversalTime();
				goto IL_0068;
				IL_00B8:
				text = dateTime.ToString(this.string_0 ?? Class15.smethod_17(2048524391 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18), this.Culture);
				num = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e == 0)
				{
					goto IL_0096;
				}
				goto IL_0148;
				IL_00FA:
				if ((this.dateTimeStyles_0 & DateTimeStyles.AssumeUniversal) != DateTimeStyles.AssumeUniversal)
				{
					goto IL_00B8;
				}
				IL_0107:
				dateTime = dateTime.ToUniversalTime();
				num = 15;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 != 0)
				{
					goto IL_0096;
				}
				goto IL_0148;
				IL_0127:
				if ((this.dateTimeStyles_0 & DateTimeStyles.AdjustToUniversal) == DateTimeStyles.AdjustToUniversal)
				{
					goto IL_0107;
				}
				num = 12;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa != 0)
				{
					goto IL_00FA;
				}
				goto IL_0148;
			}
			goto IL_01C6;
			Block_5:
			return;
			IL_01C6:
			throw new JsonSerializationException(Class15.smethod_17(1603851426 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c).FormatWith(CultureInfo.InvariantCulture, ReflectionUtils.GetObjectType(value)));
		}

		// Token: 0x06001203 RID: 4611 RVA: 0x0008F600 File Offset: 0x0008D800
		[return: Nullable(2)]
		public override object ReadJson(JsonReader reader, Type objectType, [Nullable(2)] object existingValue, JsonSerializer serializer)
		{
			object value;
			string text;
			for (;;)
			{
				IL_01F6:
				bool flag = ReflectionUtils.IsNullableType(objectType);
				int num = 12;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 != 0)
				{
					goto Block_19;
				}
				for (;;)
				{
					IL_018B:
					Type type;
					Type type2;
					switch (num)
					{
					case 0:
						goto IL_0138;
					case 1:
						goto IL_02E1;
					case 2:
						break;
					case 3:
						goto IL_0215;
					case 4:
						goto IL_0300;
					case 5:
						goto IL_0228;
					case 6:
						goto IL_00EA;
					case 7:
						goto IL_0123;
					case 8:
						type = Nullable.GetUnderlyingType(objectType);
						goto IL_0124;
					case 9:
						goto IL_0244;
					case 10:
						goto IL_02D4;
					case 11:
						goto IL_0231;
					case 12:
						if (reader.TokenType == JsonToken.Null)
						{
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 == 0)
							{
								goto IL_00EA;
							}
							continue;
						}
						else
						{
							if (!flag)
							{
								goto IL_0123;
							}
							num = 8;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf == 0)
							{
								goto IL_0138;
							}
							continue;
						}
						break;
					case 13:
						goto IL_01F6;
					case 14:
						if (!(value is DateTimeOffset))
						{
							goto IL_0271;
						}
						num = 5;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a != 0)
						{
							goto Block_8;
						}
						continue;
					case 15:
						goto IL_0278;
					case 16:
						goto IL_0059;
					case 17:
						goto IL_029A;
					case 18:
						goto IL_02A1;
					case 19:
						goto IL_02D2;
					case 20:
						IL_0009:
						if (StringUtils.IsNullOrEmpty(text) && flag)
						{
							goto IL_0332;
						}
						if (!(type2 == typeof(DateTimeOffset)))
						{
							goto Block_2;
						}
						break;
					case 21:
						goto IL_0332;
					case 22:
						goto IL_0006;
					case 23:
						goto IL_0334;
					default:
						goto IL_0138;
					}
					IL_0046:
					while (!StringUtils.IsNullOrEmpty(this.string_0))
					{
						num = 15;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 != 0)
						{
							goto IL_018B;
						}
					}
					goto IL_0319;
					IL_0007:
					string text2;
					text = text2;
					goto IL_0009;
					IL_0006:
					text2 = null;
					goto IL_0007;
					IL_0059:
					if (type2 == typeof(DateTimeOffset))
					{
						num = 3;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 != 0)
						{
							goto IL_0046;
						}
						continue;
					}
					else
					{
						value = reader.Value;
						num = 14;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf == 0)
						{
							goto Block_6;
						}
						continue;
					}
					IL_0138:
					if (reader.TokenType == JsonToken.Date)
					{
						goto IL_0059;
					}
					if (reader.TokenType != JsonToken.String)
					{
						goto Block_15;
					}
					object value2 = reader.Value;
					if (value2 != null)
					{
						text2 = value2.ToString();
						goto IL_0007;
					}
					num = 17;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f != 0)
					{
						goto IL_0006;
					}
					continue;
					IL_00EA:
					if (!flag)
					{
						goto IL_0244;
					}
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_253407eb812c4aefb734fa1e267fe779 == 0)
					{
						goto Block_11;
					}
					continue;
					IL_0124:
					type2 = type;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 == 0)
					{
						goto IL_0138;
					}
					continue;
					IL_0123:
					type = objectType;
					goto IL_0124;
				}
			}
			Block_2:
			goto IL_02D4;
			Block_6:
			goto IL_02E1;
			Block_8:
			goto IL_0300;
			Block_11:
			goto IL_02D2;
			Block_15:
			goto IL_02A1;
			Block_19:
			goto IL_0228;
			IL_0215:
			if (reader.Value is DateTimeOffset)
			{
				goto IL_029A;
			}
			goto IL_0334;
			IL_0228:
			DateTimeOffset dateTimeOffset = (DateTimeOffset)value;
			IL_0231:
			return dateTimeOffset.DateTime;
			IL_0244:
			throw JsonSerializationException.Create(reader, Class15.smethod_17(613131537 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6).FormatWith(CultureInfo.InvariantCulture, objectType));
			IL_0271:
			return reader.Value;
			IL_0278:
			return DateTimeOffset.ParseExact(text, this.string_0, this.Culture, this.dateTimeStyles_0);
			IL_029A:
			return reader.Value;
			IL_02A1:
			throw JsonSerializationException.Create(reader, Class15.smethod_17(649950520 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff).FormatWith(CultureInfo.InvariantCulture, reader.TokenType));
			IL_02D2:
			return null;
			IL_02D4:
			if (StringUtils.IsNullOrEmpty(this.string_0))
			{
				goto IL_0300;
			}
			IL_02E1:
			return DateTime.ParseExact(text, this.string_0, this.Culture, this.dateTimeStyles_0);
			IL_0300:
			return DateTime.Parse(text, this.Culture, this.dateTimeStyles_0);
			IL_0319:
			return DateTimeOffset.Parse(text, this.Culture, this.dateTimeStyles_0);
			IL_0332:
			return null;
			IL_0334:
			return new DateTimeOffset((DateTime)reader.Value);
		}

		// Token: 0x06001204 RID: 4612 RVA: 0x0008F958 File Offset: 0x0008DB58
		public IsoDateTimeConverter()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x04000807 RID: 2055
		private DateTimeStyles dateTimeStyles_0 = DateTimeStyles.RoundtripKind;

		// Token: 0x04000808 RID: 2056
		[Nullable(2)]
		private string string_0;

		// Token: 0x04000809 RID: 2057
		[Nullable(2)]
		private CultureInfo cultureInfo_0;
	}
}
