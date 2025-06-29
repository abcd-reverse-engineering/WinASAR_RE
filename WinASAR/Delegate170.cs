using System;
using System.Drawing;

// Token: 0x020002BA RID: 698
internal sealed class Delegate170 : MulticastDelegate
{
	// Token: 0x06001A7C RID: 6780
	public extern Icon Invoke(object object_0);

	// Token: 0x06001A7D RID: 6781 RVA: 0x00009203 File Offset: 0x00007403
	public static Icon smethod_0(object object_0, Delegate170 delegate170_1)
	{
		return delegate170_1(object_0);
	}

	// Token: 0x06001A7E RID: 6782
	public extern Delegate170(object object_0, IntPtr intptr_0);

	// Token: 0x06001A7F RID: 6783 RVA: 0x0000920E File Offset: 0x0000740E
	static Delegate170()
	{
		Class15.smethod_14(typeof(Delegate170).TypeHandle);
	}

	// Token: 0x04000A8A RID: 2698
	internal static Delegate170 delegate170_0;
}
