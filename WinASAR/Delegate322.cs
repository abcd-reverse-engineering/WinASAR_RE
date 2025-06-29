using System;

// Token: 0x02000352 RID: 850
internal sealed class Delegate322 : MulticastDelegate
{
	// Token: 0x06001CDC RID: 7388
	public extern string Invoke(ref short short_0, string string_0, IFormatProvider iformatProvider_0);

	// Token: 0x06001CDD RID: 7389 RVA: 0x0000A10B File Offset: 0x0000830B
	public static string smethod_0(ref short short_0, string string_0, IFormatProvider iformatProvider_0, Delegate322 delegate322_1)
	{
		return delegate322_1(ref short_0, string_0, iformatProvider_0);
	}

	// Token: 0x06001CDE RID: 7390
	public extern Delegate322(object object_0, IntPtr intptr_0);

	// Token: 0x06001CDF RID: 7391 RVA: 0x0000A11A File Offset: 0x0000831A
	static Delegate322()
	{
		Class15.smethod_14(typeof(Delegate322).TypeHandle);
	}

	// Token: 0x04000B22 RID: 2850
	internal static Delegate322 delegate322_0;
}
