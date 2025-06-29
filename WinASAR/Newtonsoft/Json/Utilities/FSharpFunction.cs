using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000B2 RID: 178
	[NullableContext(2)]
	[Nullable(0)]
	internal class FSharpFunction
	{
		// Token: 0x06000737 RID: 1847 RVA: 0x00003FD3 File Offset: 0x000021D3
		public FSharpFunction(object instance, [Nullable(new byte[] { 1, 2, 1 })] MethodCall<object, object> invoker)
		{
			this.object_0 = instance;
			this.methodCall_0 = invoker;
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x00003FEB File Offset: 0x000021EB
		[NullableContext(1)]
		public object Invoke(params object[] args)
		{
			return this.methodCall_0(this.object_0, args);
		}

		// Token: 0x0400042D RID: 1069
		private readonly object object_0;

		// Token: 0x0400042E RID: 1070
		[Nullable(new byte[] { 1, 2, 1 })]
		private readonly MethodCall<object, object> methodCall_0;
	}
}
