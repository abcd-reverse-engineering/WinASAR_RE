using System;

// Token: 0x0200057A RID: 1402
internal sealed class Delegate874 : MulticastDelegate
{
	// Token: 0x0600257C RID: 9596
	public extern string Invoke(object object_0);

	// Token: 0x0600257D RID: 9597 RVA: 0x0000D854 File Offset: 0x0000BA54
	public static string smethod_0(object object_0, Delegate874 delegate874_1)
	{
		return delegate874_1(object_0);
	}

	// Token: 0x0600257E RID: 9598
	public extern Delegate874(object object_0, IntPtr intptr_0);

	// Token: 0x0600257F RID: 9599 RVA: 0x0000D85F File Offset: 0x0000BA5F
	static Delegate874()
	{
		Class15.smethod_14(typeof(Delegate874).TypeHandle);
	}

	// Token: 0x04000D4A RID: 3402
	internal static Delegate874 delegate874_0;
}
