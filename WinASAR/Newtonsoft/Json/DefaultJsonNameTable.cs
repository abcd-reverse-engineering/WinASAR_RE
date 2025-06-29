using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Newtonsoft.Json
{
	// Token: 0x02000047 RID: 71
	[NullableContext(1)]
	[Nullable(0)]
	public class DefaultJsonNameTable : JsonNameTable
	{
		// Token: 0x0600020A RID: 522 RVA: 0x0002650C File Offset: 0x0002470C
		static DefaultJsonNameTable()
		{
			for (;;)
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b != 0)
				{
					goto IL_0003;
				}
				IL_0031:
				switch (num)
				{
				case 1:
					return;
				case 2:
					IL_0003:
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb != 0)
					{
						goto IL_0031;
					}
					break;
				case 3:
					continue;
				}
				DefaultJsonNameTable.int_0 = Environment.TickCount;
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 != 0)
				{
					goto IL_0031;
				}
				break;
			}
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00026578 File Offset: 0x00024778
		public DefaultJsonNameTable()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f == 0)
			{
				goto IL_0046;
			}
			IL_0022:
			this.class0_0 = new DefaultJsonNameTable.Class0[this.int_2 + 1];
			num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 != 0)
			{
				return;
			}
			IL_0046:
			switch (num)
			{
			case 0:
				goto IL_0022;
			case 1:
				break;
			default:
				goto IL_0022;
			}
		}

		// Token: 0x0600020C RID: 524 RVA: 0x000265DC File Offset: 0x000247DC
		[return: Nullable(2)]
		public override string Get(char[] key, int start, int length)
		{
			DefaultJsonNameTable.Class0 @class;
			for (;;)
			{
				IL_01B0:
				int num;
				if (length != 0)
				{
					num = length + DefaultJsonNameTable.int_0;
					goto IL_018A;
				}
				int num2 = 10;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 == 0)
				{
					goto Block_8;
				}
				do
				{
					IL_00BA:
					switch (num2)
					{
					case 1:
						goto IL_0034;
					case 2:
						goto IL_0183;
					case 3:
					case 19:
						goto IL_0085;
					case 4:
						goto IL_018A;
					case 5:
						goto IL_0163;
					case 6:
					case 15:
						if (@class == null)
						{
							goto Block_4;
						}
						goto IL_0034;
					case 7:
						goto IL_0156;
					case 8:
						goto IL_013C;
					case 9:
						goto IL_01C0;
					case 10:
						goto IL_0093;
					case 11:
						goto IL_01BA;
					case 12:
						goto IL_01B0;
					case 13:
						goto IL_0065;
					case 14:
						goto IL_003F;
					case 16:
					case 22:
						goto IL_0170;
					case 17:
						goto IL_017C;
					case 18:
						goto IL_0121;
					case 20:
					{
						int num3;
						@class = this.class0_0[num3];
						num2 = 15;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 == 0)
						{
							goto IL_0034;
						}
						continue;
					}
					case 21:
						goto IL_014B;
					}
					goto Block_5;
					IL_003F:
					if (DefaultJsonNameTable.smethod_0(@class.string_0, key, start, length))
					{
						goto IL_01C2;
					}
					num2 = 9;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c == 0)
					{
						goto IL_0065;
					}
					continue;
					IL_0034:
					if (@class.int_0 == num)
					{
						goto IL_003F;
					}
					IL_0065:
					@class = @class.class0_0;
					num2 = 6;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad != 0);
				goto IL_0163;
				int num4;
				for (;;)
				{
					IL_0121:
					int num3 = num & num4;
					num2 = 20;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 != 0)
					{
						goto IL_00BA;
					}
				}
				IL_0093:
				int num5;
				num5++;
				num2 = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 == 0)
				{
					goto IL_0170;
				}
				goto IL_00BA;
				IL_0085:
				num += (num << 7) ^ (int)key[num5];
				goto IL_0093;
				IL_0170:
				int num6;
				if (num5 < num6)
				{
					goto IL_0085;
				}
				goto IL_0163;
				IL_017C:
				num5 = start + 1;
				goto IL_0170;
				IL_0183:
				num6 = start + length;
				goto IL_017C;
				IL_018A:
				num += (num << 7) ^ (int)key[start];
				goto IL_0183;
				IL_013C:
				num4 = Thread.VolatileRead(ref this.int_2);
				goto IL_0121;
				IL_014B:
				num -= num >> 5;
				goto IL_013C;
				IL_0156:
				num -= num >> 11;
				goto IL_014B;
				IL_0163:
				num -= num >> 17;
				goto IL_0156;
			}
			Block_4:
			goto IL_01C0;
			Block_5:
			goto IL_01C2;
			Block_8:
			IL_01BA:
			return string.Empty;
			IL_01C0:
			return null;
			IL_01C2:
			return @class.string_0;
		}

		// Token: 0x0600020D RID: 525 RVA: 0x000267B4 File Offset: 0x000249B4
		public string Add(string key)
		{
			DefaultJsonNameTable.Class0 @class;
			int num2;
			for (;;)
			{
				int length;
				if (key != null)
				{
					length = key.Length;
					goto IL_0173;
				}
				int num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_52d717cd31b74287b67c03ee736a6211 == 0)
				{
					goto Block_8;
				}
				IL_0117:
				switch (num)
				{
				case 0:
					goto IL_00F8;
				case 1:
					goto IL_010B;
				case 2:
				case 17:
					goto IL_006E;
				case 3:
					IL_0173:
					if (length == 0)
					{
						goto IL_01CA;
					}
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 == 0)
					{
						goto IL_010B;
					}
					goto IL_0117;
				case 4:
					goto IL_0058;
				case 5:
					goto IL_00DC;
				case 6:
					break;
				case 7:
					goto IL_0106;
				case 8:
				case 11:
					goto IL_00B6;
				case 9:
					goto IL_00D2;
				case 10:
					goto IL_019D;
				case 12:
					goto IL_009E;
				case 13:
					goto IL_008C;
				case 14:
					goto IL_01A7;
				case 15:
					goto IL_01CA;
				case 16:
					goto IL_0078;
				case 18:
					goto IL_002D;
				case 19:
					goto IL_01AF;
				case 20:
					continue;
				default:
					goto IL_00F8;
				}
				IL_0038:
				if (@class.int_0 != num2)
				{
					goto IL_002D;
				}
				num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad == 0)
				{
					goto IL_0058;
				}
				goto IL_0117;
				IL_006E:
				if (@class == null)
				{
					break;
				}
				goto IL_0038;
				IL_002D:
				@class = @class.class0_0;
				goto IL_006E;
				IL_009E:
				int num3;
				num3++;
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 == 0)
				{
					goto IL_00B6;
				}
				goto IL_0117;
				IL_008C:
				num2 += (num2 << 7) ^ (int)key[num3];
				goto IL_009E;
				IL_00B6:
				if (num3 < key.Length)
				{
					goto IL_008C;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede == 0)
				{
					goto IL_00D2;
				}
				goto IL_0117;
				IL_0106:
				num3 = 0;
				goto IL_00B6;
				IL_010B:
				num2 = length + DefaultJsonNameTable.int_0;
				goto IL_0106;
				IL_00DC:
				num2 -= num2 >> 11;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 == 0)
				{
					goto IL_00F8;
				}
				goto IL_0117;
				IL_00D2:
				num2 -= num2 >> 17;
				goto IL_00DC;
				IL_0078:
				@class = this.class0_0[num2 & this.int_2];
				goto IL_006E;
				IL_00F8:
				num2 -= num2 >> 5;
				goto IL_0078;
				IL_0058:
				if (!@class.string_0.Equals(key, StringComparison.Ordinal))
				{
					goto IL_002D;
				}
				goto IL_01A7;
			}
			goto IL_019D;
			Block_8:
			goto IL_01AF;
			IL_019D:
			return this.method_0(key, num2);
			IL_01A7:
			return @class.string_0;
			IL_01AF:
			throw new ArgumentNullException(Class15.smethod_17(486539134 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c));
			IL_01CA:
			return string.Empty;
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00026990 File Offset: 0x00024B90
		private string method_0(string string_0, int int_3)
		{
			DefaultJsonNameTable.Class0 @class;
			int num3;
			for (;;)
			{
				IL_0090:
				int num = int_3 & this.int_2;
				int num2 = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a == 0)
				{
					goto IL_0049;
				}
				for (;;)
				{
					IL_006C:
					switch (num2)
					{
					case 1:
						goto IL_0049;
					case 2:
						goto IL_0090;
					case 3:
						goto IL_00C2;
					case 4:
						goto IL_00B2;
					case 5:
						goto IL_00BC;
					case 6:
						this.class0_0[num] = @class;
						num2 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 == 0)
						{
							continue;
						}
						break;
					}
					num3 = this.int_1;
					this.int_1 = num3 + 1;
					num2 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c == 0)
					{
						goto Block_1;
					}
				}
				IL_0049:
				@class = new DefaultJsonNameTable.Class0(string_0, int_3, this.class0_0[num]);
				num2 = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 == 0)
				{
					goto IL_006C;
				}
				goto IL_00AE;
			}
			Block_1:
			goto IL_00B2;
			IL_00AE:
			goto IL_00BC;
			IL_00B2:
			if (num3 != this.int_2)
			{
				goto IL_00C2;
			}
			IL_00BC:
			this.method_1();
			IL_00C2:
			return @class.string_0;
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00026A68 File Offset: 0x00024C68
		private void method_1()
		{
			for (;;)
			{
				DefaultJsonNameTable.Class0[] array = this.class0_0;
				int num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 != 0)
				{
					goto IL_00E1;
				}
				IL_0112:
				int num2;
				switch (num)
				{
				case 0:
					goto IL_003D;
				case 1:
					goto IL_0095;
				case 2:
					goto IL_00F8;
				case 3:
				case 16:
					goto IL_0067;
				case 4:
					goto IL_001F;
				case 5:
					goto IL_00ED;
				case 6:
				case 8:
					goto IL_0083;
				case 7:
					goto IL_005E;
				case 9:
					IL_00E1:
					num2 = this.int_2 * 2 + 1;
					goto IL_00ED;
				case 10:
					continue;
				case 11:
					goto IL_0087;
				case 12:
					goto IL_009D;
				case 13:
				case 14:
					goto IL_008D;
				case 15:
					goto IL_00BE;
				case 17:
					break;
				case 18:
					return;
				default:
					goto IL_003D;
				}
				IL_0006:
				DefaultJsonNameTable.Class0 class2;
				DefaultJsonNameTable.Class0 @class = class2;
				num = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 == 0)
				{
					goto IL_001F;
				}
				goto IL_0112;
				IL_005E:
				DefaultJsonNameTable.Class0[] array2;
				int num3;
				array2[num3] = @class;
				goto IL_0006;
				IL_001F:
				class2 = @class.class0_0;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 == 0)
				{
					goto IL_0112;
				}
				IL_003D:
				@class.class0_0 = array2[num3];
				num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a == 0)
				{
					goto IL_005E;
				}
				goto IL_0112;
				IL_0067:
				int num4;
				@class = array[num4];
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 == 0)
				{
					goto IL_0083;
				}
				goto IL_0112;
				IL_008D:
				if (num4 >= array.Length)
				{
					goto IL_0095;
				}
				goto IL_0067;
				IL_0087:
				num4++;
				goto IL_008D;
				IL_0083:
				if (@class == null)
				{
					goto IL_0087;
				}
				goto IL_00BE;
				IL_009D:
				Thread.VolatileWrite(ref this.int_2, num2);
				num = 18;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 == 0)
				{
					goto IL_005E;
				}
				goto IL_0112;
				IL_0095:
				this.class0_0 = array2;
				goto IL_009D;
				IL_00BE:
				num3 = @class.int_0 & num2;
				num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 == 0)
				{
					goto IL_003D;
				}
				goto IL_0112;
				IL_00F8:
				num4 = 0;
				num = 14;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 != 0)
				{
					goto IL_008D;
				}
				goto IL_0112;
				IL_00ED:
				array2 = new DefaultJsonNameTable.Class0[num2 + 1];
				goto IL_00F8;
			}
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00026C00 File Offset: 0x00024E00
		private static bool smethod_0(string string_0, object object_0, int int_3, int int_4)
		{
			while (string_0.Length == int_4)
			{
				int num = 0;
				int num2 = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 != 0)
				{
					goto IL_0048;
				}
				IL_0063:
				switch (num2)
				{
				case 0:
				case 2:
					goto IL_0048;
				case 1:
					break;
				case 3:
					return false;
				case 4:
					return false;
				case 5:
					continue;
				case 6:
					return true;
				default:
					goto IL_0048;
				}
				IL_001D:
				if (string_0[num] != object_0[int_3 + num])
				{
					return false;
				}
				num++;
				num2 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c == 0)
				{
					goto IL_0063;
				}
				IL_0048:
				if (num < string_0.Length)
				{
					goto IL_001D;
				}
				num2 = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 != 0)
				{
					goto IL_0063;
				}
				return true;
			}
			return false;
		}

		// Token: 0x040001B7 RID: 439
		private static readonly int int_0;

		// Token: 0x040001B8 RID: 440
		private int int_1;

		// Token: 0x040001B9 RID: 441
		private DefaultJsonNameTable.Class0[] class0_0;

		// Token: 0x040001BA RID: 442
		private int int_2 = 31;

		// Token: 0x02000048 RID: 72
		[Nullable(0)]
		private class Class0
		{
			// Token: 0x06000213 RID: 531 RVA: 0x00026CAC File Offset: 0x00024EAC
			internal Class0(string string_1, int int_1, DefaultJsonNameTable.Class0 class0_1)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 != 0)
				{
					goto IL_0037;
				}
				goto IL_0040;
				IL_001C:
				this.int_0 = int_1;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_52d717cd31b74287b67c03ee736a6211 == 0)
				{
					goto IL_0059;
				}
				goto IL_0040;
				IL_0037:
				this.string_0 = string_1;
				goto IL_001C;
				IL_0040:
				switch (num)
				{
				case 0:
					goto IL_0037;
				case 1:
					break;
				case 2:
					return;
				case 3:
					goto IL_001C;
				default:
					goto IL_0037;
				}
				IL_0059:
				this.class0_0 = class0_1;
			}

			// Token: 0x040001BC RID: 444
			internal readonly string string_0;

			// Token: 0x040001BD RID: 445
			internal readonly int int_0;

			// Token: 0x040001BE RID: 446
			internal DefaultJsonNameTable.Class0 class0_0;
		}
	}
}
