using System;

// Token: 0x020003CB RID: 971
internal sealed class Delegate443 : MulticastDelegate
{
	// Token: 0x06001EC0 RID: 7872
	public extern Type Invoke(Type type_0);

	// Token: 0x06001EC1 RID: 7873 RVA: 0x0000AD61 File Offset: 0x00008F61
	public static Type smethod_0(Type type_0, Delegate443 delegate443_1)
	{
		return delegate443_1(type_0);
	}

	// Token: 0x06001EC2 RID: 7874
	public extern Delegate443(object object_0, IntPtr intptr_0);

	// Token: 0x06001EC3 RID: 7875 RVA: 0x0000AD6C File Offset: 0x00008F6C
	static Delegate443()
	{
		Class15.smethod_14(typeof(Delegate443).TypeHandle);
	}

	// Token: 0x04000B9B RID: 2971
	internal static Delegate443 delegate443_0;
}
