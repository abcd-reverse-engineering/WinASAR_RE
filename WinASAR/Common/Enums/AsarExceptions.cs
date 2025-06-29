using System;
using System.ComponentModel;

namespace WinASAR.Common.Enums
{
	// Token: 0x02000031 RID: 49
	public enum AsarExceptions
	{
		// Token: 0x04000179 RID: 377
		[Description("没有选择文件，你需要先选择文件")]
		NoFileSelected = 101,
		// Token: 0x0400017A RID: 378
		[Description("ASAR 文件路径与保存路径相同，无法执行操作")]
		FilePathIsSame,
		// Token: 0x0400017B RID: 379
		[Description("找不到文件，请重新选择文件")]
		FileNotFound = 404,
		// Token: 0x0400017C RID: 380
		[Description("在选中的对象中没有发现 ASAR 文件")]
		FileAsarNotFound,
		// Token: 0x0400017D RID: 381
		[Description("此功能暂未开放")]
		NotYetPublished = 901
	}
}
