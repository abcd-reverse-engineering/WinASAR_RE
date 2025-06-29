using System;

// Token: 0x02000340 RID: 832
internal sealed class Delegate304 : MulticastDelegate
{
	// Token: 0x06001C94 RID: 7316
	public extern void Invoke(object object_0);

	// Token: 0x06001C95 RID: 7317 RVA: 0x00009F45 File Offset: 0x00008145
	public static void smethod_0(object object_0, Delegate304 delegate304_1)
	{
		delegate304_1(object_0);
	}

	// Token: 0x06001C96 RID: 7318
	public extern Delegate304(object object_0, IntPtr intptr_0);

	// Token: 0x06001C97 RID: 7319 RVA: 0x00009F50 File Offset: 0x00008150
	static Delegate304()
	{
		Class15.smethod_14(typeof(Delegate304).TypeHandle);
	}

	// Token: 0x04000B10 RID: 2832
	internal static Delegate304 delegate304_0;
}
