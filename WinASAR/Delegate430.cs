using System;

// Token: 0x020003BE RID: 958
internal sealed class Delegate430 : MulticastDelegate
{
	// Token: 0x06001E8C RID: 7820
	public extern int Invoke(object object_0, object object_1);

	// Token: 0x06001E8D RID: 7821 RVA: 0x0000AC0F File Offset: 0x00008E0F
	public static int smethod_0(object object_0, object object_1, Delegate430 delegate430_1)
	{
		return delegate430_1(object_0, object_1);
	}

	// Token: 0x06001E8E RID: 7822
	public extern Delegate430(object object_0, IntPtr intptr_0);

	// Token: 0x06001E8F RID: 7823 RVA: 0x0000AC1C File Offset: 0x00008E1C
	static Delegate430()
	{
		Class15.smethod_14(typeof(Delegate430).TypeHandle);
	}

	// Token: 0x04000B8E RID: 2958
	internal static Delegate430 delegate430_0;
}
