using System;
using System.Globalization;

// Token: 0x0200055B RID: 1371
internal sealed class Delegate843 : MulticastDelegate
{
	// Token: 0x06002500 RID: 9472
	public extern DateTimeOffset Invoke(string string_0, IFormatProvider iformatProvider_0, DateTimeStyles dateTimeStyles_0);

	// Token: 0x06002501 RID: 9473 RVA: 0x0000D526 File Offset: 0x0000B726
	public static DateTimeOffset smethod_0(string string_0, IFormatProvider iformatProvider_0, DateTimeStyles dateTimeStyles_0, Delegate843 delegate843_1)
	{
		return delegate843_1(string_0, iformatProvider_0, dateTimeStyles_0);
	}

	// Token: 0x06002502 RID: 9474
	public extern Delegate843(object object_0, IntPtr intptr_0);

	// Token: 0x06002503 RID: 9475 RVA: 0x0000D535 File Offset: 0x0000B735
	static Delegate843()
	{
		Class15.smethod_14(typeof(Delegate843).TypeHandle);
	}

	// Token: 0x04000D2B RID: 3371
	internal static Delegate843 delegate843_0;
}
