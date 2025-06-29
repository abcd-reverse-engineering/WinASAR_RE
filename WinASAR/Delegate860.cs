using System;
using System.Xml;

// Token: 0x0200056C RID: 1388
internal sealed class Delegate860 : MulticastDelegate
{
	// Token: 0x06002544 RID: 9540
	public extern XmlElement Invoke(object object_0, string string_0);

	// Token: 0x06002545 RID: 9541 RVA: 0x0000D6F0 File Offset: 0x0000B8F0
	public static XmlElement smethod_0(object object_0, string string_0, Delegate860 delegate860_1)
	{
		return delegate860_1(object_0, string_0);
	}

	// Token: 0x06002546 RID: 9542
	public extern Delegate860(object object_0, IntPtr intptr_0);

	// Token: 0x06002547 RID: 9543 RVA: 0x0000D6FD File Offset: 0x0000B8FD
	static Delegate860()
	{
		Class15.smethod_14(typeof(Delegate860).TypeHandle);
	}

	// Token: 0x04000D3C RID: 3388
	internal static Delegate860 delegate860_0;
}
