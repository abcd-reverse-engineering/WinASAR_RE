using System;

// Token: 0x020003AC RID: 940
internal sealed class Delegate412 : MulticastDelegate
{
	// Token: 0x06001E44 RID: 7748
	public extern DateTime Invoke(object object_0, IFormatProvider iformatProvider_0);

	// Token: 0x06001E45 RID: 7749 RVA: 0x0000AA39 File Offset: 0x00008C39
	public static DateTime smethod_0(object object_0, IFormatProvider iformatProvider_0, Delegate412 delegate412_1)
	{
		return delegate412_1(object_0, iformatProvider_0);
	}

	// Token: 0x06001E46 RID: 7750
	public extern Delegate412(object object_0, IntPtr intptr_0);

	// Token: 0x06001E47 RID: 7751 RVA: 0x0000AA46 File Offset: 0x00008C46
	static Delegate412()
	{
		Class15.smethod_14(typeof(Delegate412).TypeHandle);
	}

	// Token: 0x04000B7C RID: 2940
	internal static Delegate412 delegate412_0;
}
