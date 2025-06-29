using System;
using System.Globalization;

// Token: 0x0200037C RID: 892
internal sealed class Delegate364 : MulticastDelegate
{
	// Token: 0x06001D84 RID: 7556
	public extern bool Invoke(string string_0, NumberStyles numberStyles_0, IFormatProvider iformatProvider_0, ref decimal decimal_0);

	// Token: 0x06001D85 RID: 7557 RVA: 0x0000A55F File Offset: 0x0000875F
	public static bool smethod_0(string string_0, NumberStyles numberStyles_0, IFormatProvider iformatProvider_0, ref decimal decimal_0, Delegate364 delegate364_1)
	{
		return delegate364_1(string_0, numberStyles_0, iformatProvider_0, ref decimal_0);
	}

	// Token: 0x06001D86 RID: 7558
	public extern Delegate364(object object_0, IntPtr intptr_0);

	// Token: 0x06001D87 RID: 7559 RVA: 0x0000A570 File Offset: 0x00008770
	static Delegate364()
	{
		Class15.smethod_14(typeof(Delegate364).TypeHandle);
	}

	// Token: 0x04000B4C RID: 2892
	internal static Delegate364 delegate364_0;
}
