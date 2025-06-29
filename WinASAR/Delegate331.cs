using System;

// Token: 0x0200035B RID: 859
internal sealed class Delegate331 : MulticastDelegate
{
	// Token: 0x06001D00 RID: 7424
	public extern string Invoke(ref double double_0, string string_0, IFormatProvider iformatProvider_0);

	// Token: 0x06001D01 RID: 7425 RVA: 0x0000A1FF File Offset: 0x000083FF
	public static string smethod_0(ref double double_0, string string_0, IFormatProvider iformatProvider_0, Delegate331 delegate331_1)
	{
		return delegate331_1(ref double_0, string_0, iformatProvider_0);
	}

	// Token: 0x06001D02 RID: 7426
	public extern Delegate331(object object_0, IntPtr intptr_0);

	// Token: 0x06001D03 RID: 7427 RVA: 0x0000A20E File Offset: 0x0000840E
	static Delegate331()
	{
		Class15.smethod_14(typeof(Delegate331).TypeHandle);
	}

	// Token: 0x04000B2B RID: 2859
	internal static Delegate331 delegate331_0;
}
