using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x0200018A RID: 394
	[NullableContext(1)]
	[Nullable(0)]
	internal class ScanMultipleFilter : PathFilter
	{
		// Token: 0x06001190 RID: 4496 RVA: 0x000069B0 File Offset: 0x00004BB0
		public ScanMultipleFilter(List<string> names)
		{
			this.list_0 = names;
		}

		// Token: 0x06001191 RID: 4497 RVA: 0x000069C1 File Offset: 0x00004BC1
		public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, [Nullable(2)] JsonSelectSettings settings)
		{
			ScanMultipleFilter.<ExecuteFilter>d__2 <ExecuteFilter>d__ = new ScanMultipleFilter.<ExecuteFilter>d__2(-2);
			<ExecuteFilter>d__.<>4__this = this;
			<ExecuteFilter>d__.<>3__current = current;
			return <ExecuteFilter>d__;
		}

		// Token: 0x040007E0 RID: 2016
		private List<string> list_0;
	}
}
