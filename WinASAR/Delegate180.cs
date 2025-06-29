using System;

// Token: 0x020002C4 RID: 708
internal sealed class Delegate180 : MulticastDelegate
{
	// Token: 0x06001AA4 RID: 6820
	public extern string Invoke();

	// Token: 0x06001AA5 RID: 6821 RVA: 0x000092FD File Offset: 0x000074FD
	public static string smethod_0(Delegate180 delegate180_1)
	{
		return delegate180_1();
	}

	// Token: 0x06001AA6 RID: 6822
	public extern Delegate180(object object_0, IntPtr intptr_0);

	// Token: 0x06001AA7 RID: 6823 RVA: 0x00009306 File Offset: 0x00007506
	static Delegate180()
	{
		Class15.smethod_14(typeof(Delegate180).TypeHandle);
	}

	// Token: 0x04000A94 RID: 2708
	internal static Delegate180 delegate180_0;
}
