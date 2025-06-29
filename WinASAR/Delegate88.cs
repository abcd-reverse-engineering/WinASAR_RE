using System;

// Token: 0x02000268 RID: 616
internal sealed class Delegate88 : MulticastDelegate
{
	// Token: 0x06001934 RID: 6452
	public extern string Invoke(string string_0);

	// Token: 0x06001935 RID: 6453 RVA: 0x000089F9 File Offset: 0x00006BF9
	public static string smethod_0(string string_0, Delegate88 delegate88_1)
	{
		return delegate88_1(string_0);
	}

	// Token: 0x06001936 RID: 6454
	public extern Delegate88(object object_0, IntPtr intptr_0);

	// Token: 0x06001937 RID: 6455 RVA: 0x00008A04 File Offset: 0x00006C04
	static Delegate88()
	{
		Class15.smethod_14(typeof(Delegate88).TypeHandle);
	}

	// Token: 0x04000A38 RID: 2616
	internal static Delegate88 delegate88_0;
}
