using System;

// Token: 0x020002AA RID: 682
internal sealed class Delegate154 : MulticastDelegate
{
	// Token: 0x06001A3C RID: 6716
	public extern int Invoke(object object_0);

	// Token: 0x06001A3D RID: 6717 RVA: 0x00009073 File Offset: 0x00007273
	public static int smethod_0(object object_0, Delegate154 delegate154_1)
	{
		return delegate154_1(object_0);
	}

	// Token: 0x06001A3E RID: 6718
	public extern Delegate154(object object_0, IntPtr intptr_0);

	// Token: 0x06001A3F RID: 6719 RVA: 0x0000907E File Offset: 0x0000727E
	static Delegate154()
	{
		Class15.smethod_14(typeof(Delegate154).TypeHandle);
	}

	// Token: 0x04000A7A RID: 2682
	internal static Delegate154 delegate154_0;
}
