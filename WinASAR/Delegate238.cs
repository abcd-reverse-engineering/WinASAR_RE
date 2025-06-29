using System;
using System.Drawing;

// Token: 0x020002FE RID: 766
internal sealed class Delegate238 : MulticastDelegate
{
	// Token: 0x06001B8C RID: 7052
	public extern void Invoke(object object_0, ContentAlignment contentAlignment_0);

	// Token: 0x06001B8D RID: 7053 RVA: 0x000098BB File Offset: 0x00007ABB
	public static void smethod_0(object object_0, ContentAlignment contentAlignment_0, Delegate238 delegate238_1)
	{
		delegate238_1(object_0, contentAlignment_0);
	}

	// Token: 0x06001B8E RID: 7054
	public extern Delegate238(object object_0, IntPtr intptr_0);

	// Token: 0x06001B8F RID: 7055 RVA: 0x000098C8 File Offset: 0x00007AC8
	static Delegate238()
	{
		Class15.smethod_14(typeof(Delegate238).TypeHandle);
	}

	// Token: 0x04000ACE RID: 2766
	internal static Delegate238 delegate238_0;
}
