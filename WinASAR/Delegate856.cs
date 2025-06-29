using System;
using System.Xml;

// Token: 0x02000568 RID: 1384
internal sealed class Delegate856 : MulticastDelegate
{
	// Token: 0x06002534 RID: 9524
	public extern XmlSignificantWhitespace Invoke(object object_0, string string_0);

	// Token: 0x06002535 RID: 9525 RVA: 0x0000D67C File Offset: 0x0000B87C
	public static XmlSignificantWhitespace smethod_0(object object_0, string string_0, Delegate856 delegate856_1)
	{
		return delegate856_1(object_0, string_0);
	}

	// Token: 0x06002536 RID: 9526
	public extern Delegate856(object object_0, IntPtr intptr_0);

	// Token: 0x06002537 RID: 9527 RVA: 0x0000D689 File Offset: 0x0000B889
	static Delegate856()
	{
		Class15.smethod_14(typeof(Delegate856).TypeHandle);
	}

	// Token: 0x04000D38 RID: 3384
	internal static Delegate856 delegate856_0;
}
