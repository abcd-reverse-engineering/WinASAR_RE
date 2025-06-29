using System;
using System.Globalization;

// Token: 0x0200046C RID: 1132
internal sealed class Delegate604 : MulticastDelegate
{
	// Token: 0x06002144 RID: 8516
	public extern CultureInfo Invoke();

	// Token: 0x06002145 RID: 8517 RVA: 0x0000BD8B File Offset: 0x00009F8B
	public static CultureInfo smethod_0(Delegate604 delegate604_1)
	{
		return delegate604_1();
	}

	// Token: 0x06002146 RID: 8518
	public extern Delegate604(object object_0, IntPtr intptr_0);

	// Token: 0x06002147 RID: 8519 RVA: 0x0000BD94 File Offset: 0x00009F94
	static Delegate604()
	{
		Class15.smethod_14(typeof(Delegate604).TypeHandle);
	}

	// Token: 0x04000C3C RID: 3132
	internal static Delegate604 delegate604_0;
}
