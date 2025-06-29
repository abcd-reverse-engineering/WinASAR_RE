using System;

// Token: 0x020003F8 RID: 1016
internal sealed class Delegate488 : MulticastDelegate
{
	// Token: 0x06001F74 RID: 8052
	public extern TimeSpan Invoke(double double_0);

	// Token: 0x06001F75 RID: 8053 RVA: 0x0000B1EB File Offset: 0x000093EB
	public static TimeSpan smethod_0(double double_0, Delegate488 delegate488_1)
	{
		return delegate488_1(double_0);
	}

	// Token: 0x06001F76 RID: 8054
	public extern Delegate488(object object_0, IntPtr intptr_0);

	// Token: 0x06001F77 RID: 8055 RVA: 0x0000B1F6 File Offset: 0x000093F6
	static Delegate488()
	{
		Class15.smethod_14(typeof(Delegate488).TypeHandle);
	}

	// Token: 0x04000BC8 RID: 3016
	internal static Delegate488 delegate488_0;
}
