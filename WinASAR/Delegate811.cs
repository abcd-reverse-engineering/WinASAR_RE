using System;
using System.Numerics;

// Token: 0x0200053B RID: 1339
internal sealed class Delegate811 : MulticastDelegate
{
	// Token: 0x06002480 RID: 9344
	public extern BigInteger Invoke(BigInteger bigInteger_0, BigInteger bigInteger_1);

	// Token: 0x06002481 RID: 9345 RVA: 0x0000D1F8 File Offset: 0x0000B3F8
	public static BigInteger smethod_0(BigInteger bigInteger_0, BigInteger bigInteger_1, Delegate811 delegate811_1)
	{
		return delegate811_1(bigInteger_0, bigInteger_1);
	}

	// Token: 0x06002482 RID: 9346
	public extern Delegate811(object object_0, IntPtr intptr_0);

	// Token: 0x06002483 RID: 9347 RVA: 0x0000D205 File Offset: 0x0000B405
	static Delegate811()
	{
		Class15.smethod_14(typeof(Delegate811).TypeHandle);
	}

	// Token: 0x04000D0B RID: 3339
	internal static Delegate811 delegate811_0;
}
