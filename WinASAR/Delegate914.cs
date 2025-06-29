using System;

// Token: 0x020005A2 RID: 1442
internal sealed class Delegate914 : MulticastDelegate
{
	// Token: 0x0600261C RID: 9756
	public extern void Invoke(object object_0, string string_0);

	// Token: 0x0600261D RID: 9757 RVA: 0x0000DC24 File Offset: 0x0000BE24
	public static void smethod_0(object object_0, string string_0, Delegate914 delegate914_1)
	{
		delegate914_1(object_0, string_0);
	}

	// Token: 0x0600261E RID: 9758
	public extern Delegate914(object object_0, IntPtr intptr_0);

	// Token: 0x0600261F RID: 9759 RVA: 0x0000DC31 File Offset: 0x0000BE31
	static Delegate914()
	{
		Class15.smethod_14(typeof(Delegate914).TypeHandle);
	}

	// Token: 0x04000D72 RID: 3442
	internal static Delegate914 delegate914_0;
}
