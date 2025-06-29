using System;
using System.Windows.Forms;

// Token: 0x020002BE RID: 702
internal sealed class Delegate174 : MulticastDelegate
{
	// Token: 0x06001A8C RID: 6796
	public extern void Invoke(object object_0, View view_0);

	// Token: 0x06001A8D RID: 6797 RVA: 0x00009269 File Offset: 0x00007469
	public static void smethod_0(object object_0, View view_0, Delegate174 delegate174_1)
	{
		delegate174_1(object_0, view_0);
	}

	// Token: 0x06001A8E RID: 6798
	public extern Delegate174(object object_0, IntPtr intptr_0);

	// Token: 0x06001A8F RID: 6799 RVA: 0x00009276 File Offset: 0x00007476
	static Delegate174()
	{
		Class15.smethod_14(typeof(Delegate174).TypeHandle);
	}

	// Token: 0x04000A8E RID: 2702
	internal static Delegate174 delegate174_0;
}
