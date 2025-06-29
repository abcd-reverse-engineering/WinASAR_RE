using System;

// Token: 0x0200027B RID: 635
internal sealed class Delegate107 : MulticastDelegate
{
	// Token: 0x06001980 RID: 6528
	public extern void Invoke(object object_0);

	// Token: 0x06001981 RID: 6529 RVA: 0x00008BDF File Offset: 0x00006DDF
	public static void smethod_0(object object_0, Delegate107 delegate107_1)
	{
		delegate107_1(object_0);
	}

	// Token: 0x06001982 RID: 6530
	public extern Delegate107(object object_0, IntPtr intptr_0);

	// Token: 0x06001983 RID: 6531 RVA: 0x00008BEA File Offset: 0x00006DEA
	static Delegate107()
	{
		Class15.smethod_14(typeof(Delegate107).TypeHandle);
	}

	// Token: 0x04000A4B RID: 2635
	internal static Delegate107 delegate107_0;
}
