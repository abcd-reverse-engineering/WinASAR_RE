using System;
using System.Numerics;

// Token: 0x02000394 RID: 916
internal sealed class Delegate388 : MulticastDelegate
{
	// Token: 0x06001DE4 RID: 7652
	public extern BigInteger Invoke(string string_0, IFormatProvider iformatProvider_0);

	// Token: 0x06001DE5 RID: 7653 RVA: 0x0000A7D3 File Offset: 0x000089D3
	public static BigInteger smethod_0(string string_0, IFormatProvider iformatProvider_0, Delegate388 delegate388_1)
	{
		return delegate388_1(string_0, iformatProvider_0);
	}

	// Token: 0x06001DE6 RID: 7654
	public extern Delegate388(object object_0, IntPtr intptr_0);

	// Token: 0x06001DE7 RID: 7655 RVA: 0x0000A7E0 File Offset: 0x000089E0
	static Delegate388()
	{
		Class15.smethod_14(typeof(Delegate388).TypeHandle);
	}

	// Token: 0x04000B64 RID: 2916
	internal static Delegate388 delegate388_0;
}
