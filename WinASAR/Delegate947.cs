using System;

// Token: 0x020005C3 RID: 1475
internal sealed class Delegate947 : MulticastDelegate
{
	// Token: 0x060026A0 RID: 9888
	public extern string Invoke(double double_0);

	// Token: 0x060026A1 RID: 9889 RVA: 0x0000DF54 File Offset: 0x0000C154
	public static string smethod_0(double double_0, Delegate947 delegate947_1)
	{
		return delegate947_1(double_0);
	}

	// Token: 0x060026A2 RID: 9890
	public extern Delegate947(object object_0, IntPtr intptr_0);

	// Token: 0x060026A3 RID: 9891 RVA: 0x0000DF5F File Offset: 0x0000C15F
	static Delegate947()
	{
		Class15.smethod_14(typeof(Delegate947).TypeHandle);
	}

	// Token: 0x04000D93 RID: 3475
	internal static Delegate947 delegate947_0;
}
