using System;

// Token: 0x020003F6 RID: 1014
internal sealed class Delegate486 : MulticastDelegate
{
	// Token: 0x06001F6C RID: 8044
	public extern DateTime Invoke(ref DateTime dateTime_0, TimeSpan timeSpan_0);

	// Token: 0x06001F6D RID: 8045 RVA: 0x0000B1B9 File Offset: 0x000093B9
	public static DateTime smethod_0(ref DateTime dateTime_0, TimeSpan timeSpan_0, Delegate486 delegate486_1)
	{
		return delegate486_1(ref dateTime_0, timeSpan_0);
	}

	// Token: 0x06001F6E RID: 8046
	public extern Delegate486(object object_0, IntPtr intptr_0);

	// Token: 0x06001F6F RID: 8047 RVA: 0x0000B1C6 File Offset: 0x000093C6
	static Delegate486()
	{
		Class15.smethod_14(typeof(Delegate486).TypeHandle);
	}

	// Token: 0x04000BC6 RID: 3014
	internal static Delegate486 delegate486_0;
}
