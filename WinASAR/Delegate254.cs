using System;

// Token: 0x0200030E RID: 782
internal sealed class Delegate254 : MulticastDelegate
{
	// Token: 0x06001BCC RID: 7116
	public extern void Invoke(object object_0, bool bool_0);

	// Token: 0x06001BCD RID: 7117 RVA: 0x00009A5B File Offset: 0x00007C5B
	public static void smethod_0(object object_0, bool bool_0, Delegate254 delegate254_1)
	{
		delegate254_1(object_0, bool_0);
	}

	// Token: 0x06001BCE RID: 7118
	public extern Delegate254(object object_0, IntPtr intptr_0);

	// Token: 0x06001BCF RID: 7119 RVA: 0x00009A68 File Offset: 0x00007C68
	static Delegate254()
	{
		Class15.smethod_14(typeof(Delegate254).TypeHandle);
	}

	// Token: 0x04000ADE RID: 2782
	internal static Delegate254 delegate254_0;
}
