using System;

// Token: 0x020002E1 RID: 737
internal sealed class Delegate209 : MulticastDelegate
{
	// Token: 0x06001B18 RID: 6936
	public extern void Invoke(object object_0);

	// Token: 0x06001B19 RID: 6937 RVA: 0x000095DD File Offset: 0x000077DD
	public static void smethod_0(object object_0, Delegate209 delegate209_1)
	{
		delegate209_1(object_0);
	}

	// Token: 0x06001B1A RID: 6938
	public extern Delegate209(object object_0, IntPtr intptr_0);

	// Token: 0x06001B1B RID: 6939 RVA: 0x000095E8 File Offset: 0x000077E8
	static Delegate209()
	{
		Class15.smethod_14(typeof(Delegate209).TypeHandle);
	}

	// Token: 0x04000AB1 RID: 2737
	internal static Delegate209 delegate209_0;
}
