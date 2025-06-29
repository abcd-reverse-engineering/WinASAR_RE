using System;
using System.Drawing;

// Token: 0x020002DB RID: 731
internal sealed class Delegate203 : MulticastDelegate
{
	// Token: 0x06001B00 RID: 6912
	public extern Point Invoke();

	// Token: 0x06001B01 RID: 6913 RVA: 0x00009545 File Offset: 0x00007745
	public static Point smethod_0(Delegate203 delegate203_1)
	{
		return delegate203_1();
	}

	// Token: 0x06001B02 RID: 6914
	public extern Delegate203(object object_0, IntPtr intptr_0);

	// Token: 0x06001B03 RID: 6915 RVA: 0x0000954E File Offset: 0x0000774E
	static Delegate203()
	{
		Class15.smethod_14(typeof(Delegate203).TypeHandle);
	}

	// Token: 0x04000AAB RID: 2731
	internal static Delegate203 delegate203_0;
}
