using System;
using System.Collections;

// Token: 0x0200040D RID: 1037
internal sealed class Delegate509 : MulticastDelegate
{
	// Token: 0x06001FC8 RID: 8136
	public extern IDictionaryEnumerator Invoke(object object_0);

	// Token: 0x06001FC9 RID: 8137 RVA: 0x0000B407 File Offset: 0x00009607
	public static IDictionaryEnumerator smethod_0(object object_0, Delegate509 delegate509_1)
	{
		return delegate509_1(object_0);
	}

	// Token: 0x06001FCA RID: 8138
	public extern Delegate509(object object_0, IntPtr intptr_0);

	// Token: 0x06001FCB RID: 8139 RVA: 0x0000B412 File Offset: 0x00009612
	static Delegate509()
	{
		Class15.smethod_14(typeof(Delegate509).TypeHandle);
	}

	// Token: 0x04000BDD RID: 3037
	internal static Delegate509 delegate509_0;
}
