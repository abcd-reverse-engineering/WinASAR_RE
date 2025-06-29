using System;
using System.Threading;

// Token: 0x020005F5 RID: 1525
internal sealed class Delegate997 : MulticastDelegate
{
	// Token: 0x06002768 RID: 10088
	public extern Thread Invoke();

	// Token: 0x06002769 RID: 10089 RVA: 0x0000E48C File Offset: 0x0000C68C
	public static Thread smethod_0(Delegate997 delegate997_1)
	{
		return delegate997_1();
	}

	// Token: 0x0600276A RID: 10090
	public extern Delegate997(object object_0, IntPtr intptr_0);

	// Token: 0x0600276B RID: 10091 RVA: 0x0000E495 File Offset: 0x0000C695
	static Delegate997()
	{
		Class15.smethod_14(typeof(Delegate997).TypeHandle);
	}

	// Token: 0x04000DC5 RID: 3525
	internal static Delegate997 delegate997_0;
}
