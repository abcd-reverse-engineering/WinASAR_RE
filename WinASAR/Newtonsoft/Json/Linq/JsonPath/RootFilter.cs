using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x02000187 RID: 391
	[Nullable(0)]
	[NullableContext(1)]
	internal class RootFilter : PathFilter
	{
		// Token: 0x0600117A RID: 4474 RVA: 0x0008B734 File Offset: 0x00089934
		private RootFilter()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 == 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x0600117B RID: 4475 RVA: 0x0000697D File Offset: 0x00004B7D
		public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, [Nullable(2)] JsonSelectSettings settings)
		{
			return new JToken[] { root };
		}

		// Token: 0x0600117C RID: 4476 RVA: 0x0008B768 File Offset: 0x00089968
		static RootFilter()
		{
			for (;;)
			{
				for (;;)
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 != 0)
					{
						goto IL_0003;
					}
					IL_001E:
					switch (num)
					{
					case 1:
						return;
					case 2:
						continue;
					case 3:
						continue;
					}
					IL_0003:
					RootFilter.Instance = new RootFilter();
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 != 0)
					{
						goto IL_001E;
					}
					return;
				}
			}
		}

		// Token: 0x040007D2 RID: 2002
		public static readonly RootFilter Instance;
	}
}
