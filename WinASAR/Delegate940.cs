using System;

// Token: 0x020005BC RID: 1468
internal sealed class Delegate940 : MulticastDelegate
{
	// Token: 0x06002684 RID: 9860
	public extern string Invoke(string string_0);

	// Token: 0x06002685 RID: 9861 RVA: 0x0000DEA6 File Offset: 0x0000C0A6
	public static string smethod_0(string string_0, Delegate940 delegate940_1)
	{
		return delegate940_1(string_0);
	}

	// Token: 0x06002686 RID: 9862
	public extern Delegate940(object object_0, IntPtr intptr_0);

	// Token: 0x06002687 RID: 9863 RVA: 0x0000DEB1 File Offset: 0x0000C0B1
	static Delegate940()
	{
		Class15.smethod_14(typeof(Delegate940).TypeHandle);
	}

	// Token: 0x04000D8C RID: 3468
	internal static Delegate940 delegate940_0;
}
