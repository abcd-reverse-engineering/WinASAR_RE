using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000BD RID: 189
	[NullableContext(2)]
	[Nullable(0)]
	internal static class BufferUtils
	{
		// Token: 0x06000792 RID: 1938 RVA: 0x00004136 File Offset: 0x00002336
		[NullableContext(1)]
		public static char[] RentBuffer([Nullable(2)] IArrayPool<char> bufferPool, int minSize)
		{
			if (bufferPool == null)
			{
				return new char[minSize];
			}
			return bufferPool.Rent(minSize);
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x00004149 File Offset: 0x00002349
		public static void ReturnBuffer(IArrayPool<char> bufferPool, char[] buffer)
		{
			if (bufferPool != null)
			{
				bufferPool.Return(buffer);
			}
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x00004155 File Offset: 0x00002355
		[return: Nullable(1)]
		public static char[] EnsureBufferSize(IArrayPool<char> bufferPool, int size, char[] buffer)
		{
			if (bufferPool == null)
			{
				return new char[size];
			}
			if (buffer != null)
			{
				bufferPool.Return(buffer);
			}
			return bufferPool.Rent(size);
		}
	}
}
