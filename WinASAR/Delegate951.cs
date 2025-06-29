using System;

// Token: 0x020005C7 RID: 1479
internal sealed class Delegate951 : MulticastDelegate
{
	// Token: 0x060026B0 RID: 9904
	public extern string Invoke(string string_0);

	// Token: 0x060026B1 RID: 9905 RVA: 0x0000DFB6 File Offset: 0x0000C1B6
	public static string smethod_0(string string_0, Delegate951 delegate951_1)
	{
		return delegate951_1(string_0);
	}

	// Token: 0x060026B2 RID: 9906
	public extern Delegate951(object object_0, IntPtr intptr_0);

	// Token: 0x060026B3 RID: 9907 RVA: 0x0000DFC1 File Offset: 0x0000C1C1
	static Delegate951()
	{
		Class15.smethod_14(typeof(Delegate951).TypeHandle);
	}

	// Token: 0x04000D97 RID: 3479
	internal static Delegate951 delegate951_0;
}
