using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000082 RID: 130
	[Nullable(0)]
	[NullableContext(1)]
	internal static class CollectionUtils
	{
		// Token: 0x060005A0 RID: 1440 RVA: 0x000037EA File Offset: 0x000019EA
		public static bool IsNullOrEmpty<[Nullable(2)] T>(ICollection<T> collection)
		{
			return collection == null || collection.Count == 0;
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x0003F380 File Offset: 0x0003D580
		public static void AddRange<[Nullable(2)] T>(this IList<T> initial, IEnumerable<T> collection)
		{
			if (initial == null)
			{
				throw new ArgumentNullException(Class15.smethod_17(594347404 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b));
			}
			if (collection == null)
			{
				return;
			}
			foreach (T t in collection)
			{
				initial.Add(t);
			}
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x0003F3EC File Offset: 0x0003D5EC
		public static bool IsDictionaryType(Type type)
		{
			for (;;)
			{
				ValidationUtils.ArgumentNotNull(type, Class15.smethod_17(1802354827 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4));
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f == 0)
				{
					goto IL_0003;
				}
				IL_0026:
				switch (num)
				{
				case 1:
					goto IL_0072;
				case 2:
					IL_0003:
					if (!typeof(IDictionary).IsAssignableFrom(type))
					{
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a == 0)
						{
							goto IL_0026;
						}
						goto IL_0071;
					}
					break;
				case 3:
					continue;
				case 4:
					return true;
				}
				break;
			}
			return true;
			IL_0071:
			IL_0072:
			if (!ReflectionUtils.ImplementsGenericDefinition(type, typeof(IDictionary<, >)))
			{
				return false;
			}
			return true;
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x0003F484 File Offset: 0x0003D684
		[return: Nullable(2)]
		public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType)
		{
			Type type;
			for (;;)
			{
				type = typeof(IList<>).MakeGenericType(new Type[] { collectionItemType });
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 == 0)
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
			return CollectionUtils.ResolveEnumerableCollectionConstructor(collectionType, collectionItemType, type);
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x0003F4D8 File Offset: 0x0003D6D8
		[return: Nullable(2)]
		public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType, Type constructorArgumentType)
		{
			ConstructorInfo constructorInfo;
			ConstructorInfo constructorInfo2;
			for (;;)
			{
				IL_0151:
				Type type = typeof(IEnumerable<>).MakeGenericType(new Type[] { collectionItemType });
				for (;;)
				{
					IL_0136:
					constructorInfo = null;
					int num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93ade03426d44b1841bfa7c633f49f3 == 0)
					{
						goto IL_0038;
					}
					IList<ParameterInfo> parameters;
					for (;;)
					{
						IL_00D7:
						switch (num)
						{
						case 1:
							goto IL_0084;
						case 2:
							goto IL_00C6;
						case 3:
							goto IL_0136;
						case 4:
							goto IL_0151;
						case 5:
							goto IL_016E;
						case 6:
							goto IL_00B7;
						case 7:
							for (;;)
							{
								parameters = constructorInfo2.GetParameters();
								num = 12;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 != 0)
								{
									goto IL_00D7;
								}
							}
							break;
						case 8:
							goto IL_0091;
						case 9:
							goto IL_007A;
						case 10:
						case 18:
							goto IL_000C;
						case 11:
						case 13:
						case 20:
							goto IL_0006;
						case 12:
							if (parameters.Count != 1)
							{
								goto IL_0006;
							}
							num = 6;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c == 0)
							{
								continue;
							}
							break;
						case 14:
						case 16:
							goto IL_0017;
						case 15:
							goto IL_0038;
						case 17:
						case 19:
							return constructorInfo;
						}
						goto Block_6;
					}
					IL_0006:
					int num2;
					num2++;
					goto IL_000C;
					Block_6:
					goto IL_0057;
					IL_007A:
					if (constructorInfo == null)
					{
						goto IL_0084;
					}
					goto IL_0006;
					IL_00C6:
					Type parameterType;
					if (type == parameterType)
					{
						goto Block_5;
					}
					goto IL_007A;
					IL_00B7:
					parameterType = parameters[0].ParameterType;
					goto IL_00C6;
					IL_0084:
					if (!parameterType.IsAssignableFrom(constructorArgumentType))
					{
						goto IL_0006;
					}
					IL_0091:
					constructorInfo = constructorInfo2;
					goto IL_0006;
					IL_0017:
					ConstructorInfo[] constructors;
					constructorInfo2 = constructors[num2];
					num = 7;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba == 0)
					{
						break;
					}
					goto IL_00D7;
					IL_000C:
					if (num2 < constructors.Length)
					{
						goto IL_0017;
					}
					return constructorInfo;
					IL_0038:
					constructors = collectionType.GetConstructors(BindingFlags.Instance | BindingFlags.Public);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 != 0)
					{
						goto IL_00D7;
					}
					IL_0057:
					num2 = 0;
					goto IL_000C;
				}
			}
			Block_5:
			IL_016E:
			constructorInfo = constructorInfo2;
			return constructorInfo;
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x000037FA File Offset: 0x000019FA
		public static bool AddDistinct<[Nullable(2)] T>(this IList<T> list, T value)
		{
			return list.AddDistinct(value, EqualityComparer<T>.Default);
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00003808 File Offset: 0x00001A08
		public static bool AddDistinct<[Nullable(2)] T>(this IList<T> list, T value, IEqualityComparer<T> comparer)
		{
			if (list.ContainsValue(value, comparer))
			{
				return false;
			}
			list.Add(value);
			return true;
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x0003F65C File Offset: 0x0003D85C
		public static bool ContainsValue<[Nullable(2)] TSource>(this IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer)
		{
			if (comparer == null)
			{
				comparer = EqualityComparer<TSource>.Default;
			}
			if (source == null)
			{
				throw new ArgumentNullException(Class15.smethod_17(613102645 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6));
			}
			using (IEnumerator<TSource> enumerator = source.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					TSource tsource = enumerator.Current;
					if (comparer.Equals(tsource, value))
					{
						return true;
					}
				}
				return false;
			}
			bool flag;
			return flag;
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x0003F6D8 File Offset: 0x0003D8D8
		public static bool AddRangeDistinct<[Nullable(2)] T>(this IList<T> list, IEnumerable<T> values, IEqualityComparer<T> comparer)
		{
			bool flag = true;
			foreach (T t in values)
			{
				if (!list.AddDistinct(t, comparer))
				{
					flag = false;
				}
			}
			return flag;
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x0003F72C File Offset: 0x0003D92C
		public static int IndexOf<[Nullable(2)] T>(this IEnumerable<T> collection, Func<T, bool> predicate)
		{
			int num = 0;
			using (IEnumerator<T> enumerator = collection.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					T t = enumerator.Current;
					if (predicate(t))
					{
						return num;
					}
					num++;
				}
				return -1;
			}
			int num2;
			return num2;
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x0003F784 File Offset: 0x0003D984
		public static bool Contains<[Nullable(2)] T>(this List<T> list, T value, IEqualityComparer comparer)
		{
			for (int i = 0; i < list.Count; i++)
			{
				if (comparer.Equals(value, list[i]))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x0003F7C0 File Offset: 0x0003D9C0
		public static int IndexOfReference<[Nullable(2)] T>(this List<T> list, T item)
		{
			for (int i = 0; i < list.Count; i++)
			{
				if (item == list[i])
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x0003F7F8 File Offset: 0x0003D9F8
		public static void FastReverse<[Nullable(2)] T>(this List<T> list)
		{
			int i = 0;
			int num = list.Count - 1;
			while (i < num)
			{
				T t = list[i];
				list[i] = list[num];
				list[num] = t;
				i++;
				num--;
			}
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x0003F83C File Offset: 0x0003DA3C
		private static IList<int> smethod_0(IList ilist_0, int int_0)
		{
			IList<int> list = new List<int>();
			IList list2 = ilist_0;
			for (;;)
			{
				list.Add(list2.Count);
				if (list.Count == int_0 || list2.Count == 0)
				{
					break;
				}
				IList list3 = list2[0] as IList;
				if (list3 == null)
				{
					break;
				}
				list2 = list3;
			}
			return list;
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x0003F888 File Offset: 0x0003DA88
		private static void smethod_1(IList ilist_0, Array array_0, int[] int_0)
		{
			for (;;)
			{
				IL_013B:
				int num = int_0.Length;
				IL_012B:
				while (num != array_0.Rank)
				{
					int length = array_0.GetLength(num);
					for (;;)
					{
						IL_0110:
						int num2;
						int[] array;
						if (((IList)CollectionUtils.smethod_2(ilist_0, int_0)).Count != length)
						{
							num2 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_48fe014748e848c88d3254f339047927 == 0)
							{
								goto Block_4;
							}
						}
						else
						{
							array = new int[num + 1];
							num2 = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 != 0)
							{
								goto Block_1;
							}
						}
						for (;;)
						{
							int num3;
							switch (num2)
							{
							case 1:
								num3 = 0;
								num2 = 11;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c != 0)
								{
									continue;
								}
								break;
							case 2:
							case 11:
								goto IL_006D;
							case 3:
								goto IL_0165;
							case 4:
								goto IL_012B;
							case 5:
								goto IL_013B;
							case 6:
							case 17:
								goto IL_003A;
							case 7:
								goto IL_0067;
							case 8:
							case 15:
								goto IL_0073;
							case 9:
								CollectionUtils.smethod_1(ilist_0, array_0, array);
								goto IL_007E;
							case 10:
								goto IL_0049;
							case 12:
								return;
							case 13:
								goto IL_007E;
							case 14:
								return;
							case 16:
								goto IL_0110;
							case 18:
								goto IL_0037;
							}
							goto Block_3;
							IL_0049:
							int num4;
							array[num] = num4;
							num2 = 9;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 != 0)
							{
								goto Block_2;
							}
							continue;
							IL_003A:
							if (num4 < array_0.GetLength(num))
							{
								goto IL_0049;
							}
							return;
							IL_0037:
							num4 = 0;
							goto IL_003A;
							IL_006D:
							if (num3 < num)
							{
								goto IL_0073;
							}
							goto IL_0037;
							IL_0067:
							num3++;
							goto IL_006D;
							IL_0073:
							array[num3] = int_0[num3];
							goto IL_0067;
							IL_007E:
							num4++;
							goto IL_003A;
						}
					}
				}
				goto Block_6;
			}
			Block_1:
			goto IL_0149;
			Block_2:
			goto IL_0165;
			Block_3:
			Block_4:
			goto IL_0149;
			Block_6:
			goto IL_0165;
			IL_0149:
			throw new Exception(Class15.smethod_17(1985296944 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba));
			IL_0165:
			array_0.SetValue(CollectionUtils.smethod_2(ilist_0, int_0), int_0);
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x0003FA0C File Offset: 0x0003DC0C
		private static object smethod_2(IList ilist_0, object object_0)
		{
			IList list;
			int num3;
			for (;;)
			{
				list = ilist_0;
				int num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b == 0)
				{
					goto IL_0061;
				}
				IL_0066:
				int num2;
				switch (num)
				{
				case 0:
					goto IL_0010;
				case 1:
					goto IL_0047;
				case 2:
					return list;
				case 3:
					break;
				case 4:
				case 8:
					goto IL_0006;
				case 5:
					IL_0061:
					num2 = 0;
					goto IL_0006;
				case 6:
					continue;
				case 7:
					goto IL_00AC;
				default:
					goto IL_0010;
				}
				IL_0016:
				if (num2 == object_0.Length - 1)
				{
					break;
				}
				list = (IList)list[num3];
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_548c52e5632b45898e377ad9c9a06469 != 0)
				{
					goto IL_0047;
				}
				goto IL_0066;
				IL_0010:
				num3 = object_0[num2];
				goto IL_0016;
				IL_0006:
				if (num2 < object_0.Length)
				{
					goto IL_0010;
				}
				return list;
				IL_0047:
				num2++;
				num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 != 0)
				{
					goto Block_2;
				}
				goto IL_0066;
			}
			goto IL_00AC;
			Block_2:
			return list;
			IL_00AC:
			return list[num3];
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x0003FAD4 File Offset: 0x0003DCD4
		public static Array ToMultidimensionalArray(IList values, Type type, int rank)
		{
			Array array;
			for (;;)
			{
				IL_008E:
				IList<int> list = CollectionUtils.smethod_0(values, rank);
				for (;;)
				{
					if (list.Count >= rank)
					{
						goto IL_0047;
					}
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e == 0)
					{
						goto IL_0006;
					}
					IL_001F:
					switch (num)
					{
					case 1:
					case 6:
						IL_0006:
						list.Add(0);
						num = 4;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 == 0)
						{
							goto IL_001F;
						}
						continue;
					case 2:
						return array;
					case 3:
						IL_0047:
						array = Array.CreateInstance(type, list.ToArray<int>());
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f != 0)
						{
							goto IL_001F;
						}
						break;
					case 4:
					case 7:
						continue;
					case 5:
						goto IL_008E;
					}
					goto Block_1;
				}
			}
			Block_1:
			CollectionUtils.smethod_1(values, array, CollectionUtils.ArrayEmpty<int>());
			return array;
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x0000381E File Offset: 0x00001A1E
		public static T[] ArrayEmpty<[Nullable(2)] T>()
		{
			return CollectionUtils.Class2<T>.gparam_0;
		}

		// Token: 0x02000083 RID: 131
		[NullableContext(0)]
		private static class Class2<[Nullable(2)] T>
		{
			// Token: 0x060005B5 RID: 1461 RVA: 0x0003FB8C File Offset: 0x0003DD8C
			static Class2()
			{
				for (;;)
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 == 0)
					{
						goto IL_0022;
					}
					IL_0025:
					switch (num)
					{
					case 1:
						continue;
					case 2:
						return;
					}
					IL_0003:
					CollectionUtils.Class2<T>.gparam_0 = new T[0];
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 == 0)
					{
						break;
					}
					goto IL_0025;
					IL_0022:
					goto IL_0003;
				}
			}

			// Token: 0x060005B6 RID: 1462 RVA: 0x00003825 File Offset: 0x00001A25
			internal static bool smethod_0()
			{
				return CollectionUtils.Class2<T>.object_0 == null;
			}

			// Token: 0x060005B7 RID: 1463 RVA: 0x0000382F File Offset: 0x00001A2F
			internal static object smethod_1()
			{
				return CollectionUtils.Class2<T>.object_0;
			}

			// Token: 0x04000362 RID: 866
			[Nullable(1)]
			public static readonly T[] gparam_0;

			// Token: 0x04000363 RID: 867
			internal static object object_0;
		}
	}
}
