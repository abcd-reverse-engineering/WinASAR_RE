using System;
using System.Reflection.Emit;

// Token: 0x0200043C RID: 1084
internal sealed class Delegate556 : MulticastDelegate
{
	// Token: 0x06002084 RID: 8324
	public extern Label Invoke(object object_0);

	// Token: 0x06002085 RID: 8325 RVA: 0x0000B8BB File Offset: 0x00009ABB
	public static Label smethod_0(object object_0, Delegate556 delegate556_1)
	{
		return delegate556_1(object_0);
	}

	// Token: 0x06002086 RID: 8326
	public extern Delegate556(object object_0, IntPtr intptr_0);

	// Token: 0x06002087 RID: 8327 RVA: 0x0000B8C6 File Offset: 0x00009AC6
	static Delegate556()
	{
		Class15.smethod_14(typeof(Delegate556).TypeHandle);
	}

	// Token: 0x04000C0C RID: 3084
	internal static Delegate556 delegate556_0;
}
