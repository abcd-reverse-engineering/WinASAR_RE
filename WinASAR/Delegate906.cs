using System;
using System.Xml.Linq;

// Token: 0x0200059A RID: 1434
internal sealed class Delegate906 : MulticastDelegate
{
	// Token: 0x060025FC RID: 9724
	public extern void Invoke(object object_0, XDeclaration xdeclaration_0);

	// Token: 0x060025FD RID: 9725 RVA: 0x0000DB5E File Offset: 0x0000BD5E
	public static void smethod_0(object object_0, XDeclaration xdeclaration_0, Delegate906 delegate906_1)
	{
		delegate906_1(object_0, xdeclaration_0);
	}

	// Token: 0x060025FE RID: 9726
	public extern Delegate906(object object_0, IntPtr intptr_0);

	// Token: 0x060025FF RID: 9727 RVA: 0x0000DB6B File Offset: 0x0000BD6B
	static Delegate906()
	{
		Class15.smethod_14(typeof(Delegate906).TypeHandle);
	}

	// Token: 0x04000D6A RID: 3434
	internal static Delegate906 delegate906_0;
}
