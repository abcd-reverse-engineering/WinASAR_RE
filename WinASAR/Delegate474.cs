using System;

// Token: 0x020003EA RID: 1002
internal sealed class Delegate474 : MulticastDelegate
{
	// Token: 0x06001F3C RID: 7996
	public extern TimeSpan Invoke(object object_0, DateTime dateTime_0);

	// Token: 0x06001F3D RID: 7997 RVA: 0x0000B07F File Offset: 0x0000927F
	public static TimeSpan smethod_0(object object_0, DateTime dateTime_0, Delegate474 delegate474_1)
	{
		return delegate474_1(object_0, dateTime_0);
	}

	// Token: 0x06001F3E RID: 7998
	public extern Delegate474(object object_0, IntPtr intptr_0);

	// Token: 0x06001F3F RID: 7999 RVA: 0x0000B08C File Offset: 0x0000928C
	static Delegate474()
	{
		Class15.smethod_14(typeof(Delegate474).TypeHandle);
	}

	// Token: 0x04000BBA RID: 3002
	internal static Delegate474 delegate474_0;
}
