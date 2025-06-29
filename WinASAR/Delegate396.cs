using System;
using System.Numerics;

// Token: 0x0200039C RID: 924
internal sealed class Delegate396 : MulticastDelegate
{
	// Token: 0x06001E04 RID: 7684
	public extern string Invoke(ref BigInteger bigInteger_0, IFormatProvider iformatProvider_0);

	// Token: 0x06001E05 RID: 7685 RVA: 0x0000A89F File Offset: 0x00008A9F
	public static string smethod_0(ref BigInteger bigInteger_0, IFormatProvider iformatProvider_0, Delegate396 delegate396_1)
	{
		return delegate396_1(ref bigInteger_0, iformatProvider_0);
	}

	// Token: 0x06001E06 RID: 7686
	public extern Delegate396(object object_0, IntPtr intptr_0);

	// Token: 0x06001E07 RID: 7687 RVA: 0x0000A8AC File Offset: 0x00008AAC
	static Delegate396()
	{
		Class15.smethod_14(typeof(Delegate396).TypeHandle);
	}

	// Token: 0x04000B6C RID: 2924
	internal static Delegate396 delegate396_0;
}
