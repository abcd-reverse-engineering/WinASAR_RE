using System;
using System.Xml;

// Token: 0x02000583 RID: 1411
internal sealed class Delegate883 : MulticastDelegate
{
	// Token: 0x060025A0 RID: 9632
	public extern XmlAttributeCollection Invoke(object object_0);

	// Token: 0x060025A1 RID: 9633 RVA: 0x0000D92C File Offset: 0x0000BB2C
	public static XmlAttributeCollection smethod_0(object object_0, Delegate883 delegate883_1)
	{
		return delegate883_1(object_0);
	}

	// Token: 0x060025A2 RID: 9634
	public extern Delegate883(object object_0, IntPtr intptr_0);

	// Token: 0x060025A3 RID: 9635 RVA: 0x0000D937 File Offset: 0x0000BB37
	static Delegate883()
	{
		Class15.smethod_14(typeof(Delegate883).TypeHandle);
	}

	// Token: 0x04000D53 RID: 3411
	internal static Delegate883 delegate883_0;
}
