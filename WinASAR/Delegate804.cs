using System;

// Token: 0x02000534 RID: 1332
internal sealed class Delegate804 : MulticastDelegate
{
	// Token: 0x06002464 RID: 9316
	public extern int Invoke(string string_0, string string_1);

	// Token: 0x06002465 RID: 9317 RVA: 0x0000D142 File Offset: 0x0000B342
	public static int smethod_0(string string_0, string string_1, Delegate804 delegate804_1)
	{
		return delegate804_1(string_0, string_1);
	}

	// Token: 0x06002466 RID: 9318
	public extern Delegate804(object object_0, IntPtr intptr_0);

	// Token: 0x06002467 RID: 9319 RVA: 0x0000D14F File Offset: 0x0000B34F
	static Delegate804()
	{
		Class15.smethod_14(typeof(Delegate804).TypeHandle);
	}

	// Token: 0x04000D04 RID: 3332
	internal static Delegate804 delegate804_0;
}
