using System;

// Token: 0x020005F4 RID: 1524
internal sealed class Delegate996 : MulticastDelegate
{
	// Token: 0x06002764 RID: 10084
	public extern int Invoke(object object_0);

	// Token: 0x06002765 RID: 10085 RVA: 0x0000E474 File Offset: 0x0000C674
	public static int smethod_0(object object_0, Delegate996 delegate996_1)
	{
		return delegate996_1(object_0);
	}

	// Token: 0x06002766 RID: 10086
	public extern Delegate996(object object_0, IntPtr intptr_0);

	// Token: 0x06002767 RID: 10087 RVA: 0x0000E47F File Offset: 0x0000C67F
	static Delegate996()
	{
		Class15.smethod_14(typeof(Delegate996).TypeHandle);
	}

	// Token: 0x04000DC4 RID: 3524
	internal static Delegate996 delegate996_0;
}
