using System;

// Token: 0x0200059E RID: 1438
internal sealed class Delegate910 : MulticastDelegate
{
	// Token: 0x0600260C RID: 9740
	public extern string Invoke(object object_0);

	// Token: 0x0600260D RID: 9741 RVA: 0x0000DBC2 File Offset: 0x0000BDC2
	public static string smethod_0(object object_0, Delegate910 delegate910_1)
	{
		return delegate910_1(object_0);
	}

	// Token: 0x0600260E RID: 9742
	public extern Delegate910(object object_0, IntPtr intptr_0);

	// Token: 0x0600260F RID: 9743 RVA: 0x0000DBCD File Offset: 0x0000BDCD
	static Delegate910()
	{
		Class15.smethod_14(typeof(Delegate910).TypeHandle);
	}

	// Token: 0x04000D6E RID: 3438
	internal static Delegate910 delegate910_0;
}
