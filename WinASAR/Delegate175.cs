using System;

// Token: 0x020002BF RID: 703
internal sealed class Delegate175 : MulticastDelegate
{
	// Token: 0x06001A90 RID: 6800
	public extern void Invoke(object object_0, bool bool_0);

	// Token: 0x06001A91 RID: 6801 RVA: 0x00009283 File Offset: 0x00007483
	public static void smethod_0(object object_0, bool bool_0, Delegate175 delegate175_1)
	{
		delegate175_1(object_0, bool_0);
	}

	// Token: 0x06001A92 RID: 6802
	public extern Delegate175(object object_0, IntPtr intptr_0);

	// Token: 0x06001A93 RID: 6803 RVA: 0x00009290 File Offset: 0x00007490
	static Delegate175()
	{
		Class15.smethod_14(typeof(Delegate175).TypeHandle);
	}

	// Token: 0x04000A8F RID: 2703
	internal static Delegate175 delegate175_0;
}
