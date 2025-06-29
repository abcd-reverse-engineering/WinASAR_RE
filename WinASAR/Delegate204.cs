using System;
using System.Drawing;

// Token: 0x020002DC RID: 732
internal sealed class Delegate204 : MulticastDelegate
{
	// Token: 0x06001B04 RID: 6916
	public extern Point Invoke(object object_0, Point point_0);

	// Token: 0x06001B05 RID: 6917 RVA: 0x0000955B File Offset: 0x0000775B
	public static Point smethod_0(object object_0, Point point_0, Delegate204 delegate204_1)
	{
		return delegate204_1(object_0, point_0);
	}

	// Token: 0x06001B06 RID: 6918
	public extern Delegate204(object object_0, IntPtr intptr_0);

	// Token: 0x06001B07 RID: 6919 RVA: 0x00009568 File Offset: 0x00007768
	static Delegate204()
	{
		Class15.smethod_14(typeof(Delegate204).TypeHandle);
	}

	// Token: 0x04000AAC RID: 2732
	internal static Delegate204 delegate204_0;
}
