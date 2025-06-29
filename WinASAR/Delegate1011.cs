using System;

// Token: 0x02000603 RID: 1539
internal sealed class Delegate1011 : MulticastDelegate
{
	// Token: 0x060027A0 RID: 10144
	public extern long Invoke(object object_0);

	// Token: 0x060027A1 RID: 10145 RVA: 0x0000E5E4 File Offset: 0x0000C7E4
	public static long smethod_0(object object_0, Delegate1011 delegate1011_1)
	{
		return delegate1011_1(object_0);
	}

	// Token: 0x060027A2 RID: 10146
	public extern Delegate1011(object object_0, IntPtr intptr_0);

	// Token: 0x060027A3 RID: 10147 RVA: 0x0000E5EF File Offset: 0x0000C7EF
	static Delegate1011()
	{
		Class15.smethod_14(typeof(Delegate1011).TypeHandle);
	}

	// Token: 0x04000DD3 RID: 3539
	internal static Delegate1011 delegate1011_0;
}
