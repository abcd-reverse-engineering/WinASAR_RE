using System;

// Token: 0x020003F4 RID: 1012
internal sealed class Delegate484 : MulticastDelegate
{
	// Token: 0x06001F64 RID: 8036
	public extern DateTime Invoke(DateTime dateTime_0, DateTimeKind dateTimeKind_0);

	// Token: 0x06001F65 RID: 8037 RVA: 0x0000B187 File Offset: 0x00009387
	public static DateTime smethod_0(DateTime dateTime_0, DateTimeKind dateTimeKind_0, Delegate484 delegate484_1)
	{
		return delegate484_1(dateTime_0, dateTimeKind_0);
	}

	// Token: 0x06001F66 RID: 8038
	public extern Delegate484(object object_0, IntPtr intptr_0);

	// Token: 0x06001F67 RID: 8039 RVA: 0x0000B194 File Offset: 0x00009394
	static Delegate484()
	{
		Class15.smethod_14(typeof(Delegate484).TypeHandle);
	}

	// Token: 0x04000BC4 RID: 3012
	internal static Delegate484 delegate484_0;
}
