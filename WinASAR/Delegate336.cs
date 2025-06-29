using System;

// Token: 0x02000360 RID: 864
internal sealed class Delegate336 : MulticastDelegate
{
	// Token: 0x06001D14 RID: 7444
	public extern string Invoke(ref char char_0, IFormatProvider iformatProvider_0);

	// Token: 0x06001D15 RID: 7445 RVA: 0x0000A28B File Offset: 0x0000848B
	public static string smethod_0(ref char char_0, IFormatProvider iformatProvider_0, Delegate336 delegate336_1)
	{
		return delegate336_1(ref char_0, iformatProvider_0);
	}

	// Token: 0x06001D16 RID: 7446
	public extern Delegate336(object object_0, IntPtr intptr_0);

	// Token: 0x06001D17 RID: 7447 RVA: 0x0000A298 File Offset: 0x00008498
	static Delegate336()
	{
		Class15.smethod_14(typeof(Delegate336).TypeHandle);
	}

	// Token: 0x04000B30 RID: 2864
	internal static Delegate336 delegate336_0;
}
