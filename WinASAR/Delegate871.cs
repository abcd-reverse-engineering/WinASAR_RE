using System;

// Token: 0x02000577 RID: 1399
internal sealed class Delegate871 : MulticastDelegate
{
	// Token: 0x06002570 RID: 9584
	public extern string Invoke(object object_0);

	// Token: 0x06002571 RID: 9585 RVA: 0x0000D80A File Offset: 0x0000BA0A
	public static string smethod_0(object object_0, Delegate871 delegate871_1)
	{
		return delegate871_1(object_0);
	}

	// Token: 0x06002572 RID: 9586
	public extern Delegate871(object object_0, IntPtr intptr_0);

	// Token: 0x06002573 RID: 9587 RVA: 0x0000D815 File Offset: 0x0000BA15
	static Delegate871()
	{
		Class15.smethod_14(typeof(Delegate871).TypeHandle);
	}

	// Token: 0x04000D47 RID: 3399
	internal static Delegate871 delegate871_0;
}
