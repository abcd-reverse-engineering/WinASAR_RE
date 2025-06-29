using System;

// Token: 0x020004F8 RID: 1272
internal sealed class Delegate744 : MulticastDelegate
{
	// Token: 0x06002374 RID: 9076
	public extern void Invoke(object object_0, string string_0, object object_1);

	// Token: 0x06002375 RID: 9077 RVA: 0x0000CB5A File Offset: 0x0000AD5A
	public static void smethod_0(object object_0, string string_0, object object_1, Delegate744 delegate744_1)
	{
		delegate744_1(object_0, string_0, object_1);
	}

	// Token: 0x06002376 RID: 9078
	public extern Delegate744(object object_0, IntPtr intptr_0);

	// Token: 0x06002377 RID: 9079 RVA: 0x0000CB69 File Offset: 0x0000AD69
	static Delegate744()
	{
		Class15.smethod_14(typeof(Delegate744).TypeHandle);
	}

	// Token: 0x04000CC8 RID: 3272
	internal static Delegate744 delegate744_0;
}
