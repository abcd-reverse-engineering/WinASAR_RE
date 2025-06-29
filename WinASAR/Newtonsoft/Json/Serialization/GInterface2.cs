using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020000FC RID: 252
	[NullableContext(1)]
	public interface GInterface2
	{
		// Token: 0x060009AC RID: 2476
		Type BindToType([Nullable(2)] string assemblyName, string typeName);

		// Token: 0x060009AD RID: 2477
		[NullableContext(2)]
		void BindToName([Nullable(1)] Type serializedType, out string assemblyName, out string typeName);
	}
}
