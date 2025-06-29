using System;

// Token: 0x02000595 RID: 1429
internal sealed class Delegate901 : MulticastDelegate
{
	// Token: 0x060025E8 RID: 9704
	public extern string Invoke(object object_0);

	// Token: 0x060025E9 RID: 9705 RVA: 0x0000DAE4 File Offset: 0x0000BCE4
	public static string smethod_0(object object_0, Delegate901 delegate901_1)
	{
		return delegate901_1(object_0);
	}

	// Token: 0x060025EA RID: 9706
	public extern Delegate901(object object_0, IntPtr intptr_0);

	// Token: 0x060025EB RID: 9707 RVA: 0x0000DAEF File Offset: 0x0000BCEF
	static Delegate901()
	{
		Class15.smethod_14(typeof(Delegate901).TypeHandle);
	}

	// Token: 0x04000D65 RID: 3429
	internal static Delegate901 delegate901_0;
}
