using System;
using System.Globalization;

// Token: 0x020003F3 RID: 1011
internal sealed class Delegate483 : MulticastDelegate
{
	// Token: 0x06001F60 RID: 8032
	public extern bool Invoke(string string_0, string string_1, IFormatProvider iformatProvider_0, DateTimeStyles dateTimeStyles_0, ref DateTimeOffset dateTimeOffset_0);

	// Token: 0x06001F61 RID: 8033 RVA: 0x0000B167 File Offset: 0x00009367
	public static bool smethod_0(string string_0, string string_1, IFormatProvider iformatProvider_0, DateTimeStyles dateTimeStyles_0, ref DateTimeOffset dateTimeOffset_0, Delegate483 delegate483_1)
	{
		return delegate483_1(string_0, string_1, iformatProvider_0, dateTimeStyles_0, ref dateTimeOffset_0);
	}

	// Token: 0x06001F62 RID: 8034
	public extern Delegate483(object object_0, IntPtr intptr_0);

	// Token: 0x06001F63 RID: 8035 RVA: 0x0000B17A File Offset: 0x0000937A
	static Delegate483()
	{
		Class15.smethod_14(typeof(Delegate483).TypeHandle);
	}

	// Token: 0x04000BC3 RID: 3011
	internal static Delegate483 delegate483_0;
}
