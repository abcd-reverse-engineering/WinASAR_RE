using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Xml;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200008E RID: 142
	[Nullable(0)]
	[NullableContext(1)]
	internal static class DateTimeUtils
	{
		// Token: 0x06000603 RID: 1539 RVA: 0x00043E44 File Offset: 0x00042044
		static DateTimeUtils()
		{
			for (;;)
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d == 0)
				{
					goto IL_0068;
				}
				IL_006B:
				switch (num)
				{
				case 0:
					goto IL_003D;
				case 1:
					IL_0068:
					goto IL_0006;
				case 2:
					continue;
				case 3:
					break;
				case 4:
					goto IL_0006;
				case 5:
					return;
				default:
					goto IL_003D;
				}
				IL_0014:
				DateTimeUtils.int_0 = new int[]
				{
					0, 31, 59, 90, 120, 151, 181, 212, 243, 273,
					304, 334, 365
				};
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 == 0)
				{
					goto IL_003D;
				}
				goto IL_006B;
				IL_0006:
				DateTimeUtils.InitialJavaScriptDateTicks = 621355968000000000L;
				goto IL_0014;
				IL_003D:
				DateTimeUtils.int_1 = new int[]
				{
					0, 31, 60, 91, 121, 152, 182, 213, 244, 274,
					305, 335, 366
				};
				num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 == 0)
				{
					break;
				}
				goto IL_006B;
			}
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x0000397C File Offset: 0x00001B7C
		public static TimeSpan GetUtcOffset(this DateTime d)
		{
			return TimeZoneInfo.Local.GetUtcOffset(d);
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x00043EF4 File Offset: 0x000420F4
		public static XmlDateTimeSerializationMode ToSerializationMode(DateTimeKind kind)
		{
			for (;;)
			{
				switch (kind)
				{
				case DateTimeKind.Unspecified:
					return XmlDateTimeSerializationMode.Unspecified;
				case DateTimeKind.Utc:
					return XmlDateTimeSerializationMode.Utc;
				case DateTimeKind.Local:
					return XmlDateTimeSerializationMode.Local;
				default:
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 == 0)
					{
						switch (num)
						{
						case 1:
							continue;
						case 2:
							return XmlDateTimeSerializationMode.Local;
						}
						goto Block_2;
					}
					goto IL_003D;
				}
				}
			}
			Block_2:
			IL_003D:
			throw MiscellaneousUtils.CreateArgumentOutOfRangeException(Class15.smethod_17(642153284 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba), kind, Class15.smethod_17(1678110414 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a));
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x00043F7C File Offset: 0x0004217C
		internal static DateTime EnsureDateTime(DateTime value, DateTimeZoneHandling timeZone)
		{
			switch (timeZone)
			{
			case DateTimeZoneHandling.Local:
				value = DateTimeUtils.smethod_0(value);
				break;
			case DateTimeZoneHandling.Utc:
				value = DateTimeUtils.smethod_1(value);
				break;
			case DateTimeZoneHandling.Unspecified:
				value = new DateTime(value.Ticks, DateTimeKind.Unspecified);
				break;
			case DateTimeZoneHandling.RoundtripKind:
				break;
			default:
				throw new ArgumentException(Class15.smethod_17(2060597746 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177));
			}
			return value;
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x00043FE0 File Offset: 0x000421E0
		private static DateTime smethod_0(DateTime dateTime_0)
		{
			for (;;)
			{
				IL_0042:
				DateTimeKind kind = dateTime_0.Kind;
				for (;;)
				{
					switch (kind)
					{
					case DateTimeKind.Unspecified:
						goto IL_0050;
					case DateTimeKind.Utc:
						goto IL_005E;
					case DateTimeKind.Local:
						return dateTime_0;
					default:
					{
						int num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f != 0)
						{
							switch (num)
							{
							case 1:
								return dateTime_0;
							case 2:
								continue;
							case 3:
								goto IL_0042;
							}
							goto Block_2;
						}
						return dateTime_0;
					}
					}
				}
			}
			Block_2:
			IL_0050:
			return new DateTime(dateTime_0.Ticks, DateTimeKind.Local);
			IL_005E:
			return dateTime_0.ToLocalTime();
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x00044054 File Offset: 0x00042254
		private static DateTime smethod_1(DateTime dateTime_0)
		{
			DateTimeKind kind;
			for (;;)
			{
				kind = dateTime_0.Kind;
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 != 0)
				{
					switch (num)
					{
					case 1:
						goto IL_0033;
					case 2:
						continue;
					case 3:
						return dateTime_0;
					}
					break;
				}
				break;
			}
			goto IL_0056;
			IL_0033:
			switch (kind)
			{
			case DateTimeKind.Unspecified:
				IL_0056:
				return new DateTime(dateTime_0.Ticks, DateTimeKind.Utc);
			case DateTimeKind.Utc:
				return dateTime_0;
			case DateTimeKind.Local:
				return dateTime_0.ToUniversalTime();
			}
			return dateTime_0;
			goto IL_0056;
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x000440C4 File Offset: 0x000422C4
		private static long smethod_2(DateTime dateTime_0)
		{
			while (dateTime_0.Kind == DateTimeKind.Utc)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 != 0)
				{
					switch (num)
					{
					case 1:
						continue;
					}
				}
				return dateTime_0.Ticks;
			}
			return DateTimeUtils.smethod_3(dateTime_0, dateTime_0.GetUtcOffset());
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x00044118 File Offset: 0x00042318
		private static long smethod_3(DateTime dateTime_0, TimeSpan timeSpan_0)
		{
			while (dateTime_0.Kind != DateTimeKind.Utc)
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 == 0)
				{
					goto IL_007E;
				}
				IL_008E:
				long num2;
				switch (num)
				{
				case 0:
					goto IL_005D;
				case 1:
					IL_007E:
					if (!(dateTime_0 == DateTime.MaxValue))
					{
						goto IL_001A;
					}
					goto IL_00E6;
				case 2:
					continue;
				case 3:
					goto IL_00D2;
				case 4:
					goto IL_002A;
				case 5:
					goto IL_00E6;
				case 6:
					break;
				case 7:
					return num2;
				case 8:
					goto IL_001A;
				case 9:
					goto IL_00DC;
				default:
					goto IL_005D;
				}
				IL_003B:
				if (num2 > 3155378975999999999L)
				{
					goto IL_00DC;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 != 0)
				{
					goto IL_005D;
				}
				goto IL_008E;
				IL_002A:
				num2 = dateTime_0.Ticks - timeSpan_0.Ticks;
				goto IL_003B;
				IL_001A:
				if (!(dateTime_0 == DateTime.MinValue))
				{
					goto IL_002A;
				}
				break;
				IL_005D:
				if (num2 < 0L)
				{
					goto IL_00D2;
				}
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 != 0)
				{
					goto IL_008E;
				}
				return num2;
				IL_00D2:
				return 0L;
				IL_00DC:
				return 3155378975999999999L;
			}
			IL_00E6:
			return dateTime_0.Ticks;
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x00003989 File Offset: 0x00001B89
		internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, TimeSpan offset)
		{
			return DateTimeUtils.smethod_4(DateTimeUtils.smethod_3(dateTime, offset));
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x00003997 File Offset: 0x00001B97
		internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime)
		{
			return DateTimeUtils.ConvertDateTimeToJavaScriptTicks(dateTime, true);
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x00044214 File Offset: 0x00042414
		internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, bool convertToUtc)
		{
			long num2;
			while (!convertToUtc)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 == 0)
				{
					switch (num)
					{
					case 1:
						continue;
					}
				}
				num2 = dateTime.Ticks;
				IL_003A:
				return DateTimeUtils.smethod_4(num2);
			}
			num2 = DateTimeUtils.smethod_2(dateTime);
			goto IL_003A;
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x000039A0 File Offset: 0x00001BA0
		private static long smethod_4(long long_0)
		{
			return (long_0 - DateTimeUtils.InitialJavaScriptDateTicks) / 10000L;
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x000039B3 File Offset: 0x00001BB3
		internal static DateTime ConvertJavaScriptTicksToDateTime(long javaScriptTicks)
		{
			return new DateTime(javaScriptTicks * 10000L + DateTimeUtils.InitialJavaScriptDateTicks, DateTimeKind.Utc);
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x00044260 File Offset: 0x00042460
		internal static bool TryParseDateTimeIso(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt)
		{
			for (;;)
			{
				IL_0364:
				DateTimeParser dateTimeParser = default(DateTimeParser);
				int num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad != 0)
				{
					goto IL_00F7;
				}
				DateTime dateTime;
				long num2;
				DateTime dateTime2;
				for (;;)
				{
					IL_02C5:
					switch (num)
					{
					case 2:
						goto IL_021E;
					case 4:
					case 15:
						goto IL_00C8;
					case 5:
						goto IL_00F7;
					case 6:
						goto IL_0364;
					case 7:
						goto IL_0138;
					case 8:
						goto IL_0276;
					case 9:
						goto IL_003E;
					case 10:
					case 21:
						goto IL_01B0;
					case 12:
						goto IL_038B;
					case 13:
					{
						TimeSpan timeSpan;
						num2 = dateTime.Ticks + timeSpan.Ticks;
						num = 35;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b == 0)
						{
							continue;
						}
						goto IL_0386;
					}
					case 16:
						goto IL_01A7;
					case 17:
						goto IL_008D;
					case 18:
						goto IL_0255;
					case 19:
						return true;
					case 20:
						goto IL_01A0;
					case 22:
						goto IL_0149;
					case 23:
					case 24:
						goto IL_01F4;
					case 25:
						goto IL_0062;
					case 26:
						goto IL_024C;
					case 27:
						goto IL_009E;
					case 28:
						goto IL_0280;
					case 29:
						return false;
					case 30:
						goto IL_0195;
					case 31:
						goto IL_0047;
					case 33:
						goto IL_0176;
					case 34:
						goto IL_0245;
					case 35:
					{
						long num3 = num2;
						dateTime2 = DateTime.MaxValue;
						if (num3 > dateTime2.Ticks)
						{
							goto IL_01F4;
						}
						goto IL_0276;
					}
					case 36:
						goto IL_0006;
					}
					break;
					IL_01F4:
					num2 += dateTime.GetUtcOffset().Ticks;
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 == 0)
					{
						continue;
					}
					IL_021E:
					long num4 = num2;
					dateTime2 = DateTime.MaxValue;
					if (num4 > dateTime2.Ticks)
					{
						num = 32;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b != 0)
						{
							goto IL_0245;
						}
						continue;
					}
					IL_0255:
					dateTime = new DateTime(num2, DateTimeKind.Local);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e == 0)
					{
						break;
					}
					continue;
					IL_024C:
					num2 = dateTime2.Ticks;
					goto IL_0255;
					IL_0245:
					dateTime2 = DateTime.MaxValue;
					goto IL_024C;
					IL_0280:
					dateTime = dateTime2.ToLocalTime();
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c == 0)
					{
						break;
					}
					continue;
					IL_0276:
					dateTime2 = new DateTime(num2, DateTimeKind.Utc);
					goto IL_0280;
				}
				goto IL_01BA;
				IL_0006:
				long num5 = num2;
				dateTime2 = DateTime.MinValue;
				if (num5 < dateTime2.Ticks)
				{
					goto IL_01A0;
				}
				num = 10;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 == 0)
				{
					goto IL_00F7;
				}
				goto IL_02C5;
				IL_0047:
				ParserTimeZone zone;
				TimeSpan timeSpan2;
				switch (zone)
				{
				case ParserTimeZone.Utc:
					IL_0138:
					dateTime = new DateTime(dateTime.Ticks, DateTimeKind.Utc);
					goto IL_01BA;
				case ParserTimeZone.LocalWestOfUtc:
				{
					IL_0149:
					TimeSpan timeSpan = new TimeSpan(dateTimeParser.ZoneHour, dateTimeParser.ZoneMinute, 0);
					num = 13;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d == 0)
					{
						goto IL_01BA;
					}
					goto IL_02C5;
				}
				case ParserTimeZone.LocalEastOfUtc:
					IL_0062:
					timeSpan2 = new TimeSpan(dateTimeParser.ZoneHour, dateTimeParser.ZoneMinute, 0);
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 != 0)
					{
						goto IL_008D;
					}
					goto IL_02C5;
				default:
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a == 0)
					{
						goto IL_01BA;
					}
					goto IL_02C5;
				}
				IL_003E:
				zone = dateTimeParser.Zone;
				goto IL_0047;
				IL_00F7:
				if (!dateTimeParser.Parse(text.Chars, text.StartIndex, text.Length))
				{
					break;
				}
				dateTime = DateTimeUtils.smethod_5(dateTimeParser);
				goto IL_003E;
				IL_009E:
				long num6 = num2;
				dateTime2 = DateTime.MinValue;
				if (num6 >= dateTime2.Ticks)
				{
					goto IL_0176;
				}
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f != 0)
				{
					goto IL_00C8;
				}
				goto IL_02C5;
				IL_008D:
				num2 = dateTime.Ticks - timeSpan2.Ticks;
				goto IL_009E;
				IL_00C8:
				num2 += dateTime.GetUtcOffset().Ticks;
				num = 35;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 == 0)
				{
					goto IL_0006;
				}
				goto IL_02C5;
				IL_0176:
				dateTime2 = new DateTime(num2, DateTimeKind.Utc);
				num = 12;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 != 0)
				{
					goto IL_0195;
				}
				goto IL_02C5;
				IL_01BA:
				dt = DateTimeUtils.EnsureDateTime(dateTime, dateTimeZoneHandling);
				num = 19;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 != 0)
				{
					goto IL_01A7;
				}
				goto IL_02C5;
				IL_01B0:
				dateTime = new DateTime(num2, DateTimeKind.Local);
				goto IL_01BA;
				IL_01A7:
				num2 = dateTime2.Ticks;
				goto IL_01B0;
				IL_01A0:
				dateTime2 = DateTime.MinValue;
				goto IL_01A7;
				IL_0195:
				dateTime = dateTime2.ToLocalTime();
				goto IL_01BA;
			}
			IL_0386:
			IL_038B:
			dt = default(DateTime);
			return false;
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x00044600 File Offset: 0x00042800
		internal static bool TryParseDateTimeOffsetIso(StringReference text, out DateTimeOffset dt)
		{
			for (;;)
			{
				IL_021E:
				DateTimeParser dateTimeParser = default(DateTimeParser);
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa != 0)
				{
					goto IL_0006;
				}
				long num2;
				DateTime dateTime;
				TimeSpan utcOffset;
				for (;;)
				{
					IL_01C2:
					switch (num)
					{
					case 1:
					case 14:
						goto IL_00AB;
					case 2:
					case 4:
					case 15:
					case 17:
						goto IL_013C;
					case 3:
						return false;
					case 5:
						return true;
					case 6:
						goto IL_0111;
					case 7:
						goto IL_0039;
					case 8:
						goto IL_0063;
					case 9:
						if (num2 >= 0L)
						{
							goto IL_0187;
						}
						goto IL_0194;
					case 10:
						goto IL_0081;
					case 11:
						goto IL_0194;
					case 12:
						goto IL_00D0;
					case 13:
						goto IL_0187;
					case 16:
						goto IL_0161;
					case 18:
						goto IL_00E2;
					case 19:
						goto IL_0006;
					case 20:
						goto IL_021E;
					}
					goto Block_10;
					IL_0161:
					dt = new DateTimeOffset(dateTime, utcOffset);
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e != 0)
					{
						goto Block_7;
					}
					continue;
					IL_0187:
					if (num2 <= 3155378975999999999L)
					{
						goto IL_0161;
					}
					IL_0194:
					dt = default(DateTimeOffset);
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff != 0)
					{
						goto Block_8;
					}
				}
				IL_0006:
				if (dateTimeParser.Parse(text.Chars, text.StartIndex, text.Length))
				{
					dateTime = DateTimeUtils.smethod_5(dateTimeParser);
					goto IL_0063;
				}
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 != 0)
				{
					goto IL_01C2;
				}
				IL_0039:
				dt = default(DateTimeOffset);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 == 0)
				{
					break;
				}
				goto IL_01C2;
				IL_0063:
				ParserTimeZone zone = dateTimeParser.Zone;
				num = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf == 0)
				{
					goto IL_01C2;
				}
				IL_0081:
				switch (zone)
				{
				case ParserTimeZone.Utc:
					IL_00D0:
					utcOffset = new TimeSpan(0L);
					goto IL_013C;
				case ParserTimeZone.LocalWestOfUtc:
					IL_00E2:
					utcOffset = new TimeSpan(-dateTimeParser.ZoneHour, -dateTimeParser.ZoneMinute, 0);
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c != 0)
					{
						goto IL_013C;
					}
					goto IL_01C2;
				case ParserTimeZone.LocalEastOfUtc:
					IL_0111:
					utcOffset = new TimeSpan(dateTimeParser.ZoneHour, dateTimeParser.ZoneMinute, 0);
					num = 15;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 == 0)
					{
						goto IL_013C;
					}
					goto IL_01C2;
				default:
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 != 0)
					{
						goto IL_01C2;
					}
					break;
				}
				IL_00AB:
				utcOffset = TimeZoneInfo.Local.GetUtcOffset(dateTime);
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 != 0)
				{
					goto IL_01C2;
				}
				IL_013C:
				num2 = dateTime.Ticks - utcOffset.Ticks;
				num = 9;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 == 0)
				{
					goto IL_0111;
				}
				goto IL_01C2;
			}
			return false;
			Block_7:
			return true;
			Block_8:
			return false;
			Block_10:
			return false;
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x00044854 File Offset: 0x00042A54
		private static DateTime smethod_5(DateTimeParser dateTimeParser_0)
		{
			DateTime dateTime;
			for (;;)
			{
				if (dateTimeParser_0.Hour == 24)
				{
					goto IL_00A7;
				}
				goto IL_00E0;
				IL_00AC:
				int num;
				bool flag;
				switch (num)
				{
				case 0:
				case 3:
					goto IL_0067;
				case 1:
				case 9:
					return dateTime;
				case 2:
					goto IL_0092;
				case 4:
					IL_00E0:
					flag = false;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b == 0)
					{
						goto IL_0067;
					}
					goto IL_00AC;
				case 5:
					IL_00A7:
					flag = true;
					goto IL_004D;
				case 6:
					continue;
				case 7:
					goto IL_0024;
				case 8:
					goto IL_004D;
				case 10:
					break;
				default:
					goto IL_0067;
				}
				IL_0006:
				if (flag)
				{
					goto IL_0024;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a != 0)
				{
					break;
				}
				goto IL_00AC;
				IL_0092:
				dateTime = dateTime.AddTicks((long)dateTimeParser_0.Fraction);
				goto IL_0006;
				IL_0067:
				dateTime = new DateTime(dateTimeParser_0.Year, dateTimeParser_0.Month, dateTimeParser_0.Day, dateTimeParser_0.Hour, dateTimeParser_0.Minute, dateTimeParser_0.Second);
				goto IL_0092;
				IL_0024:
				dateTime = dateTime.AddDays(1.0);
				num = 8;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 != 0)
				{
					break;
				}
				goto IL_00AC;
				IL_004D:
				dateTimeParser_0.Hour = 0;
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede != 0)
				{
					goto IL_0067;
				}
				goto IL_00AC;
			}
			return dateTime;
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00044970 File Offset: 0x00042B70
		internal static bool TryParseDateTime(StringReference s, DateTimeZoneHandling dateTimeZoneHandling, [Nullable(2)] string dateFormatString, CultureInfo culture, out DateTime dt)
		{
			for (;;)
			{
				IL_0163:
				if (s.Length > 0)
				{
					goto IL_0141;
				}
				int num = 16;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa == 0)
				{
					goto Block_11;
				}
				for (;;)
				{
					IL_00B7:
					switch (num)
					{
					case 1:
						goto IL_0141;
					case 2:
						return true;
					case 3:
						goto IL_006F;
					case 4:
					case 12:
					case 16:
						goto IL_01E4;
					case 5:
						goto IL_0082;
					case 6:
						return true;
					case 7:
						goto IL_0095;
					case 8:
					case 9:
					case 14:
						goto IL_01C1;
					case 10:
						goto IL_012E;
					case 11:
						goto IL_0050;
					case 13:
						goto IL_017A;
					case 15:
						goto IL_0197;
					case 17:
						goto IL_0163;
					case 18:
						return true;
					case 19:
						if (s.Length < 9)
						{
							goto IL_01C1;
						}
						num = 13;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c == 0)
						{
							goto Block_4;
						}
						continue;
					case 20:
						goto IL_01B4;
					case 21:
						return false;
					}
					goto Block_8;
				}
				IL_012E:
				int startIndex;
				if (s[startIndex] == '/')
				{
					num = 19;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa != 0)
					{
						goto Block_9;
					}
					goto IL_00B7;
				}
				else
				{
					if (s.Length < 19)
					{
						goto IL_01C1;
					}
					num = 10;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 == 0)
					{
						goto IL_00B7;
					}
				}
				IL_0050:
				if (s.Length <= 40)
				{
					goto IL_006F;
				}
				num = 9;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6 != 0)
				{
					goto IL_00B7;
				}
				IL_0095:
				if (!DateTimeUtils.TryParseDateTimeIso(s, dateTimeZoneHandling, out dt))
				{
					goto IL_01C1;
				}
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 != 0)
				{
					goto IL_00B7;
				}
				return true;
				IL_0082:
				if (s[startIndex + 10] == 'T')
				{
					goto IL_0095;
				}
				goto IL_01C1;
				IL_006F:
				if (char.IsDigit(s[startIndex]))
				{
					goto IL_0082;
				}
				goto IL_01C1;
				IL_0141:
				startIndex = s.StartIndex;
				goto IL_012E;
			}
			Block_4:
			goto IL_017A;
			Block_8:
			goto IL_01C9;
			Block_9:
			return true;
			Block_11:
			goto IL_01E4;
			IL_017A:
			if (!s.StartsWith(Class15.smethod_17(124828916 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719)))
			{
				goto IL_01C1;
			}
			IL_0197:
			if (!s.EndsWith(Class15.smethod_17(768796266 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7)))
			{
				goto IL_01C1;
			}
			IL_01B4:
			if (!DateTimeUtils.smethod_7(s, dateTimeZoneHandling, out dt))
			{
				goto IL_01C1;
			}
			return true;
			IL_01C1:
			if (StringUtils.IsNullOrEmpty(dateFormatString))
			{
				goto IL_01E4;
			}
			IL_01C9:
			if (!DateTimeUtils.smethod_8(s.ToString(), dateTimeZoneHandling, dateFormatString, culture, out dt))
			{
				goto IL_01E4;
			}
			return true;
			IL_01E4:
			dt = default(DateTime);
			return false;
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x00044B6C File Offset: 0x00042D6C
		internal static bool TryParseDateTime(string s, DateTimeZoneHandling dateTimeZoneHandling, [Nullable(2)] string dateFormatString, CultureInfo culture, out DateTime dt)
		{
			IL_01E0:
			while (s.Length > 0)
			{
				for (;;)
				{
					IL_01CC:
					if (s[0] == '/')
					{
						goto IL_00B5;
					}
					if (s.Length >= 19)
					{
						goto IL_01BF;
					}
					break;
					int num;
					for (;;)
					{
						IL_00E6:
						switch (num)
						{
						case 1:
							goto IL_0019;
						case 3:
							goto IL_00C2;
						case 5:
							goto IL_0204;
						case 6:
							goto IL_0188;
						case 7:
							goto IL_00B5;
						case 8:
							goto IL_01AE;
						case 9:
							goto IL_007D;
						case 10:
							goto IL_01BF;
						case 11:
							return true;
						case 12:
							return true;
						case 13:
							return false;
						case 14:
							return true;
						case 15:
							goto IL_01CC;
						case 16:
							goto IL_0158;
						case 17:
							goto IL_0213;
						case 18:
							goto IL_01E0;
						case 19:
							if (DateTimeUtils.smethod_7(new StringReference(s.ToCharArray(), 0, s.Length), dateTimeZoneHandling, out dt))
							{
								return true;
							}
							num = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_207f975845fc40cdbe6b166fce664cd5 != 0)
							{
								continue;
							}
							break;
						}
						goto Block_8;
					}
					IL_0019:
					dt = DateTimeUtils.EnsureDateTime(dt, dateTimeZoneHandling);
					num = 12;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 != 0)
					{
						break;
					}
					goto IL_00E6;
					IL_007D:
					if (!s.EndsWith(Class15.smethod_17(2008571487 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb), StringComparison.Ordinal))
					{
						break;
					}
					num = 19;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 == 0)
					{
						goto IL_0188;
					}
					goto IL_00E6;
					IL_00C2:
					if (s.StartsWith(Class15.smethod_17(613100813 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6), StringComparison.Ordinal))
					{
						goto IL_007D;
					}
					break;
					IL_00B5:
					if (s.Length >= 9)
					{
						goto IL_00C2;
					}
					break;
					IL_01AE:
					if (char.IsDigit(s[0]))
					{
						goto IL_0188;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 == 0)
					{
						break;
					}
					goto IL_00E6;
					IL_01BF:
					if (s.Length <= 40)
					{
						goto IL_01AE;
					}
					break;
					IL_0158:
					if (DateTime.TryParseExact(s, Class15.smethod_17(1176441562 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af), CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind, out dt))
					{
						goto IL_0019;
					}
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a == 0)
					{
						break;
					}
					goto IL_00E6;
					IL_0188:
					if (s[10] == 'T')
					{
						goto IL_0158;
					}
					break;
				}
				Block_8:
				if (StringUtils.IsNullOrEmpty(dateFormatString))
				{
					break;
				}
				IL_0204:
				if (!DateTimeUtils.smethod_8(s, dateTimeZoneHandling, dateFormatString, culture, out dt))
				{
					break;
				}
				return true;
				IL_0213:
				dt = default(DateTime);
				return false;
			}
			goto IL_0213;
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x00044D98 File Offset: 0x00042F98
		internal static bool TryParseDateTimeOffset(StringReference s, [Nullable(2)] string dateFormatString, CultureInfo culture, out DateTimeOffset dt)
		{
			IL_0170:
			while (s.Length > 0)
			{
				for (;;)
				{
					IL_0165:
					int startIndex = s.StartIndex;
					for (;;)
					{
						if (s[startIndex] == '/')
						{
							goto IL_0067;
						}
						if (s.Length < 19)
						{
							goto IL_01B1;
						}
						int num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 == 0)
						{
							goto IL_00D3;
						}
						goto IL_00F2;
						IL_00AC:
						if (char.IsDigit(s[startIndex]))
						{
							goto IL_002E;
						}
						num = 13;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede != 0)
						{
							continue;
						}
						goto IL_00F2;
						IL_00D3:
						if (s.Length <= 40)
						{
							goto IL_00AC;
						}
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b != 0)
						{
							goto IL_017D;
						}
						IL_00F2:
						switch (num)
						{
						case 0:
							goto IL_00D3;
						case 1:
						case 6:
						case 9:
						case 13:
							goto IL_01B1;
						case 2:
							goto IL_0180;
						case 3:
							continue;
						case 4:
							goto IL_00AC;
						case 5:
							return true;
						case 7:
							goto IL_0075;
						case 8:
							IL_0067:
							if (s.Length >= 9)
							{
								goto IL_0075;
							}
							goto IL_01B1;
						case 10:
							return true;
						case 11:
							goto IL_01A3;
						case 12:
							return false;
						case 14:
							goto IL_0165;
						case 15:
							goto IL_0170;
						case 16:
							goto IL_01B9;
						case 17:
							goto IL_01D2;
						case 18:
							break;
						case 19:
							return true;
						case 20:
							goto IL_002E;
						default:
							goto IL_00D3;
						}
						IL_0041:
						if (!DateTimeUtils.TryParseDateTimeOffsetIso(s, out dt))
						{
							goto IL_01B1;
						}
						num = 5;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a == 0)
						{
							goto Block_4;
						}
						goto IL_00F2;
						IL_002E:
						if (s[startIndex + 10] == 'T')
						{
							goto IL_0041;
						}
						goto IL_01B1;
						IL_0075:
						if (!s.StartsWith(Class15.smethod_17(2048550337 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18)))
						{
							goto IL_01B1;
						}
						num = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 == 0)
						{
							goto Block_6;
						}
						goto IL_00F2;
					}
				}
				Block_4:
				return true;
				Block_6:
				IL_017D:
				goto IL_01B1;
				IL_0180:
				if (!s.EndsWith(Class15.smethod_17(2071417412 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808)))
				{
					goto IL_01B1;
				}
				IL_01A3:
				if (!DateTimeUtils.smethod_9(s, out dt))
				{
					goto IL_01B1;
				}
				return true;
				IL_01B1:
				if (StringUtils.IsNullOrEmpty(dateFormatString))
				{
					break;
				}
				IL_01B9:
				if (!DateTimeUtils.smethod_10(s.ToString(), dateFormatString, culture, out dt))
				{
					break;
				}
				return true;
			}
			IL_01D2:
			dt = default(DateTimeOffset);
			return false;
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00044F80 File Offset: 0x00043180
		internal static bool TryParseDateTimeOffset(string s, [Nullable(2)] string dateFormatString, CultureInfo culture, out DateTimeOffset dt)
		{
			for (;;)
			{
				if (s.Length > 0)
				{
					goto IL_0237;
				}
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 == 0)
				{
					goto IL_0055;
				}
				goto IL_01A9;
				IL_00CB:
				while (s.Length >= 9)
				{
					num = 19;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 == 0)
					{
						goto IL_01A9;
					}
				}
				goto IL_019B;
				IL_01A9:
				switch (num)
				{
				case 0:
				case 8:
				case 21:
					goto IL_0055;
				case 1:
					continue;
				case 2:
					goto IL_0164;
				case 3:
					goto IL_0071;
				case 4:
					return true;
				case 5:
					goto IL_0019;
				case 6:
					if (DateTimeUtils.TryParseDateTimeOffsetIso(new StringReference(s.ToCharArray(), 0, s.Length), out dt))
					{
						goto Block_10;
					}
					goto IL_019B;
				case 7:
					IL_0237:
					if (s[0] == '/')
					{
						goto IL_00CB;
					}
					if (s.Length < 19)
					{
						goto IL_019B;
					}
					goto IL_0227;
				case 9:
					goto IL_00DB;
				case 10:
					break;
				case 11:
					return true;
				case 12:
					return true;
				case 13:
					goto IL_0030;
				case 14:
					return false;
				case 15:
					goto IL_00CB;
				case 16:
				case 17:
				case 18:
				case 20:
					goto IL_019B;
				case 19:
					if (!s.StartsWith(Class15.smethod_17(82281134 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909), StringComparison.Ordinal))
					{
						goto IL_019B;
					}
					break;
				case 22:
					goto IL_0227;
				default:
					goto IL_0055;
				}
				if (!s.EndsWith(Class15.smethod_17(649971160 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff), StringComparison.Ordinal))
				{
					goto IL_019B;
				}
				goto IL_0164;
				IL_0030:
				if (DateTimeUtils.smethod_10(s, dateFormatString, culture, out dt))
				{
					return true;
				}
				num = 8;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf == 0)
				{
					goto IL_0071;
				}
				goto IL_01A9;
				IL_019B:
				if (!StringUtils.IsNullOrEmpty(dateFormatString))
				{
					goto IL_0030;
				}
				num = 21;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a == 0)
				{
					goto Block_13;
				}
				goto IL_01A9;
				IL_0055:
				dt = default(DateTimeOffset);
				num = 14;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 == 0)
				{
					goto IL_0071;
				}
				goto IL_01A9;
				IL_0227:
				if (s.Length > 40)
				{
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 != 0)
					{
						goto IL_019B;
					}
					goto IL_01A9;
				}
				IL_0019:
				if (char.IsDigit(s[0]))
				{
					goto IL_00DB;
				}
				goto IL_019B;
				IL_0071:
				if (!DateTimeOffset.TryParseExact(s, Class15.smethod_17(1116146927 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54), CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind, out dt))
				{
					goto IL_019B;
				}
				num = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 == 0)
				{
					goto IL_0164;
				}
				goto IL_01A9;
				IL_00DB:
				if (s[10] != 'T')
				{
					goto IL_019B;
				}
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 == 0)
				{
					goto IL_0071;
				}
				goto IL_01A9;
				IL_0164:
				if (DateTimeUtils.smethod_9(new StringReference(s.ToCharArray(), 0, s.Length), out dt))
				{
					goto Block_12;
				}
				goto IL_019B;
			}
			Block_10:
			return true;
			Block_12:
			return true;
			Block_13:
			return true;
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x00045208 File Offset: 0x00043408
		private static bool smethod_6(StringReference stringReference_0, out long long_0, out TimeSpan timeSpan_0, out DateTimeKind dateTimeKind_0)
		{
			int num2;
			for (;;)
			{
				IL_00E4:
				dateTimeKind_0 = DateTimeKind.Utc;
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a == 0)
				{
					goto IL_0087;
				}
				for (;;)
				{
					IL_00AC:
					switch (num)
					{
					case 1:
						goto IL_0087;
					case 2:
						goto IL_00E4;
					case 3:
					case 4:
						goto IL_0118;
					case 5:
						goto IL_0136;
					case 6:
						if (num2 == -1)
						{
							goto IL_0069;
						}
						goto IL_0006;
					case 7:
						goto IL_0105;
					case 8:
						goto IL_0069;
					case 9:
						return false;
					case 10:
						num2 = stringReference_0.Length - 2;
						num = 3;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 == 0)
						{
							continue;
						}
						break;
					case 11:
						goto IL_0006;
					}
					goto Block_6;
					IL_0006:
					if (num2 != -1)
					{
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 == 0)
						{
							goto Block_2;
						}
						continue;
					}
					else
					{
						timeSpan_0 = TimeSpan.Zero;
						num = 10;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 == 0)
						{
							goto Block_3;
						}
						continue;
					}
					IL_0069:
					num2 = stringReference_0.IndexOf('-', 7, stringReference_0.Length - 8);
					goto IL_0006;
				}
				IL_0087:
				num2 = stringReference_0.IndexOf('+', 7, stringReference_0.Length - 8);
				num = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf != 0)
				{
					goto IL_00AC;
				}
				break;
			}
			Block_2:
			goto IL_0102;
			Block_3:
			return false;
			Block_6:
			IL_0102:
			dateTimeKind_0 = DateTimeKind.Local;
			IL_0105:
			if (!DateTimeUtils.smethod_11(stringReference_0, num2 + stringReference_0.StartIndex, out timeSpan_0))
			{
				goto IL_0136;
			}
			IL_0118:
			return ConvertUtils.Int64TryParse(stringReference_0.Chars, 6 + stringReference_0.StartIndex, num2 - 6, out long_0) == ParseResult.Success;
			IL_0136:
			long_0 = 0L;
			return false;
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x0004535C File Offset: 0x0004355C
		private static bool smethod_7(StringReference stringReference_0, DateTimeZoneHandling dateTimeZoneHandling_0, out DateTime dateTime_0)
		{
			IL_011D:
			long num;
			TimeSpan timeSpan;
			DateTimeKind dateTimeKind;
			while (DateTimeUtils.smethod_6(stringReference_0, out num, out timeSpan, out dateTimeKind))
			{
				for (;;)
				{
					DateTime dateTime = DateTimeUtils.ConvertJavaScriptTicksToDateTime(num);
					int num2 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 == 0)
					{
						goto IL_0079;
					}
					IL_00B9:
					switch (num2)
					{
					case 1:
					case 6:
					case 10:
						goto IL_0028;
					case 2:
					case 3:
						goto IL_008F;
					case 4:
						IL_0079:
						if (dateTimeKind != DateTimeKind.Unspecified)
						{
							goto IL_0060;
						}
						num2 = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 == 0)
						{
							goto IL_008F;
						}
						goto IL_00B9;
					case 5:
						goto IL_0060;
					case 7:
						goto IL_0051;
					case 8:
						continue;
					case 9:
						goto IL_011D;
					case 11:
						return false;
					case 12:
						goto IL_0134;
					case 13:
					case 14:
						goto IL_0006;
					}
					break;
					IL_0006:
					dateTime_0 = dateTime;
					num2 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 == 0)
					{
						break;
					}
					goto IL_00B9;
					IL_0028:
					dateTime_0 = DateTimeUtils.EnsureDateTime(dateTime_0, dateTimeZoneHandling_0);
					num2 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 == 0)
					{
						break;
					}
					goto IL_00B9;
					IL_0051:
					dateTime_0 = dateTime.ToLocalTime();
					goto IL_0028;
					IL_0060:
					if (dateTimeKind == DateTimeKind.Local)
					{
						goto IL_0051;
					}
					num2 = 14;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 == 0)
					{
						goto IL_0006;
					}
					goto IL_00B9;
					IL_008F:
					dateTime_0 = DateTime.SpecifyKind(dateTime.ToLocalTime(), DateTimeKind.Unspecified);
					num2 = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a == 0)
					{
						goto IL_0028;
					}
					goto IL_00B9;
				}
				return true;
			}
			IL_0134:
			dateTime_0 = default(DateTime);
			return false;
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x000454A8 File Offset: 0x000436A8
		private static bool smethod_8(string string_0, DateTimeZoneHandling dateTimeZoneHandling_0, string string_1, IFormatProvider iformatProvider_0, out DateTime dateTime_0)
		{
			IL_005B:
			DateTime dateTime;
			while (DateTime.TryParseExact(string_0, string_1, iformatProvider_0, DateTimeStyles.RoundtripKind, out dateTime))
			{
				for (;;)
				{
					dateTime = DateTimeUtils.EnsureDateTime(dateTime, dateTimeZoneHandling_0);
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 == 0)
					{
						goto IL_0003;
					}
					IL_001D:
					switch (num)
					{
					case 1:
						return true;
					case 2:
						continue;
					case 3:
						return false;
					case 4:
						goto IL_0072;
					case 5:
						goto IL_005B;
					}
					IL_0003:
					dateTime_0 = dateTime;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 == 0)
					{
						goto IL_001D;
					}
					break;
				}
				return true;
				IL_0072:
				dateTime_0 = default(DateTime);
				return false;
			}
			goto IL_0072;
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x00045530 File Offset: 0x00043730
		private static bool smethod_9(StringReference stringReference_0, out DateTimeOffset dateTimeOffset_0)
		{
			for (;;)
			{
				long num;
				TimeSpan timeSpan;
				DateTimeKind dateTimeKind;
				if (DateTimeUtils.smethod_6(stringReference_0, out num, out timeSpan, out dateTimeKind))
				{
					goto IL_0006;
				}
				goto IL_005F;
				IL_003F:
				int num2;
				DateTime dateTime;
				switch (num2)
				{
				case 1:
					return true;
				case 2:
					goto IL_000F;
				case 3:
					IL_0006:
					dateTime = DateTimeUtils.ConvertJavaScriptTicksToDateTime(num);
					goto IL_000F;
				case 4:
					continue;
				case 5:
					IL_005F:
					dateTimeOffset_0 = default(DateTime);
					num2 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 != 0)
					{
						goto IL_003F;
					}
					break;
				}
				break;
				IL_000F:
				dateTimeOffset_0 = new DateTimeOffset(dateTime.Add(timeSpan).Ticks, timeSpan);
				num2 = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 == 0)
				{
					goto IL_003F;
				}
				return true;
			}
			return false;
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x000455E0 File Offset: 0x000437E0
		private static bool smethod_10(string string_0, string string_1, IFormatProvider iformatProvider_0, out DateTimeOffset dateTimeOffset_0)
		{
			for (;;)
			{
				DateTimeOffset dateTimeOffset;
				if (DateTimeOffset.TryParseExact(string_0, string_1, iformatProvider_0, DateTimeStyles.RoundtripKind, out dateTimeOffset))
				{
					goto IL_001E;
				}
				dateTimeOffset_0 = default(DateTimeOffset);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e == 0)
				{
					break;
				}
				IL_0037:
				switch (num)
				{
				case 1:
					return true;
				case 2:
					IL_001E:
					dateTimeOffset_0 = dateTimeOffset;
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d != 0)
					{
						goto IL_0037;
					}
					return true;
				case 3:
					continue;
				}
				break;
			}
			return false;
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x00045658 File Offset: 0x00043858
		private static bool smethod_11(StringReference stringReference_0, int int_2, out TimeSpan timeSpan_0)
		{
			for (;;)
			{
				IL_012D:
				bool flag = stringReference_0[int_2] == '-';
				for (;;)
				{
					IL_0112:
					int num;
					int num2;
					int num3;
					if (ConvertUtils.Int32TryParse(stringReference_0.Chars, int_2 + 1, 2, out num) != ParseResult.Success)
					{
						num2 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 == 0)
						{
							goto Block_8;
						}
					}
					else
					{
						num3 = 0;
						num2 = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 != 0)
						{
							goto IL_006B;
						}
					}
					for (;;)
					{
						IL_00C6:
						switch (num2)
						{
						case 1:
						case 8:
							return true;
						case 2:
							if (ConvertUtils.Int32TryParse(stringReference_0.Chars, int_2 + 3, 2, out num3) != ParseResult.Success)
							{
								goto IL_0020;
							}
							goto IL_008E;
						case 3:
							return false;
						case 4:
							goto IL_006B;
						case 5:
							goto IL_0048;
						case 6:
							return false;
						case 7:
							goto IL_0041;
						case 9:
							goto IL_0112;
						case 10:
							goto IL_012D;
						case 11:
							goto IL_0020;
						}
						goto Block_7;
						IL_0020:
						timeSpan_0 = default(TimeSpan);
						num2 = 6;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e != 0)
						{
							goto Block_2;
						}
					}
					IL_0048:
					timeSpan_0 = timeSpan_0.Negate();
					num2 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c != 0)
					{
						goto Block_3;
					}
					goto IL_00C6;
					IL_0041:
					if (flag)
					{
						goto IL_0048;
					}
					return true;
					IL_008E:
					timeSpan_0 = TimeSpan.FromHours((double)num) + TimeSpan.FromMinutes((double)num3);
					goto IL_0041;
					IL_006B:
					if (stringReference_0.Length - int_2 <= 5)
					{
						goto IL_008E;
					}
					num2 = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb == 0)
					{
						goto Block_5;
					}
					goto IL_00C6;
				}
			}
			Block_2:
			Block_3:
			return true;
			Block_5:
			Block_7:
			Block_8:
			timeSpan_0 = default(TimeSpan);
			return false;
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x000457B8 File Offset: 0x000439B8
		internal static void WriteDateTimeString(TextWriter writer, DateTime value, DateFormatHandling format, [Nullable(2)] string formatString, CultureInfo culture)
		{
			IL_007F:
			while (StringUtils.IsNullOrEmpty(formatString))
			{
				for (;;)
				{
					IL_0074:
					char[] array = new char[64];
					for (;;)
					{
						int num = DateTimeUtils.WriteDateTimeString(array, 0, value, null, value.Kind, format);
						int num2 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 == 0)
						{
							goto IL_0003;
						}
						IL_001F:
						switch (num2)
						{
						case 1:
							return;
						case 2:
							return;
						case 3:
							goto IL_0074;
						case 4:
							goto IL_008C;
						case 5:
							goto IL_007F;
						case 6:
							continue;
						}
						IL_0003:
						writer.Write(array, 0, num);
						num2 = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 == 0)
						{
							goto IL_001F;
						}
						return;
					}
				}
				return;
				IL_008C:
				writer.Write(value.ToString(formatString, culture));
				return;
			}
			goto IL_008C;
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00045864 File Offset: 0x00043A64
		internal static int WriteDateTimeString(char[] chars, int start, DateTime value, TimeSpan? offset, DateTimeKind kind, DateFormatHandling format)
		{
			int num2;
			if (format == DateFormatHandling.MicrosoftDateFormat)
			{
				TimeSpan timeSpan = offset ?? value.GetUtcOffset();
				long num = DateTimeUtils.ConvertDateTimeToJavaScriptTicks(value, timeSpan);
				Class15.smethod_17(2128245336 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9).CopyTo(0, chars, start, 7);
				num2 = start + 7;
				string text = num.ToString(CultureInfo.InvariantCulture);
				text.CopyTo(0, chars, num2, text.Length);
				num2 += text.Length;
				if (kind != DateTimeKind.Unspecified)
				{
					if (kind == DateTimeKind.Local)
					{
						num2 = DateTimeUtils.WriteDateTimeOffset(chars, num2, timeSpan, format);
					}
				}
				else if (value != DateTime.MaxValue && value != DateTime.MinValue)
				{
					num2 = DateTimeUtils.WriteDateTimeOffset(chars, num2, timeSpan, format);
				}
				Class15.smethod_17(1271004286 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112).CopyTo(0, chars, num2, 3);
				num2 += 3;
			}
			else
			{
				num2 = DateTimeUtils.WriteDefaultIsoDate(chars, start, value);
				if (kind != DateTimeKind.Utc)
				{
					if (kind == DateTimeKind.Local)
					{
						num2 = DateTimeUtils.WriteDateTimeOffset(chars, num2, offset ?? value.GetUtcOffset(), format);
					}
				}
				else
				{
					chars[num2++] = 'Z';
				}
			}
			return num2;
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x0004598C File Offset: 0x00043B8C
		internal static int WriteDefaultIsoDate(char[] chars, int start, DateTime dt)
		{
			int num;
			for (;;)
			{
				IL_02B7:
				num = 19;
				for (;;)
				{
					IL_0291:
					int num2;
					int num3;
					int num4;
					DateTimeUtils.smethod_13(dt, out num2, out num3, out num4);
					int num5 = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 == 0)
					{
						goto IL_008D;
					}
					int num6;
					int num7;
					do
					{
						IL_0226:
						switch (num5)
						{
						case 1:
							goto IL_0109;
						case 2:
							goto IL_0036;
						case 3:
							chars[start + 13] = ':';
							num5 = 14;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 != 0)
							{
								continue;
							}
							goto IL_02BD;
						case 4:
						case 5:
							goto IL_0071;
						case 6:
							DateTimeUtils.smethod_12(chars, start + 5, num3, 2);
							num5 = 9;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 == 0)
							{
								goto Block_10;
							}
							continue;
						case 7:
							goto IL_02BE;
						case 8:
							goto IL_00BF;
						case 9:
							chars[start + 7] = '-';
							num5 = 12;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 != 0)
							{
								continue;
							}
							break;
						case 10:
							goto IL_008D;
						case 11:
							goto IL_00E6;
						case 12:
							DateTimeUtils.smethod_12(chars, start + 8, num4, 2);
							goto IL_0129;
						case 13:
							goto IL_001A;
						case 14:
							DateTimeUtils.smethod_12(chars, start + 14, dt.Minute, 2);
							goto IL_00A2;
						case 15:
							chars[start + 19] = '.';
							goto IL_00E6;
						case 16:
							goto IL_0291;
						case 17:
							goto IL_02B7;
						case 18:
							goto IL_0054;
						case 19:
							num6 = 7;
							num5 = 4;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 == 0)
							{
								goto Block_8;
							}
							continue;
						case 20:
							DateTimeUtils.smethod_12(chars, start + 11, dt.Hour, 2);
							num5 = 3;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d != 0)
							{
								continue;
							}
							break;
						case 21:
							goto IL_0129;
						case 22:
							goto IL_00A2;
						case 23:
							num7 = (int)(dt.Ticks % 10000000L);
							goto IL_001A;
						}
						goto Block_11;
						for (;;)
						{
							IL_0109:
							num += num6 + 1;
							num5 = 7;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c != 0)
							{
								goto IL_0226;
							}
						}
						IL_001A:
						if (num7 == 0)
						{
							goto IL_02BE;
						}
						num5 = 19;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a != 0)
						{
							goto IL_0036;
						}
						continue;
						IL_00A2:
						chars[start + 16] = ':';
						num5 = 6;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae == 0)
						{
							continue;
						}
						IL_00BF:
						DateTimeUtils.smethod_12(chars, start + 17, dt.Second, 2);
						num5 = 23;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 == 0)
						{
							continue;
						}
						IL_00E6:
						DateTimeUtils.smethod_12(chars, start + 20, num7, num6);
						num5 = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 == 0)
						{
							goto IL_0109;
						}
						continue;
						IL_0129:
						chars[start + 10] = 'T';
						num5 = 20;
					}
					while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 == 0);
					goto IL_0054;
					Block_8:
					goto IL_0071;
					goto IL_0099;
					Block_10:
					goto IL_0071;
					Block_11:
					goto IL_0099;
					IL_0036:
					chars[start + 4] = '-';
					num5 = 6;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 != 0)
					{
						goto IL_0071;
					}
					goto IL_0226;
					IL_008D:
					DateTimeUtils.smethod_12(chars, start, num2, 4);
					goto IL_0036;
					IL_0054:
					num6--;
					num5 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 == 0)
					{
						goto IL_0099;
					}
					goto IL_0226;
					IL_0071:
					if (num7 % 10 == 0)
					{
						goto IL_0054;
					}
					num5 = 15;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 == 0)
					{
						goto IL_008D;
					}
					goto IL_0226;
					IL_0099:
					num7 /= 10;
					goto IL_0071;
				}
			}
			IL_02BD:
			IL_02BE:
			return start + num;
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00045C5C File Offset: 0x00043E5C
		private static void smethod_12(object object_0, int int_2, int int_3, int int_4)
		{
			for (;;)
			{
				if (int_4-- != 0)
				{
					goto IL_0036;
				}
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 == 0)
				{
					break;
				}
				IL_001A:
				switch (num)
				{
				case 1:
				case 3:
					continue;
				case 2:
					IL_0036:
					object_0[int_2 + int_4] = (ushort)(int_3 % 10 + 48);
					goto IL_0003;
				case 4:
					goto IL_0003;
				}
				break;
				IL_0003:
				int_3 /= 10;
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede != 0)
				{
					goto IL_001A;
				}
			}
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00045CD4 File Offset: 0x00043ED4
		internal static int WriteDateTimeOffset(char[] chars, int start, TimeSpan offset, DateFormatHandling format)
		{
			int num3;
			for (;;)
			{
				IL_0001:
				chars[start++] = ((offset.Ticks >= 0L) ? '+' : '-');
				int num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 == 0)
				{
					break;
				}
				for (;;)
				{
					int num2;
					switch (num)
					{
					case 0:
						goto IL_00D3;
					case 1:
						goto IL_0120;
					case 2:
						goto IL_012A;
					case 3:
						num2 = Math.Abs(offset.Hours);
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 == 0)
						{
							goto IL_00D3;
						}
						continue;
					case 4:
						goto IL_0001;
					case 5:
						goto IL_0057;
					case 6:
						chars[start++] = ':';
						num = 5;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad == 0)
						{
							goto Block_6;
						}
						continue;
					case 7:
						goto IL_007C;
					case 8:
						break;
					case 9:
						return start;
					default:
						goto IL_00D3;
					}
					IL_003A:
					if (format == DateFormatHandling.IsoDateFormat)
					{
						num = 6;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_207f975845fc40cdbe6b166fce664cd5 != 0)
						{
							goto Block_3;
						}
						continue;
					}
					IL_0057:
					num3 = Math.Abs(offset.Minutes);
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 == 0)
					{
						goto Block_4;
					}
					continue;
					IL_007C:
					start += 2;
					num = 6;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_253407eb812c4aefb734fa1e267fe779 == 0)
					{
						goto IL_003A;
					}
					continue;
					IL_00D3:
					DateTimeUtils.smethod_12(chars, start, num2, 2);
					goto IL_007C;
				}
			}
			goto IL_0120;
			Block_3:
			goto IL_012A;
			Block_4:
			Block_6:
			IL_0120:
			DateTimeUtils.smethod_12(chars, start, num3, 2);
			IL_012A:
			start += 2;
			return start;
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x00045E14 File Offset: 0x00044014
		internal static void WriteDateTimeOffsetString(TextWriter writer, DateTimeOffset value, DateFormatHandling format, [Nullable(2)] string formatString, CultureInfo culture)
		{
			while (StringUtils.IsNullOrEmpty(formatString))
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c != 0)
				{
					goto IL_0064;
				}
				IL_006F:
				char[] array;
				switch (num)
				{
				case 0:
					return;
				case 1:
					IL_0064:
					array = new char[64];
					goto IL_001A;
				case 2:
					continue;
				case 3:
					break;
				case 4:
					goto IL_001A;
				case 5:
					return;
				default:
					return;
				}
				IL_0045:
				int num2;
				writer.Write(array, 0, num2);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e != 0)
				{
					return;
				}
				goto IL_006F;
				IL_001A:
				num2 = DateTimeUtils.WriteDateTimeString(array, 0, (format != DateFormatHandling.IsoDateFormat) ? value.UtcDateTime : value.DateTime, new TimeSpan?(value.Offset), DateTimeKind.Local, format);
				goto IL_0045;
			}
			writer.Write(value.ToString(formatString, culture));
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x00045ED0 File Offset: 0x000440D0
		private static void smethod_13(DateTime dateTime_0, out int int_2, out int int_3, out int int_4)
		{
			int num;
			int[] array2;
			for (;;)
			{
				IL_01D6:
				num = (int)(dateTime_0.Ticks / 864000000000L);
				for (;;)
				{
					IL_01CA:
					int num2 = num / 146097;
					for (;;)
					{
						IL_01BB:
						num -= num2 * 146097;
						for (;;)
						{
							IL_0197:
							int num3 = num / 36524;
							int num4 = 22;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede != 0)
							{
								goto IL_003F;
							}
							int num5;
							do
							{
								IL_0124:
								switch (num4)
								{
								case 1:
									goto IL_003F;
								case 2:
									goto IL_0203;
								case 3:
									goto IL_0197;
								case 4:
									goto IL_01CA;
								case 5:
									goto IL_01D6;
								case 6:
									goto IL_0009;
								case 7:
									goto IL_011A;
								case 8:
									return;
								case 9:
									goto IL_01EC;
								case 10:
									goto IL_00D8;
								case 11:
								case 23:
									goto IL_01FA;
								case 12:
									goto IL_0025;
								case 13:
									goto IL_005A;
								case 14:
									goto IL_00FB;
								case 15:
								case 20:
									goto IL_01F4;
								case 16:
									goto IL_0110;
								case 17:
									goto IL_00A4;
								case 18:
									goto IL_0207;
								case 19:
									goto IL_01BB;
								case 21:
									goto IL_00AE;
								case 22:
									if (num3 == 4)
									{
										goto IL_00FB;
									}
									goto IL_00CB;
								case 24:
									goto IL_00CB;
								case 25:
									goto IL_0006;
								}
								goto Block_8;
								IL_00D8:
								num5 = num / 1461;
								num4 = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b != 0)
								{
									goto Block_7;
								}
								continue;
								IL_00CB:
								num -= num3 * 36524;
								goto IL_00D8;
								IL_00FB:
								num3 = 3;
								num4 = 24;
							}
							while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d == 0);
							IL_0110:
							bool flag = num3 == 3;
							goto IL_006D;
							IL_011A:
							int[] array = DateTimeUtils.int_0;
							goto IL_008B;
							Block_8:
							Block_7:
							goto IL_00BC;
							IL_0025:
							int num6;
							if (num6 != 3)
							{
								flag = false;
								goto IL_006D;
							}
							num4 = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 == 0)
							{
								goto IL_003F;
							}
							goto IL_0124;
							IL_005A:
							num -= num6 * 365;
							goto IL_0025;
							IL_0009:
							int_2 = num2 * 400 + num3 * 100 + num5 * 4 + num6 + 1;
							goto IL_005A;
							IL_0006:
							num6 = 3;
							goto IL_0009;
							IL_003F:
							if (num5 == 24)
							{
								num4 = 16;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 == 0)
								{
									goto IL_005A;
								}
								goto IL_0124;
							}
							else
							{
								flag = true;
							}
							IL_006D:
							if (!flag)
							{
								num4 = 7;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e == 0)
								{
									goto IL_00BC;
								}
								goto IL_0124;
							}
							else
							{
								array = DateTimeUtils.int_1;
							}
							IL_008B:
							array2 = array;
							num4 = 9;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 != 0)
							{
								goto IL_00BC;
							}
							goto IL_0124;
							IL_00AE:
							if (num6 == 4)
							{
								goto IL_0006;
							}
							goto IL_0009;
							IL_00A4:
							num6 = num / 365;
							goto IL_00AE;
							IL_00BC:
							num -= num5 * 1461;
							goto IL_00A4;
						}
					}
				}
			}
			IL_01EC:
			int num7 = num >> 6;
			goto IL_01FA;
			IL_01F4:
			num7++;
			IL_01FA:
			if (num >= array2[num7])
			{
				goto IL_01F4;
			}
			IL_0203:
			int_3 = num7;
			IL_0207:
			int_4 = num - array2[num7 - 1] + 1;
		}

		// Token: 0x040003C6 RID: 966
		internal static readonly long InitialJavaScriptDateTicks;

		// Token: 0x040003C7 RID: 967
		private static readonly int[] int_0;

		// Token: 0x040003C8 RID: 968
		private static readonly int[] int_1;
	}
}
