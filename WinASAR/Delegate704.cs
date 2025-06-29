using System;

// Token: 0x020004D0 RID: 1232
internal sealed class Delegate704 : MulticastDelegate
{
	// Token: 0x060022D4 RID: 8916
	public extern bool Invoke(object object_0);

	// Token: 0x060022D5 RID: 8917 RVA: 0x0000C77E File Offset: 0x0000A97E
	public static bool smethod_0(object object_0, Delegate704 delegate704_1)
	{
		return delegate704_1(object_0);
	}

	// Token: 0x060022D6 RID: 8918
	public extern Delegate704(object object_0, IntPtr intptr_0);

	// Token: 0x060022D7 RID: 8919 RVA: 0x0000C789 File Offset: 0x0000A989
	static Delegate704()
	{
		Class15.smethod_14(typeof(Delegate704).TypeHandle);
	}

	// Token: 0x04000CA0 RID: 3232
	internal static Delegate704 delegate704_0;
}
