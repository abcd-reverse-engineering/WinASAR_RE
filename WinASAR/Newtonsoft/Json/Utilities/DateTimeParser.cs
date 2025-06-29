using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200008D RID: 141
	[NullableContext(1)]
	[Nullable(0)]
	internal struct DateTimeParser
	{
		// Token: 0x060005F8 RID: 1528 RVA: 0x00042FE0 File Offset: 0x000411E0
		static DateTimeParser()
		{
			for (;;)
			{
				IL_02A5:
				for (;;)
				{
					IL_028C:
					int num = 7;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 != 0)
					{
						goto IL_0240;
					}
					do
					{
						IL_020D:
						DateTimeParser.int_2 = Class15.smethod_17(1570970695 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406).Length;
						num = 1;
					}
					while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa == 0);
					for (;;)
					{
						IL_0240:
						switch (num)
						{
						case 1:
							goto IL_003A;
						case 2:
							goto IL_008D;
						case 3:
							goto IL_00FF;
						case 4:
							goto IL_0176;
						case 5:
							goto IL_00AC;
						case 6:
							goto IL_02A8;
						case 7:
							DateTimeParser.int_1 = new int[] { -1, 10, 100, 1000, 10000, 100000, 1000000 };
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f == 0)
							{
								continue;
							}
							break;
						case 8:
							goto IL_028C;
						case 9:
							goto IL_02A5;
						case 10:
							DateTimeParser.int_13 = Class15.smethod_17(2060598870 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177).Length;
							num = 6;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 == 0)
							{
								goto IL_00AC;
							}
							continue;
						case 11:
							goto IL_011E;
						case 12:
							goto IL_006E;
						case 13:
							return;
						case 14:
							goto IL_00E0;
						case 15:
							DateTimeParser.int_11 = Class15.smethod_17(538825617 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa).Length;
							goto IL_0176;
						case 16:
							DateTimeParser.int_7 = Class15.smethod_17(1042111059 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad).Length;
							num = 14;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f == 0)
							{
								goto IL_003A;
							}
							continue;
						}
						break;
						IL_003A:
						DateTimeParser.int_3 = Class15.smethod_17(1793868780 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a).Length;
						num = 11;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 == 0)
						{
							goto IL_006E;
						}
						continue;
						IL_00AC:
						DateTimeParser.int_6 = Class15.smethod_17(926364351 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296).Length;
						num = 16;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 != 0)
						{
							goto IL_00E0;
						}
						continue;
						IL_008D:
						DateTimeParser.int_5 = Class15.smethod_17(2048549557 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18).Length;
						goto IL_00AC;
						IL_006E:
						DateTimeParser.int_4 = Class15.smethod_17(1802362565 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4).Length;
						goto IL_008D;
						IL_011E:
						DateTimeParser.int_10 = Class15.smethod_17(543239844 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89).Length;
						num = 15;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 != 0)
						{
							goto Block_1;
						}
						continue;
						IL_00FF:
						DateTimeParser.int_9 = Class15.smethod_17(41434095 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d).Length;
						goto IL_011E;
						IL_00E0:
						DateTimeParser.int_8 = Class15.smethod_17(1603822604 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c).Length;
						goto IL_00FF;
						IL_0176:
						DateTimeParser.int_12 = Class15.smethod_17(1829617945 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae).Length;
						num = 10;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 == 0)
						{
							goto IL_00FF;
						}
					}
					goto IL_020D;
				}
				Block_1:;
			}
			IL_02A8:
			DateTimeParser.int_14 = Class15.smethod_17(642153278 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba).Length;
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x000432B4 File Offset: 0x000414B4
		public bool Parse(char[] text, int startIndex, int length)
		{
			for (;;)
			{
				this.cXtEeywyfq = text;
				int num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b == 0)
				{
					goto IL_0034;
				}
				IL_003F:
				switch (num)
				{
				case 1:
				case 4:
					return false;
				case 2:
					goto IL_0085;
				case 3:
					goto IL_000F;
				case 5:
					IL_0034:
					this.int_0 = startIndex + length;
					goto IL_0003;
				case 6:
					continue;
				case 7:
					goto IL_0003;
				}
				goto Block_3;
				IL_000F:
				if (this.method_6(DateTimeParser.int_6 + startIndex, 'T'))
				{
					goto IL_0085;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 != 0)
				{
					break;
				}
				goto IL_003F;
				IL_0003:
				if (this.method_0(startIndex))
				{
					goto IL_000F;
				}
				break;
			}
			return false;
			Block_3:
			return true;
			IL_0085:
			if (!this.method_1(DateTimeParser.int_7 + startIndex))
			{
				return false;
			}
			return true;
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00043358 File Offset: 0x00041558
		private bool method_0(int int_15)
		{
			IL_0123:
			while (this.method_4(int_15, out this.Year))
			{
				for (;;)
				{
					if (1 <= this.Year)
					{
						goto IL_00EC;
					}
					int num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 == 0)
					{
						goto Block_10;
					}
					IL_006E:
					switch (num)
					{
					case 0:
						goto IL_00D4;
					case 1:
						goto IL_0049;
					case 2:
					case 8:
					case 10:
					case 13:
					case 14:
						return false;
					case 3:
						break;
					case 4:
						IL_00EC:
						if (!this.method_6(int_15 + DateTimeParser.int_2, '-'))
						{
							goto Block_9;
						}
						goto IL_00D4;
					case 5:
						goto IL_013C;
					case 6:
						goto IL_00B2;
					case 7:
						goto IL_0145;
					case 9:
						goto IL_00C5;
					case 11:
						continue;
					case 12:
						goto IL_0123;
					default:
						goto IL_00D4;
					}
					IL_001A:
					if (!this.method_5(int_15 + DateTimeParser.int_5, out this.Day))
					{
						return false;
					}
					num = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 != 0)
					{
						break;
					}
					goto IL_006E;
					IL_0049:
					if (this.method_6(int_15 + DateTimeParser.int_4, '-'))
					{
						goto IL_001A;
					}
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f != 0)
					{
						goto IL_006E;
					}
					goto IL_0138;
					IL_00B2:
					if (this.Month > 12)
					{
						return false;
					}
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 == 0)
					{
						goto IL_0049;
					}
					goto IL_006E;
					IL_00C5:
					if (1 > this.Month)
					{
						goto Block_7;
					}
					goto IL_00B2;
					IL_00D4:
					if (!this.method_5(int_15 + DateTimeParser.int_3, out this.Month))
					{
						goto Block_8;
					}
					goto IL_00C5;
				}
				goto IL_013C;
				Block_7:
				Block_8:
				Block_9:
				Block_10:
				IL_0138:
				break;
				IL_013C:
				if (1 > this.Day)
				{
					break;
				}
				IL_0145:
				return this.Day <= DateTime.DaysInMonth(this.Year, this.Month);
			}
			return false;
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x000434C8 File Offset: 0x000416C8
		private bool method_1(int int_15)
		{
			while (!this.method_2(ref int_15))
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 == 0)
				{
					switch (num)
					{
					case 0:
						goto IL_0038;
					case 1:
						break;
					case 2:
						continue;
					default:
						goto IL_0038;
					}
				}
				return false;
			}
			IL_0038:
			return this.method_3(int_15);
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x00043514 File Offset: 0x00041714
		private bool method_2(ref int int_15)
		{
			IL_0381:
			while (this.method_5(int_15, out this.Hour))
			{
				IL_0371:
				while (this.Hour <= 24)
				{
					int num = 13;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a == 0)
					{
						break;
					}
					do
					{
						int num2;
						int num3;
						switch (num)
						{
						case 0:
							goto IL_0142;
						case 1:
							return false;
						case 2:
							return true;
						case 3:
						case 16:
							goto IL_0078;
						case 4:
							goto IL_02C3;
						case 5:
							goto IL_00F5;
						case 6:
							goto IL_01A0;
						case 7:
							if (this.Second < 60)
							{
								goto IL_02C3;
							}
							return false;
						case 8:
							goto IL_01EC;
						case 9:
							goto IL_00CD;
						case 10:
						case 12:
						case 15:
						case 27:
							return false;
						case 11:
							goto IL_0120;
						case 13:
							if (this.method_6(int_15 + DateTimeParser.int_8, ':'))
							{
								goto IL_0187;
							}
							num = 10;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 == 0)
							{
								goto IL_00F5;
							}
							continue;
						case 14:
							goto IL_0075;
						case 17:
							goto IL_0040;
						case 18:
							if (num2 > 9)
							{
								goto IL_0103;
							}
							goto IL_0259;
						case 19:
							goto IL_0097;
						case 20:
							goto IL_0371;
						case 21:
							goto IL_0381;
						case 22:
							goto IL_006E;
						case 23:
						case 28:
							goto IL_0103;
						case 24:
							goto IL_01C2;
						case 25:
							if (num3 >= 7)
							{
								goto IL_0103;
							}
							goto IL_00CD;
						case 26:
							goto IL_0259;
						case 29:
							goto IL_004A;
						case 30:
							if (num3 != 0)
							{
								this.Fraction *= DateTimeParser.int_1[7 - num3];
								goto IL_0120;
							}
							num = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af == 0)
							{
								return false;
							}
							continue;
						case 31:
							goto IL_00DB;
						case 32:
							goto IL_0187;
						case 33:
							goto IL_0167;
						case 34:
							break;
						case 35:
							return false;
						default:
							goto IL_0142;
						}
						IL_0020:
						if (this.Second != 0)
						{
							return false;
						}
						num = 5;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba != 0)
						{
							goto IL_0040;
						}
						continue;
						IL_00F5:
						if (this.Minute == 0)
						{
							goto IL_0020;
						}
						num = 12;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 != 0)
						{
							goto IL_0120;
						}
						continue;
						IL_004A:
						if (!this.method_6(int_15, '.'))
						{
							return true;
						}
						num = 14;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 == 0)
						{
							goto IL_006E;
						}
						continue;
						IL_0040:
						int_15 += DateTimeParser.int_12;
						goto IL_004A;
						IL_02C3:
						if (this.Hour == 24)
						{
							goto IL_00F5;
						}
						goto IL_0040;
						IL_0078:
						int num4 = int_15 + 1;
						int_15 = num4;
						num = 9;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b != 0)
						{
							goto IL_0097;
						}
						continue;
						IL_0075:
						num3 = 0;
						goto IL_0078;
						IL_006E:
						this.Fraction = 0;
						goto IL_0075;
						IL_0097:
						if (num4 >= this.int_0)
						{
							goto IL_0103;
						}
						num = 25;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b == 0)
						{
							goto IL_006E;
						}
						continue;
						IL_00DB:
						if (num2 < 0)
						{
							goto IL_0103;
						}
						num = 18;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 == 0)
						{
							goto IL_00F5;
						}
						continue;
						IL_00CD:
						num2 = (int)(this.cXtEeywyfq[int_15] - '0');
						goto IL_00DB;
						IL_0103:
						if (num3 < 7)
						{
							num = 30;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a != 0)
							{
								goto IL_00CD;
							}
							continue;
						}
						IL_0120:
						if (this.Hour != 24)
						{
							return true;
						}
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf != 0)
						{
							continue;
						}
						IL_0142:
						if (this.Fraction != 0)
						{
							return false;
						}
						num = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 == 0)
						{
							break;
						}
						continue;
						IL_0167:
						num3++;
						num = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede == 0)
						{
							goto IL_0078;
						}
						continue;
						IL_0259:
						this.Fraction = this.Fraction * 10 + num2;
						goto IL_0167;
						IL_01A0:
						if (this.Minute >= 60)
						{
							return false;
						}
						num = 16;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 == 0)
						{
							goto IL_01C2;
						}
						continue;
						IL_0187:
						if (this.method_5(int_15 + DateTimeParser.int_9, out this.Minute))
						{
							goto IL_01A0;
						}
						return false;
						IL_01C2:
						if (!this.method_6(int_15 + DateTimeParser.int_10, ':'))
						{
							return false;
						}
						num = 6;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b != 0)
						{
							continue;
						}
						IL_01EC:
						if (!this.method_5(int_15 + DateTimeParser.int_11, out this.Second))
						{
							return false;
						}
						num = 7;
					}
					while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba != 0);
					return false;
				}
				break;
			}
			return false;
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x000438C8 File Offset: 0x00041AC8
		private bool method_3(int int_15)
		{
			IL_025C:
			while (int_15 < this.int_0)
			{
				for (;;)
				{
					IL_0238:
					char c = this.cXtEeywyfq[int_15];
					int num = 8;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c == 0)
					{
						goto IL_00A9;
					}
					for (;;)
					{
						IL_01A1:
						switch (num)
						{
						case 1:
						case 10:
						case 21:
						case 26:
						case 29:
						case 30:
						case 33:
							goto IL_027D;
						case 2:
							goto IL_002E;
						case 3:
							goto IL_003C;
						case 4:
							goto IL_009A;
						case 5:
							goto IL_0278;
						case 6:
							goto IL_00A9;
						case 7:
							goto IL_0104;
						case 8:
							if (c != 'Z')
							{
								goto IL_0186;
							}
							goto IL_018F;
						case 9:
							goto IL_0238;
						case 11:
							goto IL_000D;
						case 12:
						case 25:
							goto IL_00F6;
						case 13:
							goto IL_001B;
						case 14:
							goto IL_0029;
						case 15:
							goto IL_018F;
						case 16:
							goto IL_0070;
						case 17:
						case 20:
							goto IL_00B9;
						case 18:
							goto IL_004E;
						case 19:
							goto IL_0186;
						case 22:
							goto IL_0268;
						case 23:
							goto IL_0090;
						case 24:
							goto IL_0168;
						case 27:
							goto IL_00A3;
						case 28:
							goto IL_00B0;
						case 31:
							goto IL_025C;
						case 32:
							goto IL_014C;
						case 34:
							goto IL_0006;
						}
						break;
						IL_014C:
						int_15++;
						num = 33;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 == 0)
						{
							goto Block_9;
						}
						continue;
						IL_018F:
						this.Zone = ParserTimeZone.Utc;
						goto IL_014C;
						IL_0186:
						if (c == 'z')
						{
							goto IL_018F;
						}
						goto IL_0070;
					}
					goto IL_0128;
					IL_0168:
					if (this.method_5(int_15 + DateTimeParser.int_13, out this.ZoneHour))
					{
						goto IL_0090;
					}
					goto IL_00B9;
					IL_004E:
					if (this.ZoneMinute > 99)
					{
						break;
					}
					num = 22;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e != 0)
					{
						goto IL_0070;
					}
					goto IL_01A1;
					IL_003C:
					if (this.method_5(int_15, out this.ZoneMinute))
					{
						goto IL_004E;
					}
					break;
					IL_002E:
					if (int_15 + 1 < this.int_0)
					{
						goto IL_003C;
					}
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 == 0)
					{
						break;
					}
					goto IL_01A1;
					IL_0029:
					int_15++;
					goto IL_002E;
					IL_001B:
					if (this.method_6(int_15, ':'))
					{
						goto IL_0029;
					}
					goto IL_00F6;
					IL_00B9:
					if (int_15 < this.int_0)
					{
						goto IL_001B;
					}
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f == 0)
					{
						goto IL_0128;
					}
					goto IL_01A1;
					IL_000D:
					int_15 += DateTimeParser.int_14;
					goto IL_00B9;
					IL_0006:
					this.Zone = ParserTimeZone.LocalEastOfUtc;
					goto IL_000D;
					IL_009A:
					if (c != '+')
					{
						goto IL_00A3;
					}
					goto IL_0006;
					IL_0104:
					if (!this.method_5(int_15, out this.ZoneMinute))
					{
						break;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 == 0)
					{
						goto IL_0128;
					}
					goto IL_01A1;
					IL_00F6:
					if (int_15 + 1 < this.int_0)
					{
						goto IL_0104;
					}
					break;
					IL_0128:
					if (this.ZoneMinute <= 99)
					{
						goto IL_0278;
					}
					num = 10;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 == 0)
					{
						break;
					}
					goto IL_01A1;
					IL_0070:
					if (int_15 + 2 >= this.int_0)
					{
						goto IL_00B9;
					}
					num = 24;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 != 0)
					{
						goto IL_01A1;
					}
					IL_0090:
					if (this.ZoneHour <= 99)
					{
						goto IL_009A;
					}
					goto IL_00B9;
					IL_00A3:
					if (c == '-')
					{
						goto IL_00A9;
					}
					goto IL_00B9;
					IL_00B0:
					int_15 += DateTimeParser.int_14;
					goto IL_00B9;
					IL_00A9:
					this.Zone = ParserTimeZone.LocalWestOfUtc;
					goto IL_00B0;
				}
				Block_9:
				break;
				IL_0268:
				int_15 += 2;
				break;
				IL_0278:
				int_15 += 2;
				IL_027D:
				return int_15 == this.int_0;
			}
			goto IL_027D;
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x00043B5C File Offset: 0x00041D5C
		private bool method_4(int int_15, out int int_16)
		{
			while (int_15 + 3 < this.int_0)
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a != 0)
				{
					goto IL_00A2;
				}
				IL_00F0:
				int num2;
				switch (num)
				{
				case 0:
					goto IL_00D0;
				case 1:
					goto IL_005B;
				case 2:
				case 5:
				case 17:
				case 18:
					goto IL_0186;
				case 3:
					goto IL_00DF;
				case 4:
					goto IL_00AF;
				case 6:
					goto IL_003E;
				case 7:
					IL_00A2:
					num2 = (int)(this.cXtEeywyfq[int_15] - '0');
					goto IL_00AF;
				case 8:
					continue;
				case 9:
					goto IL_0078;
				case 10:
					goto IL_015D;
				case 11:
					return false;
				case 12:
					goto IL_0097;
				case 13:
					goto IL_0163;
				case 14:
					return true;
				case 15:
					break;
				case 16:
					goto IL_016E;
				case 19:
					goto IL_0168;
				default:
					goto IL_00D0;
				}
				IL_0020:
				if (num2 >= 10)
				{
					break;
				}
				num = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c == 0)
				{
					goto IL_003E;
				}
				goto IL_00F0;
				IL_0097:
				if (0 > num2)
				{
					break;
				}
				goto IL_0020;
				IL_00DF:
				int num3 = (int)(this.cXtEeywyfq[int_15 + 3] - '0');
				goto IL_0097;
				IL_00D0:
				int num4 = (int)(this.cXtEeywyfq[int_15 + 2] - '0');
				goto IL_00DF;
				IL_003E:
				int num5;
				if (0 > num5)
				{
					break;
				}
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 == 0)
				{
					goto IL_00F0;
				}
				IL_005B:
				if (num5 >= 10)
				{
					num = 18;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 == 0)
					{
						goto IL_0163;
					}
					goto IL_00F0;
				}
				IL_0078:
				if (0 > num4)
				{
					break;
				}
				num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 == 0)
				{
					goto IL_015D;
				}
				goto IL_00F0;
				IL_00AF:
				num5 = (int)(this.cXtEeywyfq[int_15 + 1] - '0');
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c == 0)
				{
					goto IL_00D0;
				}
				goto IL_00F0;
				IL_015D:
				if (num4 >= 10)
				{
					break;
				}
				IL_0163:
				if (0 > num3)
				{
					break;
				}
				IL_0168:
				if (num3 >= 10)
				{
					break;
				}
				IL_016E:
				int_16 = ((num2 * 10 + num5) * 10 + num4) * 10 + num3;
				return true;
			}
			IL_0186:
			int_16 = 0;
			return false;
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x00043CF4 File Offset: 0x00041EF4
		private bool method_5(int int_15, out int int_16)
		{
			IL_00DB:
			while (int_15 + 1 < this.int_0)
			{
				for (;;)
				{
					int num = (int)(this.cXtEeywyfq[int_15] - '0');
					int num2 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 != 0)
					{
						goto IL_0006;
					}
					IL_007B:
					int num3;
					switch (num2)
					{
					case 1:
						goto IL_0025;
					case 2:
						goto IL_002B;
					case 4:
						goto IL_00DB;
					case 6:
						goto IL_0047;
					case 7:
						goto IL_0020;
					case 8:
						continue;
					case 9:
						return false;
					case 10:
						goto IL_0015;
					case 11:
						IL_0006:
						num3 = (int)(this.cXtEeywyfq[int_15 + 1] - '0');
						goto IL_0015;
					case 12:
						return true;
					}
					break;
					IL_002B:
					int_16 = num * 10 + num3;
					num2 = 12;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 == 0)
					{
						goto IL_0047;
					}
					goto IL_007B;
					IL_0025:
					if (num3 < 10)
					{
						goto IL_002B;
					}
					num2 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 != 0)
					{
						goto IL_007B;
					}
					break;
					IL_0020:
					if (0 <= num3)
					{
						goto IL_0025;
					}
					num2 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b == 0)
					{
						goto IL_007B;
					}
					break;
					IL_0047:
					if (num < 10)
					{
						goto IL_0020;
					}
					break;
					IL_0015:
					if (0 <= num)
					{
						goto IL_0047;
					}
					break;
				}
				IL_00ED:
				int_16 = 0;
				return false;
			}
			goto IL_00ED;
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x00043DF4 File Offset: 0x00041FF4
		private bool method_6(int int_15, char char_0)
		{
			while (int_15 >= this.int_0)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 != 0)
				{
					switch (num)
					{
					case 1:
						continue;
					case 2:
						goto IL_0037;
					}
				}
				return false;
			}
			IL_0037:
			return this.cXtEeywyfq[int_15] == char_0;
		}

		// Token: 0x040003AB RID: 939
		public int Year;

		// Token: 0x040003AC RID: 940
		public int Month;

		// Token: 0x040003AD RID: 941
		public int Day;

		// Token: 0x040003AE RID: 942
		public int Hour;

		// Token: 0x040003AF RID: 943
		public int Minute;

		// Token: 0x040003B0 RID: 944
		public int Second;

		// Token: 0x040003B1 RID: 945
		public int Fraction;

		// Token: 0x040003B2 RID: 946
		public int ZoneHour;

		// Token: 0x040003B3 RID: 947
		public int ZoneMinute;

		// Token: 0x040003B4 RID: 948
		public ParserTimeZone Zone;

		// Token: 0x040003B5 RID: 949
		private char[] cXtEeywyfq;

		// Token: 0x040003B6 RID: 950
		private int int_0;

		// Token: 0x040003B7 RID: 951
		private static readonly int[] int_1;

		// Token: 0x040003B8 RID: 952
		private static readonly int int_2;

		// Token: 0x040003B9 RID: 953
		private static readonly int int_3;

		// Token: 0x040003BA RID: 954
		private static readonly int int_4;

		// Token: 0x040003BB RID: 955
		private static readonly int int_5;

		// Token: 0x040003BC RID: 956
		private static readonly int int_6;

		// Token: 0x040003BD RID: 957
		private static readonly int int_7;

		// Token: 0x040003BE RID: 958
		private static readonly int int_8;

		// Token: 0x040003BF RID: 959
		private static readonly int int_9;

		// Token: 0x040003C0 RID: 960
		private static readonly int int_10;

		// Token: 0x040003C1 RID: 961
		private static readonly int int_11;

		// Token: 0x040003C2 RID: 962
		private static readonly int int_12;

		// Token: 0x040003C3 RID: 963
		private static readonly int int_13;

		// Token: 0x040003C4 RID: 964
		private static readonly int int_14;
	}
}
