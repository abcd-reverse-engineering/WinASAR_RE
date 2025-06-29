using System;

// Token: 0x020002CD RID: 717
internal sealed class Delegate189 : MulticastDelegate
{
	// Token: 0x06001AC8 RID: 6856
	public extern string Invoke(string string_0, string string_1, string string_2);

	// Token: 0x06001AC9 RID: 6857 RVA: 0x000093E1 File Offset: 0x000075E1
	public static string smethod_0(string string_0, string string_1, string string_2, Delegate189 delegate189_1)
	{
		return delegate189_1(string_0, string_1, string_2);
	}

	// Token: 0x06001ACA RID: 6858
	public extern Delegate189(object object_0, IntPtr intptr_0);

	// Token: 0x06001ACB RID: 6859 RVA: 0x000093F0 File Offset: 0x000075F0
	static Delegate189()
	{
		Class15.smethod_14(typeof(Delegate189).TypeHandle);
	}

	// Token: 0x04000A9D RID: 2717
	internal static Delegate189 delegate189_0;
}
