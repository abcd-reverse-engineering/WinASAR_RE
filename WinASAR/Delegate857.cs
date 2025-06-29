using System;
using System.Xml;

// Token: 0x02000569 RID: 1385
internal sealed class Delegate857 : MulticastDelegate
{
	// Token: 0x06002538 RID: 9528
	public extern XmlDeclaration Invoke(object object_0, string string_0, string string_1, string string_2);

	// Token: 0x06002539 RID: 9529 RVA: 0x0000D696 File Offset: 0x0000B896
	public static XmlDeclaration smethod_0(object object_0, string string_0, string string_1, string string_2, Delegate857 delegate857_1)
	{
		return delegate857_1(object_0, string_0, string_1, string_2);
	}

	// Token: 0x0600253A RID: 9530
	public extern Delegate857(object object_0, IntPtr intptr_0);

	// Token: 0x0600253B RID: 9531 RVA: 0x0000D6A7 File Offset: 0x0000B8A7
	static Delegate857()
	{
		Class15.smethod_14(typeof(Delegate857).TypeHandle);
	}

	// Token: 0x04000D39 RID: 3385
	internal static Delegate857 delegate857_0;
}
