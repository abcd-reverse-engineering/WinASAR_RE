using System;

// Token: 0x02000507 RID: 1287
internal sealed class Delegate759 : MulticastDelegate
{
	// Token: 0x060023B0 RID: 9136
	public extern DateTime Invoke();

	// Token: 0x060023B1 RID: 9137 RVA: 0x0000CCD4 File Offset: 0x0000AED4
	public static DateTime smethod_0(Delegate759 delegate759_1)
	{
		return delegate759_1();
	}

	// Token: 0x060023B2 RID: 9138
	public extern Delegate759(object object_0, IntPtr intptr_0);

	// Token: 0x060023B3 RID: 9139 RVA: 0x0000CCDD File Offset: 0x0000AEDD
	static Delegate759()
	{
		Class15.smethod_14(typeof(Delegate759).TypeHandle);
	}

	// Token: 0x04000CD7 RID: 3287
	internal static Delegate759 delegate759_0;
}
