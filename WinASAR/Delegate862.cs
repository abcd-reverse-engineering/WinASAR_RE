using System;
using System.Xml;

// Token: 0x0200056E RID: 1390
internal sealed class Delegate862 : MulticastDelegate
{
	// Token: 0x0600254C RID: 9548
	public extern XmlAttribute Invoke(object object_0, string string_0);

	// Token: 0x0600254D RID: 9549 RVA: 0x0000D726 File Offset: 0x0000B926
	public static XmlAttribute smethod_0(object object_0, string string_0, Delegate862 delegate862_1)
	{
		return delegate862_1(object_0, string_0);
	}

	// Token: 0x0600254E RID: 9550
	public extern Delegate862(object object_0, IntPtr intptr_0);

	// Token: 0x0600254F RID: 9551 RVA: 0x0000D733 File Offset: 0x0000B933
	static Delegate862()
	{
		Class15.smethod_14(typeof(Delegate862).TypeHandle);
	}

	// Token: 0x04000D3E RID: 3390
	internal static Delegate862 delegate862_0;
}
