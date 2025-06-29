using System;
using System.Diagnostics;

// Token: 0x02000346 RID: 838
internal sealed class Delegate310 : MulticastDelegate
{
	// Token: 0x06001CAC RID: 7340
	public extern Process[] Invoke(string string_0);

	// Token: 0x06001CAD RID: 7341 RVA: 0x00009FE5 File Offset: 0x000081E5
	public static Process[] smethod_0(string string_0, Delegate310 delegate310_1)
	{
		return delegate310_1(string_0);
	}

	// Token: 0x06001CAE RID: 7342
	public extern Delegate310(object object_0, IntPtr intptr_0);

	// Token: 0x06001CAF RID: 7343 RVA: 0x00009FF0 File Offset: 0x000081F0
	static Delegate310()
	{
		Class15.smethod_14(typeof(Delegate310).TypeHandle);
	}

	// Token: 0x04000B16 RID: 2838
	internal static Delegate310 delegate310_0;
}
