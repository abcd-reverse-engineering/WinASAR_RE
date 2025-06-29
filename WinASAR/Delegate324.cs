using System;

// Token: 0x02000354 RID: 852
internal sealed class Delegate324 : MulticastDelegate
{
	// Token: 0x06001CE4 RID: 7396
	public extern string Invoke(ref uint uint_0, string string_0, IFormatProvider iformatProvider_0);

	// Token: 0x06001CE5 RID: 7397 RVA: 0x0000A143 File Offset: 0x00008343
	public static string smethod_0(ref uint uint_0, string string_0, IFormatProvider iformatProvider_0, Delegate324 delegate324_1)
	{
		return delegate324_1(ref uint_0, string_0, iformatProvider_0);
	}

	// Token: 0x06001CE6 RID: 7398
	public extern Delegate324(object object_0, IntPtr intptr_0);

	// Token: 0x06001CE7 RID: 7399 RVA: 0x0000A152 File Offset: 0x00008352
	static Delegate324()
	{
		Class15.smethod_14(typeof(Delegate324).TypeHandle);
	}

	// Token: 0x04000B24 RID: 2852
	internal static Delegate324 delegate324_0;
}
