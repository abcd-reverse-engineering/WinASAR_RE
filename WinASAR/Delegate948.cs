using System;

// Token: 0x020005C4 RID: 1476
internal sealed class Delegate948 : MulticastDelegate
{
	// Token: 0x060026A4 RID: 9892
	public extern string Invoke(bool bool_0);

	// Token: 0x060026A5 RID: 9893 RVA: 0x0000DF6C File Offset: 0x0000C16C
	public static string smethod_0(bool bool_0, Delegate948 delegate948_1)
	{
		return delegate948_1(bool_0);
	}

	// Token: 0x060026A6 RID: 9894
	public extern Delegate948(object object_0, IntPtr intptr_0);

	// Token: 0x060026A7 RID: 9895 RVA: 0x0000DF77 File Offset: 0x0000C177
	static Delegate948()
	{
		Class15.smethod_14(typeof(Delegate948).TypeHandle);
	}

	// Token: 0x04000D94 RID: 3476
	internal static Delegate948 delegate948_0;
}
