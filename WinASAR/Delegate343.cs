using System;

// Token: 0x02000367 RID: 871
internal sealed class Delegate343 : MulticastDelegate
{
	// Token: 0x06001D30 RID: 7472
	public extern int Invoke(object object_0);

	// Token: 0x06001D31 RID: 7473 RVA: 0x0000A33F File Offset: 0x0000853F
	public static int smethod_0(object object_0, Delegate343 delegate343_1)
	{
		return delegate343_1(object_0);
	}

	// Token: 0x06001D32 RID: 7474
	public extern Delegate343(object object_0, IntPtr intptr_0);

	// Token: 0x06001D33 RID: 7475 RVA: 0x0000A34A File Offset: 0x0000854A
	static Delegate343()
	{
		Class15.smethod_14(typeof(Delegate343).TypeHandle);
	}

	// Token: 0x04000B37 RID: 2871
	internal static Delegate343 delegate343_0;
}
