using System;

// Token: 0x02000225 RID: 549
internal sealed class Delegate21 : MulticastDelegate
{
	// Token: 0x06001828 RID: 6184
	public extern string Invoke(string string_0, string[] string_1);

	// Token: 0x06001829 RID: 6185 RVA: 0x00008361 File Offset: 0x00006561
	public static string smethod_0(string string_0, string[] string_1, Delegate21 delegate21_1)
	{
		return delegate21_1(string_0, string_1);
	}

	// Token: 0x0600182A RID: 6186
	public extern Delegate21(object object_0, IntPtr intptr_0);

	// Token: 0x0600182B RID: 6187 RVA: 0x0000836E File Offset: 0x0000656E
	static Delegate21()
	{
		Class15.smethod_14(typeof(Delegate21).TypeHandle);
	}

	// Token: 0x040009F5 RID: 2549
	internal static Delegate21 delegate21_0;
}
