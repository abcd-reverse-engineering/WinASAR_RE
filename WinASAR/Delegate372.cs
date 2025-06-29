using System;

// Token: 0x02000384 RID: 900
internal sealed class Delegate372 : MulticastDelegate
{
	// Token: 0x06001DA4 RID: 7588
	public extern bool Invoke(string string_0, string string_1);

	// Token: 0x06001DA5 RID: 7589 RVA: 0x0000A637 File Offset: 0x00008837
	public static bool smethod_0(string string_0, string string_1, Delegate372 delegate372_1)
	{
		return delegate372_1(string_0, string_1);
	}

	// Token: 0x06001DA6 RID: 7590
	public extern Delegate372(object object_0, IntPtr intptr_0);

	// Token: 0x06001DA7 RID: 7591 RVA: 0x0000A644 File Offset: 0x00008844
	static Delegate372()
	{
		Class15.smethod_14(typeof(Delegate372).TypeHandle);
	}

	// Token: 0x04000B54 RID: 2900
	internal static Delegate372 delegate372_0;
}
