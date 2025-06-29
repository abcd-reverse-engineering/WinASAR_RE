using System;
using System.Xml;

// Token: 0x0200056D RID: 1389
internal sealed class Delegate861 : MulticastDelegate
{
	// Token: 0x06002548 RID: 9544
	public extern XmlElement Invoke(object object_0, string string_0, string string_1);

	// Token: 0x06002549 RID: 9545 RVA: 0x0000D70A File Offset: 0x0000B90A
	public static XmlElement smethod_0(object object_0, string string_0, string string_1, Delegate861 delegate861_1)
	{
		return delegate861_1(object_0, string_0, string_1);
	}

	// Token: 0x0600254A RID: 9546
	public extern Delegate861(object object_0, IntPtr intptr_0);

	// Token: 0x0600254B RID: 9547 RVA: 0x0000D719 File Offset: 0x0000B919
	static Delegate861()
	{
		Class15.smethod_14(typeof(Delegate861).TypeHandle);
	}

	// Token: 0x04000D3D RID: 3389
	internal static Delegate861 delegate861_0;
}
