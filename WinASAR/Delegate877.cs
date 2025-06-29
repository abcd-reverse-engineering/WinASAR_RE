using System;
using System.Xml;

// Token: 0x0200057D RID: 1405
internal sealed class Delegate877 : MulticastDelegate
{
	// Token: 0x06002588 RID: 9608
	public extern XmlNodeType Invoke(object object_0);

	// Token: 0x06002589 RID: 9609 RVA: 0x0000D89C File Offset: 0x0000BA9C
	public static XmlNodeType smethod_0(object object_0, Delegate877 delegate877_1)
	{
		return delegate877_1(object_0);
	}

	// Token: 0x0600258A RID: 9610
	public extern Delegate877(object object_0, IntPtr intptr_0);

	// Token: 0x0600258B RID: 9611 RVA: 0x0000D8A7 File Offset: 0x0000BAA7
	static Delegate877()
	{
		Class15.smethod_14(typeof(Delegate877).TypeHandle);
	}

	// Token: 0x04000D4D RID: 3405
	internal static Delegate877 delegate877_0;
}
