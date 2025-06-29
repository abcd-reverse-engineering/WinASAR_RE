using System;
using System.Numerics;

// Token: 0x0200036D RID: 877
internal sealed class Delegate349 : MulticastDelegate
{
	// Token: 0x06001D48 RID: 7496
	public extern int Invoke(BigInteger bigInteger_0);

	// Token: 0x06001D49 RID: 7497 RVA: 0x0000A3D9 File Offset: 0x000085D9
	public static int smethod_0(BigInteger bigInteger_0, Delegate349 delegate349_1)
	{
		return delegate349_1(bigInteger_0);
	}

	// Token: 0x06001D4A RID: 7498
	public extern Delegate349(object object_0, IntPtr intptr_0);

	// Token: 0x06001D4B RID: 7499 RVA: 0x0000A3E4 File Offset: 0x000085E4
	static Delegate349()
	{
		Class15.smethod_14(typeof(Delegate349).TypeHandle);
	}

	// Token: 0x04000B3D RID: 2877
	internal static Delegate349 delegate349_0;
}
