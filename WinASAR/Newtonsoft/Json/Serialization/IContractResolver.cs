using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020000FA RID: 250
	[NullableContext(1)]
	public interface IContractResolver
	{
		// Token: 0x060009A7 RID: 2471
		JsonContract ResolveContract(Type type);
	}
}
