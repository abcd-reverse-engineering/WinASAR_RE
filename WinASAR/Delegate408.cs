using System;
using System.Numerics;

// Token: 0x020003A8 RID: 936
internal sealed class Delegate408 : MulticastDelegate
{
	// Token: 0x06001E34 RID: 7732
	public extern BigInteger Invoke(BigInteger bigInteger_0, BigInteger bigInteger_1);

	// Token: 0x06001E35 RID: 7733 RVA: 0x0000A9D3 File Offset: 0x00008BD3
	public static BigInteger smethod_0(BigInteger bigInteger_0, BigInteger bigInteger_1, Delegate408 delegate408_1)
	{
		return delegate408_1(bigInteger_0, bigInteger_1);
	}

	// Token: 0x06001E36 RID: 7734
	public extern Delegate408(object object_0, IntPtr intptr_0);

	// Token: 0x06001E37 RID: 7735 RVA: 0x0000A9E0 File Offset: 0x00008BE0
	static Delegate408()
	{
		Class15.smethod_14(typeof(Delegate408).TypeHandle);
	}

	// Token: 0x04000B78 RID: 2936
	internal static Delegate408 delegate408_0;
}
