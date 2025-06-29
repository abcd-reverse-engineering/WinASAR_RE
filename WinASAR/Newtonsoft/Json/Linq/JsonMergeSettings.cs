using System;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x02000160 RID: 352
	public class JsonMergeSettings
	{
		// Token: 0x06000F49 RID: 3913 RVA: 0x0007B4F0 File Offset: 0x000796F0
		public JsonMergeSettings()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a == 0)
			{
				goto IL_0035;
			}
			do
			{
				IL_001A:
				this.stringComparison_0 = StringComparison.Ordinal;
				num = 1;
			}
			while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba == 0);
			IL_0035:
			switch (num)
			{
			case 0:
				goto IL_001A;
			case 1:
				return;
			default:
				goto IL_001A;
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000F4A RID: 3914 RVA: 0x00006216 File Offset: 0x00004416
		// (set) Token: 0x06000F4B RID: 3915 RVA: 0x0007B544 File Offset: 0x00079744
		public MergeArrayHandling MergeArrayHandling
		{
			get
			{
				return this.mergeArrayHandling_0;
			}
			set
			{
				for (;;)
				{
					if (value >= MergeArrayHandling.Concat)
					{
						goto IL_004B;
					}
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_207f975845fc40cdbe6b166fce664cd5 != 0)
					{
						break;
					}
					IL_001B:
					switch (num)
					{
					case 1:
						continue;
					case 3:
						return;
					case 4:
						IL_004B:
						if (value > MergeArrayHandling.Merge)
						{
							num = 2;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 == 0)
							{
								goto IL_001B;
							}
						}
						else
						{
							this.mergeArrayHandling_0 = value;
							num = 3;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 != 0)
							{
								goto IL_001B;
							}
						}
						break;
					}
					break;
				}
				throw new ArgumentOutOfRangeException(Class15.smethod_17(82310058 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909));
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000F4C RID: 3916 RVA: 0x0000621E File Offset: 0x0000441E
		// (set) Token: 0x06000F4D RID: 3917 RVA: 0x0007B5E0 File Offset: 0x000797E0
		public MergeNullValueHandling MergeNullValueHandling
		{
			get
			{
				return this.mergeNullValueHandling_0;
			}
			set
			{
				while (value >= MergeNullValueHandling.Ignore)
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a == 0)
					{
						switch (num)
						{
						case 0:
							goto IL_0045;
						case 1:
							break;
						case 2:
							continue;
						case 3:
							goto IL_003C;
						case 4:
							return;
						default:
							goto IL_0045;
						}
					}
					if (value > MergeNullValueHandling.Merge)
					{
						break;
					}
					IL_003C:
					this.mergeNullValueHandling_0 = value;
					return;
				}
				IL_0045:
				throw new ArgumentOutOfRangeException(Class15.smethod_17(2056989927 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48));
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000F4E RID: 3918 RVA: 0x00006226 File Offset: 0x00004426
		// (set) Token: 0x06000F4F RID: 3919 RVA: 0x0007B650 File Offset: 0x00079850
		public StringComparison PropertyNameComparison
		{
			get
			{
				return this.stringComparison_0;
			}
			set
			{
				for (;;)
				{
					if (value >= StringComparison.CurrentCulture)
					{
						goto IL_0030;
					}
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b == 0)
					{
						break;
					}
					IL_0014:
					switch (num)
					{
					case 1:
						continue;
					case 3:
						IL_0030:
						if (value <= StringComparison.OrdinalIgnoreCase)
						{
							goto IL_0071;
						}
						num = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 != 0)
						{
							goto IL_0014;
						}
						break;
					case 4:
						return;
					}
					break;
				}
				throw new ArgumentOutOfRangeException(Class15.smethod_17(1243259362 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95));
				IL_0071:
				this.stringComparison_0 = value;
			}
		}

		// Token: 0x040006E4 RID: 1764
		private MergeArrayHandling mergeArrayHandling_0;

		// Token: 0x040006E5 RID: 1765
		private MergeNullValueHandling mergeNullValueHandling_0;

		// Token: 0x040006E6 RID: 1766
		private StringComparison stringComparison_0;
	}
}
