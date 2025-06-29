using System;

// Token: 0x020003F1 RID: 1009
internal sealed class Delegate481 : MulticastDelegate
{
	// Token: 0x06001F58 RID: 8024
	public extern DateTime Invoke(ref DateTime dateTime_0, double double_0);

	// Token: 0x06001F59 RID: 8025 RVA: 0x0000B12D File Offset: 0x0000932D
	public static DateTime smethod_0(ref DateTime dateTime_0, double double_0, Delegate481 delegate481_1)
	{
		return delegate481_1(ref dateTime_0, double_0);
	}

	// Token: 0x06001F5A RID: 8026
	public extern Delegate481(object object_0, IntPtr intptr_0);

	// Token: 0x06001F5B RID: 8027 RVA: 0x0000B13A File Offset: 0x0000933A
	static Delegate481()
	{
		Class15.smethod_14(typeof(Delegate481).TypeHandle);
	}

	// Token: 0x04000BC1 RID: 3009
	internal static Delegate481 delegate481_0;
}
