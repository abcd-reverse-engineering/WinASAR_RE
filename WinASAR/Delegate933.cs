using System;

// Token: 0x020005B5 RID: 1461
internal sealed class Delegate933 : MulticastDelegate
{
	// Token: 0x06002668 RID: 9832
	public extern void Invoke(object object_0, string string_0, string string_1);

	// Token: 0x06002669 RID: 9833 RVA: 0x0000DDF6 File Offset: 0x0000BFF6
	public static void smethod_0(object object_0, string string_0, string string_1, Delegate933 delegate933_1)
	{
		delegate933_1(object_0, string_0, string_1);
	}

	// Token: 0x0600266A RID: 9834
	public extern Delegate933(object object_0, IntPtr intptr_0);

	// Token: 0x0600266B RID: 9835 RVA: 0x0000DE05 File Offset: 0x0000C005
	static Delegate933()
	{
		Class15.smethod_14(typeof(Delegate933).TypeHandle);
	}

	// Token: 0x04000D85 RID: 3461
	internal static Delegate933 delegate933_0;
}
