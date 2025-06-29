using System;

// Token: 0x02000353 RID: 851
internal sealed class Delegate323 : MulticastDelegate
{
	// Token: 0x06001CE0 RID: 7392
	public extern string Invoke(ref ushort ushort_0, string string_0, IFormatProvider iformatProvider_0);

	// Token: 0x06001CE1 RID: 7393 RVA: 0x0000A127 File Offset: 0x00008327
	public static string smethod_0(ref ushort ushort_0, string string_0, IFormatProvider iformatProvider_0, Delegate323 delegate323_1)
	{
		return delegate323_1(ref ushort_0, string_0, iformatProvider_0);
	}

	// Token: 0x06001CE2 RID: 7394
	public extern Delegate323(object object_0, IntPtr intptr_0);

	// Token: 0x06001CE3 RID: 7395 RVA: 0x0000A136 File Offset: 0x00008336
	static Delegate323()
	{
		Class15.smethod_14(typeof(Delegate323).TypeHandle);
	}

	// Token: 0x04000B23 RID: 2851
	internal static Delegate323 delegate323_0;
}
