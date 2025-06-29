using System;

// Token: 0x020003D6 RID: 982
internal sealed class Delegate454 : MulticastDelegate
{
	// Token: 0x06001EEC RID: 7916
	public extern object Invoke(Type type_0, object object_0);

	// Token: 0x06001EED RID: 7917 RVA: 0x0000AE79 File Offset: 0x00009079
	public static object smethod_0(Type type_0, object object_0, Delegate454 delegate454_1)
	{
		return delegate454_1(type_0, object_0);
	}

	// Token: 0x06001EEE RID: 7918
	public extern Delegate454(object object_0, IntPtr intptr_0);

	// Token: 0x06001EEF RID: 7919 RVA: 0x0000AE86 File Offset: 0x00009086
	static Delegate454()
	{
		Class15.smethod_14(typeof(Delegate454).TypeHandle);
	}

	// Token: 0x04000BA6 RID: 2982
	internal static Delegate454 delegate454_0;
}
