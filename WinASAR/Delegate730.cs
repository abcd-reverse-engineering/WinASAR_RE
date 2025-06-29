using System;

// Token: 0x020004EA RID: 1258
internal sealed class Delegate730 : MulticastDelegate
{
	// Token: 0x0600233C RID: 9020
	public extern string Invoke(object object_0);

	// Token: 0x0600233D RID: 9021 RVA: 0x0000C9FA File Offset: 0x0000ABFA
	public static string smethod_0(object object_0, Delegate730 delegate730_1)
	{
		return delegate730_1(object_0);
	}

	// Token: 0x0600233E RID: 9022
	public extern Delegate730(object object_0, IntPtr intptr_0);

	// Token: 0x0600233F RID: 9023 RVA: 0x0000CA05 File Offset: 0x0000AC05
	static Delegate730()
	{
		Class15.smethod_14(typeof(Delegate730).TypeHandle);
	}

	// Token: 0x04000CBA RID: 3258
	internal static Delegate730 delegate730_0;
}
