using System;
using System.Numerics;

// Token: 0x02000356 RID: 854
internal sealed class Delegate326 : MulticastDelegate
{
	// Token: 0x06001CEC RID: 7404
	public extern string Invoke(ref BigInteger bigInteger_0, string string_0, IFormatProvider iformatProvider_0);

	// Token: 0x06001CED RID: 7405 RVA: 0x0000A17B File Offset: 0x0000837B
	public static string smethod_0(ref BigInteger bigInteger_0, string string_0, IFormatProvider iformatProvider_0, Delegate326 delegate326_1)
	{
		return delegate326_1(ref bigInteger_0, string_0, iformatProvider_0);
	}

	// Token: 0x06001CEE RID: 7406
	public extern Delegate326(object object_0, IntPtr intptr_0);

	// Token: 0x06001CEF RID: 7407 RVA: 0x0000A18A File Offset: 0x0000838A
	static Delegate326()
	{
		Class15.smethod_14(typeof(Delegate326).TypeHandle);
	}

	// Token: 0x04000B26 RID: 2854
	internal static Delegate326 delegate326_0;
}
