using System;
using System.Xml;

// Token: 0x020005BA RID: 1466
internal sealed class Delegate938 : MulticastDelegate
{
	// Token: 0x0600267C RID: 9852
	public extern void Invoke(object object_0, XmlResolver xmlResolver_0);

	// Token: 0x0600267D RID: 9853 RVA: 0x0000DE74 File Offset: 0x0000C074
	public static void smethod_0(object object_0, XmlResolver xmlResolver_0, Delegate938 delegate938_1)
	{
		delegate938_1(object_0, xmlResolver_0);
	}

	// Token: 0x0600267E RID: 9854
	public extern Delegate938(object object_0, IntPtr intptr_0);

	// Token: 0x0600267F RID: 9855 RVA: 0x0000DE81 File Offset: 0x0000C081
	static Delegate938()
	{
		Class15.smethod_14(typeof(Delegate938).TypeHandle);
	}

	// Token: 0x04000D8A RID: 3466
	internal static Delegate938 delegate938_0;
}
