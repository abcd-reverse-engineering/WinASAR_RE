using System;

// Token: 0x0200026D RID: 621
internal sealed class Delegate93 : MulticastDelegate
{
	// Token: 0x06001948 RID: 6472
	public extern bool Invoke(object object_0);

	// Token: 0x06001949 RID: 6473 RVA: 0x00008A77 File Offset: 0x00006C77
	public static bool smethod_0(object object_0, Delegate93 delegate93_1)
	{
		return delegate93_1(object_0);
	}

	// Token: 0x0600194A RID: 6474
	public extern Delegate93(object object_0, IntPtr intptr_0);

	// Token: 0x0600194B RID: 6475 RVA: 0x00008A82 File Offset: 0x00006C82
	static Delegate93()
	{
		Class15.smethod_14(typeof(Delegate93).TypeHandle);
	}

	// Token: 0x04000A3D RID: 2621
	internal static Delegate93 delegate93_0;
}
