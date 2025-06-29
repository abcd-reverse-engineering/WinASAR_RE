using System;
using System.Reflection.Emit;

// Token: 0x02000442 RID: 1090
internal sealed class Delegate562 : MulticastDelegate
{
	// Token: 0x0600209C RID: 8348
	public extern void Invoke(object object_0, Label label_0);

	// Token: 0x0600209D RID: 8349 RVA: 0x0000B95B File Offset: 0x00009B5B
	public static void smethod_0(object object_0, Label label_0, Delegate562 delegate562_1)
	{
		delegate562_1(object_0, label_0);
	}

	// Token: 0x0600209E RID: 8350
	public extern Delegate562(object object_0, IntPtr intptr_0);

	// Token: 0x0600209F RID: 8351 RVA: 0x0000B968 File Offset: 0x00009B68
	static Delegate562()
	{
		Class15.smethod_14(typeof(Delegate562).TypeHandle);
	}

	// Token: 0x04000C12 RID: 3090
	internal static Delegate562 delegate562_0;
}
