using System;

// Token: 0x02000505 RID: 1285
internal sealed class Delegate757 : MulticastDelegate
{
	// Token: 0x060023A8 RID: 9128
	public extern bool Invoke(object object_0);

	// Token: 0x060023A9 RID: 9129 RVA: 0x0000CCA4 File Offset: 0x0000AEA4
	public static bool smethod_0(object object_0, Delegate757 delegate757_1)
	{
		return delegate757_1(object_0);
	}

	// Token: 0x060023AA RID: 9130
	public extern Delegate757(object object_0, IntPtr intptr_0);

	// Token: 0x060023AB RID: 9131 RVA: 0x0000CCAF File Offset: 0x0000AEAF
	static Delegate757()
	{
		Class15.smethod_14(typeof(Delegate757).TypeHandle);
	}

	// Token: 0x04000CD5 RID: 3285
	internal static Delegate757 delegate757_0;
}
