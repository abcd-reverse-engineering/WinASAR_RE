using System;
using System.Drawing;

// Token: 0x02000249 RID: 585
internal sealed class Delegate57 : MulticastDelegate
{
	// Token: 0x060018B8 RID: 6328
	public extern Color Invoke();

	// Token: 0x060018B9 RID: 6329 RVA: 0x000086E7 File Offset: 0x000068E7
	public static Color smethod_0(Delegate57 delegate57_1)
	{
		return delegate57_1();
	}

	// Token: 0x060018BA RID: 6330
	public extern Delegate57(object object_0, IntPtr intptr_0);

	// Token: 0x060018BB RID: 6331 RVA: 0x000086F0 File Offset: 0x000068F0
	static Delegate57()
	{
		Class15.smethod_14(typeof(Delegate57).TypeHandle);
	}

	// Token: 0x04000A19 RID: 2585
	internal static Delegate57 delegate57_0;
}
