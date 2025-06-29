using System;

// Token: 0x02000471 RID: 1137
internal sealed class Delegate609 : MulticastDelegate
{
	// Token: 0x06002158 RID: 8536
	public extern int Invoke(string string_0, int int_0, string string_1, int int_1, int int_2, StringComparison stringComparison_0);

	// Token: 0x06002159 RID: 8537 RVA: 0x0000BE0B File Offset: 0x0000A00B
	public static int smethod_0(string string_0, int int_0, string string_1, int int_1, int int_2, StringComparison stringComparison_0, Delegate609 delegate609_1)
	{
		return delegate609_1(string_0, int_0, string_1, int_1, int_2, stringComparison_0);
	}

	// Token: 0x0600215A RID: 8538
	public extern Delegate609(object object_0, IntPtr intptr_0);

	// Token: 0x0600215B RID: 8539 RVA: 0x0000BE20 File Offset: 0x0000A020
	static Delegate609()
	{
		Class15.smethod_14(typeof(Delegate609).TypeHandle);
	}

	// Token: 0x04000C41 RID: 3137
	internal static Delegate609 delegate609_0;
}
