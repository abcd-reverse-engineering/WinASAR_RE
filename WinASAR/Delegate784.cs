using System;
using System.Numerics;

// Token: 0x02000520 RID: 1312
internal sealed class Delegate784 : MulticastDelegate
{
	// Token: 0x06002414 RID: 9236
	public extern short Invoke(BigInteger bigInteger_0);

	// Token: 0x06002415 RID: 9237 RVA: 0x0000CF4A File Offset: 0x0000B14A
	public static short smethod_0(BigInteger bigInteger_0, Delegate784 delegate784_1)
	{
		return delegate784_1(bigInteger_0);
	}

	// Token: 0x06002416 RID: 9238
	public extern Delegate784(object object_0, IntPtr intptr_0);

	// Token: 0x06002417 RID: 9239 RVA: 0x0000CF55 File Offset: 0x0000B155
	static Delegate784()
	{
		Class15.smethod_14(typeof(Delegate784).TypeHandle);
	}

	// Token: 0x04000CF0 RID: 3312
	internal static Delegate784 delegate784_0;
}
