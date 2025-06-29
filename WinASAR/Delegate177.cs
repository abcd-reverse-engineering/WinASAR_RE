using System;
using System.Collections;

// Token: 0x020002C1 RID: 705
internal sealed class Delegate177 : MulticastDelegate
{
	// Token: 0x06001A98 RID: 6808
	public extern IEnumerator Invoke(object object_0);

	// Token: 0x06001A99 RID: 6809 RVA: 0x000092B5 File Offset: 0x000074B5
	public static IEnumerator smethod_0(object object_0, Delegate177 delegate177_1)
	{
		return delegate177_1(object_0);
	}

	// Token: 0x06001A9A RID: 6810
	public extern Delegate177(object object_0, IntPtr intptr_0);

	// Token: 0x06001A9B RID: 6811 RVA: 0x000092C0 File Offset: 0x000074C0
	static Delegate177()
	{
		Class15.smethod_14(typeof(Delegate177).TypeHandle);
	}

	// Token: 0x04000A91 RID: 2705
	internal static Delegate177 delegate177_0;
}
