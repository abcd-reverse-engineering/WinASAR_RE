using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000D9 RID: 217
	[Nullable(0)]
	[NullableContext(1)]
	internal readonly struct StringReference
	{
		// Token: 0x17000114 RID: 276
		public char this[int i]
		{
			get
			{
				return this.char_0[i];
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000885 RID: 2181 RVA: 0x000045CC File Offset: 0x000027CC
		public char[] Chars
		{
			get
			{
				return this.char_0;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000886 RID: 2182 RVA: 0x000045D4 File Offset: 0x000027D4
		public int StartIndex
		{
			get
			{
				return this.int_0;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000887 RID: 2183 RVA: 0x000045DC File Offset: 0x000027DC
		public int Length
		{
			get
			{
				return this.int_1;
			}
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x00051894 File Offset: 0x0004FA94
		public StringReference(char[] chars, int startIndex, int length)
		{
			int num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d == 0)
			{
				goto IL_0050;
			}
			goto IL_0065;
			IL_0015:
			this.char_0 = chars;
			num = 2;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 != 0)
			{
				goto IL_0065;
			}
			IL_002E:
			this.int_0 = startIndex;
			IL_0035:
			this.int_1 = length;
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 == 0)
			{
				goto IL_0065;
			}
			return;
			IL_0050:
			num = 2;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c == 0)
			{
				goto IL_0015;
			}
			IL_0065:
			switch (num)
			{
			case 1:
				goto IL_0050;
			case 2:
				goto IL_0035;
			case 3:
				goto IL_002E;
			case 4:
				goto IL_0015;
			}
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x000045E4 File Offset: 0x000027E4
		public override string ToString()
		{
			return new string(this.char_0, this.int_0, this.int_1);
		}

		// Token: 0x04000497 RID: 1175
		private readonly char[] char_0;

		// Token: 0x04000498 RID: 1176
		private readonly int int_0;

		// Token: 0x04000499 RID: 1177
		private readonly int int_1;
	}
}
