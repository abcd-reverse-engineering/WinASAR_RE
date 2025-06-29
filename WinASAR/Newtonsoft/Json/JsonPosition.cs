using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	// Token: 0x0200005E RID: 94
	[NullableContext(1)]
	[Nullable(0)]
	internal struct JsonPosition
	{
		// Token: 0x060002D8 RID: 728 RVA: 0x00028AE8 File Offset: 0x00026CE8
		public JsonPosition(JsonContainerType type)
		{
			for (;;)
			{
				int num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 == 0)
				{
					goto IL_0027;
				}
				IL_004E:
				switch (num)
				{
				case 1:
					goto IL_0040;
				case 2:
					IL_0027:
					this.Type = type;
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e != 0)
					{
						goto IL_0040;
					}
					goto IL_004E;
				case 3:
					continue;
				case 4:
					goto IL_001E;
				case 5:
					goto IL_0003;
				}
				break;
				IL_0003:
				this.PropertyName = null;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 == 0)
				{
					break;
				}
				goto IL_004E;
				IL_001E:
				this.Position = -1;
				goto IL_0003;
				IL_0040:
				this.HasIndex = JsonPosition.TypeHasIndex(type);
				goto IL_001E;
			}
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00028B7C File Offset: 0x00026D7C
		internal int CalculateLength()
		{
			JsonContainerType type;
			for (;;)
			{
				type = this.Type;
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 != 0)
				{
					goto IL_0003;
				}
				IL_0019:
				switch (num)
				{
				case 1:
					goto IL_0052;
				case 2:
					goto IL_0059;
				case 3:
					IL_0003:
					if (type != JsonContainerType.Object)
					{
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a == 0)
						{
							goto IL_0019;
						}
						goto IL_0051;
					}
					break;
				case 4:
					continue;
				}
				break;
			}
			goto IL_0083;
			IL_0051:
			IL_0052:
			if (type - JsonContainerType.Array <= 1)
			{
				return MathUtils.IntLength((ulong)((long)this.Position)) + 2;
			}
			IL_0059:
			throw new ArgumentOutOfRangeException(Class15.smethod_17(676706270 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b));
			IL_0083:
			return this.PropertyName.Length + 5;
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00028C1C File Offset: 0x00026E1C
		[NullableContext(2)]
		internal void WriteTo([Nullable(1)] StringBuilder sb, ref StringWriter writer, ref char[] buffer)
		{
			string propertyName;
			for (;;)
			{
				IL_019A:
				JsonContainerType type = this.Type;
				for (;;)
				{
					if (type != JsonContainerType.Object)
					{
						goto IL_00ED;
					}
					propertyName = this.PropertyName;
					goto IL_0173;
					IL_0102:
					int num;
					switch (num)
					{
					case 1:
						goto IL_00CD;
					case 2:
						continue;
					case 3:
						goto IL_019A;
					case 4:
						IL_00ED:
						if (type - JsonContainerType.Array <= 1)
						{
							sb.Append('[');
							goto IL_00AE;
						}
						return;
					case 5:
						goto IL_009D;
					case 6:
						return;
					case 7:
					case 8:
						goto IL_01A8;
					case 9:
						goto IL_00A1;
					case 10:
						return;
					case 11:
						return;
					case 12:
						goto IL_00AE;
					case 13:
						goto IL_0156;
					case 14:
						IL_0173:
						if (propertyName.IndexOfAny(JsonPosition.char_0) != -1)
						{
							goto IL_006F;
						}
						if (sb.Length <= 0)
						{
							goto Block_1;
						}
						goto IL_0156;
					case 15:
						goto IL_006F;
					case 16:
					case 18:
						goto IL_0025;
					case 17:
						goto IL_0039;
					}
					goto Block_5;
					IL_0039:
					sb.Append(Class15.smethod_17(2060601896 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177));
					num = 11;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 == 0)
					{
						break;
					}
					goto IL_0102;
					IL_0025:
					JavaScriptUtils.WriteEscapedJavaScriptString(writer, propertyName, '\'', false, JavaScriptUtils.SingleQuoteCharEscapeFlags, StringEscapeHandling.Default, null, ref buffer);
					goto IL_0039;
					IL_009D:
					if (writer == null)
					{
						goto IL_00A1;
					}
					goto IL_0025;
					IL_006F:
					sb.Append(Class15.smethod_17(1802349087 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4));
					num = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b != 0)
					{
						goto IL_009D;
					}
					goto IL_0102;
					IL_00AE:
					sb.Append(this.Position);
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 != 0)
					{
						goto IL_0102;
					}
					IL_00CD:
					sb.Append(']');
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 != 0)
					{
						goto Block_3;
					}
					goto IL_0102;
					IL_0156:
					sb.Append('.');
					num = 8;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_52d717cd31b74287b67c03ee736a6211 == 0)
					{
						goto Block_6;
					}
					goto IL_0102;
					IL_00A1:
					writer = new StringWriter(sb);
					goto IL_0025;
				}
			}
			Block_1:
			goto IL_01A8;
			Block_3:
			Block_5:
			return;
			Block_6:
			IL_01A8:
			sb.Append(propertyName);
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00028DE0 File Offset: 0x00026FE0
		internal static bool TypeHasIndex(JsonContainerType type)
		{
			while (type != JsonContainerType.Array)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 == 0)
				{
					switch (num)
					{
					case 1:
						continue;
					}
				}
				return type == JsonContainerType.Constructor;
			}
			return true;
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00028E20 File Offset: 0x00027020
		internal static string BuildPath(List<JsonPosition> positions, JsonPosition? currentPosition)
		{
			int num = 0;
			if (positions != null)
			{
				for (int i = 0; i < positions.Count; i++)
				{
					num += positions[i].CalculateLength();
				}
			}
			if (currentPosition != null)
			{
				num += currentPosition.GetValueOrDefault().CalculateLength();
			}
			StringBuilder stringBuilder = new StringBuilder(num);
			StringWriter stringWriter = null;
			char[] array = null;
			if (positions != null)
			{
				foreach (JsonPosition jsonPosition in positions)
				{
					jsonPosition.WriteTo(stringBuilder, ref stringWriter, ref array);
				}
			}
			if (currentPosition != null)
			{
				currentPosition.GetValueOrDefault().WriteTo(stringBuilder, ref stringWriter, ref array);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060002DD RID: 733 RVA: 0x00028EF4 File Offset: 0x000270F4
		internal static string FormatMessage([Nullable(2)] IJsonLineInfo lineInfo, string path, string message)
		{
			for (;;)
			{
				if (message.EndsWith(Environment.NewLine, StringComparison.Ordinal))
				{
					goto IL_0035;
				}
				goto IL_00EE;
				IL_0071:
				int num;
				switch (num)
				{
				case 1:
				case 6:
					goto IL_0035;
				case 2:
					goto IL_00AD;
				case 3:
					return message;
				case 4:
					IL_00EE:
					message = message.Trim();
					goto IL_00DE;
				case 5:
					goto IL_00DE;
				case 7:
					continue;
				case 8:
					goto IL_0113;
				case 9:
					goto IL_0006;
				case 10:
				case 11:
					goto IL_0158;
				case 12:
					goto IL_011B;
				}
				break;
				IL_0006:
				message += Class15.smethod_17(1042099931 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e != 0)
				{
					goto IL_0071;
				}
				IL_0035:
				message += Class15.smethod_17(1387474800 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923).FormatWith(CultureInfo.InvariantCulture, path);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a != 0)
				{
					goto IL_0071;
				}
				break;
				IL_00AD:
				message += Class15.smethod_17(974446959 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f);
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 != 0)
				{
					break;
				}
				goto IL_0071;
				IL_00DE:
				if (!message.EndsWith('.'))
				{
					goto IL_0006;
				}
				goto IL_00AD;
			}
			if (lineInfo == null)
			{
				goto IL_0158;
			}
			IL_0113:
			if (!lineInfo.HasLineInfo())
			{
				goto IL_0158;
			}
			IL_011B:
			message += Class15.smethod_17(552183334 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f).FormatWith(CultureInfo.InvariantCulture, lineInfo.LineNumber, lineInfo.LinePosition);
			IL_0158:
			message += Class15.smethod_17(1603801262 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c);
			return message;
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00029078 File Offset: 0x00027278
		static JsonPosition()
		{
			for (;;)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 != 0)
				{
					goto IL_002E;
				}
				IL_0043:
				switch (num)
				{
				case 1:
					IL_002E:
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 == 0)
					{
						goto IL_0003;
					}
					goto IL_0043;
				case 2:
					continue;
				case 3:
					goto IL_0003;
				}
				break;
				IL_0003:
				JsonPosition.char_0 = new char[]
				{
					'.', ' ', '\'', '/', '"', '[', ']', '(', ')', '\t',
					'\n', '\r', '\f', '\b', '\\', '\u0085', '\u2028', '\u2029'
				};
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 != 0)
				{
					break;
				}
				goto IL_0043;
			}
		}

		// Token: 0x040001FF RID: 511
		private static readonly char[] char_0;

		// Token: 0x04000200 RID: 512
		internal JsonContainerType Type;

		// Token: 0x04000201 RID: 513
		internal int Position;

		// Token: 0x04000202 RID: 514
		[Nullable(2)]
		internal string PropertyName;

		// Token: 0x04000203 RID: 515
		internal bool HasIndex;
	}
}
