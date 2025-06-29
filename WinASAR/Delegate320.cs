using System;

// Token: 0x02000350 RID: 848
internal sealed class Delegate320 : MulticastDelegate
{
	// Token: 0x06001CD4 RID: 7380
	public extern string Invoke(object object_0, string string_0);

	// Token: 0x06001CD5 RID: 7381 RVA: 0x0000A0D5 File Offset: 0x000082D5
	public static string smethod_0(object object_0, string string_0, Delegate320 delegate320_1)
	{
		return delegate320_1(object_0, string_0);
	}

	// Token: 0x06001CD6 RID: 7382
	public extern Delegate320(object object_0, IntPtr intptr_0);

	// Token: 0x06001CD7 RID: 7383 RVA: 0x0000A0E2 File Offset: 0x000082E2
	static Delegate320()
	{
		Class15.smethod_14(typeof(Delegate320).TypeHandle);
	}

	// Token: 0x04000B20 RID: 2848
	internal static Delegate320 delegate320_0;
}
