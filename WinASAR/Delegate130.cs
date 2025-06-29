using System;

// Token: 0x02000292 RID: 658
internal sealed class Delegate130 : MulticastDelegate
{
	// Token: 0x060019DC RID: 6620
	public extern string Invoke(object object_0);

	// Token: 0x060019DD RID: 6621 RVA: 0x00008E15 File Offset: 0x00007015
	public static string smethod_0(object object_0, Delegate130 delegate130_1)
	{
		return delegate130_1(object_0);
	}

	// Token: 0x060019DE RID: 6622
	public extern Delegate130(object object_0, IntPtr intptr_0);

	// Token: 0x060019DF RID: 6623 RVA: 0x00008E20 File Offset: 0x00007020
	static Delegate130()
	{
		Class15.smethod_14(typeof(Delegate130).TypeHandle);
	}

	// Token: 0x04000A62 RID: 2658
	internal static Delegate130 delegate130_0;
}
