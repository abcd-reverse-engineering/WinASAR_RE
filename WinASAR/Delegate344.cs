using System;
using System.Text;

// Token: 0x02000368 RID: 872
internal sealed class Delegate344 : MulticastDelegate
{
	// Token: 0x06001D34 RID: 7476
	public extern StringBuilder Invoke(object object_0, char char_0);

	// Token: 0x06001D35 RID: 7477 RVA: 0x0000A357 File Offset: 0x00008557
	public static StringBuilder smethod_0(object object_0, char char_0, Delegate344 delegate344_1)
	{
		return delegate344_1(object_0, char_0);
	}

	// Token: 0x06001D36 RID: 7478
	public extern Delegate344(object object_0, IntPtr intptr_0);

	// Token: 0x06001D37 RID: 7479 RVA: 0x0000A364 File Offset: 0x00008564
	static Delegate344()
	{
		Class15.smethod_14(typeof(Delegate344).TypeHandle);
	}

	// Token: 0x04000B38 RID: 2872
	internal static Delegate344 delegate344_0;
}
