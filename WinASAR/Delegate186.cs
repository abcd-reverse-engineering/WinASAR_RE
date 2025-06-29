using System;

// Token: 0x020002CA RID: 714
internal sealed class Delegate186 : MulticastDelegate
{
	// Token: 0x06001ABC RID: 6844
	public extern bool Invoke(object object_0, string string_0);

	// Token: 0x06001ABD RID: 6845 RVA: 0x00009395 File Offset: 0x00007595
	public static bool smethod_0(object object_0, string string_0, Delegate186 delegate186_1)
	{
		return delegate186_1(object_0, string_0);
	}

	// Token: 0x06001ABE RID: 6846
	public extern Delegate186(object object_0, IntPtr intptr_0);

	// Token: 0x06001ABF RID: 6847 RVA: 0x000093A2 File Offset: 0x000075A2
	static Delegate186()
	{
		Class15.smethod_14(typeof(Delegate186).TypeHandle);
	}

	// Token: 0x04000A9A RID: 2714
	internal static Delegate186 delegate186_0;
}
