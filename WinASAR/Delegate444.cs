using System;

// Token: 0x020003CC RID: 972
internal sealed class Delegate444 : MulticastDelegate
{
	// Token: 0x06001EC4 RID: 7876
	public extern Type Invoke(Type type_0);

	// Token: 0x06001EC5 RID: 7877 RVA: 0x0000AD79 File Offset: 0x00008F79
	public static Type smethod_0(Type type_0, Delegate444 delegate444_1)
	{
		return delegate444_1(type_0);
	}

	// Token: 0x06001EC6 RID: 7878
	public extern Delegate444(object object_0, IntPtr intptr_0);

	// Token: 0x06001EC7 RID: 7879 RVA: 0x0000AD84 File Offset: 0x00008F84
	static Delegate444()
	{
		Class15.smethod_14(typeof(Delegate444).TypeHandle);
	}

	// Token: 0x04000B9C RID: 2972
	internal static Delegate444 delegate444_0;
}
