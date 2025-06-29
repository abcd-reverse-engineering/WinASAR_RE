using System;
using System.Linq.Expressions;

// Token: 0x02000422 RID: 1058
internal sealed class Delegate530 : MulticastDelegate
{
	// Token: 0x0600201C RID: 8220
	public extern Expression Invoke(object object_0);

	// Token: 0x0600201D RID: 8221 RVA: 0x0000B62D File Offset: 0x0000982D
	public static Expression smethod_0(object object_0, Delegate530 delegate530_1)
	{
		return delegate530_1(object_0);
	}

	// Token: 0x0600201E RID: 8222
	public extern Delegate530(object object_0, IntPtr intptr_0);

	// Token: 0x0600201F RID: 8223 RVA: 0x0000B638 File Offset: 0x00009838
	static Delegate530()
	{
		Class15.smethod_14(typeof(Delegate530).TypeHandle);
	}

	// Token: 0x04000BF2 RID: 3058
	internal static Delegate530 delegate530_0;
}
