using System;
using System.Drawing;

// Token: 0x0200023F RID: 575
internal sealed class Delegate47 : MulticastDelegate
{
	// Token: 0x06001890 RID: 6288
	public extern void Invoke(object object_0, Size size_0);

	// Token: 0x06001891 RID: 6289 RVA: 0x000085E7 File Offset: 0x000067E7
	public static void smethod_0(object object_0, Size size_0, Delegate47 delegate47_1)
	{
		delegate47_1(object_0, size_0);
	}

	// Token: 0x06001892 RID: 6290
	public extern Delegate47(object object_0, IntPtr intptr_0);

	// Token: 0x06001893 RID: 6291 RVA: 0x000085F4 File Offset: 0x000067F4
	static Delegate47()
	{
		Class15.smethod_14(typeof(Delegate47).TypeHandle);
	}

	// Token: 0x04000A0F RID: 2575
	internal static Delegate47 delegate47_0;
}
