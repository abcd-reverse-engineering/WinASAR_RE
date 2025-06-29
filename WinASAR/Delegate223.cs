using System;
using System.Drawing;

// Token: 0x020002EF RID: 751
internal sealed class Delegate223 : MulticastDelegate
{
	// Token: 0x06001B50 RID: 6992
	public extern void Invoke(object object_0, Font font_0);

	// Token: 0x06001B51 RID: 6993 RVA: 0x0000973D File Offset: 0x0000793D
	public static void smethod_0(object object_0, Font font_0, Delegate223 delegate223_1)
	{
		delegate223_1(object_0, font_0);
	}

	// Token: 0x06001B52 RID: 6994
	public extern Delegate223(object object_0, IntPtr intptr_0);

	// Token: 0x06001B53 RID: 6995 RVA: 0x0000974A File Offset: 0x0000794A
	static Delegate223()
	{
		Class15.smethod_14(typeof(Delegate223).TypeHandle);
	}

	// Token: 0x04000ABF RID: 2751
	internal static Delegate223 delegate223_0;
}
