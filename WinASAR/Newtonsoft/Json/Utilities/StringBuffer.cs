using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000D8 RID: 216
	[NullableContext(2)]
	[Nullable(0)]
	internal struct StringBuffer
	{
		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000875 RID: 2165 RVA: 0x00004554 File Offset: 0x00002754
		// (set) Token: 0x06000876 RID: 2166 RVA: 0x0005171C File Offset: 0x0004F91C
		public int Position
		{
			get
			{
				return this.int_0;
			}
			set
			{
				for (;;)
				{
					this.int_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c != 0)
					{
						switch (num)
						{
						case 1:
							continue;
						}
						break;
					}
					break;
				}
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x0000455C File Offset: 0x0000275C
		public bool IsEmpty
		{
			get
			{
				return this.char_0 == null;
			}
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x00004567 File Offset: 0x00002767
		public StringBuffer(IArrayPool<char> bufferPool, int initalSize)
		{
			this = new StringBuffer(BufferUtils.RentBuffer(bufferPool, initalSize));
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x00051754 File Offset: 0x0004F954
		[NullableContext(1)]
		private StringBuffer(char[] buffer)
		{
			for (;;)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 == 0)
				{
					goto IL_001E;
				}
				IL_0027:
				switch (num)
				{
				case 0:
					goto IL_001E;
				case 1:
					return;
				case 2:
					continue;
				case 3:
					break;
				default:
					goto IL_001E;
				}
				IL_0003:
				this.int_0 = 0;
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 != 0)
				{
					break;
				}
				goto IL_0027;
				IL_001E:
				this.char_0 = buffer;
				goto IL_0003;
			}
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x000517B8 File Offset: 0x0004F9B8
		public void Append(IArrayPool<char> bufferPool, char value)
		{
			if (this.int_0 == this.char_0.Length)
			{
				this.method_0(bufferPool, 1);
			}
			char[] array = this.char_0;
			int num = this.int_0;
			this.int_0 = num + 1;
			array[num] = value;
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x000517F8 File Offset: 0x0004F9F8
		[NullableContext(1)]
		public void Append([Nullable(2)] IArrayPool<char> bufferPool, char[] buffer, int startIndex, int count)
		{
			if (this.int_0 + count >= this.char_0.Length)
			{
				this.method_0(bufferPool, count);
			}
			Array.Copy(buffer, startIndex, this.char_0, this.int_0, count);
			this.int_0 += count;
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x00004578 File Offset: 0x00002778
		public void Clear(IArrayPool<char> bufferPool)
		{
			if (this.char_0 != null)
			{
				BufferUtils.ReturnBuffer(bufferPool, this.char_0);
				this.char_0 = null;
			}
			this.int_0 = 0;
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x00051848 File Offset: 0x0004FA48
		private void method_0(IArrayPool<char> iarrayPool_0, int int_1)
		{
			char[] array = BufferUtils.RentBuffer(iarrayPool_0, (this.int_0 + int_1) * 2);
			if (this.char_0 != null)
			{
				Array.Copy(this.char_0, array, this.int_0);
				BufferUtils.ReturnBuffer(iarrayPool_0, this.char_0);
			}
			this.char_0 = array;
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x0000459C File Offset: 0x0000279C
		[NullableContext(1)]
		public override string ToString()
		{
			return this.ToString(0, this.int_0);
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x000045AB File Offset: 0x000027AB
		[NullableContext(1)]
		public string ToString(int start, int length)
		{
			return new string(this.char_0, start, length);
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000880 RID: 2176 RVA: 0x000045BA File Offset: 0x000027BA
		public char[] InternalBuffer
		{
			get
			{
				return this.char_0;
			}
		}

		// Token: 0x04000494 RID: 1172
		private char[] char_0;

		// Token: 0x04000495 RID: 1173
		private int int_0;
	}
}
