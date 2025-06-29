using System;

// Token: 0x020005B6 RID: 1462
internal sealed class Delegate934 : MulticastDelegate
{
	// Token: 0x0600266C RID: 9836
	public extern string Invoke(object object_0, string string_0);

	// Token: 0x0600266D RID: 9837 RVA: 0x0000DE12 File Offset: 0x0000C012
	public static string smethod_0(object object_0, string string_0, Delegate934 delegate934_1)
	{
		return delegate934_1(object_0, string_0);
	}

	// Token: 0x0600266E RID: 9838
	public extern Delegate934(object object_0, IntPtr intptr_0);

	// Token: 0x0600266F RID: 9839 RVA: 0x0000DE1F File Offset: 0x0000C01F
	static Delegate934()
	{
		Class15.smethod_14(typeof(Delegate934).TypeHandle);
	}

	// Token: 0x04000D86 RID: 3462
	internal static Delegate934 delegate934_0;
}
