using System;

// Token: 0x020002D3 RID: 723
internal sealed class Delegate195 : MulticastDelegate
{
	// Token: 0x06001AE0 RID: 6880
	public extern int Invoke(object object_0);

	// Token: 0x06001AE1 RID: 6881 RVA: 0x0000947B File Offset: 0x0000767B
	public static int smethod_0(object object_0, Delegate195 delegate195_1)
	{
		return delegate195_1(object_0);
	}

	// Token: 0x06001AE2 RID: 6882
	public extern Delegate195(object object_0, IntPtr intptr_0);

	// Token: 0x06001AE3 RID: 6883 RVA: 0x00009486 File Offset: 0x00007686
	static Delegate195()
	{
		Class15.smethod_14(typeof(Delegate195).TypeHandle);
	}

	// Token: 0x04000AA3 RID: 2723
	internal static Delegate195 delegate195_0;
}
