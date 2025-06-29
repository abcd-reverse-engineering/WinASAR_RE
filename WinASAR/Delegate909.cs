using System;
using System.Xml.Linq;

// Token: 0x0200059D RID: 1437
internal sealed class Delegate909 : MulticastDelegate
{
	// Token: 0x06002608 RID: 9736
	public extern XElement Invoke(object object_0);

	// Token: 0x06002609 RID: 9737 RVA: 0x0000DBAA File Offset: 0x0000BDAA
	public static XElement smethod_0(object object_0, Delegate909 delegate909_1)
	{
		return delegate909_1(object_0);
	}

	// Token: 0x0600260A RID: 9738
	public extern Delegate909(object object_0, IntPtr intptr_0);

	// Token: 0x0600260B RID: 9739 RVA: 0x0000DBB5 File Offset: 0x0000BDB5
	static Delegate909()
	{
		Class15.smethod_14(typeof(Delegate909).TypeHandle);
	}

	// Token: 0x04000D6D RID: 3437
	internal static Delegate909 delegate909_0;
}
