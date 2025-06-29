using System;

// Token: 0x02000542 RID: 1346
internal sealed class Delegate818 : MulticastDelegate
{
	// Token: 0x0600249C RID: 9372
	public extern bool Invoke(char char_0);

	// Token: 0x0600249D RID: 9373 RVA: 0x0000D2B0 File Offset: 0x0000B4B0
	public static bool smethod_0(char char_0, Delegate818 delegate818_1)
	{
		return delegate818_1(char_0);
	}

	// Token: 0x0600249E RID: 9374
	public extern Delegate818(object object_0, IntPtr intptr_0);

	// Token: 0x0600249F RID: 9375 RVA: 0x0000D2BB File Offset: 0x0000B4BB
	static Delegate818()
	{
		Class15.smethod_14(typeof(Delegate818).TypeHandle);
	}

	// Token: 0x04000D12 RID: 3346
	internal static Delegate818 delegate818_0;
}
