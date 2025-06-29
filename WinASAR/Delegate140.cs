using System;

// Token: 0x0200029C RID: 668
internal sealed class Delegate140 : MulticastDelegate
{
	// Token: 0x06001A04 RID: 6660
	public extern void Invoke(object object_0);

	// Token: 0x06001A05 RID: 6661 RVA: 0x00008F0B File Offset: 0x0000710B
	public static void smethod_0(object object_0, Delegate140 delegate140_1)
	{
		delegate140_1(object_0);
	}

	// Token: 0x06001A06 RID: 6662
	public extern Delegate140(object object_0, IntPtr intptr_0);

	// Token: 0x06001A07 RID: 6663 RVA: 0x00008F16 File Offset: 0x00007116
	static Delegate140()
	{
		Class15.smethod_14(typeof(Delegate140).TypeHandle);
	}

	// Token: 0x04000A6C RID: 2668
	internal static Delegate140 delegate140_0;
}
