using System;
using System.Numerics;

// Token: 0x020003D3 RID: 979
internal sealed class Delegate451 : MulticastDelegate
{
	// Token: 0x06001EE0 RID: 7904
	public extern long Invoke(BigInteger bigInteger_0);

	// Token: 0x06001EE1 RID: 7905 RVA: 0x0000AE29 File Offset: 0x00009029
	public static long smethod_0(BigInteger bigInteger_0, Delegate451 delegate451_1)
	{
		return delegate451_1(bigInteger_0);
	}

	// Token: 0x06001EE2 RID: 7906
	public extern Delegate451(object object_0, IntPtr intptr_0);

	// Token: 0x06001EE3 RID: 7907 RVA: 0x0000AE34 File Offset: 0x00009034
	static Delegate451()
	{
		Class15.smethod_14(typeof(Delegate451).TypeHandle);
	}

	// Token: 0x04000BA3 RID: 2979
	internal static Delegate451 delegate451_0;
}
