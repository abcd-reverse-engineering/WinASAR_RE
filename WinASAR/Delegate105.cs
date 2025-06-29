using System;

// Token: 0x02000279 RID: 633
internal sealed class Delegate105 : MulticastDelegate
{
	// Token: 0x06001978 RID: 6520
	public extern void Invoke(object object_0, object object_1);

	// Token: 0x06001979 RID: 6521 RVA: 0x00008BAB File Offset: 0x00006DAB
	public static void smethod_0(object object_0, object object_1, Delegate105 delegate105_1)
	{
		delegate105_1(object_0, object_1);
	}

	// Token: 0x0600197A RID: 6522
	public extern Delegate105(object object_0, IntPtr intptr_0);

	// Token: 0x0600197B RID: 6523 RVA: 0x00008BB8 File Offset: 0x00006DB8
	static Delegate105()
	{
		Class15.smethod_14(typeof(Delegate105).TypeHandle);
	}

	// Token: 0x04000A49 RID: 2633
	internal static Delegate105 delegate105_0;
}
