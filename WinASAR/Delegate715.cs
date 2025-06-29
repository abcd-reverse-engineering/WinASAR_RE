using System;

// Token: 0x020004DB RID: 1243
internal sealed class Delegate715 : MulticastDelegate
{
	// Token: 0x06002300 RID: 8960
	public extern string Invoke(object object_0);

	// Token: 0x06002301 RID: 8961 RVA: 0x0000C88A File Offset: 0x0000AA8A
	public static string smethod_0(object object_0, Delegate715 delegate715_1)
	{
		return delegate715_1(object_0);
	}

	// Token: 0x06002302 RID: 8962
	public extern Delegate715(object object_0, IntPtr intptr_0);

	// Token: 0x06002303 RID: 8963 RVA: 0x0000C895 File Offset: 0x0000AA95
	static Delegate715()
	{
		Class15.smethod_14(typeof(Delegate715).TypeHandle);
	}

	// Token: 0x04000CAB RID: 3243
	internal static Delegate715 delegate715_0;
}
