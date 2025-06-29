using System;
using System.Dynamic;

// Token: 0x02000417 RID: 1047
internal sealed class Delegate519 : MulticastDelegate
{
	// Token: 0x06001FF0 RID: 8176
	public extern DynamicMetaObject Invoke(object object_0, DeleteMemberBinder deleteMemberBinder_0);

	// Token: 0x06001FF1 RID: 8177 RVA: 0x0000B4FF File Offset: 0x000096FF
	public static DynamicMetaObject smethod_0(object object_0, DeleteMemberBinder deleteMemberBinder_0, Delegate519 delegate519_1)
	{
		return delegate519_1(object_0, deleteMemberBinder_0);
	}

	// Token: 0x06001FF2 RID: 8178
	public extern Delegate519(object object_0, IntPtr intptr_0);

	// Token: 0x06001FF3 RID: 8179 RVA: 0x0000B50C File Offset: 0x0000970C
	static Delegate519()
	{
		Class15.smethod_14(typeof(Delegate519).TypeHandle);
	}

	// Token: 0x04000BE7 RID: 3047
	internal static Delegate519 delegate519_0;
}
