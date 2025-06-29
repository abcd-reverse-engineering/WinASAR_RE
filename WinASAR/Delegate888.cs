using System;
using System.Xml;

// Token: 0x02000588 RID: 1416
internal sealed class Delegate888 : MulticastDelegate
{
	// Token: 0x060025B4 RID: 9652
	public extern XmlElement Invoke(object object_0);

	// Token: 0x060025B5 RID: 9653 RVA: 0x0000D9A4 File Offset: 0x0000BBA4
	public static XmlElement smethod_0(object object_0, Delegate888 delegate888_1)
	{
		return delegate888_1(object_0);
	}

	// Token: 0x060025B6 RID: 9654
	public extern Delegate888(object object_0, IntPtr intptr_0);

	// Token: 0x060025B7 RID: 9655 RVA: 0x0000D9AF File Offset: 0x0000BBAF
	static Delegate888()
	{
		Class15.smethod_14(typeof(Delegate888).TypeHandle);
	}

	// Token: 0x04000D58 RID: 3416
	internal static Delegate888 delegate888_0;
}
