using System;

// Token: 0x020005B7 RID: 1463
internal sealed class Delegate935 : MulticastDelegate
{
	// Token: 0x06002670 RID: 9840
	public extern string Invoke(string string_0);

	// Token: 0x06002671 RID: 9841 RVA: 0x0000DE2C File Offset: 0x0000C02C
	public static string smethod_0(string string_0, Delegate935 delegate935_1)
	{
		return delegate935_1(string_0);
	}

	// Token: 0x06002672 RID: 9842
	public extern Delegate935(object object_0, IntPtr intptr_0);

	// Token: 0x06002673 RID: 9843 RVA: 0x0000DE37 File Offset: 0x0000C037
	static Delegate935()
	{
		Class15.smethod_14(typeof(Delegate935).TypeHandle);
	}

	// Token: 0x04000D87 RID: 3463
	internal static Delegate935 delegate935_0;
}
