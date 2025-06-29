using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x02000178 RID: 376
	[Nullable(0)]
	[NullableContext(2)]
	internal class FieldFilter : PathFilter
	{
		// Token: 0x060010F8 RID: 4344 RVA: 0x000864CC File Offset: 0x000846CC
		public FieldFilter(string name)
		{
			int num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 == 0)
			{
				goto IL_0032;
			}
			IL_001A:
			this.Name = name;
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 != 0)
			{
				return;
			}
			IL_0032:
			switch (num)
			{
			case 1:
				goto IL_001A;
			}
		}

		// Token: 0x060010F9 RID: 4345 RVA: 0x00006840 File Offset: 0x00004A40
		[NullableContext(1)]
		public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, [Nullable(2)] JsonSelectSettings settings)
		{
			FieldFilter.<ExecuteFilter>d__2 <ExecuteFilter>d__ = new FieldFilter.<ExecuteFilter>d__2(-2);
			<ExecuteFilter>d__.<>4__this = this;
			<ExecuteFilter>d__.<>3__current = current;
			<ExecuteFilter>d__.<>3__settings = settings;
			return <ExecuteFilter>d__;
		}

		// Token: 0x0400077B RID: 1915
		internal string Name;
	}
}
