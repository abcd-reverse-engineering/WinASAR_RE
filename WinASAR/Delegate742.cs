using System;

// Token: 0x020004F6 RID: 1270
internal sealed class Delegate742 : MulticastDelegate
{
	// Token: 0x0600236C RID: 9068
	public extern string Invoke(string string_0, string string_1, string string_2, string string_3);

	// Token: 0x0600236D RID: 9069 RVA: 0x0000CB22 File Offset: 0x0000AD22
	public static string smethod_0(string string_0, string string_1, string string_2, string string_3, Delegate742 delegate742_1)
	{
		return delegate742_1(string_0, string_1, string_2, string_3);
	}

	// Token: 0x0600236E RID: 9070
	public extern Delegate742(object object_0, IntPtr intptr_0);

	// Token: 0x0600236F RID: 9071 RVA: 0x0000CB33 File Offset: 0x0000AD33
	static Delegate742()
	{
		Class15.smethod_14(typeof(Delegate742).TypeHandle);
	}

	// Token: 0x04000CC6 RID: 3270
	internal static Delegate742 delegate742_0;
}
