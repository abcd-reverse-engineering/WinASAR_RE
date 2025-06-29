using System;

// Token: 0x02000259 RID: 601
internal sealed class Delegate73 : MulticastDelegate
{
	// Token: 0x060018F8 RID: 6392
	public extern void Invoke(object object_0, string string_0);

	// Token: 0x060018F9 RID: 6393 RVA: 0x0000887F File Offset: 0x00006A7F
	public static void smethod_0(object object_0, string string_0, Delegate73 delegate73_1)
	{
		delegate73_1(object_0, string_0);
	}

	// Token: 0x060018FA RID: 6394
	public extern Delegate73(object object_0, IntPtr intptr_0);

	// Token: 0x060018FB RID: 6395 RVA: 0x0000888C File Offset: 0x00006A8C
	static Delegate73()
	{
		Class15.smethod_14(typeof(Delegate73).TypeHandle);
	}

	// Token: 0x04000A29 RID: 2601
	internal static Delegate73 delegate73_0;
}
