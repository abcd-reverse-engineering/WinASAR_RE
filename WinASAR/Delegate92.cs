using System;

// Token: 0x0200026C RID: 620
internal sealed class Delegate92 : MulticastDelegate
{
	// Token: 0x06001944 RID: 6468
	public extern bool Invoke(object object_0);

	// Token: 0x06001945 RID: 6469 RVA: 0x00008A5F File Offset: 0x00006C5F
	public static bool smethod_0(object object_0, Delegate92 delegate92_1)
	{
		return delegate92_1(object_0);
	}

	// Token: 0x06001946 RID: 6470
	public extern Delegate92(object object_0, IntPtr intptr_0);

	// Token: 0x06001947 RID: 6471 RVA: 0x00008A6A File Offset: 0x00006C6A
	static Delegate92()
	{
		Class15.smethod_14(typeof(Delegate92).TypeHandle);
	}

	// Token: 0x04000A3C RID: 2620
	internal static Delegate92 delegate92_0;
}
