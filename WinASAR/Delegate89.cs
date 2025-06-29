using System;

// Token: 0x02000269 RID: 617
internal sealed class Delegate89 : MulticastDelegate
{
	// Token: 0x06001938 RID: 6456
	public extern string Invoke(string string_0, string string_1);

	// Token: 0x06001939 RID: 6457 RVA: 0x00008A11 File Offset: 0x00006C11
	public static string smethod_0(string string_0, string string_1, Delegate89 delegate89_1)
	{
		return delegate89_1(string_0, string_1);
	}

	// Token: 0x0600193A RID: 6458
	public extern Delegate89(object object_0, IntPtr intptr_0);

	// Token: 0x0600193B RID: 6459 RVA: 0x00008A1E File Offset: 0x00006C1E
	static Delegate89()
	{
		Class15.smethod_14(typeof(Delegate89).TypeHandle);
	}

	// Token: 0x04000A39 RID: 2617
	internal static Delegate89 delegate89_0;
}
