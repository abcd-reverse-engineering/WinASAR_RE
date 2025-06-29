using System;

// Token: 0x0200039B RID: 923
internal sealed class Delegate395 : MulticastDelegate
{
	// Token: 0x06001E00 RID: 7680
	public extern string Invoke(object object_0);

	// Token: 0x06001E01 RID: 7681 RVA: 0x0000A887 File Offset: 0x00008A87
	public static string smethod_0(object object_0, Delegate395 delegate395_1)
	{
		return delegate395_1(object_0);
	}

	// Token: 0x06001E02 RID: 7682
	public extern Delegate395(object object_0, IntPtr intptr_0);

	// Token: 0x06001E03 RID: 7683 RVA: 0x0000A892 File Offset: 0x00008A92
	static Delegate395()
	{
		Class15.smethod_14(typeof(Delegate395).TypeHandle);
	}

	// Token: 0x04000B6B RID: 2923
	internal static Delegate395 delegate395_0;
}
