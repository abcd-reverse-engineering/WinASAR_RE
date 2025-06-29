using System;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000C8 RID: 200
	internal static class MathUtils
	{
		// Token: 0x060007D8 RID: 2008 RVA: 0x0004DF50 File Offset: 0x0004C150
		public static int IntLength(ulong i)
		{
			for (;;)
			{
				if (i < 10000000000UL)
				{
					goto IL_021D;
				}
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b != 0)
				{
					goto IL_0104;
				}
				goto IL_01A1;
				IL_00CF:
				while (i < 10000000UL)
				{
					num = 26;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae != 0)
					{
						goto IL_01A1;
					}
				}
				if (i < 100000000UL)
				{
					return 8;
				}
				num = 9;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6 != 0)
				{
					goto Block_12;
				}
				IL_01A1:
				switch (num)
				{
				case 1:
					return 13;
				case 2:
					goto IL_018C;
				case 3:
					return 12;
				case 4:
					return 17;
				case 5:
					return 3;
				case 6:
					goto IL_0177;
				case 7:
					return 11;
				case 8:
					return 16;
				case 9:
					return 8;
				case 10:
					return 4;
				case 11:
					return 15;
				case 12:
					goto IL_0273;
				case 13:
					return 19;
				case 14:
					IL_021D:
					if (i < 10UL)
					{
						goto Block_21;
					}
					if (i < 100UL)
					{
						return 2;
					}
					if (i < 1000UL)
					{
						return 3;
					}
					if (i < 10000UL)
					{
						return 4;
					}
					if (i < 100000UL)
					{
						return 5;
					}
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c == 0)
					{
						goto IL_018C;
					}
					goto IL_01A1;
				case 15:
					goto IL_006B;
				case 16:
					return 18;
				case 17:
					return 20;
				case 18:
					return 6;
				case 19:
					return 1;
				case 20:
					return 2;
				case 21:
					goto IL_0145;
				case 22:
					IL_0104:
					if (i < 100000000000UL)
					{
						return 11;
					}
					if (i < 1000000000000UL)
					{
						num = 3;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e == 0)
						{
							goto Block_15;
						}
						goto IL_01A1;
					}
					else
					{
						if (i >= 10000000000000UL)
						{
							goto IL_0145;
						}
						return 13;
					}
					break;
				case 23:
					continue;
				case 24:
					return 5;
				case 25:
					goto IL_00CF;
				case 26:
					return 7;
				case 27:
					goto IL_005C;
				case 28:
					return 9;
				}
				goto Block_20;
				IL_006B:
				if (i < 1000000000000000000UL)
				{
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 == 0)
					{
						break;
					}
					goto IL_01A1;
				}
				else
				{
					if (i < 10000000000000000000UL)
					{
						return 19;
					}
					num = 17;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c == 0)
					{
						goto Block_9;
					}
					goto IL_01A1;
				}
				IL_005C:
				if (i >= 100000000000000000UL)
				{
					goto IL_006B;
				}
				return 17;
				IL_0177:
				if (i >= 10000000000000000UL)
				{
					goto IL_005C;
				}
				return 16;
				IL_0145:
				if (i < 100000000000000UL)
				{
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e == 0)
					{
						goto Block_17;
					}
					goto IL_01A1;
				}
				else
				{
					if (i >= 1000000000000000UL)
					{
						goto IL_0177;
					}
					return 15;
				}
				IL_018C:
				if (i < 1000000UL)
				{
					goto Block_19;
				}
				goto IL_00CF;
			}
			return 18;
			Block_9:
			return 12;
			Block_12:
			goto IL_0273;
			Block_15:
			return 13;
			Block_17:
			return 14;
			Block_19:
			return 6;
			Block_20:
			return 14;
			Block_21:
			return 1;
			IL_0273:
			if (i >= 1000000000UL)
			{
				return 10;
			}
			return 9;
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x0004E1FC File Offset: 0x0004C3FC
		public static char IntToHex(int n)
		{
			while (n > 9)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b != 0)
				{
					switch (num)
					{
					case 1:
						continue;
					case 2:
						goto IL_003A;
					}
				}
				return (char)(n - 10 + 97);
			}
			IL_003A:
			return (char)(n + 48);
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x00004377 File Offset: 0x00002577
		public static int? Min(int? val1, int? val2)
		{
			if (val1 == null)
			{
				return val2;
			}
			if (val2 == null)
			{
				return val1;
			}
			return new int?(Math.Min(val1.GetValueOrDefault(), val2.GetValueOrDefault()));
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x000043A7 File Offset: 0x000025A7
		public static int? Max(int? val1, int? val2)
		{
			if (val1 == null)
			{
				return val2;
			}
			if (val2 == null)
			{
				return val1;
			}
			return new int?(Math.Max(val1.GetValueOrDefault(), val2.GetValueOrDefault()));
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x000043D7 File Offset: 0x000025D7
		public static double? Max(double? val1, double? val2)
		{
			if (val1 == null)
			{
				return val2;
			}
			if (val2 == null)
			{
				return val1;
			}
			return new double?(Math.Max(val1.GetValueOrDefault(), val2.GetValueOrDefault()));
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x0004E248 File Offset: 0x0004C448
		public static bool ApproxEquals(double d1, double d2)
		{
			double num;
			double num3;
			for (;;)
			{
				if (d1 != d2)
				{
					num = (Math.Abs(d1) + Math.Abs(d2) + 10.0) * 2.220446049250313E-16;
					goto IL_0026;
				}
				int num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e == 0)
				{
					break;
				}
				IL_003C:
				switch (num2)
				{
				case 1:
					continue;
				case 2:
					goto IL_0077;
				case 3:
					goto IL_0080;
				case 4:
					IL_0026:
					num3 = d1 - d2;
					num2 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 == 0)
					{
						goto IL_003C;
					}
					goto IL_0076;
				}
				break;
			}
			return true;
			IL_0076:
			IL_0077:
			if (-num >= num3)
			{
				return false;
			}
			IL_0080:
			return num > num3;
		}
	}
}
