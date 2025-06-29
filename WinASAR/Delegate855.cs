using System;
using System.Xml;

// Token: 0x02000567 RID: 1383
internal sealed class Delegate855 : MulticastDelegate
{
	// Token: 0x06002530 RID: 9520
	public extern XmlWhitespace Invoke(object object_0, string string_0);

	// Token: 0x06002531 RID: 9521 RVA: 0x0000D662 File Offset: 0x0000B862
	public static XmlWhitespace smethod_0(object object_0, string string_0, Delegate855 delegate855_1)
	{
		return delegate855_1(object_0, string_0);
	}

	// Token: 0x06002532 RID: 9522
	public extern Delegate855(object object_0, IntPtr intptr_0);

	// Token: 0x06002533 RID: 9523 RVA: 0x0000D66F File Offset: 0x0000B86F
	static Delegate855()
	{
		Class15.smethod_14(typeof(Delegate855).TypeHandle);
	}

	// Token: 0x04000D37 RID: 3383
	internal static Delegate855 delegate855_0;
}
