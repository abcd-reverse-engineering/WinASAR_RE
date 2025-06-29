using System;

// Token: 0x020003BA RID: 954
internal sealed class Delegate426 : MulticastDelegate
{
	// Token: 0x06001E7C RID: 7804
	public extern int Invoke(object object_0);

	// Token: 0x06001E7D RID: 7805 RVA: 0x0000ABA7 File Offset: 0x00008DA7
	public static int smethod_0(object object_0, Delegate426 delegate426_1)
	{
		return delegate426_1(object_0);
	}

	// Token: 0x06001E7E RID: 7806
	public extern Delegate426(object object_0, IntPtr intptr_0);

	// Token: 0x06001E7F RID: 7807 RVA: 0x0000ABB2 File Offset: 0x00008DB2
	static Delegate426()
	{
		Class15.smethod_14(typeof(Delegate426).TypeHandle);
	}

	// Token: 0x04000B8A RID: 2954
	internal static Delegate426 delegate426_0;
}
