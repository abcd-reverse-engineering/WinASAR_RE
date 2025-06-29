using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x0200017A RID: 378
	[NullableContext(1)]
	[Nullable(0)]
	internal class FieldMultipleFilter : PathFilter
	{
		// Token: 0x0600110A RID: 4362 RVA: 0x0000686E File Offset: 0x00004A6E
		public FieldMultipleFilter(List<string> names)
		{
			this.Names = names;
		}

		// Token: 0x0600110B RID: 4363 RVA: 0x0000687F File Offset: 0x00004A7F
		public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, [Nullable(2)] JsonSelectSettings settings)
		{
			FieldMultipleFilter.<ExecuteFilter>d__2 <ExecuteFilter>d__ = new FieldMultipleFilter.<ExecuteFilter>d__2(-2);
			<ExecuteFilter>d__.<>4__this = this;
			<ExecuteFilter>d__.<>3__current = current;
			<ExecuteFilter>d__.<>3__settings = settings;
			return <ExecuteFilter>d__;
		}

		// Token: 0x04000788 RID: 1928
		internal List<string> Names;
	}
}
