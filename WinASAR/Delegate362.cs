using System;
using System.Numerics;

// Token: 0x0200037A RID: 890
internal sealed class Delegate362 : MulticastDelegate
{
	// Token: 0x06001D7C RID: 7548
	public extern decimal Invoke(BigInteger bigInteger_0);

	// Token: 0x06001D7D RID: 7549 RVA: 0x0000A52D File Offset: 0x0000872D
	public static decimal smethod_0(BigInteger bigInteger_0, Delegate362 delegate362_1)
	{
		return delegate362_1(bigInteger_0);
	}

	// Token: 0x06001D7E RID: 7550
	public extern Delegate362(object object_0, IntPtr intptr_0);

	// Token: 0x06001D7F RID: 7551 RVA: 0x0000A538 File Offset: 0x00008738
	static Delegate362()
	{
		Class15.smethod_14(typeof(Delegate362).TypeHandle);
	}

	// Token: 0x04000B4A RID: 2890
	internal static Delegate362 delegate362_0;
}
