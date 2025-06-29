using System;
using System.Numerics;

// Token: 0x0200053D RID: 1341
internal sealed class Delegate813 : MulticastDelegate
{
	// Token: 0x06002488 RID: 9352
	public extern BigInteger Invoke(BigInteger bigInteger_0, BigInteger bigInteger_1);

	// Token: 0x06002489 RID: 9353 RVA: 0x0000D22C File Offset: 0x0000B42C
	public static BigInteger smethod_0(BigInteger bigInteger_0, BigInteger bigInteger_1, Delegate813 delegate813_1)
	{
		return delegate813_1(bigInteger_0, bigInteger_1);
	}

	// Token: 0x0600248A RID: 9354
	public extern Delegate813(object object_0, IntPtr intptr_0);

	// Token: 0x0600248B RID: 9355 RVA: 0x0000D239 File Offset: 0x0000B439
	static Delegate813()
	{
		Class15.smethod_14(typeof(Delegate813).TypeHandle);
	}

	// Token: 0x04000D0D RID: 3341
	internal static Delegate813 delegate813_0;
}
