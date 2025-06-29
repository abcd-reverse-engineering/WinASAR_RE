using System;
using System.Xml;

// Token: 0x0200056A RID: 1386
internal sealed class Delegate858 : MulticastDelegate
{
	// Token: 0x0600253C RID: 9532
	public extern XmlDocumentType Invoke(object object_0, string string_0, string string_1, string string_2, string string_3);

	// Token: 0x0600253D RID: 9533 RVA: 0x0000D6B4 File Offset: 0x0000B8B4
	public static XmlDocumentType smethod_0(object object_0, string string_0, string string_1, string string_2, string string_3, Delegate858 delegate858_1)
	{
		return delegate858_1(object_0, string_0, string_1, string_2, string_3);
	}

	// Token: 0x0600253E RID: 9534
	public extern Delegate858(object object_0, IntPtr intptr_0);

	// Token: 0x0600253F RID: 9535 RVA: 0x0000D6C7 File Offset: 0x0000B8C7
	static Delegate858()
	{
		Class15.smethod_14(typeof(Delegate858).TypeHandle);
	}

	// Token: 0x04000D3A RID: 3386
	internal static Delegate858 delegate858_0;
}
