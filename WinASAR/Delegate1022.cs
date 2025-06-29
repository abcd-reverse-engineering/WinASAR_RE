using System;

// Token: 0x0200060E RID: 1550
internal sealed class Delegate1022 : MulticastDelegate
{
	// Token: 0x060027CC RID: 10188
	public extern string Invoke(ref int int_0);

	// Token: 0x060027CD RID: 10189 RVA: 0x0000E6FA File Offset: 0x0000C8FA
	public static string smethod_0(ref int int_0, Delegate1022 delegate1022_1)
	{
		return delegate1022_1(ref int_0);
	}

	// Token: 0x060027CE RID: 10190
	public extern Delegate1022(object object_0, IntPtr intptr_0);

	// Token: 0x060027CF RID: 10191 RVA: 0x0000E705 File Offset: 0x0000C905
	static Delegate1022()
	{
		Class15.smethod_14(typeof(Delegate1022).TypeHandle);
	}

	// Token: 0x04000DDE RID: 3550
	internal static Delegate1022 delegate1022_0;
}
