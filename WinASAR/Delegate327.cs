using System;

// Token: 0x02000357 RID: 855
internal sealed class Delegate327 : MulticastDelegate
{
	// Token: 0x06001CF0 RID: 7408
	public extern string Invoke(ref ulong ulong_0, string string_0, IFormatProvider iformatProvider_0);

	// Token: 0x06001CF1 RID: 7409 RVA: 0x0000A197 File Offset: 0x00008397
	public static string smethod_0(ref ulong ulong_0, string string_0, IFormatProvider iformatProvider_0, Delegate327 delegate327_1)
	{
		return delegate327_1(ref ulong_0, string_0, iformatProvider_0);
	}

	// Token: 0x06001CF2 RID: 7410
	public extern Delegate327(object object_0, IntPtr intptr_0);

	// Token: 0x06001CF3 RID: 7411 RVA: 0x0000A1A6 File Offset: 0x000083A6
	static Delegate327()
	{
		Class15.smethod_14(typeof(Delegate327).TypeHandle);
	}

	// Token: 0x04000B27 RID: 2855
	internal static Delegate327 delegate327_0;
}
