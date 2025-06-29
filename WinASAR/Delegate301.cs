using System;

// Token: 0x0200033D RID: 829
internal sealed class Delegate301 : MulticastDelegate
{
	// Token: 0x06001C88 RID: 7304
	public extern string Invoke(ref DateTime dateTime_0, string string_0);

	// Token: 0x06001C89 RID: 7305 RVA: 0x00009EF5 File Offset: 0x000080F5
	public static string smethod_0(ref DateTime dateTime_0, string string_0, Delegate301 delegate301_1)
	{
		return delegate301_1(ref dateTime_0, string_0);
	}

	// Token: 0x06001C8A RID: 7306
	public extern Delegate301(object object_0, IntPtr intptr_0);

	// Token: 0x06001C8B RID: 7307 RVA: 0x00009F02 File Offset: 0x00008102
	static Delegate301()
	{
		Class15.smethod_14(typeof(Delegate301).TypeHandle);
	}

	// Token: 0x04000B0D RID: 2829
	internal static Delegate301 delegate301_0;
}
