using System;

// Token: 0x02000348 RID: 840
internal sealed class Delegate312 : MulticastDelegate
{
	// Token: 0x06001CB4 RID: 7348
	public extern void Invoke(int int_0);

	// Token: 0x06001CB5 RID: 7349 RVA: 0x0000A015 File Offset: 0x00008215
	public static void smethod_0(int int_0, Delegate312 delegate312_1)
	{
		delegate312_1(int_0);
	}

	// Token: 0x06001CB6 RID: 7350
	public extern Delegate312(object object_0, IntPtr intptr_0);

	// Token: 0x06001CB7 RID: 7351 RVA: 0x0000A020 File Offset: 0x00008220
	static Delegate312()
	{
		Class15.smethod_14(typeof(Delegate312).TypeHandle);
	}

	// Token: 0x04000B18 RID: 2840
	internal static Delegate312 delegate312_0;
}
