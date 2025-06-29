using System;

// Token: 0x02000285 RID: 645
internal sealed class Delegate117 : MulticastDelegate
{
	// Token: 0x060019A8 RID: 6568
	public extern bool Invoke(object object_0, string string_0);

	// Token: 0x060019A9 RID: 6569 RVA: 0x00008CD5 File Offset: 0x00006ED5
	public static bool smethod_0(object object_0, string string_0, Delegate117 delegate117_1)
	{
		return delegate117_1(object_0, string_0);
	}

	// Token: 0x060019AA RID: 6570
	public extern Delegate117(object object_0, IntPtr intptr_0);

	// Token: 0x060019AB RID: 6571 RVA: 0x00008CE2 File Offset: 0x00006EE2
	static Delegate117()
	{
		Class15.smethod_14(typeof(Delegate117).TypeHandle);
	}

	// Token: 0x04000A55 RID: 2645
	internal static Delegate117 delegate117_0;
}
