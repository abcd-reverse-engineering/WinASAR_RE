using System;
using System.Windows.Forms;

// Token: 0x02000253 RID: 595
internal sealed class Delegate67 : MulticastDelegate
{
	// Token: 0x060018E0 RID: 6368
	public extern void Invoke(object object_0, IButtonControl ibuttonControl_0);

	// Token: 0x060018E1 RID: 6369 RVA: 0x000087E3 File Offset: 0x000069E3
	public static void smethod_0(object object_0, IButtonControl ibuttonControl_0, Delegate67 delegate67_1)
	{
		delegate67_1(object_0, ibuttonControl_0);
	}

	// Token: 0x060018E2 RID: 6370
	public extern Delegate67(object object_0, IntPtr intptr_0);

	// Token: 0x060018E3 RID: 6371 RVA: 0x000087F0 File Offset: 0x000069F0
	static Delegate67()
	{
		Class15.smethod_14(typeof(Delegate67).TypeHandle);
	}

	// Token: 0x04000A23 RID: 2595
	internal static Delegate67 delegate67_0;
}
