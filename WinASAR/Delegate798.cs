using System;
using System.Numerics;

// Token: 0x0200052E RID: 1326
internal sealed class Delegate798 : MulticastDelegate
{
	// Token: 0x0600244C RID: 9292
	public extern int Invoke(ref BigInteger bigInteger_0, BigInteger bigInteger_1);

	// Token: 0x0600244D RID: 9293 RVA: 0x0000D0AA File Offset: 0x0000B2AA
	public static int smethod_0(ref BigInteger bigInteger_0, BigInteger bigInteger_1, Delegate798 delegate798_1)
	{
		return delegate798_1(ref bigInteger_0, bigInteger_1);
	}

	// Token: 0x0600244E RID: 9294
	public extern Delegate798(object object_0, IntPtr intptr_0);

	// Token: 0x0600244F RID: 9295 RVA: 0x0000D0B7 File Offset: 0x0000B2B7
	static Delegate798()
	{
		Class15.smethod_14(typeof(Delegate798).TypeHandle);
	}

	// Token: 0x04000CFE RID: 3326
	internal static Delegate798 delegate798_0;
}
