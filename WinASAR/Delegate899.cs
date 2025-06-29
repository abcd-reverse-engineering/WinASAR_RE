using System;

// Token: 0x02000593 RID: 1427
internal sealed class Delegate899 : MulticastDelegate
{
	// Token: 0x060025E0 RID: 9696
	public extern string Invoke(object object_0);

	// Token: 0x060025E1 RID: 9697 RVA: 0x0000DAB4 File Offset: 0x0000BCB4
	public static string smethod_0(object object_0, Delegate899 delegate899_1)
	{
		return delegate899_1(object_0);
	}

	// Token: 0x060025E2 RID: 9698
	public extern Delegate899(object object_0, IntPtr intptr_0);

	// Token: 0x060025E3 RID: 9699 RVA: 0x0000DABF File Offset: 0x0000BCBF
	static Delegate899()
	{
		Class15.smethod_14(typeof(Delegate899).TypeHandle);
	}

	// Token: 0x04000D63 RID: 3427
	internal static Delegate899 delegate899_0;
}
