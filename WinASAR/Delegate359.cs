using System;
using System.Numerics;

// Token: 0x02000377 RID: 887
internal sealed class Delegate359 : MulticastDelegate
{
	// Token: 0x06001D70 RID: 7536
	public extern bool Invoke(BigInteger bigInteger_0, long long_0);

	// Token: 0x06001D71 RID: 7537 RVA: 0x0000A4DF File Offset: 0x000086DF
	public static bool smethod_0(BigInteger bigInteger_0, long long_0, Delegate359 delegate359_1)
	{
		return delegate359_1(bigInteger_0, long_0);
	}

	// Token: 0x06001D72 RID: 7538
	public extern Delegate359(object object_0, IntPtr intptr_0);

	// Token: 0x06001D73 RID: 7539 RVA: 0x0000A4EC File Offset: 0x000086EC
	static Delegate359()
	{
		Class15.smethod_14(typeof(Delegate359).TypeHandle);
	}

	// Token: 0x04000B47 RID: 2887
	internal static Delegate359 delegate359_0;
}
