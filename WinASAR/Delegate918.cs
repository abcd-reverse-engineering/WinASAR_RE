using System;
using System.Xml;

// Token: 0x020005A6 RID: 1446
internal sealed class Delegate918 : MulticastDelegate
{
	// Token: 0x0600262C RID: 9772
	public extern XmlNodeType Invoke(object object_0);

	// Token: 0x0600262D RID: 9773 RVA: 0x0000DC88 File Offset: 0x0000BE88
	public static XmlNodeType smethod_0(object object_0, Delegate918 delegate918_1)
	{
		return delegate918_1(object_0);
	}

	// Token: 0x0600262E RID: 9774
	public extern Delegate918(object object_0, IntPtr intptr_0);

	// Token: 0x0600262F RID: 9775 RVA: 0x0000DC93 File Offset: 0x0000BE93
	static Delegate918()
	{
		Class15.smethod_14(typeof(Delegate918).TypeHandle);
	}

	// Token: 0x04000D76 RID: 3446
	internal static Delegate918 delegate918_0;
}
