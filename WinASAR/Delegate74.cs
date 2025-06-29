using System;

// Token: 0x0200025A RID: 602
internal sealed class Delegate74 : MulticastDelegate
{
	// Token: 0x060018FC RID: 6396
	public extern void Invoke(object object_0, bool bool_0);

	// Token: 0x060018FD RID: 6397 RVA: 0x00008899 File Offset: 0x00006A99
	public static void smethod_0(object object_0, bool bool_0, Delegate74 delegate74_1)
	{
		delegate74_1(object_0, bool_0);
	}

	// Token: 0x060018FE RID: 6398
	public extern Delegate74(object object_0, IntPtr intptr_0);

	// Token: 0x060018FF RID: 6399 RVA: 0x000088A6 File Offset: 0x00006AA6
	static Delegate74()
	{
		Class15.smethod_14(typeof(Delegate74).TypeHandle);
	}

	// Token: 0x04000A2A RID: 2602
	internal static Delegate74 delegate74_0;
}
