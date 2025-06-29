using System;
using System.Numerics;

// Token: 0x02000374 RID: 884
internal sealed class Delegate356 : MulticastDelegate
{
	// Token: 0x06001D64 RID: 7524
	public extern double Invoke(BigInteger bigInteger_0);

	// Token: 0x06001D65 RID: 7525 RVA: 0x0000A48F File Offset: 0x0000868F
	public static double smethod_0(BigInteger bigInteger_0, Delegate356 delegate356_1)
	{
		return delegate356_1(bigInteger_0);
	}

	// Token: 0x06001D66 RID: 7526
	public extern Delegate356(object object_0, IntPtr intptr_0);

	// Token: 0x06001D67 RID: 7527 RVA: 0x0000A49A File Offset: 0x0000869A
	static Delegate356()
	{
		Class15.smethod_14(typeof(Delegate356).TypeHandle);
	}

	// Token: 0x04000B44 RID: 2884
	internal static Delegate356 delegate356_0;
}
