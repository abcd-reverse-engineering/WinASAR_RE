using System;

namespace WinASAR.Common.Helpers
{
	// Token: 0x02000028 RID: 40
	public static class Md5Helper
	{
		// Token: 0x060001B6 RID: 438 RVA: 0x000252E4 File Offset: 0x000234E4
		public static string GetMd5(this string content, bool isUpper = false)
		{
			object[] array;
			for (;;)
			{
				array = new object[2];
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 != 0)
				{
					goto IL_0028;
				}
				IL_0036:
				switch (num)
				{
				case 1:
					IL_0028:
					array[0] = content;
					goto IL_0003;
				case 2:
					continue;
				case 3:
					goto IL_0082;
				case 4:
					goto IL_0003;
				}
				break;
				IL_0003:
				array[1] = isUpper;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_52d717cd31b74287b67c03ee736a6211 != 0)
				{
					break;
				}
				goto IL_0036;
			}
			object[] array2 = Class24.smethod_1(65, array, null);
			IL_0082:
			return (string)array2[0];
		}
	}
}
