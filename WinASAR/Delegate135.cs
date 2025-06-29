using System;

// Token: 0x02000297 RID: 663
internal sealed class Delegate135 : MulticastDelegate
{
	// Token: 0x060019F0 RID: 6640
	public extern string Invoke(object object_0);

	// Token: 0x060019F1 RID: 6641 RVA: 0x00008E93 File Offset: 0x00007093
	public static string smethod_0(object object_0, Delegate135 delegate135_1)
	{
		return delegate135_1(object_0);
	}

	// Token: 0x060019F2 RID: 6642
	public extern Delegate135(object object_0, IntPtr intptr_0);

	// Token: 0x060019F3 RID: 6643 RVA: 0x00008E9E File Offset: 0x0000709E
	static Delegate135()
	{
		Class15.smethod_14(typeof(Delegate135).TypeHandle);
	}

	// Token: 0x04000A67 RID: 2663
	internal static Delegate135 delegate135_0;
}
