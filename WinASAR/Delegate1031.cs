using System;

// Token: 0x02000617 RID: 1559
internal sealed class Delegate1031 : MulticastDelegate
{
	// Token: 0x060027F0 RID: 10224
	public extern string Invoke(ref double double_0);

	// Token: 0x060027F1 RID: 10225 RVA: 0x0000E7D2 File Offset: 0x0000C9D2
	public static string smethod_0(ref double double_0, Delegate1031 delegate1031_1)
	{
		return delegate1031_1(ref double_0);
	}

	// Token: 0x060027F2 RID: 10226
	public extern Delegate1031(object object_0, IntPtr intptr_0);

	// Token: 0x060027F3 RID: 10227 RVA: 0x0000E7DD File Offset: 0x0000C9DD
	static Delegate1031()
	{
		Class15.smethod_14(typeof(Delegate1031).TypeHandle);
	}

	// Token: 0x04000DE7 RID: 3559
	internal static Delegate1031 delegate1031_0;
}
