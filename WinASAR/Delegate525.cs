using System;
using System.Dynamic;

// Token: 0x0200041D RID: 1053
internal sealed class Delegate525 : MulticastDelegate
{
	// Token: 0x06002008 RID: 8200
	public extern DynamicMetaObject Invoke(object object_0, UnaryOperationBinder unaryOperationBinder_0);

	// Token: 0x06002009 RID: 8201 RVA: 0x0000B5A3 File Offset: 0x000097A3
	public static DynamicMetaObject smethod_0(object object_0, UnaryOperationBinder unaryOperationBinder_0, Delegate525 delegate525_1)
	{
		return delegate525_1(object_0, unaryOperationBinder_0);
	}

	// Token: 0x0600200A RID: 8202
	public extern Delegate525(object object_0, IntPtr intptr_0);

	// Token: 0x0600200B RID: 8203 RVA: 0x0000B5B0 File Offset: 0x000097B0
	static Delegate525()
	{
		Class15.smethod_14(typeof(Delegate525).TypeHandle);
	}

	// Token: 0x04000BED RID: 3053
	internal static Delegate525 delegate525_0;
}
