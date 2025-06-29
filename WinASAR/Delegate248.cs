using System;

// Token: 0x02000308 RID: 776
internal sealed class Delegate248 : MulticastDelegate
{
	// Token: 0x06001BB4 RID: 7092
	public extern void Invoke(object object_0, bool bool_0);

	// Token: 0x06001BB5 RID: 7093 RVA: 0x000099BF File Offset: 0x00007BBF
	public static void smethod_0(object object_0, bool bool_0, Delegate248 delegate248_1)
	{
		delegate248_1(object_0, bool_0);
	}

	// Token: 0x06001BB6 RID: 7094
	public extern Delegate248(object object_0, IntPtr intptr_0);

	// Token: 0x06001BB7 RID: 7095 RVA: 0x000099CC File Offset: 0x00007BCC
	static Delegate248()
	{
		Class15.smethod_14(typeof(Delegate248).TypeHandle);
	}

	// Token: 0x04000AD8 RID: 2776
	internal static Delegate248 delegate248_0;
}
