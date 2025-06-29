using System;
using System.Xml;

// Token: 0x0200056F RID: 1391
internal sealed class Delegate863 : MulticastDelegate
{
	// Token: 0x06002550 RID: 9552
	public extern XmlAttribute Invoke(object object_0, string string_0, string string_1);

	// Token: 0x06002551 RID: 9553 RVA: 0x0000D740 File Offset: 0x0000B940
	public static XmlAttribute smethod_0(object object_0, string string_0, string string_1, Delegate863 delegate863_0)
	{
		return delegate863_0(object_0, string_0, string_1);
	}

	// Token: 0x06002552 RID: 9554
	public extern Delegate863(object object_0, IntPtr intptr_0);

	// Token: 0x06002553 RID: 9555 RVA: 0x0000D74F File Offset: 0x0000B94F
	static Delegate863()
	{
		Class15.smethod_14(typeof(Delegate863).TypeHandle);
	}

	// Token: 0x04000D3F RID: 3391
	internal static Delegate863 xllWoVcWsug;
}
