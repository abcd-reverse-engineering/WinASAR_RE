using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json
{
	// Token: 0x0200004D RID: 77
	[NullableContext(1)]
	public interface IArrayPool<[Nullable(2)] T>
	{
		// Token: 0x06000217 RID: 535
		T[] Rent(int minimumLength);

		// Token: 0x06000218 RID: 536
		void Return([Nullable(new byte[] { 2, 1 })] T[] array);
	}
}
