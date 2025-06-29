using System;
using System.Xml.Linq;

// Token: 0x020005A4 RID: 1444
internal sealed class Delegate916 : MulticastDelegate
{
	// Token: 0x06002624 RID: 9764
	public extern XNode Invoke(object object_0);

	// Token: 0x06002625 RID: 9765 RVA: 0x0000DC56 File Offset: 0x0000BE56
	public static XNode smethod_0(object object_0, Delegate916 delegate916_1)
	{
		return delegate916_1(object_0);
	}

	// Token: 0x06002626 RID: 9766
	public extern Delegate916(object object_0, IntPtr intptr_0);

	// Token: 0x06002627 RID: 9767 RVA: 0x0000DC61 File Offset: 0x0000BE61
	static Delegate916()
	{
		Class15.smethod_14(typeof(Delegate916).TypeHandle);
	}

	// Token: 0x04000D74 RID: 3444
	internal static Delegate916 delegate916_0;
}
