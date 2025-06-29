using System;

// Token: 0x0200039F RID: 927
internal sealed class Delegate399 : MulticastDelegate
{
	// Token: 0x06001E10 RID: 7696
	public extern string Invoke(ref DateTimeOffset dateTimeOffset_0, string string_0, IFormatProvider iformatProvider_0);

	// Token: 0x06001E11 RID: 7697 RVA: 0x0000A8ED File Offset: 0x00008AED
	public static string smethod_0(ref DateTimeOffset dateTimeOffset_0, string string_0, IFormatProvider iformatProvider_0, Delegate399 delegate399_1)
	{
		return delegate399_1(ref dateTimeOffset_0, string_0, iformatProvider_0);
	}

	// Token: 0x06001E12 RID: 7698
	public extern Delegate399(object object_0, IntPtr intptr_0);

	// Token: 0x06001E13 RID: 7699 RVA: 0x0000A8FC File Offset: 0x00008AFC
	static Delegate399()
	{
		Class15.smethod_14(typeof(Delegate399).TypeHandle);
	}

	// Token: 0x04000B6F RID: 2927
	internal static Delegate399 delegate399_0;
}
