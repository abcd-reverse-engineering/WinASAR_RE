using System;
using System.Xml.Linq;

// Token: 0x02000599 RID: 1433
internal sealed class Delegate905 : MulticastDelegate
{
	// Token: 0x060025F8 RID: 9720
	public extern XElement Invoke(object object_0);

	// Token: 0x060025F9 RID: 9721 RVA: 0x0000DB46 File Offset: 0x0000BD46
	public static XElement smethod_0(object object_0, Delegate905 delegate905_1)
	{
		return delegate905_1(object_0);
	}

	// Token: 0x060025FA RID: 9722
	public extern Delegate905(object object_0, IntPtr intptr_0);

	// Token: 0x060025FB RID: 9723 RVA: 0x0000DB51 File Offset: 0x0000BD51
	static Delegate905()
	{
		Class15.smethod_14(typeof(Delegate905).TypeHandle);
	}

	// Token: 0x04000D69 RID: 3433
	internal static Delegate905 delegate905_0;
}
