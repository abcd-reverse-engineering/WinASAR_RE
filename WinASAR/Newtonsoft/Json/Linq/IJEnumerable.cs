using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x0200014D RID: 333
	[NullableContext(1)]
	public interface IJEnumerable<[Nullable(0)] out T> : IEnumerable<T>, IEnumerable where T : JToken
	{
		// Token: 0x17000200 RID: 512
		IJEnumerable<JToken> this[object key] { get; }
	}
}
