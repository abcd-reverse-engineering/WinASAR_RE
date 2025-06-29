using System;

// Token: 0x0200030A RID: 778
internal sealed class Delegate250 : MulticastDelegate
{
	// Token: 0x06001BBC RID: 7100
	public extern void Invoke(object object_0, string string_0);

	// Token: 0x06001BBD RID: 7101 RVA: 0x000099F3 File Offset: 0x00007BF3
	public static void smethod_0(object object_0, string string_0, Delegate250 delegate250_1)
	{
		delegate250_1(object_0, string_0);
	}

	// Token: 0x06001BBE RID: 7102
	public extern Delegate250(object object_0, IntPtr intptr_0);

	// Token: 0x06001BBF RID: 7103 RVA: 0x00009A00 File Offset: 0x00007C00
	static Delegate250()
	{
		Class15.smethod_14(typeof(Delegate250).TypeHandle);
	}

	// Token: 0x04000ADA RID: 2778
	internal static Delegate250 delegate250_0;
}
