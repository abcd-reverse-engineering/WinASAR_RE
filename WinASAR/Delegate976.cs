using System;

// Token: 0x020005E0 RID: 1504
internal sealed class Delegate976 : MulticastDelegate
{
	// Token: 0x06002714 RID: 10004
	public extern sbyte Invoke(object object_0);

	// Token: 0x06002715 RID: 10005 RVA: 0x0000E24A File Offset: 0x0000C44A
	public static sbyte smethod_0(object object_0, Delegate976 delegate976_1)
	{
		return delegate976_1(object_0);
	}

	// Token: 0x06002716 RID: 10006
	public extern Delegate976(object object_0, IntPtr intptr_0);

	// Token: 0x06002717 RID: 10007 RVA: 0x0000E255 File Offset: 0x0000C455
	static Delegate976()
	{
		Class15.smethod_14(typeof(Delegate976).TypeHandle);
	}

	// Token: 0x04000DB0 RID: 3504
	internal static Delegate976 delegate976_0;
}
