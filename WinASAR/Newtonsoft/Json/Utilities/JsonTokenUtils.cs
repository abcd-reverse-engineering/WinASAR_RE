using System;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000BF RID: 191
	internal static class JsonTokenUtils
	{
		// Token: 0x060007A0 RID: 1952 RVA: 0x0004DB70 File Offset: 0x0004BD70
		internal static bool IsEndToken(JsonToken token)
		{
			while (token - JsonToken.EndObject <= 2)
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
				return true;
			}
			return false;
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x0004DBB0 File Offset: 0x0004BDB0
		internal static bool IsStartToken(JsonToken token)
		{
			while (token - JsonToken.StartObject > 2)
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 == 0)
				{
					switch (num)
					{
					case 0:
						return true;
					case 1:
						break;
					case 2:
						continue;
					default:
						return true;
					}
				}
				return false;
			}
			return true;
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x0004DBF4 File Offset: 0x0004BDF4
		internal static bool IsPrimitiveToken(JsonToken token)
		{
			for (;;)
			{
				if (token - JsonToken.Integer > 5)
				{
					goto IL_002C;
				}
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 == 0)
				{
					break;
				}
				IL_0014:
				switch (num)
				{
				case 1:
					continue;
				case 3:
					IL_002C:
					if (token - JsonToken.Date > 1)
					{
						return false;
					}
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 != 0)
					{
						goto IL_0014;
					}
					break;
				}
				break;
			}
			return true;
		}
	}
}
