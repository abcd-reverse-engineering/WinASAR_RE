using System;

// Token: 0x020003F5 RID: 1013
internal sealed class Delegate485 : MulticastDelegate
{
	// Token: 0x06001F68 RID: 8040
	public extern DateTimeOffset Invoke(DateTime dateTime_0);

	// Token: 0x06001F69 RID: 8041 RVA: 0x0000B1A1 File Offset: 0x000093A1
	public static DateTimeOffset smethod_0(DateTime dateTime_0, Delegate485 delegate485_1)
	{
		return delegate485_1(dateTime_0);
	}

	// Token: 0x06001F6A RID: 8042
	public extern Delegate485(object object_0, IntPtr intptr_0);

	// Token: 0x06001F6B RID: 8043 RVA: 0x0000B1AC File Offset: 0x000093AC
	static Delegate485()
	{
		Class15.smethod_14(typeof(Delegate485).TypeHandle);
	}

	// Token: 0x04000BC5 RID: 3013
	internal static Delegate485 delegate485_0;
}
