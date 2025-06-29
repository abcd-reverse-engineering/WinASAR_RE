using System;

// Token: 0x020003A2 RID: 930
internal sealed class Delegate402 : MulticastDelegate
{
	// Token: 0x06001E1C RID: 7708
	public extern string Invoke(ref TimeSpan timeSpan_0, string string_0, IFormatProvider iformatProvider_0);

	// Token: 0x06001E1D RID: 7709 RVA: 0x0000A939 File Offset: 0x00008B39
	public static string smethod_0(ref TimeSpan timeSpan_0, string string_0, IFormatProvider iformatProvider_0, Delegate402 delegate402_1)
	{
		return delegate402_1(ref timeSpan_0, string_0, iformatProvider_0);
	}

	// Token: 0x06001E1E RID: 7710
	public extern Delegate402(object object_0, IntPtr intptr_0);

	// Token: 0x06001E1F RID: 7711 RVA: 0x0000A948 File Offset: 0x00008B48
	static Delegate402()
	{
		Class15.smethod_14(typeof(Delegate402).TypeHandle);
	}

	// Token: 0x04000B72 RID: 2930
	internal static Delegate402 delegate402_0;
}
