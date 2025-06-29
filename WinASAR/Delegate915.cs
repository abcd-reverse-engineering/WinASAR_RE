using System;
using System.Collections.Generic;
using System.Xml.Linq;

// Token: 0x020005A3 RID: 1443
internal sealed class Delegate915 : MulticastDelegate
{
	// Token: 0x06002620 RID: 9760
	public extern IEnumerable<XNode> Invoke(object object_0);

	// Token: 0x06002621 RID: 9761 RVA: 0x0000DC3E File Offset: 0x0000BE3E
	public static IEnumerable<XNode> smethod_0(object object_0, Delegate915 delegate915_1)
	{
		return delegate915_1(object_0);
	}

	// Token: 0x06002622 RID: 9762
	public extern Delegate915(object object_0, IntPtr intptr_0);

	// Token: 0x06002623 RID: 9763 RVA: 0x0000DC49 File Offset: 0x0000BE49
	static Delegate915()
	{
		Class15.smethod_14(typeof(Delegate915).TypeHandle);
	}

	// Token: 0x04000D73 RID: 3443
	internal static Delegate915 delegate915_0;
}
