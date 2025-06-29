using System;
using System.Numerics;

// Token: 0x0200051E RID: 1310
internal sealed class Delegate782 : MulticastDelegate
{
	// Token: 0x0600240C RID: 9228
	public extern ushort Invoke(BigInteger bigInteger_0);

	// Token: 0x0600240D RID: 9229 RVA: 0x0000CF18 File Offset: 0x0000B118
	public static ushort smethod_0(BigInteger bigInteger_0, Delegate782 delegate782_1)
	{
		return delegate782_1(bigInteger_0);
	}

	// Token: 0x0600240E RID: 9230
	public extern Delegate782(object object_0, IntPtr intptr_0);

	// Token: 0x0600240F RID: 9231 RVA: 0x0000CF23 File Offset: 0x0000B123
	static Delegate782()
	{
		Class15.smethod_14(typeof(Delegate782).TypeHandle);
	}

	// Token: 0x04000CEE RID: 3310
	internal static Delegate782 delegate782_0;
}
