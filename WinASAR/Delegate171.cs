using System;
using System.Drawing;

// Token: 0x020002BB RID: 699
internal sealed class Delegate171 : MulticastDelegate
{
	// Token: 0x06001A80 RID: 6784
	public extern void Invoke(object object_0, Icon icon_0);

	// Token: 0x06001A81 RID: 6785 RVA: 0x0000921B File Offset: 0x0000741B
	public static void smethod_0(object object_0, Icon icon_0, Delegate171 delegate171_1)
	{
		delegate171_1(object_0, icon_0);
	}

	// Token: 0x06001A82 RID: 6786
	public extern Delegate171(object object_0, IntPtr intptr_0);

	// Token: 0x06001A83 RID: 6787 RVA: 0x00009228 File Offset: 0x00007428
	static Delegate171()
	{
		Class15.smethod_14(typeof(Delegate171).TypeHandle);
	}

	// Token: 0x04000A8B RID: 2699
	internal static Delegate171 delegate171_0;
}
