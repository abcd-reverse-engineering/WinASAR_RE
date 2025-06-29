using System;

// Token: 0x020004F1 RID: 1265
internal sealed class Delegate737 : MulticastDelegate
{
	// Token: 0x06002358 RID: 9048
	public extern void Invoke(object object_0);

	// Token: 0x06002359 RID: 9049 RVA: 0x0000CAA8 File Offset: 0x0000ACA8
	public static void smethod_0(object object_0, Delegate737 delegate737_1)
	{
		delegate737_1(object_0);
	}

	// Token: 0x0600235A RID: 9050
	public extern Delegate737(object object_0, IntPtr intptr_0);

	// Token: 0x0600235B RID: 9051 RVA: 0x0000CAB3 File Offset: 0x0000ACB3
	static Delegate737()
	{
		Class15.smethod_14(typeof(Delegate737).TypeHandle);
	}

	// Token: 0x04000CC1 RID: 3265
	internal static Delegate737 delegate737_0;
}
