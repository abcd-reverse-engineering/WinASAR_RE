using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000CD RID: 205
	[NullableContext(2)]
	[Nullable(0)]
	internal class ReflectionMember
	{
		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000804 RID: 2052 RVA: 0x00004407 File Offset: 0x00002607
		// (set) Token: 0x06000805 RID: 2053 RVA: 0x0004EA54 File Offset: 0x0004CC54
		public Type MemberType
		{
			[CompilerGenerated]
			get
			{
				return this.type_0;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.type_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a != 0)
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

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000806 RID: 2054 RVA: 0x0000440F File Offset: 0x0000260F
		// (set) Token: 0x06000807 RID: 2055 RVA: 0x00004417 File Offset: 0x00002617
		[Nullable(new byte[] { 2, 1, 2 })]
		public Func<object, object> Getter
		{
			[return: Nullable(new byte[] { 2, 1, 2 })]
			get;
			[param: Nullable(new byte[] { 2, 1, 2 })]
			set;
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000808 RID: 2056 RVA: 0x00004420 File Offset: 0x00002620
		// (set) Token: 0x06000809 RID: 2057 RVA: 0x00004428 File Offset: 0x00002628
		[Nullable(new byte[] { 2, 1, 2 })]
		public Action<object, object> Setter
		{
			[return: Nullable(new byte[] { 2, 1, 2 })]
			get;
			[param: Nullable(new byte[] { 2, 1, 2 })]
			set;
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x0004EA8C File Offset: 0x0004CC8C
		public ReflectionMember()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x04000475 RID: 1141
		[CompilerGenerated]
		private Type type_0;

		// Token: 0x04000476 RID: 1142
		[Nullable(new byte[] { 2, 1, 2 })]
		[CompilerGenerated]
		private Func<object, object> func_0;

		// Token: 0x04000477 RID: 1143
		[Nullable(new byte[] { 2, 1, 2 })]
		[CompilerGenerated]
		private Action<object, object> action_0;
	}
}
