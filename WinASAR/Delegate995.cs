using System;

// Token: 0x020005F3 RID: 1523
internal sealed class Delegate995 : MulticastDelegate
{
	// Token: 0x06002760 RID: 10080
	public extern bool Invoke(object object_0);

	// Token: 0x06002761 RID: 10081 RVA: 0x0000E45C File Offset: 0x0000C65C
	public static bool smethod_0(object object_0, Delegate995 delegate995_0)
	{
		return delegate995_0(object_0);
	}

	// Token: 0x06002762 RID: 10082
	public extern Delegate995(object object_0, IntPtr intptr_0);

	// Token: 0x06002763 RID: 10083 RVA: 0x0000E467 File Offset: 0x0000C667
	static Delegate995()
	{
		Class15.smethod_14(typeof(Delegate995).TypeHandle);
	}

	// Token: 0x04000DC3 RID: 3523
	internal static Delegate995 XrmWbFaLigo;
}
