using System;
using System.Xml;

// Token: 0x02000580 RID: 1408
internal sealed class Delegate880 : MulticastDelegate
{
	// Token: 0x06002594 RID: 9620
	public extern XmlNodeList Invoke(object object_0);

	// Token: 0x06002595 RID: 9621 RVA: 0x0000D8E4 File Offset: 0x0000BAE4
	public static XmlNodeList smethod_0(object object_0, Delegate880 delegate880_1)
	{
		return delegate880_1(object_0);
	}

	// Token: 0x06002596 RID: 9622
	public extern Delegate880(object object_0, IntPtr intptr_0);

	// Token: 0x06002597 RID: 9623 RVA: 0x0000D8EF File Offset: 0x0000BAEF
	static Delegate880()
	{
		Class15.smethod_14(typeof(Delegate880).TypeHandle);
	}

	// Token: 0x04000D50 RID: 3408
	internal static Delegate880 delegate880_0;
}
