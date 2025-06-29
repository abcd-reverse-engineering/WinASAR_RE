using System;
using System.Globalization;

// Token: 0x0200055C RID: 1372
internal sealed class Delegate844 : MulticastDelegate
{
	// Token: 0x06002504 RID: 9476
	public extern DateTime Invoke(string string_0, string string_1, IFormatProvider iformatProvider_0, DateTimeStyles dateTimeStyles_0);

	// Token: 0x06002505 RID: 9477 RVA: 0x0000D542 File Offset: 0x0000B742
	public static DateTime smethod_0(string string_0, string string_1, IFormatProvider iformatProvider_0, DateTimeStyles dateTimeStyles_0, Delegate844 delegate844_1)
	{
		return delegate844_1(string_0, string_1, iformatProvider_0, dateTimeStyles_0);
	}

	// Token: 0x06002506 RID: 9478
	public extern Delegate844(object object_0, IntPtr intptr_0);

	// Token: 0x06002507 RID: 9479 RVA: 0x0000D553 File Offset: 0x0000B753
	static Delegate844()
	{
		Class15.smethod_14(typeof(Delegate844).TypeHandle);
	}

	// Token: 0x04000D2C RID: 3372
	internal static Delegate844 delegate844_0;
}
