using System;

// Token: 0x020003AA RID: 938
internal sealed class Delegate410 : MulticastDelegate
{
	// Token: 0x06001E3C RID: 7740
	public extern double Invoke(double double_0);

	// Token: 0x06001E3D RID: 7741 RVA: 0x0000AA07 File Offset: 0x00008C07
	public static double smethod_0(double double_0, Delegate410 delegate410_1)
	{
		return delegate410_1(double_0);
	}

	// Token: 0x06001E3E RID: 7742
	public extern Delegate410(object object_0, IntPtr intptr_0);

	// Token: 0x06001E3F RID: 7743 RVA: 0x0000AA12 File Offset: 0x00008C12
	static Delegate410()
	{
		Class15.smethod_14(typeof(Delegate410).TypeHandle);
	}

	// Token: 0x04000B7A RID: 2938
	internal static Delegate410 delegate410_0;
}
