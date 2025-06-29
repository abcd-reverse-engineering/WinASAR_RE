using System;
using System.Drawing;

// Token: 0x020002F1 RID: 753
internal sealed class Delegate225 : MulticastDelegate
{
	// Token: 0x06001B58 RID: 7000
	public extern Color Invoke();

	// Token: 0x06001B59 RID: 7001 RVA: 0x00009771 File Offset: 0x00007971
	public static Color smethod_0(Delegate225 delegate225_1)
	{
		return delegate225_1();
	}

	// Token: 0x06001B5A RID: 7002
	public extern Delegate225(object object_0, IntPtr intptr_0);

	// Token: 0x06001B5B RID: 7003 RVA: 0x0000977A File Offset: 0x0000797A
	static Delegate225()
	{
		Class15.smethod_14(typeof(Delegate225).TypeHandle);
	}

	// Token: 0x04000AC1 RID: 2753
	internal static Delegate225 delegate225_0;
}
