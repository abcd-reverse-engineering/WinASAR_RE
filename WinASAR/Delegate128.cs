using System;

// Token: 0x02000290 RID: 656
internal sealed class Delegate128 : MulticastDelegate
{
	// Token: 0x060019D4 RID: 6612
	public extern string Invoke(string string_0);

	// Token: 0x060019D5 RID: 6613 RVA: 0x00008DE5 File Offset: 0x00006FE5
	public static string smethod_0(string string_0, Delegate128 delegate128_1)
	{
		return delegate128_1(string_0);
	}

	// Token: 0x060019D6 RID: 6614
	public extern Delegate128(object object_0, IntPtr intptr_0);

	// Token: 0x060019D7 RID: 6615 RVA: 0x00008DF0 File Offset: 0x00006FF0
	static Delegate128()
	{
		Class15.smethod_14(typeof(Delegate128).TypeHandle);
	}

	// Token: 0x04000A60 RID: 2656
	internal static Delegate128 delegate128_0;
}
