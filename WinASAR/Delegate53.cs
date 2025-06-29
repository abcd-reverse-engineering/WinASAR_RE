using System;
using System.Drawing;

// Token: 0x02000245 RID: 581
internal sealed class Delegate53 : MulticastDelegate
{
	// Token: 0x060018A8 RID: 6312
	public extern Color Invoke();

	// Token: 0x060018A9 RID: 6313 RVA: 0x00008683 File Offset: 0x00006883
	public static Color smethod_0(Delegate53 delegate53_1)
	{
		return delegate53_1();
	}

	// Token: 0x060018AA RID: 6314
	public extern Delegate53(object object_0, IntPtr intptr_0);

	// Token: 0x060018AB RID: 6315 RVA: 0x0000868C File Offset: 0x0000688C
	static Delegate53()
	{
		Class15.smethod_14(typeof(Delegate53).TypeHandle);
	}

	// Token: 0x04000A15 RID: 2581
	internal static Delegate53 delegate53_0;
}
