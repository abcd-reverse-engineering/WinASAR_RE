using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000085 RID: 133
	[Nullable(0)]
	[NullableContext(1)]
	internal class CollectionWrapper<[Nullable(2)] T> : ICollection<T>, IEnumerable<T>, IEnumerable, Interface0, IList, ICollection
	{
		// Token: 0x060005B9 RID: 1465 RVA: 0x0003FBEC File Offset: 0x0003DDEC
		public CollectionWrapper(IList list)
		{
			ICollection<T> collection;
			for (;;)
			{
				ValidationUtils.ArgumentNotNull(list, Class15.smethod_17(1270998322 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112));
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 == 0)
				{
					goto IL_0040;
				}
				IL_005C:
				switch (num)
				{
				case 0:
					goto IL_0040;
				case 1:
					break;
				case 2:
					goto IL_00B1;
				case 3:
					return;
				case 4:
					continue;
				case 5:
					return;
				default:
					goto IL_0040;
				}
				IL_000A:
				if (collection != null)
				{
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 == 0)
					{
						break;
					}
					goto IL_005C;
				}
				else
				{
					this.ilist_0 = list;
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 != 0)
					{
						goto Block_3;
					}
					goto IL_005C;
				}
				IL_0040:
				collection = list as ICollection<T>;
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 == 0)
				{
					goto IL_000A;
				}
				goto IL_005C;
			}
			goto IL_00B1;
			Block_3:
			return;
			IL_00B1:
			this.icollection_0 = collection;
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00003836 File Offset: 0x00001A36
		public CollectionWrapper(ICollection<T> list)
		{
			ValidationUtils.ArgumentNotNull(list, Class15.smethod_17(124822878 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719));
			this.icollection_0 = list;
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00003862 File Offset: 0x00001A62
		public virtual void Add(T item)
		{
			if (this.icollection_0 != null)
			{
				this.icollection_0.Add(item);
				return;
			}
			this.ilist_0.Add(item);
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x0003FCB8 File Offset: 0x0003DEB8
		public virtual void Clear()
		{
			for (;;)
			{
				int num;
				if (this.icollection_0 != null)
				{
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 == 0)
					{
						goto IL_0020;
					}
				}
				else
				{
					this.ilist_0.Clear();
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a != 0)
					{
						goto IL_0020;
					}
				}
				IL_003C:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					return;
				case 3:
					return;
				}
				IL_0020:
				this.icollection_0.Clear();
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 == 0)
				{
					goto IL_003C;
				}
				break;
			}
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x0000388B File Offset: 0x00001A8B
		public virtual bool Contains(T item)
		{
			if (this.icollection_0 != null)
			{
				return this.icollection_0.Contains(item);
			}
			return this.ilist_0.Contains(item);
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x0003FD3C File Offset: 0x0003DF3C
		public virtual void CopyTo(T[] array, int arrayIndex)
		{
			for (;;)
			{
				int num;
				if (this.icollection_0 != null)
				{
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 != 0)
					{
						goto IL_0045;
					}
				}
				else
				{
					this.ilist_0.CopyTo(array, arrayIndex);
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 == 0)
					{
						continue;
					}
					goto IL_0045;
				}
				do
				{
					IL_0024:
					this.icollection_0.CopyTo(array, arrayIndex);
					num = 2;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 == 0);
				IL_0045:
				switch (num)
				{
				case 0:
					goto IL_0024;
				case 1:
					break;
				case 2:
					return;
				case 3:
					return;
				default:
					goto IL_0024;
				}
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060005BF RID: 1471 RVA: 0x0003FDC8 File Offset: 0x0003DFC8
		public virtual int Count
		{
			get
			{
				while (this.icollection_0 != null)
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d == 0)
					{
						switch (num)
						{
						case 1:
							continue;
						}
					}
					return this.icollection_0.Count;
				}
				return this.ilist_0.Count;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060005C0 RID: 1472 RVA: 0x0003FE1C File Offset: 0x0003E01C
		public virtual bool IsReadOnly
		{
			get
			{
				while (this.icollection_0 == null)
				{
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d == 0)
					{
						switch (num)
						{
						case 0:
							goto IL_0040;
						case 1:
							break;
						case 2:
							continue;
						default:
							goto IL_0040;
						}
					}
					return this.ilist_0.IsReadOnly;
				}
				IL_0040:
				return this.icollection_0.IsReadOnly;
			}
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x000038B3 File Offset: 0x00001AB3
		public virtual bool Remove(T item)
		{
			if (this.icollection_0 != null)
			{
				return this.icollection_0.Remove(item);
			}
			bool flag = this.ilist_0.Contains(item);
			if (flag)
			{
				this.ilist_0.Remove(item);
			}
			return flag;
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x0003FE74 File Offset: 0x0003E074
		public virtual IEnumerator<T> GetEnumerator()
		{
			IEnumerable<T> enumerable = this.icollection_0;
			return (enumerable ?? this.ilist_0.Cast<T>()).GetEnumerator();
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x0003FEA0 File Offset: 0x0003E0A0
		IEnumerator IEnumerable.GetEnumerator()
		{
			IEnumerable enumerable2;
			for (;;)
			{
				IEnumerable enumerable = this.icollection_0;
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 != 0)
				{
					goto IL_001D;
				}
				IL_0003:
				while ((enumerable2 = enumerable) == null)
				{
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 == 0)
					{
						goto IL_001D;
					}
				}
				goto IL_0053;
				IL_001D:
				switch (num)
				{
				case 0:
					goto IL_0003;
				case 1:
					break;
				case 2:
					goto IL_004D;
				default:
					goto IL_0003;
				}
			}
			IL_004D:
			enumerable2 = this.ilist_0;
			IL_0053:
			return enumerable2.GetEnumerator();
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x0003FF08 File Offset: 0x0003E108
		[NullableContext(2)]
		int IList.Add(object value)
		{
			for (;;)
			{
				CollectionWrapper<T>.smethod_0(value);
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 == 0)
				{
					goto IL_0003;
				}
				IL_0020:
				switch (num)
				{
				case 1:
					IL_0003:
					this.Add((T)((object)value));
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba != 0)
					{
						goto IL_0020;
					}
					break;
				case 2:
					continue;
				}
				break;
			}
			return this.Count - 1;
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x0003FF6C File Offset: 0x0003E16C
		[NullableContext(2)]
		bool IList.Contains(object value)
		{
			while (!CollectionWrapper<T>.smethod_1(value))
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_207f975845fc40cdbe6b166fce664cd5 != 0)
				{
					switch (num)
					{
					case 0:
						goto IL_0036;
					case 1:
						break;
					case 2:
						continue;
					default:
						goto IL_0036;
					}
				}
				return false;
			}
			IL_0036:
			return this.Contains((T)((object)value));
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x0003FFBC File Offset: 0x0003E1BC
		[NullableContext(2)]
		int IList.IndexOf(object value)
		{
			IL_0037:
			while (this.icollection_0 == null)
			{
				while (CollectionWrapper<T>.smethod_1(value))
				{
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 != 0)
					{
						switch (num)
						{
						case 0:
							goto IL_005A;
						case 1:
							break;
						case 2:
							continue;
						case 3:
							goto IL_0037;
						default:
							goto IL_005A;
						}
					}
					return this.ilist_0.IndexOf((T)((object)value));
				}
				return -1;
			}
			IL_005A:
			throw new InvalidOperationException(Class15.smethod_17(649976910 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff));
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00040040 File Offset: 0x0003E240
		void IList.RemoveAt(int index)
		{
			for (;;)
			{
				int num;
				if (this.icollection_0 != null)
				{
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 != 0)
					{
						break;
					}
				}
				else
				{
					this.ilist_0.RemoveAt(index);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 != 0)
					{
						break;
					}
				}
				switch (num)
				{
				case 1:
					goto IL_0056;
				case 2:
					continue;
				}
				break;
			}
			return;
			IL_0056:
			throw new InvalidOperationException(Class15.smethod_17(82286740 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909));
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x000400C0 File Offset: 0x0003E2C0
		[NullableContext(2)]
		void IList.Insert(int index, object value)
		{
			while (this.icollection_0 == null)
			{
				CollectionWrapper<T>.smethod_0(value);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 == 0)
				{
					goto IL_001B;
				}
				IL_0043:
				switch (num)
				{
				case 1:
					return;
				case 2:
					IL_0069:
					throw new InvalidOperationException(Class15.smethod_17(277623296 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98));
				case 3:
					continue;
				}
				IL_001B:
				this.ilist_0.Insert(index, (T)((object)value));
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 == 0)
				{
					goto IL_0043;
				}
				return;
			}
			goto IL_0069;
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060005C9 RID: 1481 RVA: 0x00040154 File Offset: 0x0003E354
		bool IList.IsFixedSize
		{
			get
			{
				while (this.icollection_0 != null)
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 != 0)
					{
						switch (num)
						{
						case 1:
							continue;
						}
					}
					return this.icollection_0.IsReadOnly;
				}
				return this.ilist_0.IsFixedSize;
			}
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x000401A8 File Offset: 0x0003E3A8
		[NullableContext(2)]
		void IList.Remove(object value)
		{
			while (!CollectionWrapper<T>.smethod_1(value))
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 == 0)
				{
					switch (num)
					{
					case 1:
						continue;
					case 2:
						goto IL_003A;
					}
				}
				return;
			}
			IL_003A:
			this.Remove((T)((object)value));
		}

		// Token: 0x170000E3 RID: 227
		[Nullable(2)]
		object IList.this[int index]
		{
			[NullableContext(2)]
			get
			{
				while (this.icollection_0 != null)
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 == 0)
					{
						switch (num)
						{
						case 1:
							continue;
						}
					}
					throw new InvalidOperationException(Class15.smethod_17(1829625233 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae));
				}
				return this.ilist_0[index];
			}
			[NullableContext(2)]
			set
			{
				while (this.icollection_0 == null)
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 != 0)
					{
						goto IL_0042;
					}
					IL_004A:
					switch (num)
					{
					case 0:
						goto IL_0074;
					case 1:
						IL_0042:
						CollectionWrapper<T>.smethod_0(value);
						break;
					case 2:
						continue;
					case 3:
						break;
					case 4:
						return;
					default:
						goto IL_0074;
					}
					this.ilist_0[index] = (T)((object)value);
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 == 0)
					{
						goto IL_004A;
					}
					return;
				}
				IL_0074:
				throw new InvalidOperationException(Class15.smethod_17(698990294 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a));
			}
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x000402FC File Offset: 0x0003E4FC
		void ICollection.CopyTo(Array array, int arrayIndex)
		{
			for (;;)
			{
				this.CopyTo((T[])array, arrayIndex);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 != 0)
				{
					switch (num)
					{
					case 1:
						continue;
					}
					break;
				}
				break;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060005CE RID: 1486 RVA: 0x00003453 File Offset: 0x00001653
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060005CF RID: 1487 RVA: 0x0004033C File Offset: 0x0003E53C
		object ICollection.SyncRoot
		{
			get
			{
				while (this.object_0 == null)
				{
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 != 0)
					{
						goto IL_0015;
					}
					IL_0038:
					switch (num)
					{
					case 0:
						goto IL_0058;
					case 1:
						IL_0015:
						Interlocked.CompareExchange(ref this.object_0, new object(), null);
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b == 0)
						{
							goto IL_0038;
						}
						goto IL_0058;
					case 2:
						break;
					default:
						goto IL_0058;
					}
				}
				IL_0058:
				return this.object_0;
			}
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x000403A8 File Offset: 0x0003E5A8
		[NullableContext(2)]
		private static void smethod_0(object object_2)
		{
			while (CollectionWrapper<T>.smethod_1(object_2))
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 != 0)
				{
					switch (num)
					{
					case 1:
						continue;
					case 2:
						goto IL_0036;
					}
				}
				return;
			}
			IL_0036:
			throw new ArgumentException(Class15.smethod_17(1396540950 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7).FormatWith(CultureInfo.InvariantCulture, object_2, typeof(T)), Class15.smethod_17(552182932 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f));
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x00040430 File Offset: 0x0003E630
		[NullableContext(2)]
		private static bool smethod_1(object object_2)
		{
			for (;;)
			{
				if (!(object_2 is T))
				{
					goto IL_0034;
				}
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 == 0)
				{
					goto Block_3;
				}
				IL_0014:
				switch (num)
				{
				case 1:
					return true;
				case 2:
					continue;
				case 3:
					goto IL_006E;
				case 4:
					return false;
				case 5:
					IL_0034:
					if (object_2 != null)
					{
						return false;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 == 0)
					{
						goto IL_0014;
					}
					break;
				}
				break;
			}
			goto IL_005D;
			Block_3:
			return true;
			IL_005D:
			if (!typeof(T).IsValueType())
			{
				return true;
			}
			IL_006E:
			if (!ReflectionUtils.IsNullableType(typeof(T)))
			{
				return false;
			}
			return true;
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060005D2 RID: 1490 RVA: 0x000404C0 File Offset: 0x0003E6C0
		public object UnderlyingCollection
		{
			get
			{
				ICollection<T> collection;
				while ((collection = this.icollection_0) == null)
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d != 0)
					{
						switch (num)
						{
						case 1:
							continue;
						}
					}
					collection = this.ilist_0;
					break;
				}
				return collection;
			}
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x000038EF File Offset: 0x00001AEF
		internal static bool smethod_2()
		{
			return CollectionWrapper<T>.object_1 == null;
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x000038F9 File Offset: 0x00001AF9
		internal static object smethod_3()
		{
			return CollectionWrapper<T>.object_1;
		}

		// Token: 0x04000364 RID: 868
		[Nullable(2)]
		private readonly IList ilist_0;

		// Token: 0x04000365 RID: 869
		[Nullable(new byte[] { 2, 1 })]
		private readonly ICollection<T> icollection_0;

		// Token: 0x04000366 RID: 870
		[Nullable(2)]
		private object object_0;

		// Token: 0x04000367 RID: 871
		internal static object object_1;
	}
}
