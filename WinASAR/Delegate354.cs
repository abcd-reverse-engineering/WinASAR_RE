using System;

// Token: 0x02000372 RID: 882
internal sealed class Delegate354 : MulticastDelegate
{
	// Token: 0x06001D5C RID: 7516
	public extern byte[] Invoke(string string_0);

	// Token: 0x06001D5D RID: 7517 RVA: 0x0000A45D File Offset: 0x0000865D
	public static byte[] smethod_0(string string_0, Delegate354 delegate354_1)
	{
		return delegate354_1(string_0);
	}

	// Token: 0x06001D5E RID: 7518
	public extern Delegate354(object object_0, IntPtr intptr_0);

	// Token: 0x06001D5F RID: 7519 RVA: 0x0000A468 File Offset: 0x00008668
	static Delegate354()
	{
		Class15.smethod_14(typeof(Delegate354).TypeHandle);
	}

	// Token: 0x04000B42 RID: 2882
	internal static Delegate354 delegate354_0;
}
