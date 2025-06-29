using System;

// Token: 0x02000363 RID: 867
internal sealed class Delegate339 : MulticastDelegate
{
	// Token: 0x06001D20 RID: 7456
	public extern bool Invoke(object object_0, Type type_0);

	// Token: 0x06001D21 RID: 7457 RVA: 0x0000A2D7 File Offset: 0x000084D7
	public static bool smethod_0(object object_0, Type type_0, Delegate339 delegate339_1)
	{
		return delegate339_1(object_0, type_0);
	}

	// Token: 0x06001D22 RID: 7458
	public extern Delegate339(object object_0, IntPtr intptr_0);

	// Token: 0x06001D23 RID: 7459 RVA: 0x0000A2E4 File Offset: 0x000084E4
	static Delegate339()
	{
		Class15.smethod_14(typeof(Delegate339).TypeHandle);
	}

	// Token: 0x04000B33 RID: 2867
	internal static Delegate339 delegate339_0;
}
