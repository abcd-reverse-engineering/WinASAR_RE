using System;
using System.Windows.Forms;

// Token: 0x02000252 RID: 594
internal sealed class Delegate66 : MulticastDelegate
{
	// Token: 0x060018DC RID: 6364
	public extern void Invoke(object object_0, AutoScaleMode autoScaleMode_0);

	// Token: 0x060018DD RID: 6365 RVA: 0x000087C9 File Offset: 0x000069C9
	public static void smethod_0(object object_0, AutoScaleMode autoScaleMode_0, Delegate66 delegate66_1)
	{
		delegate66_1(object_0, autoScaleMode_0);
	}

	// Token: 0x060018DE RID: 6366
	public extern Delegate66(object object_0, IntPtr intptr_0);

	// Token: 0x060018DF RID: 6367 RVA: 0x000087D6 File Offset: 0x000069D6
	static Delegate66()
	{
		Class15.smethod_14(typeof(Delegate66).TypeHandle);
	}

	// Token: 0x04000A22 RID: 2594
	internal static Delegate66 delegate66_0;
}
