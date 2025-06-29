using System;
using System.Windows.Forms;

// Token: 0x020002B9 RID: 697
internal sealed class Delegate169 : MulticastDelegate
{
	// Token: 0x06001A78 RID: 6776
	public extern void Invoke(object object_0, FormStartPosition formStartPosition_0);

	// Token: 0x06001A79 RID: 6777 RVA: 0x000091E9 File Offset: 0x000073E9
	public static void smethod_0(object object_0, FormStartPosition formStartPosition_0, Delegate169 delegate169_0)
	{
		delegate169_0(object_0, formStartPosition_0);
	}

	// Token: 0x06001A7A RID: 6778
	public extern Delegate169(object object_0, IntPtr intptr_0);

	// Token: 0x06001A7B RID: 6779 RVA: 0x000091F6 File Offset: 0x000073F6
	static Delegate169()
	{
		Class15.smethod_14(typeof(Delegate169).TypeHandle);
	}

	// Token: 0x04000A89 RID: 2697
	internal static Delegate169 pjhPxdCamo;
}
