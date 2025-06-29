using System;
using System.Globalization;

// Token: 0x02000380 RID: 896
internal sealed class Delegate368 : MulticastDelegate
{
	// Token: 0x06001D94 RID: 7572
	public extern bool Invoke(string string_0, IFormatProvider iformatProvider_0, DateTimeStyles dateTimeStyles_0, ref DateTimeOffset dateTimeOffset_0);

	// Token: 0x06001D95 RID: 7573 RVA: 0x0000A5CB File Offset: 0x000087CB
	public static bool smethod_0(string string_0, IFormatProvider iformatProvider_0, DateTimeStyles dateTimeStyles_0, ref DateTimeOffset dateTimeOffset_0, Delegate368 delegate368_1)
	{
		return delegate368_1(string_0, iformatProvider_0, dateTimeStyles_0, ref dateTimeOffset_0);
	}

	// Token: 0x06001D96 RID: 7574
	public extern Delegate368(object object_0, IntPtr intptr_0);

	// Token: 0x06001D97 RID: 7575 RVA: 0x0000A5DC File Offset: 0x000087DC
	static Delegate368()
	{
		Class15.smethod_14(typeof(Delegate368).TypeHandle);
	}

	// Token: 0x04000B50 RID: 2896
	internal static Delegate368 delegate368_0;
}
