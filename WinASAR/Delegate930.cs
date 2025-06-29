using System;
using System.Xml.Linq;

// Token: 0x020005B2 RID: 1458
internal sealed class Delegate930 : MulticastDelegate
{
	// Token: 0x0600265C RID: 9820
	public extern string Invoke(object object_0, XNamespace xnamespace_0);

	// Token: 0x0600265D RID: 9821 RVA: 0x0000DDAC File Offset: 0x0000BFAC
	public static string smethod_0(object object_0, XNamespace xnamespace_0, Delegate930 delegate930_1)
	{
		return delegate930_1(object_0, xnamespace_0);
	}

	// Token: 0x0600265E RID: 9822
	public extern Delegate930(object object_0, IntPtr intptr_0);

	// Token: 0x0600265F RID: 9823 RVA: 0x0000DDB9 File Offset: 0x0000BFB9
	static Delegate930()
	{
		Class15.smethod_14(typeof(Delegate930).TypeHandle);
	}

	// Token: 0x04000D82 RID: 3458
	internal static Delegate930 delegate930_0;
}
