using System;

// Token: 0x020003A0 RID: 928
internal sealed class Delegate400 : MulticastDelegate
{
	// Token: 0x06001E14 RID: 7700
	public extern DateTime Invoke(ref DateTimeOffset dateTimeOffset_0);

	// Token: 0x06001E15 RID: 7701 RVA: 0x0000A909 File Offset: 0x00008B09
	public static DateTime smethod_0(ref DateTimeOffset dateTimeOffset_0, Delegate400 delegate400_1)
	{
		return delegate400_1(ref dateTimeOffset_0);
	}

	// Token: 0x06001E16 RID: 7702
	public extern Delegate400(object object_0, IntPtr intptr_0);

	// Token: 0x06001E17 RID: 7703 RVA: 0x0000A914 File Offset: 0x00008B14
	static Delegate400()
	{
		Class15.smethod_14(typeof(Delegate400).TypeHandle);
	}

	// Token: 0x04000B70 RID: 2928
	internal static Delegate400 delegate400_0;
}
