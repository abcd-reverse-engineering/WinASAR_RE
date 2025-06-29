using System;

// Token: 0x0200040C RID: 1036
internal sealed class Delegate508 : MulticastDelegate
{
	// Token: 0x06001FC4 RID: 8132
	public extern void Invoke(object object_0);

	// Token: 0x06001FC5 RID: 8133 RVA: 0x0000B3EF File Offset: 0x000095EF
	public static void smethod_0(object object_0, Delegate508 delegate508_1)
	{
		delegate508_1(object_0);
	}

	// Token: 0x06001FC6 RID: 8134
	public extern Delegate508(object object_0, IntPtr intptr_0);

	// Token: 0x06001FC7 RID: 8135 RVA: 0x0000B3FA File Offset: 0x000095FA
	static Delegate508()
	{
		Class15.smethod_14(typeof(Delegate508).TypeHandle);
	}

	// Token: 0x04000BDC RID: 3036
	internal static Delegate508 delegate508_0;
}
