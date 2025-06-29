using System;

// Token: 0x02000355 RID: 853
internal sealed class Delegate325 : MulticastDelegate
{
	// Token: 0x06001CE8 RID: 7400
	public extern string Invoke(ref long long_0, string string_0, IFormatProvider iformatProvider_0);

	// Token: 0x06001CE9 RID: 7401 RVA: 0x0000A15F File Offset: 0x0000835F
	public static string smethod_0(ref long long_0, string string_0, IFormatProvider iformatProvider_0, Delegate325 delegate325_1)
	{
		return delegate325_1(ref long_0, string_0, iformatProvider_0);
	}

	// Token: 0x06001CEA RID: 7402
	public extern Delegate325(object object_0, IntPtr intptr_0);

	// Token: 0x06001CEB RID: 7403 RVA: 0x0000A16E File Offset: 0x0000836E
	static Delegate325()
	{
		Class15.smethod_14(typeof(Delegate325).TypeHandle);
	}

	// Token: 0x04000B25 RID: 2853
	internal static Delegate325 delegate325_0;
}
