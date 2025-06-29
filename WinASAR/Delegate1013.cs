using System;

// Token: 0x02000605 RID: 1541
internal sealed class Delegate1013 : MulticastDelegate
{
	// Token: 0x060027A8 RID: 10152
	public extern long Invoke(object object_0);

	// Token: 0x060027A9 RID: 10153 RVA: 0x0000E616 File Offset: 0x0000C816
	public static long smethod_0(object object_0, Delegate1013 delegate1013_1)
	{
		return delegate1013_1(object_0);
	}

	// Token: 0x060027AA RID: 10154
	public extern Delegate1013(object object_0, IntPtr intptr_0);

	// Token: 0x060027AB RID: 10155 RVA: 0x0000E621 File Offset: 0x0000C821
	static Delegate1013()
	{
		Class15.smethod_14(typeof(Delegate1013).TypeHandle);
	}

	// Token: 0x04000DD5 RID: 3541
	internal static Delegate1013 delegate1013_0;
}
