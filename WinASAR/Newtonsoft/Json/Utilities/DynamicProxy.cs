using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000093 RID: 147
	[NullableContext(1)]
	[Nullable(0)]
	internal class DynamicProxy<[Nullable(2)] T>
	{
		// Token: 0x0600065A RID: 1626 RVA: 0x00003C41 File Offset: 0x00001E41
		public virtual IEnumerable<string> GetDynamicMemberNames(T instance)
		{
			return CollectionUtils.ArrayEmpty<string>();
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x00003C48 File Offset: 0x00001E48
		public virtual bool TryBinaryOperation(T instance, BinaryOperationBinder binder, object arg, [Nullable(2)] out object result)
		{
			result = null;
			return false;
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x00003C4F File Offset: 0x00001E4F
		public virtual bool TryConvert(T instance, ConvertBinder binder, [Nullable(2)] out object result)
		{
			result = null;
			return false;
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00003C48 File Offset: 0x00001E48
		public virtual bool TryCreateInstance(T instance, CreateInstanceBinder binder, object[] args, [Nullable(2)] out object result)
		{
			result = null;
			return false;
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x00003453 File Offset: 0x00001653
		public virtual bool TryDeleteIndex(T instance, DeleteIndexBinder binder, object[] indexes)
		{
			return false;
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x00003453 File Offset: 0x00001653
		public virtual bool TryDeleteMember(T instance, DeleteMemberBinder binder)
		{
			return false;
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x00003C48 File Offset: 0x00001E48
		public virtual bool TryGetIndex(T instance, GetIndexBinder binder, object[] indexes, [Nullable(2)] out object result)
		{
			result = null;
			return false;
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x00003C4F File Offset: 0x00001E4F
		public virtual bool TryGetMember(T instance, GetMemberBinder binder, [Nullable(2)] out object result)
		{
			result = null;
			return false;
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x00003C48 File Offset: 0x00001E48
		public virtual bool TryInvoke(T instance, InvokeBinder binder, object[] args, [Nullable(2)] out object result)
		{
			result = null;
			return false;
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x00003C48 File Offset: 0x00001E48
		public virtual bool TryInvokeMember(T instance, InvokeMemberBinder binder, object[] args, [Nullable(2)] out object result)
		{
			result = null;
			return false;
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x00003453 File Offset: 0x00001653
		public virtual bool TrySetIndex(T instance, SetIndexBinder binder, object[] indexes, object value)
		{
			return false;
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x00003453 File Offset: 0x00001653
		public virtual bool TrySetMember(T instance, SetMemberBinder binder, object value)
		{
			return false;
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x00003C4F File Offset: 0x00001E4F
		public virtual bool TryUnaryOperation(T instance, UnaryOperationBinder binder, [Nullable(2)] out object result)
		{
			result = null;
			return false;
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x00046BFC File Offset: 0x00044DFC
		public DynamicProxy()
		{
			int num = 0;
			if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 != 0)
			{
				switch (num)
				{
				}
			}
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x00003C55 File Offset: 0x00001E55
		internal static bool smethod_0()
		{
			return DynamicProxy<T>.object_0 == null;
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x00003C5F File Offset: 0x00001E5F
		internal static object smethod_1()
		{
			return DynamicProxy<T>.object_0;
		}

		// Token: 0x040003D2 RID: 978
		private static object object_0;
	}
}
