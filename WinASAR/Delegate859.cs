using System;
using System.Xml;

// Token: 0x0200056B RID: 1387
internal sealed class Delegate859 : MulticastDelegate
{
	// Token: 0x06002540 RID: 9536
	public extern XmlProcessingInstruction Invoke(object object_0, string string_0, string string_1);

	// Token: 0x06002541 RID: 9537 RVA: 0x0000D6D4 File Offset: 0x0000B8D4
	public static XmlProcessingInstruction smethod_0(object object_0, string string_0, string string_1, Delegate859 delegate859_1)
	{
		return delegate859_1(object_0, string_0, string_1);
	}

	// Token: 0x06002542 RID: 9538
	public extern Delegate859(object object_0, IntPtr intptr_0);

	// Token: 0x06002543 RID: 9539 RVA: 0x0000D6E3 File Offset: 0x0000B8E3
	static Delegate859()
	{
		Class15.smethod_14(typeof(Delegate859).TypeHandle);
	}

	// Token: 0x04000D3B RID: 3387
	internal static Delegate859 delegate859_0;
}
