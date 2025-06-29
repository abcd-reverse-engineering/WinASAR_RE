using System;

// Token: 0x020002B0 RID: 688
internal sealed class Delegate160 : MulticastDelegate
{
	// Token: 0x06001A54 RID: 6740
	public extern void Invoke(object object_0, bool bool_0);

	// Token: 0x06001A55 RID: 6741 RVA: 0x00009105 File Offset: 0x00007305
	public static void smethod_0(object object_0, bool bool_0, Delegate160 delegate160_1)
	{
		delegate160_1(object_0, bool_0);
	}

	// Token: 0x06001A56 RID: 6742
	public extern Delegate160(object object_0, IntPtr intptr_0);

	// Token: 0x06001A57 RID: 6743 RVA: 0x00009112 File Offset: 0x00007312
	static Delegate160()
	{
		Class15.smethod_14(typeof(Delegate160).TypeHandle);
	}

	// Token: 0x04000A80 RID: 2688
	internal static Delegate160 delegate160_0;
}
