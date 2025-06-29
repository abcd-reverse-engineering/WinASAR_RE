using System;
using System.ComponentModel;

namespace WinASAR.Common.Enums
{
	// Token: 0x02000035 RID: 53
	public enum OverwriteTypes
	{
		// Token: 0x04000188 RID: 392
		[Description("覆盖前询问")]
		Ask,
		// Token: 0x04000189 RID: 393
		[Description("覆盖不提示")]
		Silent,
		// Token: 0x0400018A RID: 394
		[Description("跳过已存在的文件")]
		Skip
	}
}
