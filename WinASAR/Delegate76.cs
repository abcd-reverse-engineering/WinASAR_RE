using System;

// Token: 0x0200025C RID: 604
internal sealed class Delegate76 : MulticastDelegate
{
	// Token: 0x06001904 RID: 6404
	public extern void Invoke(object object_0);

	// Token: 0x06001905 RID: 6405 RVA: 0x000088CD File Offset: 0x00006ACD
	public static void smethod_0(object object_0, Delegate76 delegate76_1)
	{
		delegate76_1(object_0);
	}

	// Token: 0x06001906 RID: 6406
	public extern Delegate76(object object_0, IntPtr intptr_0);

	// Token: 0x06001907 RID: 6407 RVA: 0x000088D8 File Offset: 0x00006AD8
	static Delegate76()
	{
		Class15.smethod_14(typeof(Delegate76).TypeHandle);
	}

	// Token: 0x04000A2C RID: 2604
	internal static Delegate76 delegate76_0;
}
