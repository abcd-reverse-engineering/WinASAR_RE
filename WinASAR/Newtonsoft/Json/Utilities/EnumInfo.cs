using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000AB RID: 171
	[NullableContext(1)]
	[Nullable(0)]
	internal class EnumInfo
	{
		// Token: 0x06000704 RID: 1796 RVA: 0x00049920 File Offset: 0x00047B20
		public EnumInfo(bool isFlags, ulong[] values, string[] names, string[] resolvedNames)
		{
			int num = 4;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 != 0)
			{
				goto IL_004E;
			}
			for (;;)
			{
				IL_006E:
				switch (num)
				{
				case 1:
					goto IL_004E;
				case 2:
					goto IL_0035;
				case 3:
					goto IL_0055;
				case 4:
					this.IsFlags = isFlags;
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 == 0)
					{
						goto IL_0035;
					}
					continue;
				}
				break;
				IL_0035:
				this.Values = values;
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_52d717cd31b74287b67c03ee736a6211 == 0)
				{
					goto IL_004E;
				}
			}
			return;
			IL_004E:
			this.Names = names;
			IL_0055:
			this.ResolvedNames = resolvedNames;
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 == 0)
			{
				goto IL_006E;
			}
		}

		// Token: 0x04000417 RID: 1047
		public readonly bool IsFlags;

		// Token: 0x04000418 RID: 1048
		public readonly ulong[] Values;

		// Token: 0x04000419 RID: 1049
		public readonly string[] Names;

		// Token: 0x0400041A RID: 1050
		public readonly string[] ResolvedNames;
	}
}
