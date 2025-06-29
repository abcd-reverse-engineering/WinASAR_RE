using System;

// Token: 0x02000260 RID: 608
internal sealed class Delegate80 : MulticastDelegate
{
	// Token: 0x06001914 RID: 6420
	public extern bool Invoke(string string_0);

	// Token: 0x06001915 RID: 6421 RVA: 0x00008931 File Offset: 0x00006B31
	public static bool smethod_0(string string_0, Delegate80 delegate80_1)
	{
		return delegate80_1(string_0);
	}

	// Token: 0x06001916 RID: 6422
	public extern Delegate80(object object_0, IntPtr intptr_0);

	// Token: 0x06001917 RID: 6423 RVA: 0x0000893C File Offset: 0x00006B3C
	static Delegate80()
	{
		Class15.smethod_14(typeof(Delegate80).TypeHandle);
	}

	// Token: 0x04000A30 RID: 2608
	internal static Delegate80 delegate80_0;
}
