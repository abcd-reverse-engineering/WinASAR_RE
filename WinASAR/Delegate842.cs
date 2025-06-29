using System;
using System.Globalization;

// Token: 0x0200055A RID: 1370
internal sealed class Delegate842 : MulticastDelegate
{
	// Token: 0x060024FC RID: 9468
	public extern DateTimeOffset Invoke(string string_0, string string_1, IFormatProvider iformatProvider_0, DateTimeStyles dateTimeStyles_0);

	// Token: 0x060024FD RID: 9469 RVA: 0x0000D508 File Offset: 0x0000B708
	public static DateTimeOffset smethod_0(string string_0, string string_1, IFormatProvider iformatProvider_0, DateTimeStyles dateTimeStyles_0, Delegate842 delegate842_1)
	{
		return delegate842_1(string_0, string_1, iformatProvider_0, dateTimeStyles_0);
	}

	// Token: 0x060024FE RID: 9470
	public extern Delegate842(object object_0, IntPtr intptr_0);

	// Token: 0x060024FF RID: 9471 RVA: 0x0000D519 File Offset: 0x0000B719
	static Delegate842()
	{
		Class15.smethod_14(typeof(Delegate842).TypeHandle);
	}

	// Token: 0x04000D2A RID: 3370
	internal static Delegate842 delegate842_0;
}
