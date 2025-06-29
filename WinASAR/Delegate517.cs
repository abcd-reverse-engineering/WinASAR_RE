using System;
using System.Dynamic;

// Token: 0x02000415 RID: 1045
internal sealed class Delegate517 : MulticastDelegate
{
	// Token: 0x06001FE8 RID: 8168
	public extern DynamicMetaObject Invoke(object object_0, GetMemberBinder getMemberBinder_0);

	// Token: 0x06001FE9 RID: 8169 RVA: 0x0000B4C9 File Offset: 0x000096C9
	public static DynamicMetaObject smethod_0(object object_0, GetMemberBinder getMemberBinder_0, Delegate517 delegate517_1)
	{
		return delegate517_1(object_0, getMemberBinder_0);
	}

	// Token: 0x06001FEA RID: 8170
	public extern Delegate517(object object_0, IntPtr intptr_0);

	// Token: 0x06001FEB RID: 8171 RVA: 0x0000B4D6 File Offset: 0x000096D6
	static Delegate517()
	{
		Class15.smethod_14(typeof(Delegate517).TypeHandle);
	}

	// Token: 0x04000BE5 RID: 3045
	internal static Delegate517 delegate517_0;
}
