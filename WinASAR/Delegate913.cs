using System;

// Token: 0x020005A1 RID: 1441
internal sealed class Delegate913 : MulticastDelegate
{
	// Token: 0x06002618 RID: 9752
	public extern string Invoke(object object_0);

	// Token: 0x06002619 RID: 9753 RVA: 0x0000DC0C File Offset: 0x0000BE0C
	public static string smethod_0(object object_0, Delegate913 delegate913_1)
	{
		return delegate913_1(object_0);
	}

	// Token: 0x0600261A RID: 9754
	public extern Delegate913(object object_0, IntPtr intptr_0);

	// Token: 0x0600261B RID: 9755 RVA: 0x0000DC17 File Offset: 0x0000BE17
	static Delegate913()
	{
		Class15.smethod_14(typeof(Delegate913).TypeHandle);
	}

	// Token: 0x04000D71 RID: 3441
	internal static Delegate913 delegate913_0;
}
