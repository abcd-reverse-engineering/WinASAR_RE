using System;

// Token: 0x020002A8 RID: 680
internal sealed class Delegate152 : MulticastDelegate
{
	// Token: 0x06001A34 RID: 6708
	public extern void Invoke(string string_0, string string_1, bool bool_0);

	// Token: 0x06001A35 RID: 6709 RVA: 0x0000903F File Offset: 0x0000723F
	public static void smethod_0(string string_0, string string_1, bool bool_0, Delegate152 delegate152_1)
	{
		delegate152_1(string_0, string_1, bool_0);
	}

	// Token: 0x06001A36 RID: 6710
	public extern Delegate152(object object_0, IntPtr intptr_0);

	// Token: 0x06001A37 RID: 6711 RVA: 0x0000904E File Offset: 0x0000724E
	static Delegate152()
	{
		Class15.smethod_14(typeof(Delegate152).TypeHandle);
	}

	// Token: 0x04000A78 RID: 2680
	internal static Delegate152 delegate152_0;
}
