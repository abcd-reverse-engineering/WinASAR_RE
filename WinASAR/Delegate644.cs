using System;

// Token: 0x02000494 RID: 1172
internal sealed class Delegate644 : MulticastDelegate
{
	// Token: 0x060021E4 RID: 8676
	public extern string Invoke(object object_0, int int_0, int int_1);

	// Token: 0x060021E5 RID: 8677 RVA: 0x0000C195 File Offset: 0x0000A395
	public static string smethod_0(object object_0, int int_0, int int_1, Delegate644 delegate644_1)
	{
		return delegate644_1(object_0, int_0, int_1);
	}

	// Token: 0x060021E6 RID: 8678
	public extern Delegate644(object object_0, IntPtr intptr_0);

	// Token: 0x060021E7 RID: 8679 RVA: 0x0000C1A4 File Offset: 0x0000A3A4
	static Delegate644()
	{
		Class15.smethod_14(typeof(Delegate644).TypeHandle);
	}

	// Token: 0x04000C64 RID: 3172
	internal static Delegate644 delegate644_0;
}
