using System;

// Token: 0x0200039E RID: 926
internal sealed class Delegate398 : MulticastDelegate
{
	// Token: 0x06001E0C RID: 7692
	public extern DateTimeKind Invoke(ref DateTime dateTime_0);

	// Token: 0x06001E0D RID: 7693 RVA: 0x0000A8D5 File Offset: 0x00008AD5
	public static DateTimeKind smethod_0(ref DateTime dateTime_0, Delegate398 delegate398_1)
	{
		return delegate398_1(ref dateTime_0);
	}

	// Token: 0x06001E0E RID: 7694
	public extern Delegate398(object object_0, IntPtr intptr_0);

	// Token: 0x06001E0F RID: 7695 RVA: 0x0000A8E0 File Offset: 0x00008AE0
	static Delegate398()
	{
		Class15.smethod_14(typeof(Delegate398).TypeHandle);
	}

	// Token: 0x04000B6E RID: 2926
	internal static Delegate398 delegate398_0;
}
