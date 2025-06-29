using System;
using System.ComponentModel;
using System.Reflection;

namespace WinASAR.Common.Helpers
{
	// Token: 0x02000024 RID: 36
	public static class EnumHelper
	{
		// Token: 0x06000192 RID: 402 RVA: 0x00024650 File Offset: 0x00022850
		public static string GetEnumDescription(Enum value)
		{
			DescriptionAttribute[] array;
			for (;;)
			{
				IL_0074:
				FieldInfo field = value.GetType().GetField(value.ToString());
				for (;;)
				{
					if (!(field == null))
					{
						array = (DescriptionAttribute[])field.GetCustomAttributes(typeof(DescriptionAttribute), false);
						goto IL_004B;
					}
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 != 0)
					{
						goto Block_3;
					}
					IL_002F:
					switch (num)
					{
					case 1:
						goto IL_008A;
					case 2:
						IL_004B:
						if (array.Length == 0)
						{
							goto IL_009B;
						}
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad == 0)
						{
							goto IL_002F;
						}
						break;
					case 3:
						continue;
					case 4:
						goto IL_0074;
					}
					goto Block_1;
				}
			}
			Block_1:
			goto IL_0091;
			Block_3:
			IL_008A:
			return string.Empty;
			IL_0091:
			return array[0].Description;
			IL_009B:
			return value.ToString();
		}
	}
}
