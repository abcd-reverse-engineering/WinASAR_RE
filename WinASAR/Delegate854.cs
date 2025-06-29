using System;
using System.Xml;

// Token: 0x02000566 RID: 1382
internal sealed class Delegate854 : MulticastDelegate
{
	// Token: 0x0600252C RID: 9516
	public extern XmlCDataSection Invoke(object object_0, string string_0);

	// Token: 0x0600252D RID: 9517 RVA: 0x0000D648 File Offset: 0x0000B848
	public static XmlCDataSection smethod_0(object object_0, string string_0, Delegate854 delegate854_1)
	{
		return delegate854_1(object_0, string_0);
	}

	// Token: 0x0600252E RID: 9518
	public extern Delegate854(object object_0, IntPtr intptr_0);

	// Token: 0x0600252F RID: 9519 RVA: 0x0000D655 File Offset: 0x0000B855
	static Delegate854()
	{
		Class15.smethod_14(typeof(Delegate854).TypeHandle);
	}

	// Token: 0x04000D36 RID: 3382
	internal static Delegate854 delegate854_0;
}
