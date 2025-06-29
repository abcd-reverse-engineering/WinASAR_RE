using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020000FB RID: 251
	[NullableContext(1)]
	public interface GInterface1
	{
		// Token: 0x060009A8 RID: 2472
		object ResolveReference(object context, string reference);

		// Token: 0x060009A9 RID: 2473
		string GetReference(object context, object value);

		// Token: 0x060009AA RID: 2474
		bool IsReferenced(object context, object value);

		// Token: 0x060009AB RID: 2475
		void AddReference(object context, string reference, object value);
	}
}
