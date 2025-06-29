using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x02000185 RID: 389
	[NullableContext(1)]
	[Nullable(0)]
	internal class QueryScanFilter : PathFilter
	{
		// Token: 0x06001168 RID: 4456 RVA: 0x0008B094 File Offset: 0x00089294
		public QueryScanFilter(QueryExpression expression)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a != 0)
			{
				goto IL_0032;
			}
			IL_001A:
			this.Expression = expression;
			num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 == 0)
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

		// Token: 0x06001169 RID: 4457 RVA: 0x00006948 File Offset: 0x00004B48
		public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, [Nullable(2)] JsonSelectSettings settings)
		{
			QueryScanFilter.<ExecuteFilter>d__2 <ExecuteFilter>d__ = new QueryScanFilter.<ExecuteFilter>d__2(-2);
			<ExecuteFilter>d__.<>4__this = this;
			<ExecuteFilter>d__.<>3__root = root;
			<ExecuteFilter>d__.<>3__current = current;
			<ExecuteFilter>d__.<>3__settings = settings;
			return <ExecuteFilter>d__;
		}

		// Token: 0x040007C3 RID: 1987
		internal QueryExpression Expression;
	}
}
