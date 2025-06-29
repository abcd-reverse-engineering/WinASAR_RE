using System;

// Token: 0x0200033F RID: 831
internal sealed class Delegate303 : MulticastDelegate
{
	// Token: 0x06001C90 RID: 7312
	public extern void Invoke(object object_0, string string_0, object object_1);

	// Token: 0x06001C91 RID: 7313 RVA: 0x00009F29 File Offset: 0x00008129
	public static void smethod_0(object object_0, string string_0, object object_1, Delegate303 delegate303_1)
	{
		delegate303_1(object_0, string_0, object_1);
	}

	// Token: 0x06001C92 RID: 7314
	public extern Delegate303(object object_0, IntPtr intptr_0);

	// Token: 0x06001C93 RID: 7315 RVA: 0x00009F38 File Offset: 0x00008138
	static Delegate303()
	{
		Class15.smethod_14(typeof(Delegate303).TypeHandle);
	}

	// Token: 0x04000B0F RID: 2831
	internal static Delegate303 delegate303_0;
}
