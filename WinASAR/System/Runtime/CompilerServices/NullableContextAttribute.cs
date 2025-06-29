using System;
using Microsoft.CodeAnalysis;

namespace System.Runtime.CompilerServices
{
	// Token: 0x0200003D RID: 61
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		// Token: 0x060001F0 RID: 496 RVA: 0x00026380 File Offset: 0x00024580
		public NullableContextAttribute(byte byte_0)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 == 0)
			{
				goto IL_0032;
			}
			IL_001A:
			this.Flag = byte_0;
			num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c != 0)
			{
				return;
			}
			IL_0032:
			switch (num)
			{
			case 1:
				goto IL_001A;
			}
		}

		// Token: 0x0400019F RID: 415
		public readonly byte Flag;
	}
}
