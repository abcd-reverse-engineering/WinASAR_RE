using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x02000183 RID: 387
	[Nullable(0)]
	[NullableContext(1)]
	internal class QueryFilter : PathFilter
	{
		// Token: 0x06001156 RID: 4438 RVA: 0x0008AA48 File Offset: 0x00088C48
		public QueryFilter(QueryExpression expression)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 == 0)
			{
				goto IL_0032;
			}
			IL_001A:
			this.Expression = expression;
			num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 == 0)
			{
				return;
			}
			IL_0032:
			switch (num)
			{
			case 0:
				goto IL_001A;
			case 1:
				break;
			default:
				goto IL_001A;
			}
		}

		// Token: 0x06001157 RID: 4439 RVA: 0x00006913 File Offset: 0x00004B13
		public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, [Nullable(2)] JsonSelectSettings settings)
		{
			QueryFilter.<ExecuteFilter>d__2 <ExecuteFilter>d__ = new QueryFilter.<ExecuteFilter>d__2(-2);
			<ExecuteFilter>d__.<>4__this = this;
			<ExecuteFilter>d__.<>3__root = root;
			<ExecuteFilter>d__.<>3__current = current;
			<ExecuteFilter>d__.<>3__settings = settings;
			return <ExecuteFilter>d__;
		}

		// Token: 0x040007B4 RID: 1972
		internal QueryExpression Expression;
	}
}
