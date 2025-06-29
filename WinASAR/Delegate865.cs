using System;
using System.Xml;

// Token: 0x02000571 RID: 1393
internal sealed class Delegate865 : MulticastDelegate
{
	// Token: 0x06002558 RID: 9560
	public extern XmlAttribute Invoke(object object_0, XmlAttribute xmlAttribute_0);

	// Token: 0x06002559 RID: 9561 RVA: 0x0000D774 File Offset: 0x0000B974
	public static XmlAttribute smethod_0(object object_0, XmlAttribute xmlAttribute_0, Delegate865 delegate865_1)
	{
		return delegate865_1(object_0, xmlAttribute_0);
	}

	// Token: 0x0600255A RID: 9562
	public extern Delegate865(object object_0, IntPtr intptr_0);

	// Token: 0x0600255B RID: 9563 RVA: 0x0000D781 File Offset: 0x0000B981
	static Delegate865()
	{
		Class15.smethod_14(typeof(Delegate865).TypeHandle);
	}

	// Token: 0x04000D41 RID: 3393
	internal static Delegate865 delegate865_0;
}
