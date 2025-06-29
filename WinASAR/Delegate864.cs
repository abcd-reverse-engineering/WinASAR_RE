using System;
using System.Xml;

// Token: 0x02000570 RID: 1392
internal sealed class Delegate864 : MulticastDelegate
{
	// Token: 0x06002554 RID: 9556
	public extern XmlElement Invoke(object object_0);

	// Token: 0x06002555 RID: 9557 RVA: 0x0000D75C File Offset: 0x0000B95C
	public static XmlElement smethod_0(object object_0, Delegate864 delegate864_1)
	{
		return delegate864_1(object_0);
	}

	// Token: 0x06002556 RID: 9558
	public extern Delegate864(object object_0, IntPtr intptr_0);

	// Token: 0x06002557 RID: 9559 RVA: 0x0000D767 File Offset: 0x0000B967
	static Delegate864()
	{
		Class15.smethod_14(typeof(Delegate864).TypeHandle);
	}

	// Token: 0x04000D40 RID: 3392
	internal static Delegate864 delegate864_0;
}
