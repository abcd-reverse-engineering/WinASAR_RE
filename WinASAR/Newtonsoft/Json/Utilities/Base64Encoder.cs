using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200007F RID: 127
	[Nullable(0)]
	[NullableContext(1)]
	internal class Base64Encoder
	{
		// Token: 0x06000585 RID: 1413 RVA: 0x0003E4BC File Offset: 0x0003C6BC
		public Base64Encoder(TextWriter writer)
		{
			int num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a != 0)
			{
				do
				{
					switch (num)
					{
					case 1:
						ValidationUtils.ArgumentNotNull(writer, Class15.smethod_17(926362957 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296));
						goto IL_0029;
					case 2:
						goto IL_0029;
					}
					break;
					IL_0029:
					this.textWriter_0 = writer;
					num = 0;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 != 0);
			}
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x0003E540 File Offset: 0x0003C740
		private void method_0(byte[] byte_1, int int_1, int int_2)
		{
			IL_006E:
			while (byte_1 != null)
			{
				if (int_1 >= 0)
				{
					for (;;)
					{
						int num;
						if (int_2 < 0)
						{
							num = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa == 0)
							{
								break;
							}
						}
						else
						{
							if (int_2 > byte_1.Length - int_1)
							{
								goto IL_00B0;
							}
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 == 0)
							{
								break;
							}
						}
						switch (num)
						{
						case 1:
							goto IL_0077;
						case 2:
							goto IL_0092;
						case 3:
							goto IL_006E;
						case 4:
							goto IL_00B0;
						case 5:
							continue;
						case 6:
							goto IL_00CB;
						}
						break;
					}
					return;
					IL_0077:
					throw new ArgumentOutOfRangeException(Class15.smethod_17(1603828638 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c));
					IL_0092:
					throw new ArgumentNullException(Class15.smethod_17(89052626 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454));
					IL_00B0:
					throw new ArgumentOutOfRangeException(Class15.smethod_17(314787069 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927));
				}
				IL_00CB:
				throw new ArgumentOutOfRangeException(Class15.smethod_17(926362925 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296));
			}
			goto IL_0092;
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x0003E634 File Offset: 0x0003C834
		public void Encode(byte[] buffer, int index, int count)
		{
			for (;;)
			{
				IL_01A2:
				this.method_0(buffer, index, count);
				for (;;)
				{
					IL_0196:
					if (this.int_0 > 0)
					{
						goto IL_016A;
					}
					int num = 14;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 != 0)
					{
						goto IL_00BC;
					}
					int num2;
					for (;;)
					{
						IL_0103:
						switch (num)
						{
						case 1:
							goto IL_00FA;
						case 2:
						case 10:
							goto IL_00BC;
						case 3:
							goto IL_00E3;
						case 4:
							goto IL_016A;
						case 5:
							goto IL_001C;
						case 6:
							return;
						case 7:
						case 14:
							this.method_1(buffer, index, ref count);
							num = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e != 0)
							{
								goto IL_00E3;
							}
							continue;
						case 8:
							goto IL_0099;
						case 11:
							goto IL_0196;
						case 12:
							goto IL_01A2;
						case 13:
							return;
						case 15:
							goto IL_0062;
						case 16:
							goto IL_0081;
						case 17:
							goto IL_0045;
						}
						break;
						IL_00E3:
						num2 = index + count;
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 != 0)
						{
							goto IL_00FA;
						}
					}
					goto IL_0087;
					IL_001C:
					int num3;
					this.method_3(this.char_0, 0, num3);
					num = 7;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 == 0)
					{
						goto IL_00FA;
					}
					goto IL_0103;
					IL_016A:
					if (!this.method_2(buffer, index, ref count))
					{
						num3 = Convert.ToBase64CharArray(this.byte_0, 0, 3, this.char_0, 0);
						goto IL_001C;
					}
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_253407eb812c4aefb734fa1e267fe779 == 0)
					{
						return;
					}
					goto IL_0103;
					IL_0045:
					int num4;
					index += num4;
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede == 0)
					{
						goto IL_00BC;
					}
					goto IL_0103;
					IL_0062:
					if (index + num4 > num2)
					{
						goto IL_0081;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9bd9937edf9d4ad8bd673dfcb5a5e3cb != 0)
					{
						goto IL_0087;
					}
					goto IL_0103;
					IL_00BC:
					if (index >= num2)
					{
						goto Block_6;
					}
					goto IL_0062;
					IL_00FA:
					num4 = 57;
					goto IL_00BC;
					IL_0099:
					int num5;
					this.method_3(this.char_0, 0, num5);
					num = 9;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e != 0)
					{
						goto IL_0045;
					}
					goto IL_0103;
					IL_0087:
					num5 = Convert.ToBase64CharArray(buffer, index, num4, this.char_0, 0);
					goto IL_0099;
					IL_0081:
					num4 = num2 - index;
					goto IL_0087;
				}
			}
			Block_6:;
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x0003E7F0 File Offset: 0x0003C9F0
		private void method_1(byte[] byte_1, int int_1, ref int int_2)
		{
			int num;
			for (;;)
			{
				IL_00FF:
				num = int_2 % 3;
				for (;;)
				{
					if (num > 0)
					{
						goto IL_00DA;
					}
					int num2 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b == 0)
					{
						goto Block_7;
					}
					IL_0075:
					switch (num2)
					{
					case 1:
					case 4:
						goto IL_005E;
					case 2:
					case 7:
						goto IL_0009;
					case 3:
						goto IL_0046;
					case 5:
						goto IL_0026;
					case 6:
						goto IL_0006;
					case 8:
						return;
					case 9:
						IL_00DA:
						int_2 -= num;
						goto IL_00CC;
					case 11:
						goto IL_00CC;
					case 12:
						continue;
					case 13:
						goto IL_00FF;
					}
					goto Block_4;
					IL_0009:
					int num3;
					if (num3 >= num)
					{
						goto IL_0108;
					}
					num2 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 != 0)
					{
						goto IL_005E;
					}
					goto IL_0075;
					IL_0006:
					num3 = 0;
					goto IL_0009;
					IL_0026:
					this.byte_0 = new byte[3];
					num2 = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d == 0)
					{
						goto IL_0006;
					}
					goto IL_0075;
					IL_0046:
					num3++;
					num2 = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 != 0)
					{
						goto IL_0075;
					}
					IL_005E:
					this.byte_0[num3] = byte_1[int_1 + int_2 + num3];
					goto IL_0046;
					IL_00CC:
					if (this.byte_0 != null)
					{
						goto IL_0006;
					}
					num2 = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 != 0)
					{
						goto IL_0026;
					}
					goto IL_0075;
				}
			}
			Block_4:
			Block_7:
			IL_0108:
			this.int_0 = num;
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x0003E910 File Offset: 0x0003CB10
		private bool method_2(byte[] byte_1, int int_1, ref int int_2)
		{
			for (;;)
			{
				int num = this.int_0;
				int num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b != 0)
				{
					goto IL_0006;
				}
				IL_0086:
				switch (num2)
				{
				case 0:
					goto IL_0024;
				case 1:
					goto IL_004C;
				case 2:
					goto IL_006D;
				case 3:
				case 8:
					IL_0006:
					if (num >= 3)
					{
						goto IL_0064;
					}
					break;
				case 4:
					continue;
				case 5:
					goto IL_0064;
				case 6:
					goto IL_0068;
				case 7:
					break;
				case 9:
					return true;
				default:
					goto IL_0024;
				}
				if (int_2 <= 0)
				{
					num2 = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b != 0)
					{
						goto IL_0064;
					}
					goto IL_0086;
				}
				IL_0024:
				this.byte_0[num++] = byte_1[int_1++];
				num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 == 0)
				{
					goto IL_0086;
				}
				IL_004C:
				int_2--;
				num2 = 8;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 == 0)
				{
					goto IL_0064;
				}
				goto IL_0086;
				IL_006D:
				this.int_0 = num;
				num2 = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 != 0)
				{
					goto IL_0086;
				}
				break;
				IL_0068:
				if (num < 3)
				{
					goto IL_006D;
				}
				return false;
				IL_0064:
				if (int_2 == 0)
				{
					goto IL_0068;
				}
				return false;
			}
			return true;
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x0003E9FC File Offset: 0x0003CBFC
		public void Flush()
		{
			while (this.int_0 > 0)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 != 0)
				{
					goto IL_0058;
				}
				IL_0075:
				switch (num)
				{
				case 0:
					goto IL_0058;
				case 1:
					continue;
				case 2:
					return;
				case 3:
					goto IL_0035;
				case 4:
					break;
				default:
					goto IL_0058;
				}
				IL_001A:
				this.int_0 = 0;
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b != 0)
				{
					goto IL_0058;
				}
				goto IL_0075;
				IL_0035:
				int num2;
				this.method_3(this.char_0, 0, num2);
				num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a != 0)
				{
					goto IL_001A;
				}
				goto IL_0075;
				IL_0058:
				num2 = Convert.ToBase64CharArray(this.byte_0, 0, this.int_0, this.char_0, 0);
				goto IL_0035;
			}
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x0003EAA8 File Offset: 0x0003CCA8
		private void method_3(char[] char_1, int int_1, int int_2)
		{
			for (;;)
			{
				this.textWriter_0.Write(char_1, int_1, int_2);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9bd9937edf9d4ad8bd673dfcb5a5e3cb != 0)
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

		// Token: 0x0400033B RID: 827
		private readonly char[] char_0 = new char[76];

		// Token: 0x0400033C RID: 828
		private readonly TextWriter textWriter_0;

		// Token: 0x0400033D RID: 829
		[Nullable(2)]
		private byte[] byte_0;

		// Token: 0x0400033E RID: 830
		private int int_0;
	}
}
