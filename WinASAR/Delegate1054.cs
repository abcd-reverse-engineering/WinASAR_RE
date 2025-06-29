using System;
using System.Text;

// Token: 0x0200062E RID: 1582
internal sealed class Delegate1054 : MulticastDelegate
{
	// Token: 0x0600284C RID: 10316
	public extern StringBuilder Invoke(object object_0);

	// Token: 0x0600284D RID: 10317 RVA: 0x0000EA1A File Offset: 0x0000CC1A
	public static StringBuilder smethod_0(object object_0, Delegate1054 delegate1054_1)
	{
		return delegate1054_1(object_0);
	}

	// Token: 0x0600284E RID: 10318
	public extern Delegate1054(object object_0, IntPtr intptr_0);

	// Token: 0x0600284F RID: 10319 RVA: 0x0000EA25 File Offset: 0x0000CC25
	static Delegate1054()
	{
		Class15.smethod_14(typeof(Delegate1054).TypeHandle);
	}

	// Token: 0x04000DFE RID: 3582
	internal static Delegate1054 delegate1054_0;
}
