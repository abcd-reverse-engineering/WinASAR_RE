using System;

// Token: 0x020003B2 RID: 946
internal sealed class Delegate418 : MulticastDelegate
{
	// Token: 0x06001E5C RID: 7772
	public extern Type Invoke(object object_0, Type[] type_0);

	// Token: 0x06001E5D RID: 7773 RVA: 0x0000AADB File Offset: 0x00008CDB
	public static Type smethod_0(object object_0, Type[] type_0, Delegate418 delegate418_1)
	{
		return delegate418_1(object_0, type_0);
	}

	// Token: 0x06001E5E RID: 7774
	public extern Delegate418(object object_0, IntPtr intptr_0);

	// Token: 0x06001E5F RID: 7775 RVA: 0x0000AAE8 File Offset: 0x00008CE8
	static Delegate418()
	{
		Class15.smethod_14(typeof(Delegate418).TypeHandle);
	}

	// Token: 0x04000B82 RID: 2946
	internal static Delegate418 delegate418_0;
}
