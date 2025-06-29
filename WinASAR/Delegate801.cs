using System;

// Token: 0x02000531 RID: 1329
internal sealed class Delegate801 : MulticastDelegate
{
	// Token: 0x06002458 RID: 9304
	public extern int Invoke(ref decimal decimal_0, decimal decimal_1);

	// Token: 0x06002459 RID: 9305 RVA: 0x0000D0F4 File Offset: 0x0000B2F4
	public static int smethod_0(ref decimal decimal_0, decimal decimal_1, Delegate801 delegate801_1)
	{
		return delegate801_1(ref decimal_0, decimal_1);
	}

	// Token: 0x0600245A RID: 9306
	public extern Delegate801(object object_0, IntPtr intptr_0);

	// Token: 0x0600245B RID: 9307 RVA: 0x0000D101 File Offset: 0x0000B301
	static Delegate801()
	{
		Class15.smethod_14(typeof(Delegate801).TypeHandle);
	}

	// Token: 0x04000D01 RID: 3329
	internal static Delegate801 delegate801_0;
}
