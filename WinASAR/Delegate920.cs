using System;

// Token: 0x020005A8 RID: 1448
internal sealed class Delegate920 : MulticastDelegate
{
	// Token: 0x06002634 RID: 9780
	public extern void Invoke(object object_0, string string_0);

	// Token: 0x06002635 RID: 9781 RVA: 0x0000DCB8 File Offset: 0x0000BEB8
	public static void smethod_0(object object_0, string string_0, Delegate920 delegate920_1)
	{
		delegate920_1(object_0, string_0);
	}

	// Token: 0x06002636 RID: 9782
	public extern Delegate920(object object_0, IntPtr intptr_0);

	// Token: 0x06002637 RID: 9783 RVA: 0x0000DCC5 File Offset: 0x0000BEC5
	static Delegate920()
	{
		Class15.smethod_14(typeof(Delegate920).TypeHandle);
	}

	// Token: 0x04000D78 RID: 3448
	internal static Delegate920 delegate920_0;
}
