using System;

// Token: 0x02000362 RID: 866
internal sealed class Delegate338 : MulticastDelegate
{
	// Token: 0x06001D1C RID: 7452
	public extern string Invoke(object object_0);

	// Token: 0x06001D1D RID: 7453 RVA: 0x0000A2BF File Offset: 0x000084BF
	public static string smethod_0(object object_0, Delegate338 delegate338_1)
	{
		return delegate338_1(object_0);
	}

	// Token: 0x06001D1E RID: 7454
	public extern Delegate338(object object_0, IntPtr intptr_0);

	// Token: 0x06001D1F RID: 7455 RVA: 0x0000A2CA File Offset: 0x000084CA
	static Delegate338()
	{
		Class15.smethod_14(typeof(Delegate338).TypeHandle);
	}

	// Token: 0x04000B32 RID: 2866
	internal static Delegate338 delegate338_0;
}
