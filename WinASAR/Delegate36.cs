using System;
using System.Globalization;

// Token: 0x02000234 RID: 564
internal sealed class Delegate36 : MulticastDelegate
{
	// Token: 0x06001864 RID: 6244
	public extern object Invoke(object object_0, string string_0, CultureInfo cultureInfo_0);

	// Token: 0x06001865 RID: 6245 RVA: 0x000084D1 File Offset: 0x000066D1
	public static object smethod_0(object object_0, string string_0, CultureInfo cultureInfo_0, Delegate36 delegate36_1)
	{
		return delegate36_1(object_0, string_0, cultureInfo_0);
	}

	// Token: 0x06001866 RID: 6246
	public extern Delegate36(object object_0, IntPtr intptr_0);

	// Token: 0x06001867 RID: 6247 RVA: 0x000084E0 File Offset: 0x000066E0
	static Delegate36()
	{
		Class15.smethod_14(typeof(Delegate36).TypeHandle);
	}

	// Token: 0x04000A04 RID: 2564
	internal static Delegate36 delegate36_0;
}
