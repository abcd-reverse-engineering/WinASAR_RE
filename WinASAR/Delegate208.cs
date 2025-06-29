using System;

// Token: 0x020002E0 RID: 736
internal sealed class Delegate208 : MulticastDelegate
{
	// Token: 0x06001B14 RID: 6932
	public extern void Invoke(object object_0, int int_0);

	// Token: 0x06001B15 RID: 6933 RVA: 0x000095C3 File Offset: 0x000077C3
	public static void smethod_0(object object_0, int int_0, Delegate208 delegate208_0)
	{
		delegate208_0(object_0, int_0);
	}

	// Token: 0x06001B16 RID: 6934
	public extern Delegate208(object object_0, IntPtr intptr_0);

	// Token: 0x06001B17 RID: 6935 RVA: 0x000095D0 File Offset: 0x000077D0
	static Delegate208()
	{
		Class15.smethod_14(typeof(Delegate208).TypeHandle);
	}

	// Token: 0x04000AB0 RID: 2736
	internal static Delegate208 qVuvUyGcgy;
}
