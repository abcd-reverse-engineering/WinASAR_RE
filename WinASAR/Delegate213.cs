using System;

// Token: 0x020002E5 RID: 741
internal sealed class Delegate213 : MulticastDelegate
{
	// Token: 0x06001B28 RID: 6952
	public extern void Invoke(object object_0);

	// Token: 0x06001B29 RID: 6953 RVA: 0x00009641 File Offset: 0x00007841
	public static void smethod_0(object object_0, Delegate213 delegate213_1)
	{
		delegate213_1(object_0);
	}

	// Token: 0x06001B2A RID: 6954
	public extern Delegate213(object object_0, IntPtr intptr_0);

	// Token: 0x06001B2B RID: 6955 RVA: 0x0000964C File Offset: 0x0000784C
	static Delegate213()
	{
		Class15.smethod_14(typeof(Delegate213).TypeHandle);
	}

	// Token: 0x04000AB5 RID: 2741
	internal static Delegate213 delegate213_0;
}
