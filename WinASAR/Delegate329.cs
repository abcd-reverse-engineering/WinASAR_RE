using System;

// Token: 0x02000359 RID: 857
internal sealed class Delegate329 : MulticastDelegate
{
	// Token: 0x06001CF8 RID: 7416
	public extern bool Invoke(double double_0);

	// Token: 0x06001CF9 RID: 7417 RVA: 0x0000A1CF File Offset: 0x000083CF
	public static bool smethod_0(double double_0, Delegate329 delegate329_1)
	{
		return delegate329_1(double_0);
	}

	// Token: 0x06001CFA RID: 7418
	public extern Delegate329(object object_0, IntPtr intptr_0);

	// Token: 0x06001CFB RID: 7419 RVA: 0x0000A1DA File Offset: 0x000083DA
	static Delegate329()
	{
		Class15.smethod_14(typeof(Delegate329).TypeHandle);
	}

	// Token: 0x04000B29 RID: 2857
	internal static Delegate329 delegate329_0;
}
