using System;

// Token: 0x0200022A RID: 554
internal sealed class Delegate26 : MulticastDelegate
{
	// Token: 0x0600183C RID: 6204
	public extern void Invoke(object object_0, string string_0);

	// Token: 0x0600183D RID: 6205 RVA: 0x000083DB File Offset: 0x000065DB
	public static void smethod_0(object object_0, string string_0, Delegate26 delegate26_1)
	{
		delegate26_1(object_0, string_0);
	}

	// Token: 0x0600183E RID: 6206
	public extern Delegate26(object object_0, IntPtr intptr_0);

	// Token: 0x0600183F RID: 6207 RVA: 0x000083E8 File Offset: 0x000065E8
	static Delegate26()
	{
		Class15.smethod_14(typeof(Delegate26).TypeHandle);
	}

	// Token: 0x040009FA RID: 2554
	internal static Delegate26 delegate26_0;
}
