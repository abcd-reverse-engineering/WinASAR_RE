using System;

// Token: 0x02000613 RID: 1555
internal sealed class Delegate1027 : MulticastDelegate
{
	// Token: 0x060027E0 RID: 10208
	public extern long Invoke(ref IntPtr intptr_0);

	// Token: 0x060027E1 RID: 10209 RVA: 0x0000E772 File Offset: 0x0000C972
	public static long smethod_0(ref IntPtr intptr_0, Delegate1027 delegate1027_1)
	{
		return delegate1027_1(ref intptr_0);
	}

	// Token: 0x060027E2 RID: 10210
	public extern Delegate1027(object object_0, IntPtr intptr_0);

	// Token: 0x060027E3 RID: 10211 RVA: 0x0000E77D File Offset: 0x0000C97D
	static Delegate1027()
	{
		Class15.smethod_14(typeof(Delegate1027).TypeHandle);
	}

	// Token: 0x04000DE3 RID: 3555
	internal static Delegate1027 delegate1027_0;
}
