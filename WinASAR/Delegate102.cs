using System;

// Token: 0x02000276 RID: 630
internal sealed class Delegate102 : MulticastDelegate
{
	// Token: 0x0600196C RID: 6508
	public extern void Invoke(object object_0, bool bool_0);

	// Token: 0x0600196D RID: 6509 RVA: 0x00008B5D File Offset: 0x00006D5D
	public static void smethod_0(object object_0, bool bool_0, Delegate102 delegate102_1)
	{
		delegate102_1(object_0, bool_0);
	}

	// Token: 0x0600196E RID: 6510
	public extern Delegate102(object object_0, IntPtr intptr_0);

	// Token: 0x0600196F RID: 6511 RVA: 0x00008B6A File Offset: 0x00006D6A
	static Delegate102()
	{
		Class15.smethod_14(typeof(Delegate102).TypeHandle);
	}

	// Token: 0x04000A46 RID: 2630
	internal static Delegate102 delegate102_0;
}
