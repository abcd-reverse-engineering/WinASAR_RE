using System;

// Token: 0x02000370 RID: 880
internal sealed class Delegate352 : MulticastDelegate
{
	// Token: 0x06001D54 RID: 7508
	public extern string Invoke(object object_0, string string_0, IFormatProvider iformatProvider_0);

	// Token: 0x06001D55 RID: 7509 RVA: 0x0000A429 File Offset: 0x00008629
	public static string smethod_0(object object_0, string string_0, IFormatProvider iformatProvider_0, Delegate352 delegate352_1)
	{
		return delegate352_1(object_0, string_0, iformatProvider_0);
	}

	// Token: 0x06001D56 RID: 7510
	public extern Delegate352(object object_0, IntPtr intptr_0);

	// Token: 0x06001D57 RID: 7511 RVA: 0x0000A438 File Offset: 0x00008638
	static Delegate352()
	{
		Class15.smethod_14(typeof(Delegate352).TypeHandle);
	}

	// Token: 0x04000B40 RID: 2880
	internal static Delegate352 delegate352_0;
}
