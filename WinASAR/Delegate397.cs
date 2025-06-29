using System;

// Token: 0x0200039D RID: 925
internal sealed class Delegate397 : MulticastDelegate
{
	// Token: 0x06001E08 RID: 7688
	public extern string Invoke(ref DateTime dateTime_0, string string_0, IFormatProvider iformatProvider_0);

	// Token: 0x06001E09 RID: 7689 RVA: 0x0000A8B9 File Offset: 0x00008AB9
	public static string smethod_0(ref DateTime dateTime_0, string string_0, IFormatProvider iformatProvider_0, Delegate397 delegate397_1)
	{
		return delegate397_1(ref dateTime_0, string_0, iformatProvider_0);
	}

	// Token: 0x06001E0A RID: 7690
	public extern Delegate397(object object_0, IntPtr intptr_0);

	// Token: 0x06001E0B RID: 7691 RVA: 0x0000A8C8 File Offset: 0x00008AC8
	static Delegate397()
	{
		Class15.smethod_14(typeof(Delegate397).TypeHandle);
	}

	// Token: 0x04000B6D RID: 2925
	internal static Delegate397 delegate397_0;
}
