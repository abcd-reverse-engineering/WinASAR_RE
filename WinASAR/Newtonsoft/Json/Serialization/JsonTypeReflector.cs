using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200011C RID: 284
	[NullableContext(1)]
	[Nullable(0)]
	internal static class JsonTypeReflector
	{
		// Token: 0x06000B84 RID: 2948 RVA: 0x000051A5 File Offset: 0x000033A5
		[return: Nullable(2)]
		public static T GetCachedAttribute<[Nullable(0)] T>(object attributeProvider) where T : Attribute
		{
			return CachedAttributeGetter<T>.GetAttribute(attributeProvider);
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x000680D0 File Offset: 0x000662D0
		public static bool CanTypeDescriptorConvertString(Type type, out TypeConverter typeConverter)
		{
			Type type2;
			for (;;)
			{
				IL_00FF:
				typeConverter = TypeDescriptor.GetConverter(type);
				IL_00F8:
				while (typeConverter != null)
				{
					for (;;)
					{
						IL_00ED:
						type2 = typeConverter.GetType();
						while (!string.Equals(type2.FullName, Class15.smethod_17(1829584183 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae), StringComparison.Ordinal))
						{
							int num = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 == 0)
							{
								goto IL_0058;
							}
							IL_0093:
							switch (num)
							{
							case 1:
								IL_0058:
								if (!string.Equals(type2.FullName, Class15.smethod_17(486503574 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c), StringComparison.Ordinal))
								{
									num = 4;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 == 0)
									{
										goto IL_001A;
									}
									goto IL_0093;
								}
								break;
							case 3:
								goto IL_011F;
							case 4:
								goto IL_00ED;
							case 5:
								goto IL_00F8;
							case 6:
								goto IL_00FF;
							case 7:
								goto IL_010C;
							case 8:
								continue;
							case 9:
								goto IL_001A;
							}
							break;
							IL_001A:
							if (!string.Equals(type2.FullName, Class15.smethod_17(698958280 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a), StringComparison.Ordinal))
							{
								goto IL_010C;
							}
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa == 0)
							{
								break;
							}
							goto IL_0093;
						}
						return false;
					}
				}
				break;
			}
			return false;
			IL_010C:
			if (!(type2 != typeof(TypeConverter)))
			{
				return false;
			}
			IL_011F:
			return typeConverter.CanConvertTo(typeof(string));
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x00068210 File Offset: 0x00066410
		[return: Nullable(2)]
		public static DataContractAttribute GetDataContractAttribute(Type type)
		{
			DataContractAttribute attribute;
			for (;;)
			{
				IL_008B:
				Type type2 = type;
				int num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 == 0)
				{
					goto Block_6;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						goto IL_00A3;
					case 2:
					case 7:
						if (type2 != null)
						{
							goto IL_0024;
						}
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 != 0)
						{
							goto Block_2;
						}
						continue;
					case 3:
						goto IL_008B;
					case 4:
						goto IL_0024;
					case 5:
						goto IL_0041;
					case 6:
						goto IL_005C;
					}
					goto Block_5;
					IL_0024:
					attribute = CachedAttributeGetter<DataContractAttribute>.GetAttribute(type2);
					num = 6;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98 == 0)
					{
						goto Block_3;
					}
					continue;
					IL_0041:
					type2 = type2.BaseType();
					num = 7;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 == 0)
					{
						continue;
					}
					IL_005C:
					if (attribute == null)
					{
						goto IL_0041;
					}
					return attribute;
				}
			}
			Block_2:
			goto IL_00A3;
			Block_3:
			Block_5:
			Block_6:
			return attribute;
			IL_00A3:
			return null;
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x000682C8 File Offset: 0x000664C8
		[return: Nullable(2)]
		public static DataMemberAttribute GetDataMemberAttribute(MemberInfo memberInfo)
		{
			IL_0151:
			while (memberInfo.MemberType() != MemberTypes.Field)
			{
				PropertyInfo propertyInfo = (PropertyInfo)memberInfo;
				DataMemberAttribute dataMemberAttribute;
				for (;;)
				{
					dataMemberAttribute = CachedAttributeGetter<DataMemberAttribute>.GetAttribute(propertyInfo);
					int num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 == 0)
					{
						goto IL_00C5;
					}
					IL_00DD:
					switch (num)
					{
					case 1:
						goto IL_0067;
					case 2:
						goto IL_001D;
					case 3:
						IL_00C5:
						if (dataMemberAttribute == null)
						{
							goto IL_00A5;
						}
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 != 0)
						{
							goto IL_00DD;
						}
						break;
					case 4:
						goto IL_002D;
					case 5:
						goto IL_004C;
					case 6:
					case 16:
						goto IL_0079;
					case 7:
						continue;
					case 8:
					case 15:
						goto IL_0070;
					case 11:
						goto IL_0013;
					case 12:
						goto IL_00A5;
					case 14:
						goto IL_009A;
					case 17:
						goto IL_016A;
					case 18:
						goto IL_0151;
					}
					break;
					IL_002D:
					PropertyInfo propertyInfo2;
					if (propertyInfo2 != null)
					{
						goto IL_004C;
					}
					num = 15;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e5c1d856e0c64e6f8377f7d819e11923 == 0)
					{
						goto IL_004C;
					}
					goto IL_00DD;
					IL_001D:
					Type type;
					propertyInfo2 = (PropertyInfo)ReflectionUtils.GetMemberInfoFromType(type, propertyInfo);
					goto IL_002D;
					IL_0013:
					if (type != null)
					{
						goto IL_001D;
					}
					num = 4;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e != 0)
					{
						break;
					}
					goto IL_00DD;
					IL_0079:
					if (dataMemberAttribute != null)
					{
						break;
					}
					goto IL_0013;
					IL_0070:
					type = type.BaseType();
					goto IL_0079;
					IL_004C:
					if (!propertyInfo2.IsVirtual())
					{
						goto IL_0070;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 != 0)
					{
						goto IL_0067;
					}
					goto IL_00DD;
					IL_00A5:
					if (!propertyInfo.IsVirtual())
					{
						num = 10;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 == 0)
						{
							break;
						}
						goto IL_00DD;
					}
					IL_009A:
					type = propertyInfo.DeclaringType;
					goto IL_0079;
					IL_0067:
					dataMemberAttribute = CachedAttributeGetter<DataMemberAttribute>.GetAttribute(propertyInfo2);
					goto IL_0070;
				}
				return dataMemberAttribute;
				IL_016A:
				return CachedAttributeGetter<DataMemberAttribute>.GetAttribute(memberInfo);
			}
			goto IL_016A;
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x00068448 File Offset: 0x00066648
		public static MemberSerialization GetObjectMemberSerialization(Type objectType, bool ignoreSerializableAttribute)
		{
			JsonObjectAttribute cachedAttribute;
			for (;;)
			{
				IL_0062:
				cachedAttribute = JsonTypeReflector.GetCachedAttribute<JsonObjectAttribute>(objectType);
				for (;;)
				{
					int num;
					if (cachedAttribute != null)
					{
						num = 3;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81 == 0)
						{
							goto Block_4;
						}
					}
					else
					{
						if (JsonTypeReflector.GetDataContractAttribute(objectType) != null)
						{
							return MemberSerialization.OptIn;
						}
						if (!ignoreSerializableAttribute)
						{
							goto IL_007A;
						}
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba != 0)
						{
							goto IL_0077;
						}
					}
					switch (num)
					{
					case 1:
					case 4:
						return MemberSerialization.OptOut;
					case 2:
						goto IL_007A;
					case 3:
						goto IL_006F;
					case 5:
						continue;
					case 6:
						goto IL_0062;
					case 7:
						return MemberSerialization.OptIn;
					}
					goto Block_3;
				}
			}
			Block_3:
			Block_4:
			return MemberSerialization.Fields;
			IL_006F:
			return cachedAttribute.MemberSerialization;
			IL_0077:
			return MemberSerialization.OptOut;
			IL_007A:
			if (JsonTypeReflector.IsSerializable(objectType))
			{
				return MemberSerialization.Fields;
			}
			return MemberSerialization.OptOut;
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x000684DC File Offset: 0x000666DC
		[return: Nullable(2)]
		public static JsonConverter GetJsonConverter(object attributeProvider)
		{
			JsonConverterAttribute cachedAttribute;
			Func<object[], object> func;
			for (;;)
			{
				cachedAttribute = JsonTypeReflector.GetCachedAttribute<JsonConverterAttribute>(attributeProvider);
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 != 0)
				{
					goto IL_0043;
				}
				goto IL_005B;
				IL_003C:
				while (func == null)
				{
					num = 3;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 == 0)
					{
						goto IL_005B;
					}
				}
				goto IL_0099;
				IL_005B:
				switch (num)
				{
				case 0:
					goto IL_003C;
				case 1:
					IL_0043:
					if (cachedAttribute == null)
					{
						goto IL_0097;
					}
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 != 0)
					{
						goto IL_005B;
					}
					break;
				case 2:
					continue;
				case 3:
					goto IL_0097;
				case 4:
					goto IL_0099;
				case 5:
					break;
				default:
					goto IL_003C;
				}
				func = JsonTypeReflector.threadSafeStore_0.Get(cachedAttribute.ConverterType);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 == 0)
				{
					goto IL_003C;
				}
				goto IL_005B;
			}
			IL_0097:
			return null;
			IL_0099:
			return (JsonConverter)func(cachedAttribute.ConverterParameters);
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x000051AD File Offset: 0x000033AD
		public static JsonConverter CreateJsonConverterInstance(Type converterType, [Nullable(new byte[] { 2, 1 })] object[] args)
		{
			return (JsonConverter)JsonTypeReflector.threadSafeStore_0.Get(converterType)(args);
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x000051C5 File Offset: 0x000033C5
		public static NamingStrategy CreateNamingStrategyInstance(Type namingStrategyType, [Nullable(new byte[] { 2, 1 })] object[] args)
		{
			return (NamingStrategy)JsonTypeReflector.threadSafeStore_0.Get(namingStrategyType)(args);
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x00068598 File Offset: 0x00066798
		[return: Nullable(2)]
		public static NamingStrategy GetContainerNamingStrategy(JsonContainerAttribute containerAttribute)
		{
			for (;;)
			{
				if (containerAttribute.NamingStrategyInstance == null)
				{
					goto IL_004B;
				}
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 == 0)
				{
					break;
				}
				IL_002B:
				switch (num)
				{
				case 1:
					continue;
				case 3:
					IL_004B:
					if (!(containerAttribute.NamingStrategyType == null))
					{
						goto IL_0003;
					}
					goto IL_0086;
				case 4:
					goto IL_0003;
				case 5:
					goto IL_0086;
				}
				break;
				IL_0003:
				containerAttribute.NamingStrategyInstance = JsonTypeReflector.CreateNamingStrategyInstance(containerAttribute.NamingStrategyType, containerAttribute.NamingStrategyParameters);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 != 0)
				{
					goto IL_002B;
				}
				break;
			}
			return containerAttribute.NamingStrategyInstance;
			IL_0086:
			return null;
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x0006862C File Offset: 0x0006682C
		[return: Nullable(new byte[] { 1, 2, 1, 1 })]
		private static Func<object[], object> smethod_0(Type type_0)
		{
			JsonTypeReflector.<>c__DisplayClass22_0 CS$<>8__locals1 = new JsonTypeReflector.<>c__DisplayClass22_0();
			CS$<>8__locals1.type_0 = type_0;
			CS$<>8__locals1.func_0 = (ReflectionUtils.HasDefaultConstructor(CS$<>8__locals1.type_0, false) ? JsonTypeReflector.ReflectionDelegateFactory.CreateDefaultConstructor<object>(CS$<>8__locals1.type_0) : null);
			return new Func<object[], object>(CS$<>8__locals1.method_0);
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x000051DD File Offset: 0x000033DD
		[return: Nullable(2)]
		private static Type smethod_1(Type type_0)
		{
			return JsonTypeReflector.threadSafeStore_1.Get(type_0);
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x0006867C File Offset: 0x0006687C
		[return: Nullable(2)]
		private static Type smethod_2(Type type_0)
		{
			Attribute attribute;
			for (;;)
			{
				IL_010D:
				Attribute[] attributes = ReflectionUtils.GetAttributes(type_0, null, true);
				for (;;)
				{
					IL_00F6:
					int num = 0;
					int num2 = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 == 0)
					{
						goto IL_0099;
					}
					Type type;
					for (;;)
					{
						IL_00BE:
						switch (num2)
						{
						case 1:
						case 3:
							goto IL_0099;
						case 2:
							goto IL_004C;
						case 4:
							goto IL_0010;
						case 5:
						case 6:
							goto IL_011D;
						case 7:
							goto IL_00F6;
						case 8:
							goto IL_010D;
						case 9:
							goto IL_00B5;
						case 10:
							if (!string.Equals(type.FullName, Class15.smethod_17(486501344 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c), StringComparison.Ordinal))
							{
								goto Block_2;
							}
							goto IL_0006;
						case 11:
							goto IL_0006;
						}
						goto Block_5;
						IL_0010:
						JsonTypeReflector.reflectionObject_0 = ReflectionObject.Create(type, new string[] { Class15.smethod_17(1793892848 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a) });
						num2 = 6;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 == 0)
						{
							goto IL_004C;
						}
						continue;
						IL_0006:
						if (JsonTypeReflector.reflectionObject_0 == null)
						{
							goto IL_0010;
						}
						goto IL_011D;
					}
					Block_2:
					num++;
					goto IL_0099;
					IL_004C:
					type = attribute.GetType();
					num2 = 10;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 != 0)
					{
						goto Block_1;
					}
					goto IL_00BE;
					IL_00B5:
					attribute = attributes[num];
					goto IL_004C;
					IL_0099:
					if (num < attributes.Length)
					{
						goto IL_00B5;
					}
					num2 = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c == 0)
					{
						goto Block_4;
					}
					goto IL_00BE;
				}
			}
			Block_1:
			goto IL_011D;
			Block_4:
			Block_5:
			return null;
			IL_011D:
			return (Type)JsonTypeReflector.reflectionObject_0.GetValue(attribute, Class15.smethod_17(1116203407 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54));
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x000687CC File Offset: 0x000669CC
		[return: Nullable(2)]
		private static T smethod_3<[Nullable(0)] T>(Type type_0) where T : Attribute
		{
			Type type = JsonTypeReflector.smethod_1(type_0);
			T t;
			if (type != null)
			{
				t = ReflectionUtils.GetAttribute<T>(type, true);
				if (t != null)
				{
					return t;
				}
			}
			t = ReflectionUtils.GetAttribute<T>(type_0, true);
			if (t != null)
			{
				return t;
			}
			Type[] interfaces = type_0.GetInterfaces();
			for (int i = 0; i < interfaces.Length; i++)
			{
				t = ReflectionUtils.GetAttribute<T>(interfaces[i], true);
				if (t != null)
				{
					return t;
				}
			}
			return default(T);
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x00068840 File Offset: 0x00066A40
		[return: Nullable(2)]
		private static T smethod_4<[Nullable(0)] T>(MemberInfo memberInfo_0) where T : Attribute
		{
			Type type = JsonTypeReflector.smethod_1(memberInfo_0.DeclaringType);
			T t;
			if (type != null)
			{
				MemberInfo memberInfoFromType = ReflectionUtils.GetMemberInfoFromType(type, memberInfo_0);
				if (memberInfoFromType != null)
				{
					t = ReflectionUtils.GetAttribute<T>(memberInfoFromType, true);
					if (t != null)
					{
						return t;
					}
				}
			}
			t = ReflectionUtils.GetAttribute<T>(memberInfo_0, true);
			if (t != null)
			{
				return t;
			}
			if (memberInfo_0.DeclaringType != null)
			{
				Type[] interfaces = memberInfo_0.DeclaringType.GetInterfaces();
				for (int i = 0; i < interfaces.Length; i++)
				{
					MemberInfo memberInfoFromType2 = ReflectionUtils.GetMemberInfoFromType(interfaces[i], memberInfo_0);
					if (memberInfoFromType2 != null)
					{
						t = ReflectionUtils.GetAttribute<T>(memberInfoFromType2, true);
						if (t != null)
						{
							return t;
						}
					}
				}
			}
			return default(T);
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x000051EA File Offset: 0x000033EA
		public static bool IsNonSerializable(ICustomAttributeProvider provider)
		{
			return ReflectionUtils.GetAttribute<NonSerializedAttribute>(provider, false) != null;
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x000051F6 File Offset: 0x000033F6
		public static bool IsSerializable(ICustomAttributeProvider provider)
		{
			return ReflectionUtils.GetAttribute<SerializableAttribute>(provider, false) != null;
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x000688FC File Offset: 0x00066AFC
		[return: Nullable(2)]
		public static T GetAttribute<[Nullable(0)] T>(ICustomAttributeProvider provider) where T : Attribute
		{
			Type type = provider as Type;
			if (type != null)
			{
				return JsonTypeReflector.smethod_3<T>(type);
			}
			MemberInfo memberInfo = provider as MemberInfo;
			if (memberInfo != null)
			{
				return JsonTypeReflector.smethod_4<T>(memberInfo);
			}
			return ReflectionUtils.GetAttribute<T>(provider, true);
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000B95 RID: 2965 RVA: 0x00068934 File Offset: 0x00066B34
		public static bool DynamicCodeGeneration
		{
			[SecuritySafeCritical]
			get
			{
				while (JsonTypeReflector.nullable_0 == null)
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 == 0)
					{
						switch (num)
						{
						case 1:
							continue;
						case 2:
							goto IL_0137;
						}
					}
					try
					{
						new ReflectionPermission(ReflectionPermissionFlag.MemberAccess).Demand();
						int num2 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 == 0)
						{
							goto IL_00C3;
						}
						goto IL_00D0;
						IL_005B:
						new SecurityPermission(PermissionState.Unrestricted).Demand();
						num2 = 4;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf != 0)
						{
							goto IL_00D0;
						}
						IL_0078:
						JsonTypeReflector.nullable_0 = new bool?(true);
						num2 = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 == 0)
						{
							break;
						}
						goto IL_00D0;
						IL_0097:
						new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Demand();
						goto IL_005B;
						IL_00A4:
						new SecurityPermission(SecurityPermissionFlag.SkipVerification).Demand();
						num2 = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 != 0)
						{
							goto IL_0097;
						}
						goto IL_00D0;
						IL_00C3:
						new ReflectionPermission(ReflectionPermissionFlag.RestrictedMemberAccess).Demand();
						goto IL_00A4;
						IL_00D0:
						switch (num2)
						{
						case 0:
							goto IL_00C3;
						case 1:
							break;
						case 2:
							goto IL_00A4;
						case 3:
							goto IL_0097;
						case 4:
							goto IL_0078;
						case 5:
							goto IL_005B;
						default:
							goto IL_00C3;
						}
					}
					catch (Exception)
					{
						int num3 = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67cbcb2ad04040d48847c1ca2f65be32 == 0)
						{
							goto IL_0125;
						}
						do
						{
							IL_0106:
							JsonTypeReflector.nullable_0 = new bool?(false);
							num3 = 1;
						}
						while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 == 0);
						IL_0125:
						switch (num3)
						{
						case 0:
							goto IL_0106;
						case 1:
							break;
						default:
							goto IL_0106;
						}
					}
					break;
				}
				IL_0137:
				return JsonTypeReflector.nullable_0.GetValueOrDefault();
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000B96 RID: 2966 RVA: 0x00068A94 File Offset: 0x00066C94
		public static bool FullyTrusted
		{
			get
			{
				IL_0072:
				while (JsonTypeReflector.nullable_1 == null)
				{
					for (;;)
					{
						IL_0057:
						AppDomain currentDomain = AppDomain.CurrentDomain;
						int num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 != 0)
						{
							break;
						}
						for (;;)
						{
							switch (num)
							{
							case 1:
								if (!currentDomain.IsHomogenous)
								{
									goto IL_0028;
								}
								goto IL_0003;
							case 2:
								goto IL_0028;
							case 3:
								goto IL_0057;
							case 4:
								goto IL_0072;
							case 5:
								goto IL_0003;
							}
							goto Block_3;
							IL_000A:
							bool flag;
							JsonTypeReflector.nullable_1 = new bool?(flag);
							num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b != 0)
							{
								goto Block_1;
							}
							continue;
							IL_0003:
							flag = currentDomain.IsFullyTrusted;
							goto IL_000A;
							IL_0028:
							flag = false;
							goto IL_000A;
						}
					}
					Block_1:
					Block_3:
					break;
				}
				return JsonTypeReflector.nullable_1.GetValueOrDefault();
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000B97 RID: 2967 RVA: 0x00068B30 File Offset: 0x00066D30
		public static ReflectionDelegateFactory ReflectionDelegateFactory
		{
			get
			{
				while (JsonTypeReflector.DynamicCodeGeneration)
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e != 0)
					{
						switch (num)
						{
						case 1:
							continue;
						}
					}
					return DynamicReflectionDelegateFactory.Instance;
				}
				return LateBoundReflectionDelegateFactory.Instance;
			}
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x00068B78 File Offset: 0x00066D78
		static JsonTypeReflector()
		{
			for (;;)
			{
				IL_0089:
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf != 0)
				{
					goto IL_0058;
				}
				for (;;)
				{
					IL_006D:
					switch (num)
					{
					case 1:
						goto IL_002E;
					case 2:
						goto IL_0058;
					case 3:
						goto IL_0089;
					case 4:
						JsonTypeReflector.threadSafeStore_0 = new ThreadSafeStore<Type, Func<object[], object>>(new Func<Type, Func<object[], object>>(JsonTypeReflector.smethod_0));
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_aa43e77a676848e0bd70abf647d6a9f1 == 0)
						{
							goto IL_002E;
						}
						continue;
					}
					return;
				}
				IL_002E:
				JsonTypeReflector.threadSafeStore_1 = new ThreadSafeStore<Type, Type>(new Func<Type, Type>(JsonTypeReflector.smethod_2));
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a != 0)
				{
					break;
				}
				goto IL_006D;
				IL_0058:
				num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba == 0)
				{
					goto IL_002E;
				}
				goto IL_006D;
			}
		}

		// Token: 0x040005AA RID: 1450
		private static bool? nullable_0;

		// Token: 0x040005AB RID: 1451
		private static bool? nullable_1;

		// Token: 0x040005AC RID: 1452
		public const string IdPropertyName = "$id";

		// Token: 0x040005AD RID: 1453
		public const string RefPropertyName = "$ref";

		// Token: 0x040005AE RID: 1454
		public const string TypePropertyName = "$type";

		// Token: 0x040005AF RID: 1455
		public const string ValuePropertyName = "$value";

		// Token: 0x040005B0 RID: 1456
		public const string ArrayValuesPropertyName = "$values";

		// Token: 0x040005B1 RID: 1457
		public const string ShouldSerializePrefix = "ShouldSerialize";

		// Token: 0x040005B2 RID: 1458
		public const string SpecifiedPostfix = "Specified";

		// Token: 0x040005B3 RID: 1459
		public const string ConcurrentDictionaryTypeName = "System.Collections.Concurrent.ConcurrentDictionary`2";

		// Token: 0x040005B4 RID: 1460
		[Nullable(new byte[] { 1, 1, 1, 2, 1, 1 })]
		private static readonly ThreadSafeStore<Type, Func<object[], object>> threadSafeStore_0;

		// Token: 0x040005B5 RID: 1461
		[Nullable(new byte[] { 1, 1, 2 })]
		private static readonly ThreadSafeStore<Type, Type> threadSafeStore_1;

		// Token: 0x040005B6 RID: 1462
		[Nullable(2)]
		private static ReflectionObject reflectionObject_0;
	}
}
