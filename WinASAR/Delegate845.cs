using System;
using System.Globalization;

// Token: 0x0200055D RID: 1373
internal sealed class Delegate845 : MulticastDelegate
{
	// Token: 0x06002508 RID: 9480
	public extern DateTime Invoke(string string_0, IFormatProvider iformatProvider_0, DateTimeStyles dateTimeStyles_0);

	// Token: 0x06002509 RID: 9481 RVA: 0x0000D560 File Offset: 0x0000B760
	public static DateTime smethod_0(string string_0, IFormatProvider iformatProvider_0, DateTimeStyles dateTimeStyles_0, Delegate845 delegate845_1)
	{
		return delegate845_1(string_0, iformatProvider_0, dateTimeStyles_0);
	}

	// Token: 0x0600250A RID: 9482
	public extern Delegate845(object object_0, IntPtr intptr_0);

	// Token: 0x0600250B RID: 9483 RVA: 0x0000D56F File Offset: 0x0000B76F
	static Delegate845()
	{
		Class15.smethod_14(typeof(Delegate845).TypeHandle);
	}

	// Token: 0x04000D2D RID: 3373
	internal static Delegate845 delegate845_0;
}
