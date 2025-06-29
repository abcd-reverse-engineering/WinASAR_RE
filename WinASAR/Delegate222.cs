using System;
using System.Windows.Forms;

// Token: 0x020002EE RID: 750
internal sealed class Delegate222 : MulticastDelegate
{
	// Token: 0x06001B4C RID: 6988
	public extern void Invoke(object object_0, CheckState checkState_0);

	// Token: 0x06001B4D RID: 6989 RVA: 0x00009723 File Offset: 0x00007923
	public static void smethod_0(object object_0, CheckState checkState_0, Delegate222 delegate222_1)
	{
		delegate222_1(object_0, checkState_0);
	}

	// Token: 0x06001B4E RID: 6990
	public extern Delegate222(object object_0, IntPtr intptr_0);

	// Token: 0x06001B4F RID: 6991 RVA: 0x00009730 File Offset: 0x00007930
	static Delegate222()
	{
		Class15.smethod_14(typeof(Delegate222).TypeHandle);
	}

	// Token: 0x04000ABE RID: 2750
	internal static Delegate222 delegate222_0;
}
