using System;
using System.Runtime.CompilerServices;

namespace System.Diagnostics.CodeAnalysis
{
	// Token: 0x0200003F RID: 63
	[AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false)]
	internal sealed class NotNullWhenAttribute : Attribute
	{
		// Token: 0x060001F8 RID: 504 RVA: 0x00026404 File Offset: 0x00024604
		public NotNullWhenAttribute(bool returnValue)
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 != 0)
			{
				goto IL_0032;
			}
			IL_001A:
			this.ReturnValue = returnValue;
			num = 1;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 != 0)
			{
				return;
			}
			IL_0032:
			switch (num)
			{
			case 0:
				goto IL_001A;
			case 1:
				break;
			default:
				goto IL_001A;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x000028EB File Offset: 0x00000AEB
		public bool ReturnValue { get; }

		// Token: 0x040001A2 RID: 418
		[CompilerGenerated]
		private readonly bool bool_0;
	}
}
