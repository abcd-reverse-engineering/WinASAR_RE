using System;
using System.Xml.Linq;

// Token: 0x020005B0 RID: 1456
internal sealed class Delegate928 : MulticastDelegate
{
	// Token: 0x06002654 RID: 9812
	public extern XName Invoke(object object_0);

	// Token: 0x06002655 RID: 9813 RVA: 0x0000DD7C File Offset: 0x0000BF7C
	public static XName smethod_0(object object_0, Delegate928 delegate928_1)
	{
		return delegate928_1(object_0);
	}

	// Token: 0x06002656 RID: 9814
	public extern Delegate928(object object_0, IntPtr intptr_0);

	// Token: 0x06002657 RID: 9815 RVA: 0x0000DD87 File Offset: 0x0000BF87
	static Delegate928()
	{
		Class15.smethod_14(typeof(Delegate928).TypeHandle);
	}

	// Token: 0x04000D80 RID: 3456
	internal static Delegate928 delegate928_0;
}
