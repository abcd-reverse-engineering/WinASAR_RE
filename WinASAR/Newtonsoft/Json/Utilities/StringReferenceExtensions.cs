using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000DA RID: 218
	[NullableContext(1)]
	[Nullable(0)]
	internal static class StringReferenceExtensions
	{
		// Token: 0x0600088D RID: 2189 RVA: 0x00051924 File Offset: 0x0004FB24
		public static int IndexOf(this StringReference s, char c, int startIndex, int length)
		{
			int num;
			for (;;)
			{
				num = Array.IndexOf<char>(s.Chars, c, s.StartIndex + startIndex, length);
				int num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b == 0)
				{
					goto IL_0003;
				}
				IL_0019:
				switch (num2)
				{
				case 1:
					continue;
				case 2:
					return -1;
				}
				IL_0003:
				if (num != -1)
				{
					goto IL_005D;
				}
				num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 == 0)
				{
					goto IL_0019;
				}
				break;
			}
			return -1;
			IL_005D:
			return num - s.StartIndex;
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x0005199C File Offset: 0x0004FB9C
		public static bool StartsWith(this StringReference s, string text)
		{
			while (text.Length <= s.Length)
			{
				char[] chars = s.Chars;
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 == 0)
				{
					goto IL_0076;
				}
				IL_008D:
				switch (num)
				{
				case 0:
					goto IL_0076;
				case 1:
				case 4:
					goto IL_0055;
				case 2:
					return false;
				case 3:
					continue;
				case 5:
					return true;
				case 6:
				case 7:
					break;
				case 8:
					return false;
				default:
					goto IL_0076;
				}
				IL_0023:
				int num2;
				if (text[num2] != chars[num2 + s.StartIndex])
				{
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a == 0)
					{
						return false;
					}
					goto IL_008D;
				}
				else
				{
					num2++;
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c == 0)
					{
						goto IL_008D;
					}
				}
				IL_0055:
				if (num2 < text.Length)
				{
					goto IL_0023;
				}
				return true;
				IL_0076:
				num2 = 0;
				num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 == 0)
				{
					goto IL_0055;
				}
				goto IL_008D;
			}
			return false;
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x00051A7C File Offset: 0x0004FC7C
		public static bool EndsWith(this StringReference s, string text)
		{
			while (text.Length <= s.Length)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 == 0)
				{
					goto IL_005B;
				}
				IL_0078:
				char[] chars;
				switch (num)
				{
				case 0:
					return true;
				case 1:
					IL_005B:
					chars = s.Chars;
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af == 0)
					{
						goto IL_0078;
					}
					break;
				case 2:
					continue;
				case 3:
				case 5:
					goto IL_00C4;
				case 4:
					return false;
				case 6:
					return false;
				case 7:
					goto IL_0044;
				case 8:
				case 10:
					goto IL_00DF;
				case 9:
					break;
				default:
					return true;
				}
				int num2 = s.StartIndex + s.Length - text.Length;
				num = 7;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf != 0)
				{
					goto IL_0078;
				}
				IL_0044:
				int num3 = 0;
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 != 0)
				{
					goto IL_00DF;
				}
				goto IL_0078;
				IL_00C4:
				if (text[num3] != chars[num3 + num2])
				{
					return false;
				}
				num3++;
				IL_00DF:
				if (num3 < text.Length)
				{
					goto IL_00C4;
				}
				return true;
			}
			return false;
		}
	}
}
