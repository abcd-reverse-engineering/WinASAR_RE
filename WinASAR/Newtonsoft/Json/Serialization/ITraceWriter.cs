using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020000FD RID: 253
	[NullableContext(1)]
	public interface ITraceWriter
	{
		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060009AE RID: 2478
		TraceLevel LevelFilter { get; }

		// Token: 0x060009AF RID: 2479
		void Trace(TraceLevel level, string message, [Nullable(2)] Exception ex);
	}
}
