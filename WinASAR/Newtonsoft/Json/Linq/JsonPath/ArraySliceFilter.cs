using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x02000176 RID: 374
	internal class ArraySliceFilter : PathFilter
	{
		// Token: 0x17000269 RID: 617
		// (get) Token: 0x060010E0 RID: 4320 RVA: 0x000067DF File Offset: 0x000049DF
		// (set) Token: 0x060010E1 RID: 4321 RVA: 0x000067E7 File Offset: 0x000049E7
		public int? Start { get; set; }

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x060010E2 RID: 4322 RVA: 0x000067F0 File Offset: 0x000049F0
		// (set) Token: 0x060010E3 RID: 4323 RVA: 0x000067F8 File Offset: 0x000049F8
		public int? End { get; set; }

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x060010E4 RID: 4324 RVA: 0x00006801 File Offset: 0x00004A01
		// (set) Token: 0x060010E5 RID: 4325 RVA: 0x00006809 File Offset: 0x00004A09
		public int? Step { get; set; }

		// Token: 0x060010E6 RID: 4326 RVA: 0x00006812 File Offset: 0x00004A12
		[NullableContext(1)]
		public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, [Nullable(2)] JsonSelectSettings settings)
		{
			ArraySliceFilter.<ExecuteFilter>d__12 <ExecuteFilter>d__ = new ArraySliceFilter.<ExecuteFilter>d__12(-2);
			<ExecuteFilter>d__.<>4__this = this;
			<ExecuteFilter>d__.<>3__current = current;
			<ExecuteFilter>d__.<>3__settings = settings;
			return <ExecuteFilter>d__;
		}

		// Token: 0x060010E7 RID: 4327 RVA: 0x00085BEC File Offset: 0x00083DEC
		private bool method_0(int int_0, int int_1, bool bool_0)
		{
			while (!bool_0)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 == 0)
				{
					switch (num)
					{
					case 0:
						goto IL_0034;
					case 1:
						break;
					case 2:
						continue;
					default:
						goto IL_0034;
					}
				}
				return int_0 > int_1;
			}
			IL_0034:
			return int_0 < int_1;
		}

		// Token: 0x060010E8 RID: 4328 RVA: 0x00085C34 File Offset: 0x00083E34
		public ArraySliceFilter()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x04000768 RID: 1896
		[CompilerGenerated]
		private int? nullable_0;

		// Token: 0x04000769 RID: 1897
		[CompilerGenerated]
		private int? nullable_1;

		// Token: 0x0400076A RID: 1898
		[CompilerGenerated]
		private int? nullable_2;
	}
}
