using System;

// Token: 0x020005B4 RID: 1460
internal sealed class Delegate932 : MulticastDelegate
{
	// Token: 0x06002664 RID: 9828
	public extern void Invoke(object object_0);

	// Token: 0x06002665 RID: 9829 RVA: 0x0000DDDE File Offset: 0x0000BFDE
	public static void smethod_0(object object_0, Delegate932 delegate932_1)
	{
		delegate932_1(object_0);
	}

	// Token: 0x06002666 RID: 9830
	public extern Delegate932(object object_0, IntPtr intptr_0);

	// Token: 0x06002667 RID: 9831 RVA: 0x0000DDE9 File Offset: 0x0000BFE9
	static Delegate932()
	{
		Class15.smethod_14(typeof(Delegate932).TypeHandle);
	}

	// Token: 0x04000D84 RID: 3460
	internal static Delegate932 delegate932_0;
}
