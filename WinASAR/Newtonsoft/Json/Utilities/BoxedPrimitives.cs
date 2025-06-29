using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000081 RID: 129
	[Nullable(0)]
	[NullableContext(1)]
	internal static class BoxedPrimitives
	{
		// Token: 0x06000598 RID: 1432 RVA: 0x0003EBD0 File Offset: 0x0003CDD0
		internal static object Get(bool value)
		{
			while (value)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 != 0)
				{
					switch (num)
					{
					case 1:
						continue;
					case 2:
						goto IL_0035;
					}
				}
				return BoxedPrimitives.BooleanTrue;
			}
			IL_0035:
			return BoxedPrimitives.BooleanFalse;
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x0003EC18 File Offset: 0x0003CE18
		internal static object Get(int value)
		{
			object obj;
			for (;;)
			{
				int num;
				switch (value)
				{
				case -1:
					IL_0025:
					obj = BoxedPrimitives.Int32_M1;
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c != 0)
					{
						goto IL_00A9;
					}
					break;
				case 0:
					goto IL_0144;
				case 1:
					goto IL_0117;
				case 2:
					goto IL_013B;
				case 3:
					goto IL_0129;
				case 4:
					goto IL_0150;
				case 5:
					goto IL_0120;
				case 6:
					goto IL_0132;
				case 7:
					goto IL_0159;
				case 8:
					goto IL_00A9;
				default:
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 == 0)
					{
						goto IL_0006;
					}
					break;
				}
				IL_003D:
				switch (num)
				{
				case 1:
					goto IL_00A9;
				case 2:
					goto IL_0117;
				case 6:
					goto IL_0120;
				case 7:
					goto IL_0129;
				case 10:
					goto IL_0025;
				case 11:
					goto IL_0132;
				case 13:
				case 20:
					IL_0006:
					obj = value;
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 != 0)
					{
						goto IL_003D;
					}
					break;
				case 14:
					continue;
				case 15:
					goto IL_013B;
				case 16:
					goto IL_0144;
				case 21:
					goto IL_0150;
				case 22:
					goto IL_0159;
				}
				break;
				IL_00A9:
				obj = BoxedPrimitives.Int32_8;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c == 0)
				{
					break;
				}
				goto IL_003D;
			}
			return obj;
			IL_0117:
			return BoxedPrimitives.Int32_1;
			IL_0120:
			return BoxedPrimitives.Int32_5;
			IL_0129:
			return BoxedPrimitives.Int32_3;
			IL_0132:
			return BoxedPrimitives.Int32_6;
			IL_013B:
			return BoxedPrimitives.Int32_2;
			IL_0144:
			return BoxedPrimitives.Int32_0;
			IL_0150:
			return BoxedPrimitives.Int32_4;
			IL_0159:
			obj = BoxedPrimitives.Int32_7;
			return obj;
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x0003ED88 File Offset: 0x0003CF88
		internal static object Get(long value)
		{
			object obj;
			for (;;)
			{
				long num = value - -1L;
				int num2;
				if (num > 9L)
				{
					num2 = 21;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 == 0)
					{
						break;
					}
				}
				else
				{
					switch ((uint)num)
					{
					case 0U:
						goto IL_0174;
					case 1U:
						goto IL_01A1;
					case 2U:
						goto IL_017D;
					case 3U:
						goto IL_0036;
					case 4U:
						goto IL_008C;
					case 5U:
						goto IL_006E;
					case 6U:
						goto IL_00AA;
					case 7U:
						goto IL_018F;
					case 8U:
						goto IL_0186;
					case 9U:
						goto IL_0168;
					default:
						goto IL_004F;
					}
				}
				IL_00C5:
				switch (num2)
				{
				case 5:
					goto IL_0168;
				case 8:
					IL_00AA:
					obj = BoxedPrimitives.Int64_5;
					num2 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 != 0)
					{
						goto IL_00C5;
					}
					break;
				case 10:
				case 15:
				case 21:
					goto IL_004F;
				case 11:
					goto IL_0174;
				case 12:
					goto IL_017D;
				case 13:
					goto IL_0186;
				case 17:
					goto IL_018F;
				case 19:
					IL_008C:
					obj = BoxedPrimitives.Int64_3;
					num2 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba == 0)
					{
						goto IL_00C5;
					}
					break;
				case 20:
					IL_006E:
					obj = BoxedPrimitives.Int64_4;
					num2 = 6;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 != 0)
					{
						goto IL_00C5;
					}
					break;
				case 22:
					continue;
				case 23:
					IL_0036:
					obj = BoxedPrimitives.Int64_2;
					num2 = 16;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 == 0)
					{
						goto IL_004F;
					}
					goto IL_00C5;
				case 24:
					goto IL_01A1;
				}
				break;
				IL_004F:
				obj = value;
				num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 == 0)
				{
					break;
				}
				goto IL_00C5;
			}
			return obj;
			IL_0168:
			return BoxedPrimitives.Int64_8;
			IL_0174:
			return BoxedPrimitives.Int64_M1;
			IL_017D:
			return BoxedPrimitives.Int64_1;
			IL_0186:
			return BoxedPrimitives.Int64_7;
			IL_018F:
			return BoxedPrimitives.Int64_6;
			IL_01A1:
			obj = BoxedPrimitives.Int64_0;
			return obj;
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x000037E2 File Offset: 0x000019E2
		internal static object Get(decimal value)
		{
			return value;
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x0003EF40 File Offset: 0x0003D140
		internal static object Get(double value)
		{
			for (;;)
			{
				if (value == 0.0)
				{
					goto IL_0022;
				}
				if (!double.IsInfinity(value))
				{
					goto IL_00AD;
				}
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 != 0)
				{
					goto IL_0048;
				}
				IL_0061:
				switch (num)
				{
				case 1:
					goto IL_0094;
				case 2:
					IL_0048:
					if (double.IsPositiveInfinity(value))
					{
						goto IL_009A;
					}
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf == 0)
					{
						goto IL_0061;
					}
					goto IL_0093;
				case 3:
					goto IL_00B5;
				case 4:
					IL_0022:
					if (double.IsNegativeInfinity(1.0 / value))
					{
						goto IL_00A7;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 != 0)
					{
						goto IL_0061;
					}
					break;
				case 5:
					continue;
				}
				break;
			}
			goto IL_00A1;
			IL_0093:
			IL_0094:
			return BoxedPrimitives.DoubleNegativeInfinity;
			IL_009A:
			return BoxedPrimitives.DoublePositiveInfinity;
			IL_00A1:
			return BoxedPrimitives.DoubleZero;
			IL_00A7:
			return BoxedPrimitives.DoubleNegativeZero;
			IL_00AD:
			if (!double.IsNaN(value))
			{
				return value;
			}
			IL_00B5:
			return BoxedPrimitives.DoubleNaN;
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x0003F010 File Offset: 0x0003D210
		static BoxedPrimitives()
		{
			for (;;)
			{
				IL_0313:
				for (;;)
				{
					IL_02F8:
					int num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 == 0)
					{
						goto IL_00C1;
					}
					for (;;)
					{
						IL_0275:
						switch (num)
						{
						case 0:
							goto IL_019C;
						case 1:
							goto IL_0233;
						case 2:
							goto IL_023E;
						case 3:
							goto IL_0209;
						case 4:
							goto IL_032A;
						case 5:
							goto IL_02F8;
						case 6:
							goto IL_0313;
						case 7:
							goto IL_0041;
						case 8:
							goto IL_0094;
						case 9:
							goto IL_0350;
						case 10:
							goto IL_004C;
						case 11:
							BoxedPrimitives.Int64_7 = 7L;
							num = 4;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 == 0)
							{
								goto Block_6;
							}
							continue;
						case 12:
							goto IL_00F9;
						case 13:
							break;
						case 14:
							BoxedPrimitives.Int32_3 = 3;
							num = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 == 0)
							{
								goto IL_0233;
							}
							continue;
						case 15:
							return;
						case 16:
							goto IL_033D;
						case 17:
							goto IL_01FE;
						case 18:
							goto IL_0144;
						case 19:
							goto IL_014F;
						case 20:
							goto IL_010C;
						case 21:
							goto IL_01C4;
						case 22:
							goto IL_006C;
						case 23:
							goto IL_01EE;
						case 24:
							goto IL_0317;
						case 25:
							BoxedPrimitives.Int64_4 = 4L;
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 == 0)
							{
								goto IL_019C;
							}
							continue;
						case 26:
							BoxedPrimitives.Int32_0 = 0;
							goto IL_0144;
						case 27:
							goto IL_00E6;
						case 28:
							goto IL_00C1;
						case 29:
							goto IL_0006;
						default:
							goto IL_019C;
						}
						IL_0019:
						BoxedPrimitives.Int64_3 = 3L;
						num = 25;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf == 0)
						{
							goto IL_0041;
						}
						continue;
						IL_0006:
						BoxedPrimitives.Int64_2 = 2L;
						goto IL_0019;
						IL_010C:
						BoxedPrimitives.Int64_1 = 1L;
						num = 5;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 != 0)
						{
							goto IL_0006;
						}
						continue;
						IL_00F9:
						BoxedPrimitives.Int64_0 = 0L;
						goto IL_010C;
						IL_00E6:
						BoxedPrimitives.Int64_M1 = -1L;
						goto IL_00F9;
						IL_01EE:
						BoxedPrimitives.Int32_8 = 8;
						goto IL_00E6;
						IL_0209:
						BoxedPrimitives.Int32_7 = 7;
						goto IL_01EE;
						IL_01FE:
						BoxedPrimitives.Int32_6 = 6;
						goto IL_0209;
						IL_023E:
						BoxedPrimitives.Int32_5 = 5;
						goto IL_01FE;
						IL_0233:
						BoxedPrimitives.Int32_4 = 4;
						goto IL_023E;
						IL_014F:
						BoxedPrimitives.Int32_2 = 2;
						num = 14;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 != 0)
						{
							break;
						}
						continue;
						IL_0144:
						BoxedPrimitives.Int32_1 = 1;
						goto IL_014F;
						IL_019C:
						BoxedPrimitives.Int64_5 = 5L;
						num = 13;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 == 0)
						{
							continue;
						}
						IL_01C4:
						BoxedPrimitives.Int64_6 = 6L;
						num = 11;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb == 0)
						{
							goto IL_019C;
						}
					}
					goto IL_004C;
					Block_6:
					goto IL_006C;
					IL_004C:
					BoxedPrimitives.Int32_M1 = -1;
					num = 26;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 == 0)
					{
						goto IL_006C;
					}
					goto IL_0275;
					IL_0041:
					BoxedPrimitives.BooleanFalse = false;
					goto IL_004C;
					IL_006C:
					BoxedPrimitives.Int64_8 = 8L;
					num = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 != 0)
					{
						goto IL_0275;
					}
					IL_0094:
					BoxedPrimitives.DoubleNaN = double.NaN;
					num = 12;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 != 0)
					{
						goto Block_1;
					}
					goto IL_0275;
					IL_00C1:
					BoxedPrimitives.BooleanTrue = true;
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 != 0)
					{
						goto IL_0041;
					}
					goto IL_0275;
				}
			}
			Block_1:
			IL_0317:
			BoxedPrimitives.DoublePositiveInfinity = double.PositiveInfinity;
			IL_032A:
			BoxedPrimitives.DoubleNegativeInfinity = double.NegativeInfinity;
			IL_033D:
			BoxedPrimitives.DoubleZero = 0.0;
			IL_0350:
			BoxedPrimitives.DoubleNegativeZero = -0.0;
		}

		// Token: 0x04000345 RID: 837
		internal static readonly object BooleanTrue;

		// Token: 0x04000346 RID: 838
		internal static readonly object BooleanFalse;

		// Token: 0x04000347 RID: 839
		internal static readonly object Int32_M1;

		// Token: 0x04000348 RID: 840
		internal static readonly object Int32_0;

		// Token: 0x04000349 RID: 841
		internal static readonly object Int32_1;

		// Token: 0x0400034A RID: 842
		internal static readonly object Int32_2;

		// Token: 0x0400034B RID: 843
		internal static readonly object Int32_3;

		// Token: 0x0400034C RID: 844
		internal static readonly object Int32_4;

		// Token: 0x0400034D RID: 845
		internal static readonly object Int32_5;

		// Token: 0x0400034E RID: 846
		internal static readonly object Int32_6;

		// Token: 0x0400034F RID: 847
		internal static readonly object Int32_7;

		// Token: 0x04000350 RID: 848
		internal static readonly object Int32_8;

		// Token: 0x04000351 RID: 849
		internal static readonly object Int64_M1;

		// Token: 0x04000352 RID: 850
		internal static readonly object Int64_0;

		// Token: 0x04000353 RID: 851
		internal static readonly object Int64_1;

		// Token: 0x04000354 RID: 852
		internal static readonly object Int64_2;

		// Token: 0x04000355 RID: 853
		internal static readonly object Int64_3;

		// Token: 0x04000356 RID: 854
		internal static readonly object Int64_4;

		// Token: 0x04000357 RID: 855
		internal static readonly object Int64_5;

		// Token: 0x04000358 RID: 856
		internal static readonly object Int64_6;

		// Token: 0x04000359 RID: 857
		internal static readonly object Int64_7;

		// Token: 0x0400035A RID: 858
		internal static readonly object Int64_8;

		// Token: 0x0400035B RID: 859
		internal static readonly object DoubleNaN;

		// Token: 0x0400035C RID: 860
		internal static readonly object DoublePositiveInfinity;

		// Token: 0x0400035D RID: 861
		internal static readonly object DoubleNegativeInfinity;

		// Token: 0x0400035E RID: 862
		internal static readonly object DoubleZero;

		// Token: 0x0400035F RID: 863
		internal static readonly object DoubleNegativeZero;
	}
}
