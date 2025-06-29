using System;

// Token: 0x02000264 RID: 612
internal sealed class Delegate84 : MulticastDelegate
{
	// Token: 0x06001924 RID: 6436
	public extern void Invoke(object object_0, int int_0);

	// Token: 0x06001925 RID: 6437 RVA: 0x00008997 File Offset: 0x00006B97
	public static void smethod_0(object object_0, int int_0, Delegate84 delegate84_1)
	{
		delegate84_1(object_0, int_0);
	}

	// Token: 0x06001926 RID: 6438
	public extern Delegate84(object object_0, IntPtr intptr_0);

	// Token: 0x06001927 RID: 6439 RVA: 0x000089A4 File Offset: 0x00006BA4
	static Delegate84()
	{
		Class15.smethod_14(typeof(Delegate84).TypeHandle);
	}

	// Token: 0x04000A34 RID: 2612
	internal static Delegate84 delegate84_0;
}
