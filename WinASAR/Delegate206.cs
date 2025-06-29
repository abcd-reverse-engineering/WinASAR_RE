using System;

// Token: 0x020002DE RID: 734
internal sealed class Delegate206 : MulticastDelegate
{
	// Token: 0x06001B0C RID: 6924
	public extern void Invoke(object object_0, int int_0);

	// Token: 0x06001B0D RID: 6925 RVA: 0x00009591 File Offset: 0x00007791
	public static void smethod_0(object object_0, int int_0, Delegate206 delegate206_1)
	{
		delegate206_1(object_0, int_0);
	}

	// Token: 0x06001B0E RID: 6926
	public extern Delegate206(object object_0, IntPtr intptr_0);

	// Token: 0x06001B0F RID: 6927 RVA: 0x0000959E File Offset: 0x0000779E
	static Delegate206()
	{
		Class15.smethod_14(typeof(Delegate206).TypeHandle);
	}

	// Token: 0x04000AAE RID: 2734
	internal static Delegate206 delegate206_0;
}
