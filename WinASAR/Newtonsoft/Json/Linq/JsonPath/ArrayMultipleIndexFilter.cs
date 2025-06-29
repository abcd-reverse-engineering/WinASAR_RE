using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x02000174 RID: 372
	[NullableContext(1)]
	[Nullable(0)]
	internal class ArrayMultipleIndexFilter : PathFilter
	{
		// Token: 0x060010D0 RID: 4304 RVA: 0x000067A0 File Offset: 0x000049A0
		public ArrayMultipleIndexFilter(List<int> indexes)
		{
			this.Indexes = indexes;
		}

		// Token: 0x060010D1 RID: 4305 RVA: 0x000067B1 File Offset: 0x000049B1
		public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, [Nullable(2)] JsonSelectSettings settings)
		{
			ArrayMultipleIndexFilter.<ExecuteFilter>d__2 <ExecuteFilter>d__ = new ArrayMultipleIndexFilter.<ExecuteFilter>d__2(-2);
			<ExecuteFilter>d__.<>4__this = this;
			<ExecuteFilter>d__.<>3__current = current;
			<ExecuteFilter>d__.<>3__settings = settings;
			return <ExecuteFilter>d__;
		}

		// Token: 0x0400075B RID: 1883
		internal List<int> Indexes;
	}
}
