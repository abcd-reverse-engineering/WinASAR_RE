using System;
using System.Globalization;
using System.IO;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	// Token: 0x02000052 RID: 82
	[Nullable(0)]
	[NullableContext(1)]
	public static class JsonConvert
	{
		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000245 RID: 581 RVA: 0x00002977 File Offset: 0x00000B77
		// (set) Token: 0x06000246 RID: 582 RVA: 0x0000297E File Offset: 0x00000B7E
		[Nullable(new byte[] { 2, 1 })]
		public static Func<JsonSerializerSettings> DefaultSettings
		{
			[return: Nullable(new byte[] { 2, 1 })]
			get;
			[param: Nullable(new byte[] { 2, 1 })]
			set;
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00002986 File Offset: 0x00000B86
		public static string ToString(DateTime value)
		{
			return JsonConvert.ToString(value, DateFormatHandling.IsoDateFormat, DateTimeZoneHandling.RoundtripKind);
		}

		// Token: 0x06000248 RID: 584 RVA: 0x000271B4 File Offset: 0x000253B4
		public static string ToString(DateTime value, DateFormatHandling format, DateTimeZoneHandling timeZoneHandling)
		{
			for (;;)
			{
				DateTime dateTime = DateTimeUtils.EnsureDateTime(value, timeZoneHandling);
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb == 0)
				{
					switch (num)
					{
					case 1:
						goto IL_0037;
					case 2:
						continue;
					case 3:
						goto IL_0040;
					}
					break;
				}
				goto IL_0036;
			}
			string text;
			return text;
			IL_0036:
			IL_0037:
			StringWriter stringWriter = StringUtils.CreateStringWriter(64);
			IL_0040:
			try
			{
				stringWriter.Write('"');
				for (;;)
				{
					DateTime dateTime;
					DateTimeUtils.WriteDateTimeString(stringWriter, dateTime, format, null, CultureInfo.InvariantCulture);
					int num2 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa == 0)
					{
						goto IL_0069;
					}
					do
					{
						IL_004C:
						stringWriter.Write('"');
						num2 = 1;
					}
					while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba == 0);
					IL_0069:
					switch (num2)
					{
					case 0:
						goto IL_004C;
					case 1:
						goto IL_00A5;
					case 2:
						break;
					case 3:
						goto IL_00AE;
					default:
						goto IL_004C;
					}
				}
				IL_00A5:
				text = stringWriter.ToString();
				IL_00AE:;
			}
			finally
			{
				if (stringWriter != null)
				{
					int num3 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 == 0)
					{
						goto IL_00DE;
					}
					IL_00C6:
					((IDisposable)stringWriter).Dispose();
					num3 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba == 0)
					{
						goto IL_00EF;
					}
					IL_00DE:
					switch (num3)
					{
					case 1:
						goto IL_00C6;
					}
				}
				IL_00EF:;
			}
			return text;
		}

		// Token: 0x0600024A RID: 586 RVA: 0x000272C4 File Offset: 0x000254C4
		public static string ToString(DateTimeOffset value, DateFormatHandling format)
		{
			for (;;)
			{
				StringWriter stringWriter = StringUtils.CreateStringWriter(64);
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a != 0)
				{
					switch (num)
					{
					case 1:
						goto IL_0033;
					case 2:
						continue;
					}
					break;
				}
				goto IL_0032;
			}
			string text;
			return text;
			IL_0032:
			IL_0033:
			try
			{
				StringWriter stringWriter;
				stringWriter.Write('"');
				for (;;)
				{
					DateTimeUtils.WriteDateTimeOffsetString(stringWriter, value, format, null, CultureInfo.InvariantCulture);
					int num2 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c == 0)
					{
						goto IL_005C;
					}
					IL_0079:
					switch (num2)
					{
					case 1:
						IL_005C:
						stringWriter.Write('"');
						num2 = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 != 0)
						{
							goto IL_003F;
						}
						goto IL_0079;
					case 2:
						continue;
					case 3:
						goto IL_003F;
					}
					break;
					IL_003F:
					text = stringWriter.ToString();
					num2 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 == 0)
					{
						break;
					}
					goto IL_0079;
				}
			}
			finally
			{
				StringWriter stringWriter;
				if (stringWriter != null)
				{
					for (;;)
					{
						((IDisposable)stringWriter).Dispose();
						int num3 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 == 0)
						{
							break;
						}
						switch (num3)
						{
						case 1:
						case 2:
							goto IL_00E8;
						}
					}
				}
				IL_00E8:;
			}
			return text;
		}

		// Token: 0x0600024B RID: 587 RVA: 0x000273CC File Offset: 0x000255CC
		public static string ToString(bool value)
		{
			while (value)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae != 0)
				{
					switch (num)
					{
					case 1:
						continue;
					case 2:
						goto IL_0035;
					}
				}
				return JsonConvert.True;
			}
			IL_0035:
			return JsonConvert.False;
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00002990 File Offset: 0x00000B90
		public static string ToString(char value)
		{
			return JsonConvert.ToString(char.ToString(value), '"');
		}

		// Token: 0x0600024D RID: 589 RVA: 0x0000299F File Offset: 0x00000B9F
		public static string ToString(Enum value)
		{
			return value.ToString(Class15.smethod_17(2021163446 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8));
		}

		// Token: 0x0600024E RID: 590 RVA: 0x000029BC File Offset: 0x00000BBC
		public static string ToString(int value)
		{
			return value.ToString(null, CultureInfo.InvariantCulture);
		}

		// Token: 0x0600024F RID: 591 RVA: 0x000029CB File Offset: 0x00000BCB
		public static string ToString(short value)
		{
			return value.ToString(null, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000250 RID: 592 RVA: 0x000029DA File Offset: 0x00000BDA
		[CLSCompliant(false)]
		public static string ToString(ushort value)
		{
			return value.ToString(null, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000251 RID: 593 RVA: 0x000029E9 File Offset: 0x00000BE9
		[CLSCompliant(false)]
		public static string ToString(uint value)
		{
			return value.ToString(null, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000252 RID: 594 RVA: 0x000029F8 File Offset: 0x00000BF8
		public static string ToString(long value)
		{
			return value.ToString(null, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00002A07 File Offset: 0x00000C07
		private static string smethod_0(BigInteger bigInteger_0)
		{
			return bigInteger_0.ToString(null, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00002A16 File Offset: 0x00000C16
		[CLSCompliant(false)]
		public static string ToString(ulong value)
		{
			return value.ToString(null, CultureInfo.InvariantCulture);
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00002A25 File Offset: 0x00000C25
		public static string ToString(float value)
		{
			return JsonConvert.smethod_2((double)value, value.ToString(Class15.smethod_17(564896660 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610), CultureInfo.InvariantCulture));
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00002A4F File Offset: 0x00000C4F
		internal static string ToString(float value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable)
		{
			return JsonConvert.smethod_1((double)value, JsonConvert.smethod_2((double)value, value.ToString(Class15.smethod_17(1788744917 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c), CultureInfo.InvariantCulture)), floatFormatHandling, quoteChar, nullable);
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00027414 File Offset: 0x00025614
		private static string smethod_1(double double_0, string string_0, FloatFormatHandling floatFormatHandling_0, char char_0, bool bool_0)
		{
			while (floatFormatHandling_0 != FloatFormatHandling.Symbol)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 == 0)
				{
					goto IL_0036;
				}
				IL_004F:
				switch (num)
				{
				case 0:
					goto IL_0036;
				case 1:
					continue;
				case 2:
					return string_0;
				case 3:
				case 5:
					goto IL_0082;
				case 4:
					break;
				case 6:
					goto IL_009E;
				case 7:
					goto IL_00B8;
				default:
					goto IL_0036;
				}
				IL_0017:
				if (!double.IsNaN(double_0))
				{
					break;
				}
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 == 0)
				{
					goto IL_0082;
				}
				goto IL_004F;
				IL_0036:
				if (!double.IsInfinity(double_0))
				{
					goto IL_0017;
				}
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_52d717cd31b74287b67c03ee736a6211 != 0)
				{
					goto IL_004F;
				}
				IL_0082:
				if (floatFormatHandling_0 != FloatFormatHandling.DefaultValue)
				{
					return char_0.ToString() + string_0 + char_0.ToString();
				}
				IL_009E:
				if (!bool_0)
				{
					return Class15.smethod_17(2048529799 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18);
				}
				IL_00B8:
				return JsonConvert.Null;
			}
			return string_0;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00002A83 File Offset: 0x00000C83
		public static string ToString(double value)
		{
			return JsonConvert.smethod_2(value, value.ToString(Class15.smethod_17(1424584066 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf), CultureInfo.InvariantCulture));
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00002AAC File Offset: 0x00000CAC
		internal static string ToString(double value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable)
		{
			return JsonConvert.smethod_1(value, JsonConvert.smethod_2(value, value.ToString(Class15.smethod_17(926369255 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296), CultureInfo.InvariantCulture)), floatFormatHandling, quoteChar, nullable);
		}

		// Token: 0x0600025A RID: 602 RVA: 0x000274E0 File Offset: 0x000256E0
		private static string smethod_2(double double_0, string string_0)
		{
			for (;;)
			{
				if (!double.IsNaN(double_0))
				{
					goto IL_0062;
				}
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 == 0)
				{
					break;
				}
				IL_0014:
				switch (num)
				{
				case 1:
					continue;
				case 3:
					goto IL_0046;
				case 4:
					goto IL_0054;
				case 5:
					goto IL_0038;
				case 6:
					IL_0062:
					if (!double.IsInfinity(double_0))
					{
						goto IL_0054;
					}
					break;
				}
				break;
				IL_0038:
				if (StringUtils.IndexOf(string_0, 'e') == -1)
				{
					goto IL_0092;
				}
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_52d717cd31b74287b67c03ee736a6211 != 0)
				{
					goto IL_0014;
				}
				break;
				IL_0046:
				if (StringUtils.IndexOf(string_0, 'E') == -1)
				{
					goto IL_0038;
				}
				break;
				IL_0054:
				if (StringUtils.IndexOf(string_0, '.') == -1)
				{
					goto IL_0046;
				}
				break;
			}
			return string_0;
			IL_0092:
			return string_0 + Class15.smethod_17(2071405060 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808);
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0002759C File Offset: 0x0002579C
		private static string smethod_3(string string_0)
		{
			while (StringUtils.IndexOf(string_0, '.') != -1)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a != 0)
				{
					switch (num)
					{
					case 1:
						continue;
					}
				}
				return string_0;
			}
			return string_0 + Class15.smethod_17(1270975720 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112);
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00002ADE File Offset: 0x00000CDE
		public static string ToString(byte value)
		{
			return value.ToString(null, CultureInfo.InvariantCulture);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00002AED File Offset: 0x00000CED
		[CLSCompliant(false)]
		public static string ToString(sbyte value)
		{
			return value.ToString(null, CultureInfo.InvariantCulture);
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00002AFC File Offset: 0x00000CFC
		public static string ToString(decimal value)
		{
			return JsonConvert.smethod_3(value.ToString(null, CultureInfo.InvariantCulture));
		}

		// Token: 0x06000260 RID: 608 RVA: 0x000275FC File Offset: 0x000257FC
		internal static string ToString(Guid value, char quoteChar)
		{
			string text;
			string text2;
			for (;;)
			{
				text = value.ToString(Class15.smethod_17(1788744927 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c), CultureInfo.InvariantCulture);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff == 0)
				{
					goto IL_0003;
				}
				IL_0022:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					goto IL_006E;
				}
				IL_0003:
				text2 = quoteChar.ToString(CultureInfo.InvariantCulture);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f != 0)
				{
					goto IL_0022;
				}
				break;
			}
			IL_006E:
			return text2 + text + text2;
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00002B10 File Offset: 0x00000D10
		internal static string ToString(TimeSpan value, char quoteChar)
		{
			return JsonConvert.ToString(value.ToString(), quoteChar, StringEscapeHandling.Default);
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00027684 File Offset: 0x00025884
		public static string ToString([Nullable(2)] Uri value)
		{
			while (value == null)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f == 0)
				{
					switch (num)
					{
					case 1:
						continue;
					}
				}
				return JsonConvert.Null;
			}
			return JsonConvert.ToString(value, '"');
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00002B26 File Offset: 0x00000D26
		internal static string ToString(Uri value, char quoteChar)
		{
			return JsonConvert.ToString(value.OriginalString, quoteChar, StringEscapeHandling.Default);
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00002B35 File Offset: 0x00000D35
		public static string ToString([Nullable(2)] string value)
		{
			return JsonConvert.ToString(value, '"', StringEscapeHandling.Default);
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00002B40 File Offset: 0x00000D40
		public static string ToString([Nullable(2)] string value, char delimiter)
		{
			return JsonConvert.ToString(value, delimiter, StringEscapeHandling.Default);
		}

		// Token: 0x06000267 RID: 615 RVA: 0x000276D0 File Offset: 0x000258D0
		public static string ToString([Nullable(2)] string value, char delimiter, StringEscapeHandling stringEscapeHandling)
		{
			while (delimiter != '"')
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 == 0)
				{
					goto IL_0015;
				}
				IL_002B:
				switch (num)
				{
				case 1:
					IL_0015:
					if (delimiter == '\'')
					{
						goto IL_0078;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 == 0)
					{
						goto IL_002B;
					}
					break;
				case 2:
					continue;
				}
				throw new ArgumentException(Class15.smethod_17(552183288 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f), Class15.smethod_17(1116175381 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54));
			}
			IL_0078:
			return JavaScriptUtils.ToEscapedJavaScriptString(value, delimiter, true, stringEscapeHandling);
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00027760 File Offset: 0x00025960
		public static string ToString([Nullable(2)] object value)
		{
			while (value != null)
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c != 0)
				{
					goto IL_00DB;
				}
				IL_00ED:
				switch (num)
				{
				case 0:
					goto IL_0242;
				case 1:
					goto IL_00DB;
				case 2:
					continue;
				case 3:
					break;
				case 4:
					goto IL_020B;
				case 5:
					goto IL_0217;
				default:
					goto IL_0242;
				}
				IL_0020:
				PrimitiveTypeCode typeCode;
				switch (typeCode)
				{
				case PrimitiveTypeCode.Char:
					return JsonConvert.ToString((char)value);
				case PrimitiveTypeCode.CharNullable:
				case PrimitiveTypeCode.BooleanNullable:
				case PrimitiveTypeCode.SByteNullable:
				case PrimitiveTypeCode.Int16Nullable:
				case PrimitiveTypeCode.UInt16Nullable:
				case PrimitiveTypeCode.Int32Nullable:
				case PrimitiveTypeCode.ByteNullable:
				case PrimitiveTypeCode.UInt32Nullable:
				case PrimitiveTypeCode.Int64Nullable:
				case PrimitiveTypeCode.UInt64Nullable:
				case PrimitiveTypeCode.SingleNullable:
				case PrimitiveTypeCode.DoubleNullable:
				case PrimitiveTypeCode.DateTimeNullable:
				case PrimitiveTypeCode.DateTimeOffsetNullable:
				case PrimitiveTypeCode.DecimalNullable:
				case PrimitiveTypeCode.GuidNullable:
				case PrimitiveTypeCode.TimeSpanNullable:
				case PrimitiveTypeCode.BigIntegerNullable:
				case PrimitiveTypeCode.Bytes:
					IL_0217:
					throw new ArgumentException(Class15.smethod_17(1807881240 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3).FormatWith(CultureInfo.InvariantCulture, value.GetType()));
				case PrimitiveTypeCode.Boolean:
					return JsonConvert.ToString((bool)value);
				case PrimitiveTypeCode.SByte:
					return JsonConvert.ToString((sbyte)value);
				case PrimitiveTypeCode.Int16:
					return JsonConvert.ToString((short)value);
				case PrimitiveTypeCode.UInt16:
					return JsonConvert.ToString((ushort)value);
				case PrimitiveTypeCode.Int32:
					return JsonConvert.ToString((int)value);
				case PrimitiveTypeCode.Byte:
					return JsonConvert.ToString((byte)value);
				case PrimitiveTypeCode.UInt32:
					return JsonConvert.ToString((uint)value);
				case PrimitiveTypeCode.Int64:
					return JsonConvert.ToString((long)value);
				case PrimitiveTypeCode.UInt64:
					return JsonConvert.ToString((ulong)value);
				case PrimitiveTypeCode.Single:
					return JsonConvert.ToString((float)value);
				case PrimitiveTypeCode.Double:
					return JsonConvert.ToString((double)value);
				case PrimitiveTypeCode.DateTime:
					return JsonConvert.ToString((DateTime)value);
				case PrimitiveTypeCode.DateTimeOffset:
					return JsonConvert.ToString((DateTimeOffset)value, DateFormatHandling.IsoDateFormat);
				case PrimitiveTypeCode.Decimal:
					return JsonConvert.ToString((decimal)value);
				case PrimitiveTypeCode.Guid:
					return JsonConvert.ToString((Guid)value, '"');
				case PrimitiveTypeCode.TimeSpan:
					return JsonConvert.ToString((TimeSpan)value, '"');
				case PrimitiveTypeCode.BigInteger:
					return JsonConvert.smethod_0((BigInteger)value);
				case PrimitiveTypeCode.Uri:
					return JsonConvert.ToString((Uri)value);
				case PrimitiveTypeCode.String:
					IL_020B:
					return JsonConvert.ToString((string)value);
				case PrimitiveTypeCode.DBNull:
					return JsonConvert.Null;
				default:
					num = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c != 0)
					{
						goto IL_00ED;
					}
					break;
				}
				IL_00DB:
				typeCode = ConvertUtils.GetTypeCode(value.GetType());
				goto IL_0020;
			}
			IL_0242:
			return JsonConvert.Null;
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00002B4A File Offset: 0x00000D4A
		public static string SerializeObject([Nullable(2)] object value)
		{
			return JsonConvert.SerializeObject(value, null, null);
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00002B54 File Offset: 0x00000D54
		public static string SerializeObject([Nullable(2)] object value, Formatting formatting)
		{
			return JsonConvert.SerializeObject(value, formatting, null);
		}

		// Token: 0x0600026B RID: 619 RVA: 0x000279B4 File Offset: 0x00025BB4
		public static string SerializeObject([Nullable(2)] object value, params JsonConverter[] converters)
		{
			for (;;)
			{
				if (converters != null)
				{
					goto IL_0034;
				}
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a == 0)
				{
					break;
				}
				IL_0014:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					goto IL_0059;
				case 3:
					goto IL_006A;
				case 4:
					IL_0034:
					if (converters.Length != 0)
					{
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 != 0)
						{
							goto IL_0014;
						}
						goto IL_0058;
					}
					break;
				}
				break;
			}
			goto IL_0067;
			IL_0058:
			IL_0059:
			JsonSerializerSettings jsonSerializerSettings;
			(jsonSerializerSettings = new JsonSerializerSettings()).Converters = converters;
			goto IL_0068;
			IL_0067:
			jsonSerializerSettings = null;
			IL_0068:
			JsonSerializerSettings jsonSerializerSettings2 = jsonSerializerSettings;
			IL_006A:
			return JsonConvert.SerializeObject(value, null, jsonSerializerSettings2);
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00027A34 File Offset: 0x00025C34
		public static string SerializeObject([Nullable(2)] object value, Formatting formatting, params JsonConverter[] converters)
		{
			JsonSerializerSettings jsonSerializerSettings2;
			for (;;)
			{
				if (converters == null)
				{
					goto IL_003E;
				}
				goto IL_0055;
				IL_0022:
				int num;
				JsonSerializerSettings jsonSerializerSettings;
				switch (num)
				{
				case 1:
					IL_0055:
					if (converters.Length != 0)
					{
						(jsonSerializerSettings = new JsonSerializerSettings()).Converters = converters;
						goto IL_000F;
					}
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 == 0)
					{
						goto IL_003E;
					}
					goto IL_0022;
				case 2:
				case 3:
					goto IL_003E;
				case 4:
					continue;
				}
				break;
				IL_000F:
				jsonSerializerSettings2 = jsonSerializerSettings;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 != 0)
				{
					goto IL_0022;
				}
				break;
				IL_003E:
				jsonSerializerSettings = null;
				goto IL_000F;
			}
			return JsonConvert.SerializeObject(value, null, formatting, jsonSerializerSettings2);
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00002B5E File Offset: 0x00000D5E
		[NullableContext(2)]
		[return: Nullable(1)]
		public static string SerializeObject(object value, JsonSerializerSettings settings)
		{
			return JsonConvert.SerializeObject(value, null, settings);
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00027AB0 File Offset: 0x00025CB0
		[NullableContext(2)]
		[return: Nullable(1)]
		public static string SerializeObject(object value, Type type, JsonSerializerSettings settings)
		{
			JsonSerializer jsonSerializer;
			for (;;)
			{
				jsonSerializer = JsonSerializer.CreateDefault(settings);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 != 0)
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
			return JsonConvert.smethod_4(value, type, jsonSerializer);
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00002B68 File Offset: 0x00000D68
		[NullableContext(2)]
		[return: Nullable(1)]
		public static string SerializeObject(object value, Formatting formatting, JsonSerializerSettings settings)
		{
			return JsonConvert.SerializeObject(value, null, formatting, settings);
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00027AF4 File Offset: 0x00025CF4
		[NullableContext(2)]
		[return: Nullable(1)]
		public static string SerializeObject(object value, Type type, Formatting formatting, JsonSerializerSettings settings)
		{
			JsonSerializer jsonSerializer;
			for (;;)
			{
				jsonSerializer = JsonSerializer.CreateDefault(settings);
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c != 0)
				{
					goto IL_0003;
				}
				IL_001C:
				switch (num)
				{
				case 1:
					IL_0003:
					jsonSerializer.Formatting = formatting;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 == 0)
					{
						goto IL_001C;
					}
					break;
				case 2:
					continue;
				}
				break;
			}
			return JsonConvert.smethod_4(value, type, jsonSerializer);
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00027B58 File Offset: 0x00025D58
		private static string smethod_4([Nullable(2)] object value, [Nullable(2)] Type type, JsonSerializer jsonSerializer_0)
		{
			StringWriter stringWriter;
			JsonTextWriter jsonTextWriter;
			for (;;)
			{
				stringWriter = new StringWriter(new StringBuilder(256), CultureInfo.InvariantCulture);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 == 0)
				{
					goto IL_0003;
				}
				IL_001D:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					goto IL_0060;
				case 3:
					goto IL_00F0;
				}
				IL_0003:
				jsonTextWriter = new JsonTextWriter(stringWriter);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d != 0)
				{
					goto IL_001D;
				}
			}
			IL_0060:
			try
			{
				jsonTextWriter.Formatting = jsonSerializer_0.Formatting;
				int num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 != 0)
				{
					goto IL_009E;
				}
				do
				{
					IL_0080:
					jsonSerializer_0.Serialize(jsonTextWriter, value, type);
					num2 = 1;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 != 0);
				IL_009E:
				switch (num2)
				{
				case 0:
					goto IL_0080;
				case 1:
					break;
				default:
					goto IL_0080;
				}
			}
			finally
			{
				if (jsonTextWriter != null)
				{
					int num3 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 != 0)
					{
						goto IL_00DE;
					}
					IL_00C6:
					((IDisposable)jsonTextWriter).Dispose();
					num3 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa != 0)
					{
						goto IL_00EF;
					}
					IL_00DE:
					switch (num3)
					{
					case 1:
						goto IL_00C6;
					}
				}
				IL_00EF:;
			}
			IL_00F0:
			return stringWriter.ToString();
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00002B73 File Offset: 0x00000D73
		[return: Nullable(2)]
		public static object DeserializeObject(string value)
		{
			return JsonConvert.DeserializeObject(value, null, null);
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00002B7D File Offset: 0x00000D7D
		[return: Nullable(2)]
		public static object DeserializeObject(string value, JsonSerializerSettings settings)
		{
			return JsonConvert.DeserializeObject(value, null, settings);
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00002B87 File Offset: 0x00000D87
		[return: Nullable(2)]
		public static object DeserializeObject(string value, Type type)
		{
			return JsonConvert.DeserializeObject(value, type, null);
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00002B91 File Offset: 0x00000D91
		[NullableContext(2)]
		public static T DeserializeObject<T>([Nullable(1)] string value)
		{
			return JsonConvert.DeserializeObject<T>(value, null);
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00002B9A File Offset: 0x00000D9A
		[return: Nullable(2)]
		public static T DeserializeAnonymousType<[Nullable(2)] T>(string value, T anonymousTypeObject)
		{
			return JsonConvert.DeserializeObject<T>(value);
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00002BA2 File Offset: 0x00000DA2
		[return: Nullable(2)]
		public static T DeserializeAnonymousType<[Nullable(2)] T>(string value, T anonymousTypeObject, JsonSerializerSettings settings)
		{
			return JsonConvert.DeserializeObject<T>(value, settings);
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00002BAB File Offset: 0x00000DAB
		[return: Nullable(2)]
		public static T DeserializeObject<[Nullable(2)] T>(string value, params JsonConverter[] converters)
		{
			return (T)((object)JsonConvert.DeserializeObject(value, typeof(T), converters));
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00002BC3 File Offset: 0x00000DC3
		[NullableContext(2)]
		public static T DeserializeObject<T>([Nullable(1)] string value, JsonSerializerSettings settings)
		{
			return (T)((object)JsonConvert.DeserializeObject(value, typeof(T), settings));
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00027C6C File Offset: 0x00025E6C
		[return: Nullable(2)]
		public static object DeserializeObject(string value, Type type, params JsonConverter[] converters)
		{
			JsonSerializerSettings jsonSerializerSettings;
			for (;;)
			{
				if (converters == null)
				{
					goto IL_0045;
				}
				goto IL_005C;
				IL_0022:
				int num;
				switch (num)
				{
				case 0:
					goto IL_0003;
				case 1:
					goto IL_0069;
				case 2:
				case 3:
					goto IL_0045;
				case 4:
					continue;
				case 5:
					IL_005C:
					if (converters.Length == 0)
					{
						goto IL_0045;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff != 0)
					{
						goto IL_0003;
					}
					goto IL_0022;
				default:
					goto IL_0003;
				}
				IL_000F:
				JsonSerializerSettings jsonSerializerSettings2;
				jsonSerializerSettings = jsonSerializerSettings2;
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede == 0)
				{
					goto IL_0022;
				}
				IL_0003:
				(jsonSerializerSettings2 = new JsonSerializerSettings()).Converters = converters;
				goto IL_000F;
				IL_0045:
				jsonSerializerSettings2 = null;
				goto IL_000F;
			}
			IL_0069:
			return JsonConvert.DeserializeObject(value, type, jsonSerializerSettings);
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00027CEC File Offset: 0x00025EEC
		[NullableContext(2)]
		public static object DeserializeObject([Nullable(1)] string value, Type type, JsonSerializerSettings settings)
		{
			JsonTextReader jsonTextReader;
			object obj;
			JsonSerializer jsonSerializer;
			for (;;)
			{
				ValidationUtils.ArgumentNotNull(value, Class15.smethod_17(299944497 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e));
				int num = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 == 0)
				{
					goto IL_000E;
				}
				goto IL_0066;
				do
				{
					IL_0045:
					jsonTextReader = new JsonTextReader(new StringReader(value));
					num = 5;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad == 0);
				IL_0066:
				switch (num)
				{
				case 0:
				case 2:
					goto IL_0045;
				case 1:
					goto IL_002B;
				case 3:
					return obj;
				case 4:
					break;
				case 5:
					goto IL_00C0;
				case 6:
					jsonSerializer = JsonSerializer.CreateDefault(settings);
					break;
				case 7:
					continue;
				default:
					goto IL_0045;
				}
				IL_000E:
				if (jsonSerializer.IsCheckAdditionalContentSet())
				{
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 == 0)
					{
						goto IL_0045;
					}
					goto IL_0066;
				}
				IL_002B:
				jsonSerializer.CheckAdditionalContent = true;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 == 0)
				{
					goto IL_0045;
				}
				goto IL_0066;
			}
			IL_00C0:
			try
			{
				obj = jsonSerializer.Deserialize(jsonTextReader, type);
				int num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 == 0)
				{
					switch (num2)
					{
					}
				}
			}
			finally
			{
				if (jsonTextReader != null)
				{
					int num3 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e != 0)
					{
						goto IL_011A;
					}
					IL_0102:
					((IDisposable)jsonTextReader).Dispose();
					num3 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 == 0)
					{
						goto IL_012B;
					}
					IL_011A:
					switch (num3)
					{
					case 1:
						goto IL_0102;
					}
				}
				IL_012B:;
			}
			return obj;
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00027E38 File Offset: 0x00026038
		public static void PopulateObject(string value, object target)
		{
			for (;;)
			{
				JsonConvert.PopulateObject(value, target, null);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 != 0)
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

		// Token: 0x0600027D RID: 637 RVA: 0x00027E70 File Offset: 0x00026070
		public static void PopulateObject(string value, object target, [Nullable(2)] JsonSerializerSettings settings)
		{
			for (;;)
			{
				IL_003C:
				JsonSerializer jsonSerializer = JsonSerializer.CreateDefault(settings);
				for (;;)
				{
					JsonReader jsonReader = new JsonTextReader(new StringReader(value));
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 != 0)
					{
						switch (num)
						{
						case 1:
							goto IL_0047;
						case 2:
							continue;
						case 3:
							goto IL_003C;
						}
						goto Block_2;
					}
					goto IL_0046;
				}
			}
			Block_2:
			return;
			IL_0046:
			IL_0047:
			try
			{
				JsonSerializer jsonSerializer;
				JsonReader jsonReader;
				jsonSerializer.Populate(jsonReader, target);
				int num2 = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 == 0)
				{
					goto IL_00AA;
				}
				for (;;)
				{
					IL_00B5:
					switch (num2)
					{
					case 1:
						goto IL_00E1;
					case 2:
						goto IL_0066;
					case 3:
					case 4:
					case 6:
						goto IL_00FE;
					case 5:
						if (settings == null)
						{
							num2 = 3;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 != 0)
							{
								goto Block_10;
							}
							continue;
						}
						break;
					case 7:
						goto IL_0073;
					}
					goto Block_12;
				}
				Block_10:
				goto IL_00FE;
				Block_12:
				goto IL_00AA;
				IL_0066:
				if (jsonReader.TokenType != JsonToken.Comment)
				{
					num2 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 == 0)
					{
						goto IL_00E1;
					}
					goto IL_00B5;
				}
				IL_0073:
				if (!jsonReader.Read())
				{
					goto IL_00FE;
				}
				goto IL_0066;
				IL_00AA:
				if (!settings.CheckAdditionalContent)
				{
					goto IL_00FE;
				}
				goto IL_0073;
				IL_00E1:
				throw JsonSerializationException.Create(jsonReader, Class15.smethod_17(2008559453 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb));
				IL_00FE:;
			}
			finally
			{
				JsonReader jsonReader;
				if (jsonReader != null)
				{
					for (;;)
					{
						((IDisposable)jsonReader).Dispose();
						int num3 = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 == 0)
						{
							break;
						}
						switch (num3)
						{
						case 1:
						case 2:
							goto IL_0131;
						}
					}
				}
				IL_0131:;
			}
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00002BDB File Offset: 0x00000DDB
		public static string SerializeXmlNode([Nullable(2)] XmlNode node)
		{
			return JsonConvert.SerializeXmlNode(node, Formatting.None);
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00027FC0 File Offset: 0x000261C0
		public static string SerializeXmlNode([Nullable(2)] XmlNode node, Formatting formatting)
		{
			XmlNodeConverter xmlNodeConverter;
			for (;;)
			{
				xmlNodeConverter = new XmlNodeConverter();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 != 0)
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
			return JsonConvert.SerializeObject(node, formatting, new JsonConverter[] { xmlNodeConverter });
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0002800C File Offset: 0x0002620C
		public static string SerializeXmlNode([Nullable(2)] XmlNode node, Formatting formatting, bool omitRootObject)
		{
			XmlNodeConverter xmlNodeConverter;
			for (;;)
			{
				xmlNodeConverter = new XmlNodeConverter
				{
					OmitRootObject = omitRootObject
				};
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 == 0)
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
			return JsonConvert.SerializeObject(node, formatting, new JsonConverter[] { xmlNodeConverter });
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00002BE4 File Offset: 0x00000DE4
		[return: Nullable(2)]
		public static XmlDocument DeserializeXmlNode(string value)
		{
			return JsonConvert.DeserializeXmlNode(value, null, false);
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00002BEE File Offset: 0x00000DEE
		[NullableContext(2)]
		public static XmlDocument DeserializeXmlNode([Nullable(1)] string value, string deserializeRootElementName, bool writeArrayAttribute)
		{
			return JsonConvert.DeserializeXmlNode(value, deserializeRootElementName, writeArrayAttribute, false);
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0002805C File Offset: 0x0002625C
		[NullableContext(2)]
		public static XmlDocument DeserializeXmlNode([Nullable(1)] string value, string deserializeRootElementName, bool writeArrayAttribute, bool encodeSpecialCharacters)
		{
			XmlNodeConverter xmlNodeConverter;
			for (;;)
			{
				xmlNodeConverter = new XmlNodeConverter();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 == 0)
				{
					goto IL_0029;
				}
				goto IL_0045;
				IL_0003:
				xmlNodeConverter.EncodeSpecialCharacters = encodeSpecialCharacters;
				num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 == 0)
				{
					continue;
				}
				goto IL_0045;
				IL_001F:
				xmlNodeConverter.WriteArrayAttribute = writeArrayAttribute;
				goto IL_0003;
				IL_0029:
				xmlNodeConverter.DeserializeRootElementName = deserializeRootElementName;
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e == 0)
				{
					goto IL_001F;
				}
				IL_0045:
				switch (num)
				{
				case 0:
					goto IL_0029;
				case 1:
					break;
				case 2:
					goto IL_001F;
				case 3:
					goto IL_0003;
				case 4:
					goto IL_007D;
				default:
					goto IL_0029;
				}
			}
			IL_007D:
			return (XmlDocument)JsonConvert.DeserializeObject(value, typeof(XmlDocument), new JsonConverter[] { xmlNodeConverter });
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00002BF9 File Offset: 0x00000DF9
		public static string SerializeXNode([Nullable(2)] XObject node)
		{
			return JsonConvert.SerializeXNode(node, Formatting.None, false);
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00028108 File Offset: 0x00026308
		public static string SerializeXNode([Nullable(2)] XObject node, Formatting formatting, bool omitRootObject)
		{
			XmlNodeConverter xmlNodeConverter;
			for (;;)
			{
				xmlNodeConverter = new XmlNodeConverter
				{
					OmitRootObject = omitRootObject
				};
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 == 0)
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
			return JsonConvert.SerializeObject(node, formatting, new JsonConverter[] { xmlNodeConverter });
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00002C03 File Offset: 0x00000E03
		[return: Nullable(2)]
		public static XDocument DeserializeXNode(string value)
		{
			return JsonConvert.DeserializeXNode(value, null, false);
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00002C0D File Offset: 0x00000E0D
		[NullableContext(2)]
		public static XDocument DeserializeXNode([Nullable(1)] string value, string deserializeRootElementName, bool writeArrayAttribute)
		{
			return JsonConvert.DeserializeXNode(value, deserializeRootElementName, writeArrayAttribute, false);
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00028158 File Offset: 0x00026358
		[NullableContext(2)]
		public static XDocument DeserializeXNode([Nullable(1)] string value, string deserializeRootElementName, bool writeArrayAttribute, bool encodeSpecialCharacters)
		{
			XmlNodeConverter xmlNodeConverter;
			for (;;)
			{
				IL_0045:
				xmlNodeConverter = new XmlNodeConverter();
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 == 0)
				{
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						xmlNodeConverter.DeserializeRootElementName = deserializeRootElementName;
						goto IL_0003;
					case 2:
						goto IL_0045;
					case 3:
						goto IL_0069;
					case 4:
						goto IL_0003;
					}
					goto Block_2;
					IL_0003:
					xmlNodeConverter.WriteArrayAttribute = writeArrayAttribute;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 == 0)
					{
						goto Block_1;
					}
				}
			}
			Block_1:
			Block_2:
			xmlNodeConverter.EncodeSpecialCharacters = encodeSpecialCharacters;
			IL_0069:
			return (XDocument)JsonConvert.DeserializeObject(value, typeof(XDocument), new JsonConverter[] { xmlNodeConverter });
		}

		// Token: 0x0600028C RID: 652 RVA: 0x000281F0 File Offset: 0x000263F0
		static JsonConvert()
		{
			for (;;)
			{
				IL_0179:
				for (;;)
				{
					IL_0164:
					int num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa == 0)
					{
						goto IL_0109;
					}
					for (;;)
					{
						IL_0134:
						switch (num)
						{
						case 1:
							goto IL_00DB;
						case 2:
							goto IL_0109;
						case 3:
							goto IL_0035;
						case 4:
							goto IL_00AF;
						case 5:
							goto IL_0164;
						case 6:
							goto IL_0179;
						case 7:
							goto IL_0080;
						case 8:
							JsonConvert.Null = Class15.smethod_17(1788637618 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1);
							num = 7;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a != 0)
							{
								goto IL_0080;
							}
							continue;
						case 9:
							goto IL_0006;
						}
						return;
						IL_0006:
						JsonConvert.False = Class15.smethod_17(1396567958 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7);
						num = 8;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 != 0)
						{
							continue;
						}
						IL_0035:
						JsonConvert.True = Class15.smethod_17(1603801468 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c);
						goto IL_0006;
						IL_0080:
						JsonConvert.Undefined = Class15.smethod_17(124833412 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719);
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c != 0)
						{
							continue;
						}
						IL_00AF:
						JsonConvert.PositiveInfinity = Class15.smethod_17(1807881862 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3);
						num = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 == 0)
						{
							continue;
						}
						IL_00DB:
						JsonConvert.NaN = Class15.smethod_17(2060602248 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177);
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a != 0)
						{
							return;
						}
					}
					IL_0109:
					JsonConvert.NegativeInfinity = Class15.smethod_17(698996654 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a);
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_207f975845fc40cdbe6b166fce664cd5 == 0)
					{
						goto IL_0134;
					}
					return;
				}
			}
		}

		// Token: 0x040001DF RID: 479
		[CompilerGenerated]
		[Nullable(new byte[] { 2, 1 })]
		private static Func<JsonSerializerSettings> func_0;

		// Token: 0x040001E0 RID: 480
		public static readonly string True;

		// Token: 0x040001E1 RID: 481
		public static readonly string False;

		// Token: 0x040001E2 RID: 482
		public static readonly string Null;

		// Token: 0x040001E3 RID: 483
		public static readonly string Undefined;

		// Token: 0x040001E4 RID: 484
		public static readonly string PositiveInfinity;

		// Token: 0x040001E5 RID: 485
		public static readonly string NegativeInfinity;

		// Token: 0x040001E6 RID: 486
		public static readonly string NaN;
	}
}
