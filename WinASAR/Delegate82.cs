using System;

// Token: 0x02000262 RID: 610
internal sealed class Delegate82 : MulticastDelegate
{
	// Token: 0x0600191C RID: 6428
	public extern void Invoke(object object_0, string string_0);

	// Token: 0x0600191D RID: 6429 RVA: 0x00008963 File Offset: 0x00006B63
	public static void smethod_0(object object_0, string string_0, Delegate82 delegate82_1)
	{
		delegate82_1(object_0, string_0);
	}

	// Token: 0x0600191E RID: 6430
	public extern Delegate82(object object_0, IntPtr intptr_0);

	// Token: 0x0600191F RID: 6431 RVA: 0x00008970 File Offset: 0x00006B70
	static Delegate82()
	{
		Class15.smethod_14(typeof(Delegate82).TypeHandle);
	}

	// Token: 0x04000A32 RID: 2610
	internal static Delegate82 delegate82_0;
}
