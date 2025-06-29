using System;

// Token: 0x02000283 RID: 643
internal sealed class Delegate115 : MulticastDelegate
{
	// Token: 0x060019A0 RID: 6560
	public extern bool Invoke(string string_0);

	// Token: 0x060019A1 RID: 6561 RVA: 0x00008CA5 File Offset: 0x00006EA5
	public static bool smethod_0(string string_0, Delegate115 delegate115_1)
	{
		return delegate115_1(string_0);
	}

	// Token: 0x060019A2 RID: 6562
	public extern Delegate115(object object_0, IntPtr intptr_0);

	// Token: 0x060019A3 RID: 6563 RVA: 0x00008CB0 File Offset: 0x00006EB0
	static Delegate115()
	{
		Class15.smethod_14(typeof(Delegate115).TypeHandle);
	}

	// Token: 0x04000A53 RID: 2643
	internal static Delegate115 delegate115_0;
}
