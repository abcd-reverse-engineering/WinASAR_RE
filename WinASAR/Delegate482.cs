using System;
using System.Globalization;

// Token: 0x020003F2 RID: 1010
internal sealed class Delegate482 : MulticastDelegate
{
	// Token: 0x06001F5C RID: 8028
	public extern bool Invoke(string string_0, string string_1, IFormatProvider iformatProvider_0, DateTimeStyles dateTimeStyles_0, ref DateTime dateTime_0);

	// Token: 0x06001F5D RID: 8029 RVA: 0x0000B147 File Offset: 0x00009347
	public static bool smethod_0(string string_0, string string_1, IFormatProvider iformatProvider_0, DateTimeStyles dateTimeStyles_0, ref DateTime dateTime_0, Delegate482 delegate482_1)
	{
		return delegate482_1(string_0, string_1, iformatProvider_0, dateTimeStyles_0, ref dateTime_0);
	}

	// Token: 0x06001F5E RID: 8030
	public extern Delegate482(object object_0, IntPtr intptr_0);

	// Token: 0x06001F5F RID: 8031 RVA: 0x0000B15A File Offset: 0x0000935A
	static Delegate482()
	{
		Class15.smethod_14(typeof(Delegate482).TypeHandle);
	}

	// Token: 0x04000BC2 RID: 3010
	internal static Delegate482 delegate482_0;
}
