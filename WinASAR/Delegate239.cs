using System;

// Token: 0x020002FF RID: 767
internal sealed class Delegate239 : MulticastDelegate
{
	// Token: 0x06001B90 RID: 7056
	public extern void Invoke(object object_0, bool bool_0);

	// Token: 0x06001B91 RID: 7057 RVA: 0x000098D5 File Offset: 0x00007AD5
	public static void smethod_0(object object_0, bool bool_0, Delegate239 delegate239_1)
	{
		delegate239_1(object_0, bool_0);
	}

	// Token: 0x06001B92 RID: 7058
	public extern Delegate239(object object_0, IntPtr intptr_0);

	// Token: 0x06001B93 RID: 7059 RVA: 0x000098E2 File Offset: 0x00007AE2
	static Delegate239()
	{
		Class15.smethod_14(typeof(Delegate239).TypeHandle);
	}

	// Token: 0x04000ACF RID: 2767
	internal static Delegate239 delegate239_0;
}
