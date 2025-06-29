using System;

// Token: 0x020003B9 RID: 953
internal sealed class Delegate425 : MulticastDelegate
{
	// Token: 0x06001E78 RID: 7800
	public extern object Invoke(object object_0, int int_0);

	// Token: 0x06001E79 RID: 7801 RVA: 0x0000AB8D File Offset: 0x00008D8D
	public static object smethod_0(object object_0, int int_0, Delegate425 delegate425_1)
	{
		return delegate425_1(object_0, int_0);
	}

	// Token: 0x06001E7A RID: 7802
	public extern Delegate425(object object_0, IntPtr intptr_0);

	// Token: 0x06001E7B RID: 7803 RVA: 0x0000AB9A File Offset: 0x00008D9A
	static Delegate425()
	{
		Class15.smethod_14(typeof(Delegate425).TypeHandle);
	}

	// Token: 0x04000B89 RID: 2953
	internal static Delegate425 delegate425_0;
}
