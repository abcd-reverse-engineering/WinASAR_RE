using System;

// Token: 0x020002C7 RID: 711
internal sealed class Delegate183 : MulticastDelegate
{
	// Token: 0x06001AB0 RID: 6832
	public extern bool Invoke(object object_0);

	// Token: 0x06001AB1 RID: 6833 RVA: 0x0000934D File Offset: 0x0000754D
	public static bool smethod_0(object object_0, Delegate183 delegate183_1)
	{
		return delegate183_1(object_0);
	}

	// Token: 0x06001AB2 RID: 6834
	public extern Delegate183(object object_0, IntPtr intptr_0);

	// Token: 0x06001AB3 RID: 6835 RVA: 0x00009358 File Offset: 0x00007558
	static Delegate183()
	{
		Class15.smethod_14(typeof(Delegate183).TypeHandle);
	}

	// Token: 0x04000A97 RID: 2711
	internal static Delegate183 delegate183_0;
}
