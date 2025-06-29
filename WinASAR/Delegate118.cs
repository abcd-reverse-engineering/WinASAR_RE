using System;

// Token: 0x02000286 RID: 646
internal sealed class Delegate118 : MulticastDelegate
{
	// Token: 0x060019AC RID: 6572
	public extern char Invoke(object object_0, int int_0);

	// Token: 0x060019AD RID: 6573 RVA: 0x00008CEF File Offset: 0x00006EEF
	public static char smethod_0(object object_0, int int_0, Delegate118 delegate118_1)
	{
		return delegate118_1(object_0, int_0);
	}

	// Token: 0x060019AE RID: 6574
	public extern Delegate118(object object_0, IntPtr intptr_0);

	// Token: 0x060019AF RID: 6575 RVA: 0x00008CFC File Offset: 0x00006EFC
	static Delegate118()
	{
		Class15.smethod_14(typeof(Delegate118).TypeHandle);
	}

	// Token: 0x04000A56 RID: 2646
	internal static Delegate118 delegate118_0;
}
