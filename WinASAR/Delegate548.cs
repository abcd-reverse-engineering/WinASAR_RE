using System;

// Token: 0x02000434 RID: 1076
internal sealed class Delegate548 : MulticastDelegate
{
	// Token: 0x06002064 RID: 8292
	public extern bool Invoke(object object_0);

	// Token: 0x06002065 RID: 8293 RVA: 0x0000B7F5 File Offset: 0x000099F5
	public static bool smethod_0(object object_0, Delegate548 delegate548_1)
	{
		return delegate548_1(object_0);
	}

	// Token: 0x06002066 RID: 8294
	public extern Delegate548(object object_0, IntPtr intptr_0);

	// Token: 0x06002067 RID: 8295 RVA: 0x0000B800 File Offset: 0x00009A00
	static Delegate548()
	{
		Class15.smethod_14(typeof(Delegate548).TypeHandle);
	}

	// Token: 0x04000C04 RID: 3076
	internal static Delegate548 delegate548_0;
}
