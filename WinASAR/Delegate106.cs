using System;

// Token: 0x0200027A RID: 634
internal sealed class Delegate106 : MulticastDelegate
{
	// Token: 0x0600197C RID: 6524
	public extern void Invoke(object object_0, bool bool_0);

	// Token: 0x0600197D RID: 6525 RVA: 0x00008BC5 File Offset: 0x00006DC5
	public static void smethod_0(object object_0, bool bool_0, Delegate106 delegate106_1)
	{
		delegate106_1(object_0, bool_0);
	}

	// Token: 0x0600197E RID: 6526
	public extern Delegate106(object object_0, IntPtr intptr_0);

	// Token: 0x0600197F RID: 6527 RVA: 0x00008BD2 File Offset: 0x00006DD2
	static Delegate106()
	{
		Class15.smethod_14(typeof(Delegate106).TypeHandle);
	}

	// Token: 0x04000A4A RID: 2634
	internal static Delegate106 delegate106_0;
}
