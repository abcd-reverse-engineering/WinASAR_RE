using System;

// Token: 0x02000404 RID: 1028
internal sealed class Delegate500 : MulticastDelegate
{
	// Token: 0x06001FA4 RID: 8100
	public extern int Invoke(ref TimeSpan timeSpan_0);

	// Token: 0x06001FA5 RID: 8101 RVA: 0x0000B321 File Offset: 0x00009521
	public static int smethod_0(ref TimeSpan timeSpan_0, Delegate500 delegate500_1)
	{
		return delegate500_1(ref timeSpan_0);
	}

	// Token: 0x06001FA6 RID: 8102
	public extern Delegate500(object object_0, IntPtr intptr_0);

	// Token: 0x06001FA7 RID: 8103 RVA: 0x0000B32C File Offset: 0x0000952C
	static Delegate500()
	{
		Class15.smethod_14(typeof(Delegate500).TypeHandle);
	}

	// Token: 0x04000BD4 RID: 3028
	internal static Delegate500 delegate500_0;
}
