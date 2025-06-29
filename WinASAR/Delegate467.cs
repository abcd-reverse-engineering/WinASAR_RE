using System;

// Token: 0x020003E3 RID: 995
internal sealed class Delegate467 : MulticastDelegate
{
	// Token: 0x06001F20 RID: 7968
	public extern decimal Invoke(decimal decimal_0, decimal decimal_1);

	// Token: 0x06001F21 RID: 7969 RVA: 0x0000AFD1 File Offset: 0x000091D1
	public static decimal smethod_0(decimal decimal_0, decimal decimal_1, Delegate467 delegate467_1)
	{
		return delegate467_1(decimal_0, decimal_1);
	}

	// Token: 0x06001F22 RID: 7970
	public extern Delegate467(object object_0, IntPtr intptr_0);

	// Token: 0x06001F23 RID: 7971 RVA: 0x0000AFDE File Offset: 0x000091DE
	static Delegate467()
	{
		Class15.smethod_14(typeof(Delegate467).TypeHandle);
	}

	// Token: 0x04000BB3 RID: 2995
	internal static Delegate467 delegate467_0;
}
