using System;
using System.Xml.Linq;

// Token: 0x020005A9 RID: 1449
internal sealed class Delegate921 : MulticastDelegate
{
	// Token: 0x06002638 RID: 9784
	public extern XName Invoke(object object_0);

	// Token: 0x06002639 RID: 9785 RVA: 0x0000DCD2 File Offset: 0x0000BED2
	public static XName smethod_0(object object_0, Delegate921 delegate921_1)
	{
		return delegate921_1(object_0);
	}

	// Token: 0x0600263A RID: 9786
	public extern Delegate921(object object_0, IntPtr intptr_0);

	// Token: 0x0600263B RID: 9787 RVA: 0x0000DCDD File Offset: 0x0000BEDD
	static Delegate921()
	{
		Class15.smethod_14(typeof(Delegate921).TypeHandle);
	}

	// Token: 0x04000D79 RID: 3449
	internal static Delegate921 delegate921_0;
}
