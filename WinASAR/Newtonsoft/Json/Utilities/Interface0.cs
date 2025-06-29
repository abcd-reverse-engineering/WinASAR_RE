using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000084 RID: 132
	internal interface Interface0 : IList, ICollection, IEnumerable
	{
		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060005B8 RID: 1464
		[Nullable(1)]
		object UnderlyingCollection
		{
			[NullableContext(1)]
			get;
		}
	}
}
