using System;
using System.Drawing;

// Token: 0x02000248 RID: 584
internal sealed class Delegate56 : MulticastDelegate
{
	// Token: 0x060018B4 RID: 6324
	public extern void Invoke(object object_0, Color color_0);

	// Token: 0x060018B5 RID: 6325 RVA: 0x000086CD File Offset: 0x000068CD
	public static void smethod_0(object object_0, Color color_0, Delegate56 delegate56_1)
	{
		delegate56_1(object_0, color_0);
	}

	// Token: 0x060018B6 RID: 6326
	public extern Delegate56(object object_0, IntPtr intptr_0);

	// Token: 0x060018B7 RID: 6327 RVA: 0x000086DA File Offset: 0x000068DA
	static Delegate56()
	{
		Class15.smethod_14(typeof(Delegate56).TypeHandle);
	}

	// Token: 0x04000A18 RID: 2584
	internal static Delegate56 delegate56_0;
}
