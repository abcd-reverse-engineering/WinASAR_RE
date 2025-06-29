using System;

// Token: 0x020004A0 RID: 1184
internal sealed class Delegate656 : MulticastDelegate
{
	// Token: 0x06002214 RID: 8724
	public extern bool Invoke(object object_0);

	// Token: 0x06002215 RID: 8725 RVA: 0x0000C2C3 File Offset: 0x0000A4C3
	public static bool smethod_0(object object_0, Delegate656 delegate656_1)
	{
		return delegate656_1(object_0);
	}

	// Token: 0x06002216 RID: 8726
	public extern Delegate656(object object_0, IntPtr intptr_0);

	// Token: 0x06002217 RID: 8727 RVA: 0x0000C2CE File Offset: 0x0000A4CE
	static Delegate656()
	{
		Class15.smethod_14(typeof(Delegate656).TypeHandle);
	}

	// Token: 0x04000C70 RID: 3184
	internal static Delegate656 delegate656_0;
}
