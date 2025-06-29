using System;
using System.Xml;

// Token: 0x02000564 RID: 1380
internal sealed class Delegate852 : MulticastDelegate
{
	// Token: 0x06002524 RID: 9508
	public extern XmlComment Invoke(object object_0, string string_0);

	// Token: 0x06002525 RID: 9509 RVA: 0x0000D614 File Offset: 0x0000B814
	public static XmlComment smethod_0(object object_0, string string_0, Delegate852 delegate852_1)
	{
		return delegate852_1(object_0, string_0);
	}

	// Token: 0x06002526 RID: 9510
	public extern Delegate852(object object_0, IntPtr intptr_0);

	// Token: 0x06002527 RID: 9511 RVA: 0x0000D621 File Offset: 0x0000B821
	static Delegate852()
	{
		Class15.smethod_14(typeof(Delegate852).TypeHandle);
	}

	// Token: 0x04000D34 RID: 3380
	internal static Delegate852 delegate852_0;
}
