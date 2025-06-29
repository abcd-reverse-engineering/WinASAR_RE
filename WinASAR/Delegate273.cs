using System;

// Token: 0x02000321 RID: 801
internal sealed class Delegate273 : MulticastDelegate
{
	// Token: 0x06001C18 RID: 7192
	public extern void Invoke(object object_0);

	// Token: 0x06001C19 RID: 7193 RVA: 0x00009C2D File Offset: 0x00007E2D
	public static void smethod_0(object object_0, Delegate273 delegate273_1)
	{
		delegate273_1(object_0);
	}

	// Token: 0x06001C1A RID: 7194
	public extern Delegate273(object object_0, IntPtr intptr_0);

	// Token: 0x06001C1B RID: 7195 RVA: 0x00009C38 File Offset: 0x00007E38
	static Delegate273()
	{
		Class15.smethod_14(typeof(Delegate273).TypeHandle);
	}

	// Token: 0x04000AF1 RID: 2801
	internal static Delegate273 delegate273_0;
}
