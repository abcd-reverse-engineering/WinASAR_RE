using System;

// Token: 0x020002A3 RID: 675
internal sealed class Delegate147 : MulticastDelegate
{
	// Token: 0x06001A20 RID: 6688
	public extern bool Invoke(string string_0);

	// Token: 0x06001A21 RID: 6689 RVA: 0x00008FBB File Offset: 0x000071BB
	public static bool smethod_0(string string_0, Delegate147 delegate147_1)
	{
		return delegate147_1(string_0);
	}

	// Token: 0x06001A22 RID: 6690
	public extern Delegate147(object object_0, IntPtr intptr_0);

	// Token: 0x06001A23 RID: 6691 RVA: 0x00008FC6 File Offset: 0x000071C6
	static Delegate147()
	{
		Class15.smethod_14(typeof(Delegate147).TypeHandle);
	}

	// Token: 0x04000A73 RID: 2675
	internal static Delegate147 delegate147_0;
}
