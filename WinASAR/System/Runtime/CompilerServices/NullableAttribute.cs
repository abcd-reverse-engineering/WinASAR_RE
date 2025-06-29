using System;
using Microsoft.CodeAnalysis;

namespace System.Runtime.CompilerServices
{
	// Token: 0x0200003C RID: 60
	[CompilerGenerated]
	[Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		// Token: 0x060001EB RID: 491 RVA: 0x000262D0 File Offset: 0x000244D0
		public NullableAttribute(byte byte_0)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 != 0)
			{
				goto IL_003E;
			}
			do
			{
				IL_001A:
				this.NullableFlags = new byte[] { byte_0 };
				num = 1;
			}
			while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c == 0);
			IL_003E:
			switch (num)
			{
			case 0:
				goto IL_001A;
			case 1:
				return;
			default:
				goto IL_001A;
			}
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0002632C File Offset: 0x0002452C
		public NullableAttribute(byte[] byte_0)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 != 0)
			{
				goto IL_0035;
			}
			do
			{
				IL_001A:
				this.NullableFlags = byte_0;
				num = 1;
			}
			while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 == 0);
			IL_0035:
			switch (num)
			{
			case 0:
				goto IL_001A;
			case 1:
				return;
			default:
				goto IL_001A;
			}
		}

		// Token: 0x0400019D RID: 413
		public readonly byte[] NullableFlags;
	}
}
