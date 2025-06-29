using System;
using System.Reflection;

// Token: 0x020004AC RID: 1196
internal sealed class Delegate668 : MulticastDelegate
{
	// Token: 0x06002244 RID: 8772
	public extern Attribute[] Invoke(Assembly assembly_0, Type type_0);

	// Token: 0x06002245 RID: 8773 RVA: 0x0000C3EF File Offset: 0x0000A5EF
	public static Attribute[] smethod_0(Assembly assembly_0, Type type_0, Delegate668 delegate668_1)
	{
		return delegate668_1(assembly_0, type_0);
	}

	// Token: 0x06002246 RID: 8774
	public extern Delegate668(object object_0, IntPtr intptr_0);

	// Token: 0x06002247 RID: 8775 RVA: 0x0000C3FC File Offset: 0x0000A5FC
	static Delegate668()
	{
		Class15.smethod_14(typeof(Delegate668).TypeHandle);
	}

	// Token: 0x04000C7C RID: 3196
	internal static Delegate668 delegate668_0;
}
