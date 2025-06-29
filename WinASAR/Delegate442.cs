using System;

// Token: 0x020003CA RID: 970
internal sealed class Delegate442 : MulticastDelegate
{
	// Token: 0x06001EBC RID: 7868
	public extern object Invoke(ref object object_0, object object_1, object object_2);

	// Token: 0x06001EBD RID: 7869 RVA: 0x0000AD45 File Offset: 0x00008F45
	public static object smethod_0(ref object object_0, object object_1, object object_2, Delegate442 delegate442_1)
	{
		return delegate442_1(ref object_0, object_1, object_2);
	}

	// Token: 0x06001EBE RID: 7870
	public extern Delegate442(object object_0, IntPtr intptr_0);

	// Token: 0x06001EBF RID: 7871 RVA: 0x0000AD54 File Offset: 0x00008F54
	static Delegate442()
	{
		Class15.smethod_14(typeof(Delegate442).TypeHandle);
	}

	// Token: 0x04000B9A RID: 2970
	internal static Delegate442 delegate442_0;
}
