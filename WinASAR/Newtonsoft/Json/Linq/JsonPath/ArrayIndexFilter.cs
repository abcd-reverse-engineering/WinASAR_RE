using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x02000172 RID: 370
	internal class ArrayIndexFilter : PathFilter
	{
		// Token: 0x17000264 RID: 612
		// (get) Token: 0x060010BC RID: 4284 RVA: 0x00006761 File Offset: 0x00004961
		// (set) Token: 0x060010BD RID: 4285 RVA: 0x00006769 File Offset: 0x00004969
		public int? Index { get; set; }

		// Token: 0x060010BE RID: 4286 RVA: 0x00006772 File Offset: 0x00004972
		[NullableContext(1)]
		public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, [Nullable(2)] JsonSelectSettings settings)
		{
			ArrayIndexFilter.<ExecuteFilter>d__4 <ExecuteFilter>d__ = new ArrayIndexFilter.<ExecuteFilter>d__4(-2);
			<ExecuteFilter>d__.<>4__this = this;
			<ExecuteFilter>d__.<>3__current = current;
			<ExecuteFilter>d__.<>3__settings = settings;
			return <ExecuteFilter>d__;
		}

		// Token: 0x060010BF RID: 4287 RVA: 0x00084EE4 File Offset: 0x000830E4
		public ArrayIndexFilter()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 == 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x0400074E RID: 1870
		[CompilerGenerated]
		private int? nullable_0;
	}
}
