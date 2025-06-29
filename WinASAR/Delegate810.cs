using System;
using System.Numerics;

// Token: 0x0200053A RID: 1338
internal sealed class Delegate810 : MulticastDelegate
{
	// Token: 0x0600247C RID: 9340
	public extern BigInteger Invoke(BigInteger bigInteger_0, BigInteger bigInteger_1);

	// Token: 0x0600247D RID: 9341 RVA: 0x0000D1DE File Offset: 0x0000B3DE
	public static BigInteger smethod_0(BigInteger bigInteger_0, BigInteger bigInteger_1, Delegate810 delegate810_1)
	{
		return delegate810_1(bigInteger_0, bigInteger_1);
	}

	// Token: 0x0600247E RID: 9342
	public extern Delegate810(object object_0, IntPtr intptr_0);

	// Token: 0x0600247F RID: 9343 RVA: 0x0000D1EB File Offset: 0x0000B3EB
	static Delegate810()
	{
		Class15.smethod_14(typeof(Delegate810).TypeHandle);
	}

	// Token: 0x04000D0A RID: 3338
	internal static Delegate810 delegate810_0;
}
