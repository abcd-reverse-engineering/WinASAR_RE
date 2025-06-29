using System;
using System.Xml;

// Token: 0x02000587 RID: 1415
internal sealed class Delegate887 : MulticastDelegate
{
	// Token: 0x060025B0 RID: 9648
	public extern XmlNode Invoke(object object_0);

	// Token: 0x060025B1 RID: 9649 RVA: 0x0000D98C File Offset: 0x0000BB8C
	public static XmlNode smethod_0(object object_0, Delegate887 delegate887_1)
	{
		return delegate887_1(object_0);
	}

	// Token: 0x060025B2 RID: 9650
	public extern Delegate887(object object_0, IntPtr intptr_0);

	// Token: 0x060025B3 RID: 9651 RVA: 0x0000D997 File Offset: 0x0000BB97
	static Delegate887()
	{
		Class15.smethod_14(typeof(Delegate887).TypeHandle);
	}

	// Token: 0x04000D57 RID: 3415
	internal static Delegate887 delegate887_0;
}
