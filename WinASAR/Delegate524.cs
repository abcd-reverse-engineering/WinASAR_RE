using System;
using System.Dynamic;

// Token: 0x0200041C RID: 1052
internal sealed class Delegate524 : MulticastDelegate
{
	// Token: 0x06002004 RID: 8196
	public extern DynamicMetaObject Invoke(object object_0, BinaryOperationBinder binaryOperationBinder_0, DynamicMetaObject dynamicMetaObject_0);

	// Token: 0x06002005 RID: 8197 RVA: 0x0000B587 File Offset: 0x00009787
	public static DynamicMetaObject smethod_0(object object_0, BinaryOperationBinder binaryOperationBinder_0, DynamicMetaObject dynamicMetaObject_0, Delegate524 delegate524_0)
	{
		return delegate524_0(object_0, binaryOperationBinder_0, dynamicMetaObject_0);
	}

	// Token: 0x06002006 RID: 8198
	public extern Delegate524(object object_0, IntPtr intptr_0);

	// Token: 0x06002007 RID: 8199 RVA: 0x0000B596 File Offset: 0x00009796
	static Delegate524()
	{
		Class15.smethod_14(typeof(Delegate524).TypeHandle);
	}

	// Token: 0x04000BEC RID: 3052
	internal static Delegate524 IrJmmaTgCm;
}
