using System;

// Token: 0x0200022E RID: 558
internal sealed class Delegate30 : MulticastDelegate
{
	// Token: 0x0600184C RID: 6220
	public extern void Invoke(object object_0, string string_0);

	// Token: 0x0600184D RID: 6221 RVA: 0x0000843F File Offset: 0x0000663F
	public static void smethod_0(object object_0, string string_0, Delegate30 delegate30_1)
	{
		delegate30_1(object_0, string_0);
	}

	// Token: 0x0600184E RID: 6222
	public extern Delegate30(object object_0, IntPtr intptr_0);

	// Token: 0x0600184F RID: 6223 RVA: 0x0000844C File Offset: 0x0000664C
	static Delegate30()
	{
		Class15.smethod_14(typeof(Delegate30).TypeHandle);
	}

	// Token: 0x040009FE RID: 2558
	internal static Delegate30 delegate30_0;
}
