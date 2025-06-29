using System;
using System.Windows.Forms;

// Token: 0x020002F8 RID: 760
internal sealed class Delegate232 : MulticastDelegate
{
	// Token: 0x06001B74 RID: 7028
	public extern void Invoke(object object_0, Padding padding_0);

	// Token: 0x06001B75 RID: 7029 RVA: 0x00009823 File Offset: 0x00007A23
	public static void smethod_0(object object_0, Padding padding_0, Delegate232 delegate232_1)
	{
		delegate232_1(object_0, padding_0);
	}

	// Token: 0x06001B76 RID: 7030
	public extern Delegate232(object object_0, IntPtr intptr_0);

	// Token: 0x06001B77 RID: 7031 RVA: 0x00009830 File Offset: 0x00007A30
	static Delegate232()
	{
		Class15.smethod_14(typeof(Delegate232).TypeHandle);
	}

	// Token: 0x04000AC8 RID: 2760
	internal static Delegate232 delegate232_0;
}
