using System;

// Token: 0x0200028B RID: 651
internal sealed class Delegate123 : MulticastDelegate
{
	// Token: 0x060019C0 RID: 6592
	public extern void Invoke(object object_0);

	// Token: 0x060019C1 RID: 6593 RVA: 0x00008D69 File Offset: 0x00006F69
	public static void smethod_0(object object_0, Delegate123 delegate123_1)
	{
		delegate123_1(object_0);
	}

	// Token: 0x060019C2 RID: 6594
	public extern Delegate123(object object_0, IntPtr intptr_0);

	// Token: 0x060019C3 RID: 6595 RVA: 0x00008D74 File Offset: 0x00006F74
	static Delegate123()
	{
		Class15.smethod_14(typeof(Delegate123).TypeHandle);
	}

	// Token: 0x04000A5B RID: 2651
	internal static Delegate123 delegate123_0;
}
