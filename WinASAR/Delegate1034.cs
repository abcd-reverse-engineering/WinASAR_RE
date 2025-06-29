using System;

// Token: 0x0200061A RID: 1562
internal sealed class Delegate1034 : MulticastDelegate
{
	// Token: 0x060027FC RID: 10236
	public extern void Invoke(IntPtr intptr_0);

	// Token: 0x060027FD RID: 10237 RVA: 0x0000E81E File Offset: 0x0000CA1E
	public static void smethod_0(IntPtr intptr_0, Delegate1034 delegate1034_1)
	{
		delegate1034_1(intptr_0);
	}

	// Token: 0x060027FE RID: 10238
	public extern Delegate1034(object object_0, IntPtr intptr_0);

	// Token: 0x060027FF RID: 10239 RVA: 0x0000E829 File Offset: 0x0000CA29
	static Delegate1034()
	{
		Class15.smethod_14(typeof(Delegate1034).TypeHandle);
	}

	// Token: 0x04000DEA RID: 3562
	internal static Delegate1034 delegate1034_0;
}
