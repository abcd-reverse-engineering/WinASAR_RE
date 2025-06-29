using System;
using System.Numerics;

// Token: 0x0200053C RID: 1340
internal sealed class Delegate812 : MulticastDelegate
{
	// Token: 0x06002484 RID: 9348
	public extern BigInteger Invoke(BigInteger bigInteger_0, BigInteger bigInteger_1);

	// Token: 0x06002485 RID: 9349 RVA: 0x0000D212 File Offset: 0x0000B412
	public static BigInteger smethod_0(BigInteger bigInteger_0, BigInteger bigInteger_1, Delegate812 delegate812_1)
	{
		return delegate812_1(bigInteger_0, bigInteger_1);
	}

	// Token: 0x06002486 RID: 9350
	public extern Delegate812(object object_0, IntPtr intptr_0);

	// Token: 0x06002487 RID: 9351 RVA: 0x0000D21F File Offset: 0x0000B41F
	static Delegate812()
	{
		Class15.smethod_14(typeof(Delegate812).TypeHandle);
	}

	// Token: 0x04000D0C RID: 3340
	internal static Delegate812 delegate812_0;
}
