using System;

// Token: 0x0200035E RID: 862
internal sealed class Delegate334 : MulticastDelegate
{
	// Token: 0x06001D0C RID: 7436
	public extern string Invoke(ref decimal decimal_0, string string_0, IFormatProvider iformatProvider_0);

	// Token: 0x06001D0D RID: 7437 RVA: 0x0000A253 File Offset: 0x00008453
	public static string smethod_0(ref decimal decimal_0, string string_0, IFormatProvider iformatProvider_0, Delegate334 delegate334_1)
	{
		return delegate334_1(ref decimal_0, string_0, iformatProvider_0);
	}

	// Token: 0x06001D0E RID: 7438
	public extern Delegate334(object object_0, IntPtr intptr_0);

	// Token: 0x06001D0F RID: 7439 RVA: 0x0000A262 File Offset: 0x00008462
	static Delegate334()
	{
		Class15.smethod_14(typeof(Delegate334).TypeHandle);
	}

	// Token: 0x04000B2E RID: 2862
	internal static Delegate334 delegate334_0;
}
