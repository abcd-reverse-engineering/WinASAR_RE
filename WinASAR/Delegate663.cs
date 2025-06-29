using System;

// Token: 0x020004A7 RID: 1191
internal sealed class Delegate663 : MulticastDelegate
{
	// Token: 0x06002230 RID: 8752
	public extern bool Invoke(object object_0);

	// Token: 0x06002231 RID: 8753 RVA: 0x0000C375 File Offset: 0x0000A575
	public static bool smethod_0(object object_0, Delegate663 delegate663_1)
	{
		return delegate663_1(object_0);
	}

	// Token: 0x06002232 RID: 8754
	public extern Delegate663(object object_0, IntPtr intptr_0);

	// Token: 0x06002233 RID: 8755 RVA: 0x0000C380 File Offset: 0x0000A580
	static Delegate663()
	{
		Class15.smethod_14(typeof(Delegate663).TypeHandle);
	}

	// Token: 0x04000C77 RID: 3191
	internal static Delegate663 delegate663_0;
}
