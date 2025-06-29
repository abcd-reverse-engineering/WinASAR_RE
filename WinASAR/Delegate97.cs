using System;
using System.Drawing;

// Token: 0x02000271 RID: 625
internal sealed class Delegate97 : MulticastDelegate
{
	// Token: 0x06001958 RID: 6488
	public extern void Invoke(object object_0, Point point_0);

	// Token: 0x06001959 RID: 6489 RVA: 0x00008ADB File Offset: 0x00006CDB
	public static void smethod_0(object object_0, Point point_0, Delegate97 delegate97_1)
	{
		delegate97_1(object_0, point_0);
	}

	// Token: 0x0600195A RID: 6490
	public extern Delegate97(object object_0, IntPtr intptr_0);

	// Token: 0x0600195B RID: 6491 RVA: 0x00008AE8 File Offset: 0x00006CE8
	static Delegate97()
	{
		Class15.smethod_14(typeof(Delegate97).TypeHandle);
	}

	// Token: 0x04000A41 RID: 2625
	internal static Delegate97 delegate97_0;
}
