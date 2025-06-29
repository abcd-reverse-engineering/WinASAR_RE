using System;
using System.Collections.Generic;
using System.Xml.Linq;

// Token: 0x020005AD RID: 1453
internal sealed class Delegate925 : MulticastDelegate
{
	// Token: 0x06002648 RID: 9800
	public extern IEnumerable<XAttribute> Invoke(object object_0);

	// Token: 0x06002649 RID: 9801 RVA: 0x0000DD32 File Offset: 0x0000BF32
	public static IEnumerable<XAttribute> smethod_0(object object_0, Delegate925 delegate925_1)
	{
		return delegate925_1(object_0);
	}

	// Token: 0x0600264A RID: 9802
	public extern Delegate925(object object_0, IntPtr intptr_0);

	// Token: 0x0600264B RID: 9803 RVA: 0x0000DD3D File Offset: 0x0000BF3D
	static Delegate925()
	{
		Class15.smethod_14(typeof(Delegate925).TypeHandle);
	}

	// Token: 0x04000D7D RID: 3453
	internal static Delegate925 delegate925_0;
}
