using System;

// Token: 0x0200060F RID: 1551
internal sealed class Delegate1023 : MulticastDelegate
{
	// Token: 0x060027D0 RID: 10192
	public extern string Invoke(ref uint uint_0);

	// Token: 0x060027D1 RID: 10193 RVA: 0x0000E712 File Offset: 0x0000C912
	public static string smethod_0(ref uint uint_0, Delegate1023 delegate1023_1)
	{
		return delegate1023_1(ref uint_0);
	}

	// Token: 0x060027D2 RID: 10194
	public extern Delegate1023(object object_0, IntPtr intptr_0);

	// Token: 0x060027D3 RID: 10195 RVA: 0x0000E71D File Offset: 0x0000C91D
	static Delegate1023()
	{
		Class15.smethod_14(typeof(Delegate1023).TypeHandle);
	}

	// Token: 0x04000DDF RID: 3551
	internal static Delegate1023 delegate1023_0;
}
