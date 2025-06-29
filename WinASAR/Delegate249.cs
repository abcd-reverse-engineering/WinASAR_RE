using System;

// Token: 0x02000309 RID: 777
internal sealed class Delegate249 : MulticastDelegate
{
	// Token: 0x06001BB8 RID: 7096
	public extern void Invoke(object object_0, object object_1);

	// Token: 0x06001BB9 RID: 7097 RVA: 0x000099D9 File Offset: 0x00007BD9
	public static void smethod_0(object object_0, object object_1, Delegate249 delegate249_1)
	{
		delegate249_1(object_0, object_1);
	}

	// Token: 0x06001BBA RID: 7098
	public extern Delegate249(object object_0, IntPtr intptr_0);

	// Token: 0x06001BBB RID: 7099 RVA: 0x000099E6 File Offset: 0x00007BE6
	static Delegate249()
	{
		Class15.smethod_14(typeof(Delegate249).TypeHandle);
	}

	// Token: 0x04000AD9 RID: 2777
	internal static Delegate249 delegate249_0;
}
