using System;

// Token: 0x02000395 RID: 917
internal sealed class Delegate389 : MulticastDelegate
{
	// Token: 0x06001DE8 RID: 7656
	public extern void Invoke(object object_0);

	// Token: 0x06001DE9 RID: 7657 RVA: 0x0000A7ED File Offset: 0x000089ED
	public static void smethod_0(object object_0, Delegate389 delegate389_1)
	{
		delegate389_1(object_0);
	}

	// Token: 0x06001DEA RID: 7658
	public extern Delegate389(object object_0, IntPtr intptr_0);

	// Token: 0x06001DEB RID: 7659 RVA: 0x0000A7F8 File Offset: 0x000089F8
	static Delegate389()
	{
		Class15.smethod_14(typeof(Delegate389).TypeHandle);
	}

	// Token: 0x04000B65 RID: 2917
	internal static Delegate389 delegate389_0;
}
