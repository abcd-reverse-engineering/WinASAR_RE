using System;

// Token: 0x020004A6 RID: 1190
internal sealed class Delegate662 : MulticastDelegate
{
	// Token: 0x0600222C RID: 8748
	public extern bool Invoke(object object_0);

	// Token: 0x0600222D RID: 8749 RVA: 0x0000C35D File Offset: 0x0000A55D
	public static bool smethod_0(object object_0, Delegate662 delegate662_1)
	{
		return delegate662_1(object_0);
	}

	// Token: 0x0600222E RID: 8750
	public extern Delegate662(object object_0, IntPtr intptr_0);

	// Token: 0x0600222F RID: 8751 RVA: 0x0000C368 File Offset: 0x0000A568
	static Delegate662()
	{
		Class15.smethod_14(typeof(Delegate662).TypeHandle);
	}

	// Token: 0x04000C76 RID: 3190
	internal static Delegate662 delegate662_0;
}
