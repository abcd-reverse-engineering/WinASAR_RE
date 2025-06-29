using System;

// Token: 0x0200032A RID: 810
internal sealed class Delegate282 : MulticastDelegate
{
	// Token: 0x06001C3C RID: 7228
	public extern void Invoke(object object_0, bool bool_0);

	// Token: 0x06001C3D RID: 7229 RVA: 0x00009D0F File Offset: 0x00007F0F
	public static void smethod_0(object object_0, bool bool_0, Delegate282 delegate282_1)
	{
		delegate282_1(object_0, bool_0);
	}

	// Token: 0x06001C3E RID: 7230
	public extern Delegate282(object object_0, IntPtr intptr_0);

	// Token: 0x06001C3F RID: 7231 RVA: 0x00009D1C File Offset: 0x00007F1C
	static Delegate282()
	{
		Class15.smethod_14(typeof(Delegate282).TypeHandle);
	}

	// Token: 0x04000AFA RID: 2810
	internal static Delegate282 delegate282_0;
}
