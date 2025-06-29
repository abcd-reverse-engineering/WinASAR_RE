using System;

// Token: 0x02000514 RID: 1300
internal sealed class Delegate772 : MulticastDelegate
{
	// Token: 0x060023E4 RID: 9188
	public extern bool Invoke(Type type_0, object object_0);

	// Token: 0x060023E5 RID: 9189 RVA: 0x0000CE1E File Offset: 0x0000B01E
	public static bool smethod_0(Type type_0, object object_0, Delegate772 delegate772_1)
	{
		return delegate772_1(type_0, object_0);
	}

	// Token: 0x060023E6 RID: 9190
	public extern Delegate772(object object_0, IntPtr intptr_0);

	// Token: 0x060023E7 RID: 9191 RVA: 0x0000CE2B File Offset: 0x0000B02B
	static Delegate772()
	{
		Class15.smethod_14(typeof(Delegate772).TypeHandle);
	}

	// Token: 0x04000CE4 RID: 3300
	internal static Delegate772 delegate772_0;
}
