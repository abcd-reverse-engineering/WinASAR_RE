using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200008F RID: 143
	internal interface Interface1 : IDictionary, ICollection, IEnumerable
	{
		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000626 RID: 1574
		[Nullable(1)]
		object UnderlyingDictionary
		{
			[NullableContext(1)]
			get;
		}
	}
}
