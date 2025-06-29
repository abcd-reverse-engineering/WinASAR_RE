using System;

// Token: 0x02000459 RID: 1113
internal sealed class Delegate585 : MulticastDelegate
{
	// Token: 0x060020F8 RID: 8440
	public extern Type Invoke(object object_0);

	// Token: 0x060020F9 RID: 8441 RVA: 0x0000BBAB File Offset: 0x00009DAB
	public static Type smethod_0(object object_0, Delegate585 delegate585_1)
	{
		return delegate585_1(object_0);
	}

	// Token: 0x060020FA RID: 8442
	public extern Delegate585(object object_0, IntPtr intptr_0);

	// Token: 0x060020FB RID: 8443 RVA: 0x0000BBB6 File Offset: 0x00009DB6
	static Delegate585()
	{
		Class15.smethod_14(typeof(Delegate585).TypeHandle);
	}

	// Token: 0x04000C29 RID: 3113
	internal static Delegate585 delegate585_0;
}
