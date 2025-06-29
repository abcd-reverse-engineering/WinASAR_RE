using System;

// Token: 0x02000289 RID: 649
internal sealed class Delegate121 : MulticastDelegate
{
	// Token: 0x060019B8 RID: 6584
	public extern void Invoke(object object_0);

	// Token: 0x060019B9 RID: 6585 RVA: 0x00008D39 File Offset: 0x00006F39
	public static void smethod_0(object object_0, Delegate121 delegate121_1)
	{
		delegate121_1(object_0);
	}

	// Token: 0x060019BA RID: 6586
	public extern Delegate121(object object_0, IntPtr intptr_0);

	// Token: 0x060019BB RID: 6587 RVA: 0x00008D44 File Offset: 0x00006F44
	static Delegate121()
	{
		Class15.smethod_14(typeof(Delegate121).TypeHandle);
	}

	// Token: 0x04000A59 RID: 2649
	internal static Delegate121 delegate121_0;
}
