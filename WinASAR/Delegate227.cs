using System;
using System.Windows.Forms;

// Token: 0x020002F3 RID: 755
internal sealed class Delegate227 : MulticastDelegate
{
	// Token: 0x06001B60 RID: 7008
	public extern void Invoke(object object_0, Padding padding_0);

	// Token: 0x06001B61 RID: 7009 RVA: 0x000097A1 File Offset: 0x000079A1
	public static void smethod_0(object object_0, Padding padding_0, Delegate227 delegate227_0)
	{
		delegate227_0(object_0, padding_0);
	}

	// Token: 0x06001B62 RID: 7010
	public extern Delegate227(object object_0, IntPtr intptr_0);

	// Token: 0x06001B63 RID: 7011 RVA: 0x000097AE File Offset: 0x000079AE
	static Delegate227()
	{
		Class15.smethod_14(typeof(Delegate227).TypeHandle);
	}

	// Token: 0x04000AC3 RID: 2755
	internal static Delegate227 yjygwLjDcy;
}
