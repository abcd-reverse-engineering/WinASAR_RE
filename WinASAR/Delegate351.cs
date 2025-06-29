using System;
using System.Globalization;

// Token: 0x0200036F RID: 879
internal sealed class Delegate351 : MulticastDelegate
{
	// Token: 0x06001D50 RID: 7504
	public extern bool Invoke(string string_0, NumberStyles numberStyles_0, IFormatProvider iformatProvider_0, ref int int_0);

	// Token: 0x06001D51 RID: 7505 RVA: 0x0000A40B File Offset: 0x0000860B
	public static bool smethod_0(string string_0, NumberStyles numberStyles_0, IFormatProvider iformatProvider_0, ref int int_0, Delegate351 delegate351_1)
	{
		return delegate351_1(string_0, numberStyles_0, iformatProvider_0, ref int_0);
	}

	// Token: 0x06001D52 RID: 7506
	public extern Delegate351(object object_0, IntPtr intptr_0);

	// Token: 0x06001D53 RID: 7507 RVA: 0x0000A41C File Offset: 0x0000861C
	static Delegate351()
	{
		Class15.smethod_14(typeof(Delegate351).TypeHandle);
	}

	// Token: 0x04000B3F RID: 2879
	internal static Delegate351 delegate351_0;
}
