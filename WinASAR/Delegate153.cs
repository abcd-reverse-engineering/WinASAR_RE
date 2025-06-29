using System;

// Token: 0x020002A9 RID: 681
internal sealed class Delegate153 : MulticastDelegate
{
	// Token: 0x06001A38 RID: 6712
	public extern object Invoke(object object_0);

	// Token: 0x06001A39 RID: 6713 RVA: 0x0000905B File Offset: 0x0000725B
	public static object smethod_0(object object_0, Delegate153 delegate153_1)
	{
		return delegate153_1(object_0);
	}

	// Token: 0x06001A3A RID: 6714
	public extern Delegate153(object object_0, IntPtr intptr_0);

	// Token: 0x06001A3B RID: 6715 RVA: 0x00009066 File Offset: 0x00007266
	static Delegate153()
	{
		Class15.smethod_14(typeof(Delegate153).TypeHandle);
	}

	// Token: 0x04000A79 RID: 2681
	internal static Delegate153 delegate153_0;
}
