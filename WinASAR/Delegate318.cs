using System;
using System.Globalization;

// Token: 0x0200034E RID: 846
internal sealed class Delegate318 : MulticastDelegate
{
	// Token: 0x06001CCC RID: 7372
	public extern CultureInfo Invoke();

	// Token: 0x06001CCD RID: 7373 RVA: 0x0000A0A7 File Offset: 0x000082A7
	public static CultureInfo smethod_0(Delegate318 delegate318_1)
	{
		return delegate318_1();
	}

	// Token: 0x06001CCE RID: 7374
	public extern Delegate318(object object_0, IntPtr intptr_0);

	// Token: 0x06001CCF RID: 7375 RVA: 0x0000A0B0 File Offset: 0x000082B0
	static Delegate318()
	{
		Class15.smethod_14(typeof(Delegate318).TypeHandle);
	}

	// Token: 0x04000B1E RID: 2846
	internal static Delegate318 delegate318_0;
}
