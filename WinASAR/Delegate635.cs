using System;

// Token: 0x0200048B RID: 1163
internal sealed class Delegate635 : MulticastDelegate
{
	// Token: 0x060021C0 RID: 8640
	public extern bool Invoke(object object_0);

	// Token: 0x060021C1 RID: 8641 RVA: 0x0000C0B1 File Offset: 0x0000A2B1
	public static bool smethod_0(object object_0, Delegate635 delegate635_1)
	{
		return delegate635_1(object_0);
	}

	// Token: 0x060021C2 RID: 8642
	public extern Delegate635(object object_0, IntPtr intptr_0);

	// Token: 0x060021C3 RID: 8643 RVA: 0x0000C0BC File Offset: 0x0000A2BC
	static Delegate635()
	{
		Class15.smethod_14(typeof(Delegate635).TypeHandle);
	}

	// Token: 0x04000C5B RID: 3163
	internal static Delegate635 delegate635_0;
}
