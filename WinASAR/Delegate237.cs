using System;

// Token: 0x020002FD RID: 765
internal sealed class Delegate237 : MulticastDelegate
{
	// Token: 0x06001B88 RID: 7048
	public extern void Invoke(object object_0, bool bool_0);

	// Token: 0x06001B89 RID: 7049 RVA: 0x000098A1 File Offset: 0x00007AA1
	public static void smethod_0(object object_0, bool bool_0, Delegate237 delegate237_1)
	{
		delegate237_1(object_0, bool_0);
	}

	// Token: 0x06001B8A RID: 7050
	public extern Delegate237(object object_0, IntPtr intptr_0);

	// Token: 0x06001B8B RID: 7051 RVA: 0x000098AE File Offset: 0x00007AAE
	static Delegate237()
	{
		Class15.smethod_14(typeof(Delegate237).TypeHandle);
	}

	// Token: 0x04000ACD RID: 2765
	internal static Delegate237 delegate237_0;
}
