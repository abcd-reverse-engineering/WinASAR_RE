using System;
using System.Xml.Linq;

// Token: 0x02000596 RID: 1430
internal sealed class Delegate902 : MulticastDelegate
{
	// Token: 0x060025EC RID: 9708
	public extern XDeclaration Invoke(object object_0);

	// Token: 0x060025ED RID: 9709 RVA: 0x0000DAFC File Offset: 0x0000BCFC
	public static XDeclaration smethod_0(object object_0, Delegate902 delegate902_1)
	{
		return delegate902_1(object_0);
	}

	// Token: 0x060025EE RID: 9710
	public extern Delegate902(object object_0, IntPtr intptr_0);

	// Token: 0x060025EF RID: 9711 RVA: 0x0000DB07 File Offset: 0x0000BD07
	static Delegate902()
	{
		Class15.smethod_14(typeof(Delegate902).TypeHandle);
	}

	// Token: 0x04000D66 RID: 3430
	internal static Delegate902 delegate902_0;
}
