using System;

// Token: 0x020002CC RID: 716
internal sealed class Delegate188 : MulticastDelegate
{
	// Token: 0x06001AC4 RID: 6852
	public extern void Invoke(object object_0, int int_0);

	// Token: 0x06001AC5 RID: 6853 RVA: 0x000093C7 File Offset: 0x000075C7
	public static void smethod_0(object object_0, int int_0, Delegate188 delegate188_1)
	{
		delegate188_1(object_0, int_0);
	}

	// Token: 0x06001AC6 RID: 6854
	public extern Delegate188(object object_0, IntPtr intptr_0);

	// Token: 0x06001AC7 RID: 6855 RVA: 0x000093D4 File Offset: 0x000075D4
	static Delegate188()
	{
		Class15.smethod_14(typeof(Delegate188).TypeHandle);
	}

	// Token: 0x04000A9C RID: 2716
	internal static Delegate188 delegate188_0;
}
