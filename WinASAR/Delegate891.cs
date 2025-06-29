using System;
using System.Xml;

// Token: 0x0200058B RID: 1419
internal sealed class Delegate891 : MulticastDelegate
{
	// Token: 0x060025C0 RID: 9664
	public extern XmlNode Invoke(object object_0, XmlNode xmlNode_0);

	// Token: 0x060025C1 RID: 9665 RVA: 0x0000D9EE File Offset: 0x0000BBEE
	public static XmlNode smethod_0(object object_0, XmlNode xmlNode_0, Delegate891 delegate891_1)
	{
		return delegate891_1(object_0, xmlNode_0);
	}

	// Token: 0x060025C2 RID: 9666
	public extern Delegate891(object object_0, IntPtr intptr_0);

	// Token: 0x060025C3 RID: 9667 RVA: 0x0000D9FB File Offset: 0x0000BBFB
	static Delegate891()
	{
		Class15.smethod_14(typeof(Delegate891).TypeHandle);
	}

	// Token: 0x04000D5B RID: 3419
	internal static Delegate891 delegate891_0;
}
