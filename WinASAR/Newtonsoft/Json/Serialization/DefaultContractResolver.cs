using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020000E5 RID: 229
	[Nullable(0)]
	[NullableContext(1)]
	public class DefaultContractResolver : IContractResolver
	{
		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060008E6 RID: 2278 RVA: 0x00004838 File Offset: 0x00002A38
		internal static IContractResolver Instance
		{
			get
			{
				return DefaultContractResolver.icontractResolver_0;
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060008E7 RID: 2279 RVA: 0x0000483F File Offset: 0x00002A3F
		public bool DynamicCodeGeneration
		{
			get
			{
				return JsonTypeReflector.DynamicCodeGeneration;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060008E8 RID: 2280 RVA: 0x00004846 File Offset: 0x00002A46
		// (set) Token: 0x060008E9 RID: 2281 RVA: 0x00052DE8 File Offset: 0x00050FE8
		[Obsolete("DefaultMembersSearchFlags is obsolete. To modify the members serialized inherit from DefaultContractResolver and override the GetSerializableMembers method instead.")]
		public BindingFlags DefaultMembersSearchFlags
		{
			[CompilerGenerated]
			get
			{
				return this.bindingFlags_0;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.bindingFlags_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 != 0)
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
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060008EA RID: 2282 RVA: 0x0000484E File Offset: 0x00002A4E
		// (set) Token: 0x060008EB RID: 2283 RVA: 0x00052E20 File Offset: 0x00051020
		public bool SerializeCompilerGeneratedMembers
		{
			[CompilerGenerated]
			get
			{
				return this.bool_0;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.bool_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 != 0)
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
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060008EC RID: 2284 RVA: 0x00004856 File Offset: 0x00002A56
		// (set) Token: 0x060008ED RID: 2285 RVA: 0x00052E58 File Offset: 0x00051058
		public bool IgnoreSerializableInterface
		{
			[CompilerGenerated]
			get
			{
				return this.bool_1;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.bool_1 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_52d717cd31b74287b67c03ee736a6211 != 0)
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
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060008EE RID: 2286 RVA: 0x0000485E File Offset: 0x00002A5E
		// (set) Token: 0x060008EF RID: 2287 RVA: 0x00052E90 File Offset: 0x00051090
		public bool IgnoreSerializableAttribute
		{
			[CompilerGenerated]
			get
			{
				return this.ysvdGjichr;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.ysvdGjichr = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 == 0)
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
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060008F0 RID: 2288 RVA: 0x00004866 File Offset: 0x00002A66
		// (set) Token: 0x060008F1 RID: 2289 RVA: 0x00052EC8 File Offset: 0x000510C8
		public bool IgnoreIsSpecifiedMembers
		{
			[CompilerGenerated]
			get
			{
				return this.bool_2;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.bool_2 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c != 0)
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
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060008F2 RID: 2290 RVA: 0x0000486E File Offset: 0x00002A6E
		// (set) Token: 0x060008F3 RID: 2291 RVA: 0x00052F00 File Offset: 0x00051100
		public bool IgnoreShouldSerializeMembers
		{
			[CompilerGenerated]
			get
			{
				return this.bool_3;
			}
			[CompilerGenerated]
			set
			{
				for (;;)
				{
					this.bool_3 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 != 0)
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
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060008F4 RID: 2292 RVA: 0x00004876 File Offset: 0x00002A76
		// (set) Token: 0x060008F5 RID: 2293 RVA: 0x00052F38 File Offset: 0x00051138
		[Nullable(2)]
		public NamingStrategy NamingStrategy
		{
			[NullableContext(2)]
			[CompilerGenerated]
			get
			{
				return this.namingStrategy_0;
			}
			[CompilerGenerated]
			[NullableContext(2)]
			set
			{
				for (;;)
				{
					this.namingStrategy_0 = value;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba != 0)
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
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x00052F70 File Offset: 0x00051170
		public DefaultContractResolver()
		{
			for (;;)
			{
				this.IgnoreSerializableAttribute = true;
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 == 0)
				{
					goto IL_0015;
				}
				IL_002E:
				switch (num)
				{
				case 1:
					IL_0015:
					this.DefaultMembersSearchFlags = BindingFlags.Instance | BindingFlags.Public;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 != 0)
					{
						goto IL_002E;
					}
					break;
				case 2:
					return;
				case 3:
					continue;
				}
				break;
			}
			this.threadSafeStore_0 = new ThreadSafeStore<Type, JsonContract>(new Func<Type, JsonContract>(this.CreateContract));
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x00052FF8 File Offset: 0x000511F8
		public virtual JsonContract ResolveContract(Type type)
		{
			for (;;)
			{
				ValidationUtils.ArgumentNotNull(type, Class15.smethod_17(2056996079 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48));
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 != 0)
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
			return this.threadSafeStore_0.Get(type);
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x00053050 File Offset: 0x00051250
		private static bool smethod_0(object object_0)
		{
			PropertyInfo propertyInfo;
			FieldInfo fieldInfo;
			for (;;)
			{
				IL_0067:
				propertyInfo = object_0 as PropertyInfo;
				int num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 == 0)
				{
					break;
				}
				for (;;)
				{
					IL_003F:
					switch (num)
					{
					case 0:
						goto IL_001C;
					case 1:
						goto IL_0081;
					case 2:
						break;
					case 3:
						return false;
					case 4:
						goto IL_0091;
					case 5:
						if (propertyInfo != null)
						{
							goto IL_0091;
						}
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 == 0)
						{
							goto IL_001C;
						}
						continue;
					case 6:
						goto IL_0067;
					case 7:
						return true;
					default:
						goto IL_001C;
					}
					IL_0038:
					while (fieldInfo == null)
					{
						num = 7;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 == 0)
						{
							goto IL_003F;
						}
					}
					goto IL_0081;
					IL_001C:
					fieldInfo = object_0 as FieldInfo;
					goto IL_0038;
				}
			}
			IL_0081:
			return !ReflectionUtils.IsByRefLikeType(fieldInfo.FieldType);
			IL_0091:
			if (!ReflectionUtils.IsIndexedProperty(propertyInfo))
			{
				return !ReflectionUtils.IsByRefLikeType(propertyInfo.PropertyType);
			}
			return false;
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x0005310C File Offset: 0x0005130C
		protected virtual List<MemberInfo> GetSerializableMembers(Type objectType)
		{
			bool ignoreSerializableAttribute = this.IgnoreSerializableAttribute;
			MemberSerialization objectMemberSerialization = JsonTypeReflector.GetObjectMemberSerialization(objectType, ignoreSerializableAttribute);
			IEnumerable<MemberInfo> enumerable = ReflectionUtils.GetFieldsAndProperties(objectType, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).Where(new Func<MemberInfo, bool>(DefaultContractResolver.<>c.<>c_0.method_0));
			List<MemberInfo> list = new List<MemberInfo>();
			if (objectMemberSerialization != MemberSerialization.Fields)
			{
				DataContractAttribute dataContractAttribute = JsonTypeReflector.GetDataContractAttribute(objectType);
				List<MemberInfo> list2 = ReflectionUtils.GetFieldsAndProperties(objectType, this.DefaultMembersSearchFlags).Where(new Func<MemberInfo, bool>(DefaultContractResolver.smethod_0)).ToList<MemberInfo>();
				foreach (MemberInfo memberInfo in enumerable)
				{
					if (this.SerializeCompilerGeneratedMembers || !memberInfo.IsDefined(typeof(CompilerGeneratedAttribute), true))
					{
						if (list2.Contains(memberInfo))
						{
							list.Add(memberInfo);
						}
						else if (JsonTypeReflector.GetAttribute<JsonPropertyAttribute>(memberInfo) != null)
						{
							list.Add(memberInfo);
						}
						else if (JsonTypeReflector.GetAttribute<JsonRequiredAttribute>(memberInfo) != null)
						{
							list.Add(memberInfo);
						}
						else if (dataContractAttribute != null && JsonTypeReflector.GetAttribute<DataMemberAttribute>(memberInfo) != null)
						{
							list.Add(memberInfo);
						}
						else if (objectMemberSerialization == MemberSerialization.Fields && memberInfo.MemberType() == MemberTypes.Field)
						{
							list.Add(memberInfo);
						}
					}
				}
				Type type;
				if (objectType.AssignableToTypeName(Class15.smethod_17(1953677217 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f), false, out type))
				{
					list = list.Where(new Func<MemberInfo, bool>(this.ShouldSerializeEntityMember)).ToList<MemberInfo>();
				}
				if (typeof(Exception).IsAssignableFrom(objectType))
				{
					list = list.Where(new Func<MemberInfo, bool>(DefaultContractResolver.<>c.<>c_0.method_1)).ToList<MemberInfo>();
				}
			}
			else
			{
				foreach (MemberInfo memberInfo2 in enumerable)
				{
					FieldInfo fieldInfo = memberInfo2 as FieldInfo;
					if (fieldInfo != null && !fieldInfo.IsStatic)
					{
						list.Add(memberInfo2);
					}
				}
			}
			return list;
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x00053320 File Offset: 0x00051520
		private bool ShouldSerializeEntityMember(MemberInfo memberInfo)
		{
			for (;;)
			{
				IL_0080:
				PropertyInfo propertyInfo = memberInfo as PropertyInfo;
				IL_0079:
				while (propertyInfo != null)
				{
					IL_0068:
					while (propertyInfo.PropertyType.IsGenericType())
					{
						while (propertyInfo.PropertyType.GetGenericTypeDefinition().FullName == Class15.smethod_17(1603819992 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c))
						{
							int num = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 != 0)
							{
								return false;
							}
							switch (num)
							{
							case 0:
								goto IL_0068;
							case 1:
								return false;
							case 2:
							case 3:
								return true;
							case 4:
								goto IL_0079;
							case 5:
								goto IL_0080;
							case 6:
								break;
							default:
								goto IL_0068;
							}
						}
						break;
					}
					break;
				}
				break;
			}
			return true;
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x000533BC File Offset: 0x000515BC
		protected virtual JsonObjectContract CreateObjectContract(Type objectType)
		{
			JsonObjectContract jsonObjectContract;
			for (;;)
			{
				IL_0543:
				jsonObjectContract = new JsonObjectContract(objectType);
				for (;;)
				{
					IL_0539:
					this.method_6(jsonObjectContract);
					for (;;)
					{
						IL_052F:
						bool ignoreSerializableAttribute = this.IgnoreSerializableAttribute;
						for (;;)
						{
							IL_0518:
							jsonObjectContract.MemberSerialization = JsonTypeReflector.GetObjectMemberSerialization(jsonObjectContract.NonNullableUnderlyingType, ignoreSerializableAttribute);
							for (;;)
							{
								IL_04F6:
								jsonObjectContract.Properties.AddRange(this.CreateProperties(jsonObjectContract.NonNullableUnderlyingType, jsonObjectContract.MemberSerialization));
								for (;;)
								{
									IL_04F0:
									Func<string, string> func = null;
									for (;;)
									{
										IL_04E0:
										JsonObjectAttribute cachedAttribute = JsonTypeReflector.GetCachedAttribute<JsonObjectAttribute>(jsonObjectContract.NonNullableUnderlyingType);
										for (;;)
										{
											IL_04D6:
											if (cachedAttribute != null)
											{
												goto IL_02DA;
											}
											goto IL_04CE;
											int num;
											ConstructorInfo constructorInfo;
											ConstructorInfo constructorInfo3;
											for (;;)
											{
												IL_02FC:
												switch (num)
												{
												case 1:
													return jsonObjectContract;
												case 2:
													goto IL_0206;
												case 3:
													goto IL_0539;
												case 4:
													goto IL_0543;
												case 5:
													goto IL_04A1;
												case 8:
													goto IL_0432;
												case 9:
													goto IL_01B7;
												case 10:
													goto IL_03D3;
												case 11:
												case 41:
													goto IL_00C7;
												case 12:
													goto IL_04C2;
												case 13:
													goto IL_02DA;
												case 15:
													goto IL_02BA;
												case 16:
													goto IL_052F;
												case 17:
													goto IL_0178;
												case 18:
													goto IL_00D6;
												case 19:
													goto IL_0297;
												case 20:
													goto IL_00FA;
												case 21:
												case 25:
													goto IL_026A;
												case 22:
													goto IL_04F6;
												case 23:
													goto IL_028B;
												case 24:
													goto IL_0014;
												case 26:
													goto IL_04B3;
												case 27:
													if (!(constructorInfo != null))
													{
														goto IL_026A;
													}
													goto IL_0233;
												case 28:
													goto IL_01E2;
												case 29:
													goto IL_04E0;
												case 30:
												case 34:
													goto IL_01A6;
												case 31:
													goto IL_0233;
												case 32:
													goto IL_003D;
												case 33:
													goto IL_0402;
												case 35:
													goto IL_0518;
												case 36:
													goto IL_0157;
												case 38:
													goto IL_0122;
												case 39:
													goto IL_04D6;
												case 40:
													goto IL_04F0;
												case 42:
												case 47:
													goto IL_04CE;
												case 44:
													jsonObjectContract.ItemNullValueHandling = cachedAttribute._itemNullValueHandling;
													num = 49;
													if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 != 0)
													{
														goto IL_0006;
													}
													continue;
												case 45:
													goto IL_045B;
												case 46:
													constructorInfo = this.method_1(jsonObjectContract.NonNullableUnderlyingType);
													num = 27;
													if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 == 0)
													{
														goto Block_4;
													}
													continue;
												case 49:
													goto IL_0006;
												case 50:
													goto IL_041B;
												}
												goto Block_21;
												IL_0014:
												if (cachedAttribute.NamingStrategyType != null)
												{
													goto IL_003D;
												}
												num = 39;
												if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a != 0)
												{
													goto Block_2;
												}
												continue;
												IL_0006:
												jsonObjectContract.MissingMemberHandling = cachedAttribute._missingMemberHandling;
												goto IL_0014;
												IL_003D:
												DefaultContractResolver.<>c__DisplayClass42_0 CS$<>8__locals1 = new DefaultContractResolver.<>c__DisplayClass42_0();
												CS$<>8__locals1.namingStrategy_0 = JsonTypeReflector.GetContainerNamingStrategy(cachedAttribute);
												func = new Func<string, string>(CS$<>8__locals1.method_0);
												num = 47;
												if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a == 0)
												{
													break;
												}
												continue;
												IL_00D6:
												ConstructorInfo constructorInfo2;
												if (constructorInfo2 != null)
												{
													goto IL_00FA;
												}
												num = 42;
												if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b != 0)
												{
													goto Block_7;
												}
												continue;
												IL_00C7:
												constructorInfo2 = this.method_3(jsonObjectContract.NonNullableUnderlyingType);
												goto IL_00D6;
												IL_0297:
												if (jsonObjectContract.DefaultCreatorNonPublic)
												{
													goto IL_00C7;
												}
												num = 10;
												if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 != 0)
												{
													goto IL_01A6;
												}
												continue;
												IL_028B:
												if (jsonObjectContract.DefaultCreator != null)
												{
													goto IL_0297;
												}
												goto IL_00C7;
												IL_026A:
												if (jsonObjectContract.MemberSerialization != MemberSerialization.Fields)
												{
													goto IL_028B;
												}
												num = 14;
												if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_193800745ad94a529d9e5edc977c4f02 == 0)
												{
													goto IL_0157;
												}
												continue;
												IL_00FA:
												jsonObjectContract.ParameterizedCreator = JsonTypeReflector.ReflectionDelegateFactory.CreateParameterizedConstructor(constructorInfo2);
												num = 14;
												if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 != 0)
												{
													continue;
												}
												IL_0122:
												jsonObjectContract.CreatorParameters.AddRange(this.CreateConstructorParameters(constructorInfo2, jsonObjectContract.Properties));
												num = 21;
												if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b32b9d66294210a955990bb6fcc511 == 0)
												{
													goto Block_8;
												}
												continue;
												IL_0157:
												if (!JsonTypeReflector.FullyTrusted)
												{
													num = 0;
													if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e == 0)
													{
														goto Block_10;
													}
													continue;
												}
												IL_0178:
												jsonObjectContract.DefaultCreator = new Func<object>(jsonObjectContract.GetUninitializedObject);
												num = 19;
												if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba != 0)
												{
													goto Block_11;
												}
												continue;
												IL_01B7:
												constructorInfo3 = this.method_2(jsonObjectContract.NonNullableUnderlyingType, jsonObjectContract.Properties);
												num = 11;
												if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad != 0)
												{
													goto IL_01E2;
												}
												continue;
												IL_01A6:
												if (jsonObjectContract.NonNullableUnderlyingType.IsValueType())
												{
													goto IL_01B7;
												}
												goto IL_0476;
												IL_01E2:
												if (!(constructorInfo3 != null))
												{
													num = 0;
													if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 == 0)
													{
														goto Block_13;
													}
													continue;
												}
												IL_0206:
												jsonObjectContract.OverrideCreator = JsonTypeReflector.ReflectionDelegateFactory.CreateParameterizedConstructor(constructorInfo3);
												num = 6;
												if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 == 0)
												{
													goto Block_14;
												}
												continue;
												IL_0233:
												jsonObjectContract.OverrideCreator = JsonTypeReflector.ReflectionDelegateFactory.CreateParameterizedConstructor(constructorInfo);
												num = 45;
												if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 != 0)
												{
													goto IL_0014;
												}
											}
											continue;
											Block_2:
											goto IL_04CE;
											IL_045B:
											jsonObjectContract.CreatorParameters.AddRange(this.CreateConstructorParameters(constructorInfo, jsonObjectContract.Properties));
											goto IL_0476;
											IL_0432:
											jsonObjectContract.CreatorParameters.AddRange(this.CreateConstructorParameters(constructorInfo3, jsonObjectContract.Properties));
											goto IL_0476;
											Block_14:
											goto IL_0432;
											Block_21:
											Block_13:
											Block_11:
											Block_10:
											Block_8:
											Block_7:
											goto IL_0476;
											IL_02BA:
											MemberInfo memberInfo;
											DefaultContractResolver.smethod_2(jsonObjectContract, memberInfo);
											num = 33;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a == 0)
											{
												goto IL_04C2;
											}
											goto IL_02FC;
											IL_041B:
											if (memberInfo != null)
											{
												goto IL_02BA;
											}
											goto IL_0402;
											IL_0476:
											memberInfo = this.method_0(jsonObjectContract.NonNullableUnderlyingType);
											goto IL_041B;
											IL_04A1:
											if (!jsonObjectContract.IsInstantiable)
											{
												goto IL_0476;
											}
											num = 46;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 == 0)
											{
												return jsonObjectContract;
											}
											goto IL_02FC;
											IL_04C2:
											jsonObjectContract.ExtensionDataNameResolver = func;
											goto IL_04A1;
											IL_04CE:
											if (func != null)
											{
												goto IL_04C2;
											}
											IL_04B3:
											func = new Func<string, string>(this.ResolveExtensionDataName);
											goto IL_04C2;
											IL_02DA:
											jsonObjectContract.ItemRequired = cachedAttribute._itemRequired;
											num = 44;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 != 0)
											{
												goto IL_02FC;
											}
											goto IL_04C2;
											IL_03D3:
											jsonObjectContract.OnSerializingCallbacks.Add(new SerializationCallback(DefaultContractResolver.smethod_1));
											num = 1;
											if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 == 0)
											{
												goto IL_0476;
											}
											goto IL_02FC;
											IL_0402:
											if (Array.IndexOf<string>(DefaultContractResolver.string_0, objectType.FullName) != -1)
											{
												goto IL_03D3;
											}
											return jsonObjectContract;
										}
									}
								}
								Block_4:;
							}
						}
					}
				}
			}
			return jsonObjectContract;
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x0000487E File Offset: 0x00002A7E
		private static void smethod_1(object object_0, StreamingContext streamingContext_0)
		{
			throw new JsonSerializationException(Class15.smethod_17(594356162 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b).FormatWith(CultureInfo.InvariantCulture, object_0.GetType()));
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x0005391C File Offset: 0x00051B1C
		[return: Nullable(2)]
		private MemberInfo method_0(Type type_0)
		{
			return this.method_9(type_0).SelectMany(new Func<Type, IEnumerable<MemberInfo>>(DefaultContractResolver.<>c.<>c_0.method_2)).LastOrDefault(new Func<MemberInfo, bool>(DefaultContractResolver.<>c.<>c_0.method_3));
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x00053978 File Offset: 0x00051B78
		private static void smethod_2(JsonObjectContract jsonObjectContract_0, MemberInfo memberInfo_0)
		{
			DefaultContractResolver.<>c__DisplayClass45_0 CS$<>8__locals1;
			Type type2;
			Type type3;
			for (;;)
			{
				IL_0343:
				CS$<>8__locals1 = new DefaultContractResolver.<>c__DisplayClass45_0();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 != 0)
				{
					goto IL_0289;
				}
				Type type4;
				PropertyInfo property;
				for (;;)
				{
					IL_02A8:
					JsonExtensionDataAttribute attribute;
					Type memberUnderlyingType;
					DefaultContractResolver.<>c__DisplayClass45_0 <>c__DisplayClass45_0_0;
					switch (num)
					{
					case 1:
						goto IL_0343;
					case 2:
						return;
					case 3:
						goto IL_03D2;
					case 4:
						return;
					case 5:
						goto IL_025B;
					case 6:
					case 7:
						goto IL_010D;
					case 8:
						goto IL_0061;
					case 9:
						attribute = ReflectionUtils.GetAttribute<JsonExtensionDataAttribute>(CS$<>8__locals1.memberInfo_0);
						goto IL_025B;
					case 10:
						goto IL_01D8;
					case 11:
						goto IL_0374;
					case 12:
						goto IL_0116;
					case 13:
						goto IL_0165;
					case 14:
						goto IL_037D;
					case 15:
						goto IL_03A8;
					case 16:
						goto IL_0190;
					case 17:
						goto IL_00AA;
					case 18:
						goto IL_036A;
					case 19:
						goto IL_01C5;
					case 20:
						goto IL_00B3;
					case 21:
					case 32:
						goto IL_0092;
					case 22:
						goto IL_0044;
					case 23:
						goto IL_0170;
					case 24:
						<>c__DisplayClass45_0_0 = CS$<>8__locals1;
						num = 14;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 != 0)
						{
							goto IL_0190;
						}
						continue;
					case 25:
						goto IL_03BB;
					case 26:
						goto IL_0070;
					case 27:
						goto IL_0151;
					case 28:
						goto IL_0013;
					case 29:
						if (!ReflectionUtils.IsGenericDefinition(memberUnderlyingType, typeof(IDictionary<, >)))
						{
							goto IL_010D;
						}
						goto IL_0116;
					case 30:
						goto IL_00D4;
					case 31:
						goto IL_004E;
					case 33:
						goto IL_03CA;
					case 34:
						goto IL_0009;
					case 35:
						goto IL_0006;
					}
					goto Block_13;
					IL_00B3:
					num = 24;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff == 0)
					{
						goto Block_2;
					}
					continue;
					IL_00AA:
					if (attribute.ReadData)
					{
						goto IL_00B3;
					}
					goto IL_00D4;
					IL_0092:
					CS$<>8__locals1.func_0 = JsonTypeReflector.ReflectionDelegateFactory.CreateGet<object>(CS$<>8__locals1.memberInfo_0);
					goto IL_00AA;
					IL_010D:
					Type type = memberUnderlyingType;
					goto IL_0092;
					IL_00D4:
					if (!attribute.WriteData)
					{
						goto IL_03D2;
					}
					num = 18;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c == 0)
					{
						goto Block_4;
					}
					continue;
					IL_0116:
					type = typeof(Dictionary<, >).MakeGenericType(new Type[] { type2, type3 });
					num = 19;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3436841e08c54f56b10b76e1438d4224 == 0)
					{
						goto IL_0092;
					}
					continue;
					IL_0170:
					type3 = type4.GetGenericArguments()[1];
					num = 29;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b == 0)
					{
						goto IL_0190;
					}
					continue;
					IL_0165:
					type2 = type4.GetGenericArguments()[0];
					goto IL_0170;
					IL_0151:
					ReflectionUtils.ImplementsGenericDefinition(memberUnderlyingType, typeof(IDictionary<, >), out type4);
					goto IL_0165;
					IL_025B:
					if (attribute != null)
					{
						memberUnderlyingType = ReflectionUtils.GetMemberUnderlyingType(CS$<>8__locals1.memberInfo_0);
						goto IL_0151;
					}
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8d68b74cee6442019d959192b2974e3d == 0)
					{
						return;
					}
					continue;
					IL_01D8:
					property = memberUnderlyingType.GetProperty(Class15.smethod_17(974425307 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f), BindingFlags.Instance | BindingFlags.Public, null, type3, new Type[] { type2 }, null);
					if (property != null)
					{
						goto IL_0223;
					}
					num = 26;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 == 0)
					{
						goto Block_8;
					}
					continue;
					IL_01C5:
					Func<object> func_0 = JsonTypeReflector.ReflectionDelegateFactory.CreateDefaultConstructor<object>(type);
					goto IL_01D8;
					IL_0190:
					Action<object, object> action_0 = ((!ReflectionUtils.CanSetMemberValue(<>c__DisplayClass45_0_0.memberInfo_0, true, false)) ? null : JsonTypeReflector.ReflectionDelegateFactory.CreateSet<object>(<>c__DisplayClass45_0_0.memberInfo_0));
					goto IL_01C5;
				}
				IL_004E:
				MethodInfo methodInfo;
				CS$<>8__locals2.methodCall_0 = JsonTypeReflector.ReflectionDelegateFactory.CreateMethodCall<object>(methodInfo);
				goto IL_0061;
				IL_0009:
				if (methodInfo == null)
				{
					goto IL_0013;
				}
				goto IL_004E;
				IL_0007:
				MethodInfo methodInfo2;
				methodInfo = methodInfo2;
				goto IL_0009;
				IL_0006:
				methodInfo2 = null;
				goto IL_0007;
				Block_8:
				goto IL_0006;
				Block_13:
				goto IL_0289;
				IL_004C:
				MethodInfo methodInfo3;
				methodInfo = methodInfo3;
				goto IL_004E;
				IL_0013:
				PropertyInfo property2 = type4.GetProperty(Class15.smethod_17(2021181456 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8), BindingFlags.Instance | BindingFlags.Public, null, type3, new Type[] { type2 }, null);
				if (property2 != null)
				{
					methodInfo3 = property2.GetSetMethod();
					goto IL_004C;
				}
				IL_0044:
				methodInfo3 = null;
				goto IL_004C;
				IL_0223:
				methodInfo2 = property.GetSetMethod();
				goto IL_0007;
				IL_0070:
				ExtensionDataSetter extensionDataSetter;
				jsonObjectContract_0.ExtensionDataSetter = extensionDataSetter;
				num = 30;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 != 0)
				{
					break;
				}
				goto IL_02A8;
				IL_0061:
				extensionDataSetter = new ExtensionDataSetter(CS$<>8__locals2.method_0);
				goto IL_0070;
				IL_0289:
				CS$<>8__locals1.memberInfo_0 = memberInfo_0;
				num = 9;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 != 0)
				{
					goto IL_0061;
				}
				goto IL_02A8;
			}
			goto IL_0374;
			Block_2:
			return;
			Block_4:
			IL_036A:
			DefaultContractResolver.<>c__DisplayClass45_2 CS$<>8__locals3 = new DefaultContractResolver.<>c__DisplayClass45_2();
			IL_0374:
			CS$<>8__locals3.<>c__DisplayClass45_0_0 = CS$<>8__locals1;
			IL_037D:
			ConstructorInfo constructorInfo = typeof(DefaultContractResolver.EnumerableDictionaryWrapper<, >).MakeGenericType(new Type[] { type2, type3 }).GetConstructors().First<ConstructorInfo>();
			IL_03A8:
			CS$<>8__locals3.objectConstructor_0 = JsonTypeReflector.ReflectionDelegateFactory.CreateParameterizedConstructor(constructorInfo);
			IL_03BB:
			ExtensionDataGetter extensionDataGetter = new ExtensionDataGetter(CS$<>8__locals3.method_0);
			IL_03CA:
			jsonObjectContract_0.ExtensionDataGetter = extensionDataGetter;
			IL_03D2:
			jsonObjectContract_0.ExtensionDataValueType = type3;
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x00053D60 File Offset: 0x00051F60
		[return: Nullable(2)]
		private ConstructorInfo method_1(Type type_0)
		{
			for (;;)
			{
				IL_0001:
				IEnumerable<ConstructorInfo> constructors = type_0.GetConstructors(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
				Func<ConstructorInfo, bool> func;
				if ((func = DefaultContractResolver.<>c.func_4) == null)
				{
					func = (DefaultContractResolver.<>c.func_4 = new Func<ConstructorInfo, bool>(DefaultContractResolver.<>c.<>c_0.method_4));
				}
				IEnumerator<ConstructorInfo> enumerator = constructors.Where(func).GetEnumerator();
				for (;;)
				{
					int num;
					if (enumerator.MoveNext())
					{
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c == 0)
						{
							goto IL_0071;
						}
					}
					else
					{
						if (!(type_0 == typeof(Version)))
						{
							goto IL_0142;
						}
						num = 4;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f5329f120e842948536b8235793166c == 0)
						{
							goto Block_1;
						}
					}
					IL_007C:
					ConstructorInfo constructorInfo;
					switch (num)
					{
					case 0:
						goto IL_0071;
					case 1:
						return constructorInfo;
					case 2:
						goto IL_00E6;
					case 3:
						break;
					case 4:
						goto IL_0101;
					case 5:
						continue;
					case 6:
						goto IL_0001;
					default:
						goto IL_0071;
					}
					IL_0051:
					if (enumerator.MoveNext())
					{
						goto IL_00E6;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f77f8ab5a3534e2e914063d52217b4e1 == 0)
					{
						return constructorInfo;
					}
					goto IL_007C;
					IL_0071:
					constructorInfo = enumerator.Current;
					goto IL_0051;
				}
			}
			Block_1:
			goto IL_0101;
			IL_00E6:
			throw new JsonException(Class15.smethod_17(1270990748 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112));
			IL_0101:
			return type_0.GetConstructor(new Type[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			});
			IL_0142:
			return null;
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x00053EB0 File Offset: 0x000520B0
		[return: Nullable(2)]
		private ConstructorInfo method_2(Type type_0, JsonPropertyCollection jsonPropertyCollection_0)
		{
			ConstructorInfo constructorInfo;
			for (;;)
			{
				IL_0182:
				IEnumerator<ConstructorInfo> enumerator = ((IEnumerable<ConstructorInfo>)type_0.GetConstructors()).GetEnumerator();
				IL_0173:
				while (enumerator.MoveNext())
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_253407eb812c4aefb734fa1e267fe779 == 0)
					{
						goto IL_0110;
					}
					ParameterInfo[] parameters;
					for (;;)
					{
						IL_011B:
						switch (num)
						{
						case 1:
						case 10:
							goto IL_0064;
						case 2:
							goto IL_0101;
						case 3:
							goto IL_00E1;
						case 4:
							goto IL_00AB;
						case 5:
						case 8:
							goto IL_019E;
						case 6:
							goto IL_0037;
						case 7:
						case 14:
							goto IL_006D;
						case 9:
							return constructorInfo;
						case 11:
						case 12:
							goto IL_019C;
						case 13:
							if (parameters.Length != 0)
							{
								goto IL_0095;
							}
							num = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 == 0)
							{
								goto Block_7;
							}
							continue;
						case 15:
							goto IL_0095;
						case 16:
							goto IL_0173;
						case 17:
							goto IL_0182;
						case 18:
							goto IL_003B;
						case 19:
							goto IL_0020;
						}
						break;
						IL_006D:
						int num2;
						ParameterInfo[] array;
						if (num2 >= array.Length)
						{
							return constructorInfo;
						}
						num = 10;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6f87b5b72b9847f7b8ec5b44b0dccfa8 != 0)
						{
							goto IL_0064;
						}
						continue;
						IL_003B:
						JsonProperty jsonProperty;
						if (!jsonProperty.Writable)
						{
							num2++;
							goto IL_006D;
						}
						goto IL_019C;
						IL_0037:
						if (jsonProperty != null)
						{
							goto IL_003B;
						}
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a != 0)
						{
							goto Block_4;
						}
						continue;
						IL_0020:
						ParameterInfo parameterInfo;
						jsonProperty = this.method_4(jsonPropertyCollection_0, parameterInfo.Name, parameterInfo.ParameterType);
						goto IL_0037;
						IL_0064:
						parameterInfo = array[num2];
						goto IL_0020;
						IL_0095:
						array = parameters;
						num = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff != 0)
						{
							continue;
						}
						IL_00AB:
						num2 = 0;
						num = 14;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d == 0)
						{
							goto Block_5;
						}
					}
					goto IL_0110;
					IL_00E1:
					parameters = constructorInfo.GetParameters();
					num = 13;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d == 0)
					{
						goto Block_8;
					}
					goto IL_011B;
					IL_0101:
					if (enumerator.MoveNext())
					{
						break;
					}
					goto IL_00E1;
					IL_0110:
					constructorInfo = enumerator.Current;
					goto IL_0101;
				}
				goto IL_019E;
			}
			Block_4:
			goto IL_019C;
			Block_5:
			return constructorInfo;
			Block_7:
			goto IL_019E;
			Block_8:
			goto IL_019C;
			goto IL_019E;
			IL_019C:
			return null;
			IL_019E:
			return null;
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x0005405C File Offset: 0x0005225C
		[return: Nullable(2)]
		private ConstructorInfo method_3(Type type_0)
		{
			ConstructorInfo[] constructors;
			for (;;)
			{
				IL_002F:
				constructors = type_0.GetConstructors(BindingFlags.Instance | BindingFlags.Public);
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8bcabc342a5a44748f3978da7f62051e == 0)
				{
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						if (constructors.Length != 1)
						{
							goto IL_0053;
						}
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 == 0)
						{
							continue;
						}
						break;
					case 2:
						goto IL_002F;
					}
					goto Block_2;
				}
			}
			Block_2:
			return constructors[0];
			IL_0053:
			return null;
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x000540C0 File Offset: 0x000522C0
		protected virtual IList<JsonProperty> CreateConstructorParameters(ConstructorInfo constructor, JsonPropertyCollection memberProperties)
		{
			ParameterInfo[] parameters = constructor.GetParameters();
			JsonPropertyCollection jsonPropertyCollection = new JsonPropertyCollection(constructor.DeclaringType);
			foreach (ParameterInfo parameterInfo in parameters)
			{
				if (parameterInfo.Name != null)
				{
					JsonProperty jsonProperty = this.method_4(memberProperties, parameterInfo.Name, parameterInfo.ParameterType);
					if (jsonProperty != null || parameterInfo.Name != null)
					{
						JsonProperty jsonProperty2 = this.CreatePropertyFromConstructorParameter(jsonProperty, parameterInfo);
						if (jsonProperty2 != null)
						{
							jsonPropertyCollection.AddProperty(jsonProperty2);
						}
					}
				}
			}
			return jsonPropertyCollection;
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x00054134 File Offset: 0x00052334
		[return: Nullable(2)]
		private JsonProperty method_4(JsonPropertyCollection jsonPropertyCollection_0, string string_1, Type type_0)
		{
			JsonProperty closestMatchProperty;
			for (;;)
			{
				if (string_1 != null)
				{
					closestMatchProperty = jsonPropertyCollection_0.GetClosestMatchProperty(string_1);
					goto IL_0066;
				}
				int num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb == 0)
				{
					goto Block_5;
				}
				IL_002E:
				switch (num)
				{
				case 1:
				case 2:
					goto IL_0096;
				case 3:
					goto IL_0090;
				case 4:
					continue;
				case 5:
					goto IL_000E;
				case 6:
					IL_0066:
					if (closestMatchProperty != null)
					{
						goto IL_000E;
					}
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 == 0)
					{
						goto IL_002E;
					}
					break;
				}
				break;
				IL_000E:
				if (closestMatchProperty.PropertyType != type_0)
				{
					goto IL_0096;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b != 0)
				{
					goto IL_002E;
				}
				break;
			}
			return closestMatchProperty;
			Block_5:
			goto IL_0096;
			IL_0090:
			return null;
			IL_0096:
			return null;
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x000541D8 File Offset: 0x000523D8
		protected virtual JsonProperty CreatePropertyFromConstructorParameter([Nullable(2)] JsonProperty matchingMemberProperty, ParameterInfo parameterInfo)
		{
			JsonProperty jsonProperty;
			for (;;)
			{
				IL_026D:
				jsonProperty = new JsonProperty();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_afb77be96d644a2297c7f9466cb06ede == 0)
				{
					goto IL_0165;
				}
				do
				{
					IL_020E:
					switch (num)
					{
					case 1:
					{
						JsonProperty jsonProperty2 = jsonProperty;
						DefaultValueHandling? defaultValueHandling = jsonProperty.DefaultValueHandling;
						jsonProperty2.DefaultValueHandling = ((defaultValueHandling == null) ? matchingMemberProperty.DefaultValueHandling : defaultValueHandling);
						num = 19;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 != 0)
						{
							continue;
						}
						goto IL_028B;
					}
					case 2:
						goto IL_0030;
					case 3:
						goto IL_01BB;
					case 4:
						goto IL_0075;
					case 5:
						goto IL_000E;
					case 6:
						goto IL_00AF;
					case 7:
						jsonProperty.Readable = false;
						goto IL_01BB;
					case 8:
					case 10:
						return jsonProperty;
					case 9:
						goto IL_00D9;
					case 11:
						goto IL_0172;
					case 12:
						goto IL_017F;
					case 13:
						goto IL_02B2;
					case 14:
						goto IL_0106;
					case 15:
						goto IL_0052;
					case 16:
						goto IL_0165;
					case 17:
						goto IL_026D;
					case 18:
						goto IL_028F;
					case 19:
					{
						JsonProperty jsonProperty3 = jsonProperty;
						ReferenceLoopHandling? referenceLoopHandling = jsonProperty.ReferenceLoopHandling;
						jsonProperty3.ReferenceLoopHandling = ((referenceLoopHandling == null) ? matchingMemberProperty.ReferenceLoopHandling : referenceLoopHandling);
						num = 15;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5e301544981d4903aa4e531970a47849 == 0)
						{
							goto Block_10;
						}
						continue;
					}
					case 20:
						goto IL_0006;
					}
					break;
					IL_01BB:
					jsonProperty.Writable = true;
					num = 0;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_186d640068094cc595a341ef95c9a29a == 0);
				goto IL_011F;
				IL_000E:
				jsonProperty.DefaultValue = matchingMemberProperty.DefaultValue;
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e == 0)
				{
					goto IL_0030;
				}
				goto IL_020E;
				IL_0006:
				if (matchingMemberProperty._hasExplicitDefaultValue)
				{
					goto IL_000E;
				}
				goto IL_0030;
				IL_0106:
				if (!jsonProperty._hasExplicitDefaultValue)
				{
					goto IL_0006;
				}
				goto IL_0030;
				IL_0075:
				JsonProperty jsonProperty4 = jsonProperty;
				NullValueHandling? nullValueHandling = jsonProperty.NullValueHandling;
				jsonProperty4.NullValueHandling = ((nullValueHandling == null) ? matchingMemberProperty.NullValueHandling : nullValueHandling);
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a == 0)
				{
					goto IL_011F;
				}
				goto IL_020E;
				IL_0052:
				JsonProperty jsonProperty5 = jsonProperty;
				bool? isReference = jsonProperty.IsReference;
				jsonProperty5.IsReference = ((isReference == null) ? matchingMemberProperty.IsReference : isReference);
				goto IL_0075;
				IL_0030:
				JsonProperty jsonProperty6 = jsonProperty;
				Required? required = jsonProperty._required;
				jsonProperty6._required = ((required != null) ? required : matchingMemberProperty._required);
				goto IL_0052;
				IL_00D9:
				jsonProperty.Converter = jsonProperty.Converter ?? matchingMemberProperty.Converter;
				num = 14;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af == 0)
				{
					goto IL_0106;
				}
				goto IL_020E;
				IL_00AF:
				jsonProperty.PropertyName = ((!(jsonProperty.PropertyName != parameterInfo.Name)) ? matchingMemberProperty.PropertyName : jsonProperty.PropertyName);
				goto IL_00D9;
				IL_011F:
				if (matchingMemberProperty == null)
				{
					break;
				}
				goto IL_00AF;
				IL_017F:
				bool flag;
				this.method_10(jsonProperty, parameterInfo, parameterInfo.Name, parameterInfo.Member.DeclaringType, MemberSerialization.OptOut, out flag);
				num = 7;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 == 0)
				{
					goto IL_0075;
				}
				goto IL_020E;
				IL_0172:
				jsonProperty.AttributeProvider = new ReflectionAttributeProvider(parameterInfo);
				goto IL_017F;
				IL_0165:
				jsonProperty.PropertyType = parameterInfo.ParameterType;
				goto IL_0172;
			}
			return jsonProperty;
			Block_10:
			goto IL_028F;
			IL_028B:
			return jsonProperty;
			IL_028F:
			JsonProperty jsonProperty7 = jsonProperty;
			ObjectCreationHandling? objectCreationHandling = jsonProperty.ObjectCreationHandling;
			jsonProperty7.ObjectCreationHandling = ((objectCreationHandling == null) ? matchingMemberProperty.ObjectCreationHandling : objectCreationHandling);
			IL_02B2:
			JsonProperty jsonProperty8 = jsonProperty;
			TypeNameHandling? typeNameHandling = jsonProperty.TypeNameHandling;
			jsonProperty8.TypeNameHandling = ((typeNameHandling != null) ? typeNameHandling : matchingMemberProperty.TypeNameHandling);
			return jsonProperty;
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x000048AA File Offset: 0x00002AAA
		[return: Nullable(2)]
		protected virtual JsonConverter ResolveContractConverter(Type objectType)
		{
			return JsonTypeReflector.GetJsonConverter(objectType);
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x000048B2 File Offset: 0x00002AB2
		private Func<object> method_5(Type type_0)
		{
			return JsonTypeReflector.ReflectionDelegateFactory.CreateDefaultConstructor<object>(type_0);
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x000544BC File Offset: 0x000526BC
		private void method_6(JsonContract jsonContract_0)
		{
			for (;;)
			{
				IL_0157:
				JsonContainerAttribute cachedAttribute = JsonTypeReflector.GetCachedAttribute<JsonContainerAttribute>(jsonContract_0.NonNullableUnderlyingType);
				int num = 10;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff == 0)
				{
					goto IL_00E5;
				}
				for (;;)
				{
					IL_00F4:
					switch (num)
					{
					case 0:
						goto IL_0052;
					case 1:
					case 4:
						goto IL_0184;
					case 2:
					case 12:
					case 19:
						goto IL_01BD;
					case 3:
						return;
					case 5:
						goto IL_00E5;
					case 6:
						goto IL_0196;
					case 7:
					case 14:
					case 18:
						goto IL_0080;
					case 8:
					case 20:
						break;
					case 9:
						goto IL_0077;
					case 10:
						if (cachedAttribute != null)
						{
							goto IL_00E5;
						}
						break;
					case 11:
						goto IL_0157;
					case 13:
						goto IL_00A8;
					case 15:
						goto IL_0092;
					case 16:
						goto IL_0059;
					case 17:
						goto IL_00C7;
					case 21:
						goto IL_0006;
					default:
						goto IL_0052;
					}
					DataContractAttribute dataContractAttribute = JsonTypeReflector.GetDataContractAttribute(jsonContract_0.NonNullableUnderlyingType);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_253407eb812c4aefb734fa1e267fe779 == 0)
					{
						goto IL_0052;
					}
					continue;
					IL_0059:
					jsonContract_0.IsReference = new bool?(true);
					num = 18;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf != 0)
					{
						continue;
					}
					IL_0077:
					if (!dataContractAttribute.IsReference)
					{
						goto IL_0080;
					}
					goto IL_0059;
					IL_0052:
					if (dataContractAttribute != null)
					{
						goto IL_0077;
					}
					goto IL_0080;
				}
				IL_0006:
				if (jsonContract_0.CreatedType.IsValueType())
				{
					goto IL_0184;
				}
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 == 0)
				{
					break;
				}
				goto IL_00F4;
				IL_00C7:
				if (ReflectionUtils.HasDefaultConstructor(jsonContract_0.CreatedType, true))
				{
					goto Block_6;
				}
				goto IL_0006;
				IL_00A8:
				if (jsonContract_0.IsInstantiable)
				{
					goto IL_00C7;
				}
				num = 12;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7 == 0)
				{
					break;
				}
				goto IL_00F4;
				IL_0092:
				jsonContract_0.InternalConverter = JsonSerializer.GetMatchingConverter(DefaultContractResolver.jsonConverter_0, jsonContract_0.NonNullableUnderlyingType);
				goto IL_00A8;
				IL_0080:
				jsonContract_0.Converter = this.ResolveContractConverter(jsonContract_0.NonNullableUnderlyingType);
				goto IL_0092;
				IL_00E5:
				jsonContract_0.IsReference = cachedAttribute._isReference;
				goto IL_0080;
			}
			goto IL_01BD;
			Block_6:
			IL_0184:
			jsonContract_0.DefaultCreator = this.method_5(jsonContract_0.CreatedType);
			IL_0196:
			jsonContract_0.DefaultCreatorNonPublic = !jsonContract_0.CreatedType.IsValueType() && ReflectionUtils.GetDefaultConstructor(jsonContract_0.CreatedType) == null;
			IL_01BD:
			this.method_7(jsonContract_0, jsonContract_0.NonNullableUnderlyingType);
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x00054694 File Offset: 0x00052894
		private void method_7(JsonContract jsonContract_0, Type type_0)
		{
			List<SerializationCallback> list4;
			List<SerializationErrorCallback> list5;
			for (;;)
			{
				List<SerializationCallback> list;
				List<SerializationCallback> list2;
				List<SerializationCallback> list3;
				this.method_8(type_0, out list, out list2, out list3, out list4, out list5);
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c == 0)
				{
					goto IL_0031;
				}
				IL_00A0:
				switch (num)
				{
				case 0:
					goto IL_0047;
				case 1:
					goto IL_010C;
				case 2:
					goto IL_0066;
				case 3:
					goto IL_007C;
				case 4:
					IL_0031:
					if (list == null)
					{
						goto IL_0066;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 == 0)
					{
						goto IL_0047;
					}
					goto IL_00A0;
				case 5:
					continue;
				case 6:
				case 9:
					goto IL_011D;
				case 7:
				case 11:
					return;
				case 8:
					break;
				case 10:
					goto IL_0121;
				case 12:
					goto IL_0110;
				case 13:
					goto IL_0006;
				default:
					goto IL_0047;
				}
				IL_000D:
				jsonContract_0.OnDeserializingCallbacks.AddRange(list3);
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af == 0)
				{
					break;
				}
				goto IL_00A0;
				IL_0006:
				if (list3 != null)
				{
					goto IL_000D;
				}
				break;
				IL_0066:
				if (list2 == null)
				{
					goto IL_0006;
				}
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b == 0)
				{
					goto IL_007C;
				}
				goto IL_00A0;
				IL_0047:
				jsonContract_0.OnSerializingCallbacks.AddRange(list);
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54 != 0)
				{
					goto IL_0066;
				}
				goto IL_00A0;
				IL_007C:
				jsonContract_0.OnSerializedCallbacks.AddRange(list2);
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 == 0)
				{
					goto IL_0006;
				}
				goto IL_00A0;
			}
			IL_010C:
			if (list4 == null)
			{
				goto IL_011D;
			}
			IL_0110:
			jsonContract_0.OnDeserializedCallbacks.AddRange(list4);
			IL_011D:
			if (list5 == null)
			{
				return;
			}
			IL_0121:
			jsonContract_0.OnErrorCallbacks.AddRange(list5);
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x000547D0 File Offset: 0x000529D0
		private void method_8(Type type_0, [Nullable(new byte[] { 2, 1 })] out List<SerializationCallback> onSerializing, [Nullable(new byte[] { 2, 1 })] out List<SerializationCallback> onSerialized, [Nullable(new byte[] { 2, 1 })] out List<SerializationCallback> onDeserializing, [Nullable(new byte[] { 2, 1 })] out List<SerializationCallback> onDeserialized, [Nullable(new byte[] { 2, 1 })] out List<SerializationErrorCallback> onError)
		{
			for (;;)
			{
				IL_007C:
				onSerializing = null;
				int num = 5;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a == 0)
				{
					goto IL_0034;
				}
				for (;;)
				{
					IL_0051:
					switch (num)
					{
					case 1:
						goto IL_0093;
					case 2:
						goto IL_00A4;
					case 3:
						onDeserializing = null;
						goto IL_0003;
					case 4:
						goto IL_0019;
					case 5:
						goto IL_0034;
					case 6:
						goto IL_007C;
					case 7:
						goto IL_0003;
					}
					goto Block_3;
					IL_0003:
					onDeserialized = null;
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 != 0)
					{
						continue;
					}
					IL_0019:
					onError = null;
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a != 0)
					{
						goto Block_1;
					}
				}
				IL_0034:
				onSerialized = null;
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 == 0)
				{
					goto Block_2;
				}
				goto IL_0051;
			}
			Block_1:
			return;
			Block_2:
			goto IL_00A4;
			Block_3:
			return;
			IL_0093:
			List<Type>.Enumerator enumerator = this.method_9(type_0).GetEnumerator();
			IL_00A4:
			try
			{
				IL_0423:
				while (enumerator.MoveNext())
				{
					for (;;)
					{
						IL_03F2:
						Type type = enumerator.Current;
						MethodInfo methodInfo = null;
						MethodInfo methodInfo2 = null;
						MethodInfo methodInfo3 = null;
						MethodInfo methodInfo4 = null;
						MethodInfo methodInfo5 = null;
						bool flag = DefaultContractResolver.kBgdgYtYyq(type);
						bool flag2 = DefaultContractResolver.smethod_4(type);
						MethodInfo[] methods = type.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
						for (;;)
						{
							IL_03D5:
							int num2 = 0;
							int num3 = 4;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4ac69ea2381b403582a2723337f67fa8 == 0)
							{
								goto IL_015C;
							}
							MethodInfo methodInfo6;
							for (;;)
							{
								IL_0336:
								switch (num3)
								{
								case 1:
									goto IL_026C;
								case 2:
									goto IL_03F2;
								case 3:
									goto IL_02BD;
								case 4:
								case 11:
									goto IL_0130;
								case 5:
									goto IL_0168;
								case 6:
									methodInfo4 = methodInfo6;
									num3 = 13;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a == 0)
									{
										goto Block_23;
									}
									continue;
								case 7:
									onDeserialized = onDeserialized ?? new List<SerializationCallback>();
									num3 = 8;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e != 0)
									{
										goto IL_02CF;
									}
									continue;
								case 8:
								case 21:
									goto IL_021B;
								case 9:
									goto IL_013B;
								case 10:
									goto IL_01A9;
								case 12:
									goto IL_02F2;
								case 13:
									goto IL_00ED;
								case 14:
									goto IL_01B7;
								case 15:
								case 29:
									goto IL_023B;
								case 16:
									goto IL_019C;
								case 17:
								case 30:
									goto IL_029F;
								case 18:
									goto IL_01EB;
								case 19:
									goto IL_0118;
								case 20:
									goto IL_0127;
								case 22:
									goto IL_01F8;
								case 23:
									goto IL_02A9;
								case 24:
									goto IL_016C;
								case 25:
									goto IL_02CF;
								case 26:
									goto IL_0109;
								case 27:
									goto IL_00CF;
								case 28:
									goto IL_0423;
								case 31:
								case 32:
									goto IL_01D2;
								case 33:
									goto IL_03D5;
								case 34:
									goto IL_015F;
								case 35:
									goto IL_042C;
								case 36:
									goto IL_00AB;
								}
								goto Block_24;
								IL_02CF:
								onDeserialized.Add(JsonContract.CreateSerializationCallback(methodInfo6));
								num3 = 6;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 != 0)
								{
									goto Block_20;
								}
							}
							IL_02F2:
							methodInfo2 = methodInfo6;
							goto IL_023B;
							Block_24:
							goto IL_015C;
							Block_23:
							Block_20:
							goto IL_02BD;
							IL_00AB:
							onDeserializing.Add(JsonContract.CreateSerializationCallback(methodInfo6));
							num3 = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 == 0)
							{
								goto IL_00CF;
							}
							goto IL_0336;
							IL_02A9:
							onDeserializing = onDeserializing ?? new List<SerializationCallback>();
							goto IL_00AB;
							IL_023B:
							ParameterInfo[] parameters;
							Type type2;
							if (!DefaultContractResolver.smethod_5(methodInfo6, parameters, typeof(OnDeserializingAttribute), methodInfo3, ref type2))
							{
								goto IL_029F;
							}
							goto IL_02A9;
							IL_00CF:
							methodInfo3 = methodInfo6;
							num3 = 16;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 != 0)
							{
								goto IL_029F;
							}
							goto IL_0336;
							IL_016C:
							if (DefaultContractResolver.smethod_5(methodInfo6, parameters, typeof(OnSerializingAttribute), methodInfo, ref type2))
							{
								goto IL_019C;
							}
							num3 = 2;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_52d717cd31b74287b67c03ee736a6211 == 0)
							{
								goto IL_01D2;
							}
							goto IL_0336;
							IL_0168:
							if (!flag)
							{
								goto IL_016C;
							}
							goto IL_01D2;
							IL_015F:
							parameters = methodInfo6.GetParameters();
							goto IL_0168;
							IL_015C:
							type2 = null;
							goto IL_015F;
							IL_01B7:
							methodInfo = methodInfo6;
							num3 = 32;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 != 0)
							{
								goto IL_01EB;
							}
							goto IL_0336;
							IL_01A9:
							onSerializing.Add(JsonContract.CreateSerializationCallback(methodInfo6));
							goto IL_01B7;
							IL_019C:
							onSerializing = onSerializing ?? new List<SerializationCallback>();
							goto IL_01A9;
							IL_01F8:
							onSerialized.Add(JsonContract.CreateSerializationCallback(methodInfo6));
							num3 = 12;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3 == 0)
							{
								goto IL_021B;
							}
							goto IL_0336;
							IL_01EB:
							onSerialized = onSerialized ?? new List<SerializationCallback>();
							goto IL_01F8;
							IL_01D2:
							if (DefaultContractResolver.smethod_5(methodInfo6, parameters, typeof(OnSerializedAttribute), methodInfo2, ref type2))
							{
								goto IL_01EB;
							}
							num3 = 14;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 != 0)
							{
								goto IL_023B;
							}
							goto IL_0336;
							IL_026C:
							if (!DefaultContractResolver.smethod_5(methodInfo6, parameters, typeof(OnDeserializedAttribute), methodInfo4, ref type2))
							{
								goto IL_00ED;
							}
							num3 = 7;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f != 0)
							{
								goto IL_02BD;
							}
							goto IL_0336;
							IL_029F:
							if (flag2)
							{
								goto IL_00ED;
							}
							num3 = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cbfb1e54efd84756a9b6d7b21adc0d65 == 0)
							{
								goto IL_026C;
							}
							goto IL_0336;
							IL_02BD:
							if (methodInfo6.ContainsGenericParameters)
							{
								goto IL_021B;
							}
							num3 = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 == 0)
							{
								goto IL_015C;
							}
							goto IL_0336;
							IL_013B:
							methodInfo6 = methods[num2];
							goto IL_02BD;
							IL_0130:
							if (num2 < methods.Length)
							{
								goto IL_013B;
							}
							goto IL_0423;
							IL_021B:
							num2++;
							goto IL_0130;
							IL_0127:
							methodInfo5 = methodInfo6;
							goto IL_021B;
							IL_0118:
							onError.Add(JsonContract.CreateSerializationErrorCallback(methodInfo6));
							goto IL_0127;
							IL_0109:
							onError = onError ?? new List<SerializationErrorCallback>();
							goto IL_0118;
							IL_00ED:
							if (DefaultContractResolver.smethod_5(methodInfo6, parameters, typeof(OnErrorAttribute), methodInfo5, ref type2))
							{
								goto IL_0109;
							}
							goto IL_021B;
						}
					}
				}
				IL_042C:;
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
				int num4 = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 == 0)
				{
					switch (num4)
					{
					}
				}
			}
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x00054C54 File Offset: 0x00052E54
		private static bool smethod_3(Type type_0)
		{
			string fullName;
			for (;;)
			{
				if (type_0.IsGenericType())
				{
					goto IL_0003;
				}
				int num = 7;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 == 0)
				{
					goto IL_007A;
				}
				IL_0024:
				switch (num)
				{
				case 1:
					goto IL_0080;
				case 2:
				case 6:
				case 10:
					return true;
				case 3:
					goto IL_00BC;
				case 4:
					goto IL_00DA;
				case 5:
					goto IL_009E;
				case 7:
					IL_0003:
					fullName = type_0.GetGenericTypeDefinition().FullName;
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5be00c24d71649dcae8af3eed7b74ac9 == 0)
					{
						goto IL_0024;
					}
					break;
				case 8:
					return false;
				case 9:
					continue;
				}
				break;
			}
			goto IL_00FC;
			IL_007A:
			return false;
			IL_0080:
			if (fullName == Class15.smethod_17(1743179410 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8))
			{
				return true;
			}
			IL_009E:
			if (fullName == Class15.smethod_17(649978242 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff))
			{
				return true;
			}
			IL_00BC:
			if (fullName == Class15.smethod_17(2071426744 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808))
			{
				return true;
			}
			IL_00DA:
			if (fullName == Class15.smethod_17(1807892554 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c5a086ee5649458eb5e1e6e4f0f1f4d3))
			{
				return true;
			}
			IL_00FC:
			if (fullName == Class15.smethod_17(1042118741 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39a47a907a8a440980940ae96da3f3ad))
			{
				return true;
			}
			return false;
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x00054D80 File Offset: 0x00052F80
		private static bool smethod_4(Type type_0)
		{
			IL_0093:
			while (!DefaultContractResolver.smethod_3(type_0))
			{
				while (!(type_0.Name == Class15.smethod_17(1270995212 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112)))
				{
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb == 0)
					{
						goto IL_0018;
					}
					IL_004B:
					switch (num)
					{
					case 1:
						IL_0018:
						if (type_0.Name == Class15.smethod_17(1603815064 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c))
						{
							return true;
						}
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff != 0)
						{
							goto IL_004B;
						}
						break;
					case 2:
						return true;
					case 3:
						continue;
					case 4:
						goto IL_0093;
					case 5:
						return true;
					}
					return false;
				}
				return true;
			}
			return true;
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x00054E34 File Offset: 0x00053034
		private static bool kBgdgYtYyq(Type type_0)
		{
			for (;;)
			{
				int num;
				if (DefaultContractResolver.smethod_3(type_0))
				{
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 == 0)
					{
						return true;
					}
				}
				else
				{
					if (type_0.Name == Class15.smethod_17(1788756225 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c))
					{
						return true;
					}
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9bd9937edf9d4ad8bd673dfcb5a5e3cb == 0)
					{
						break;
					}
				}
				switch (num)
				{
				case 1:
					return true;
				case 2:
					continue;
				case 3:
					return true;
				}
				break;
			}
			if (!(type_0.Name == Class15.smethod_17(2048540799 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18)))
			{
				return false;
			}
			return true;
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x00054ED8 File Offset: 0x000530D8
		private List<Type> method_9(Type type_0)
		{
			List<Type> list = new List<Type>();
			Type type = type_0;
			while (type != null && type != typeof(object))
			{
				list.Add(type);
				type = type.BaseType();
			}
			list.Reverse();
			return list;
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x00054F20 File Offset: 0x00053120
		protected virtual JsonDictionaryContract CreateDictionaryContract(Type objectType)
		{
			JsonDictionaryContract jsonDictionaryContract;
			ParameterInfo[] parameters;
			Type type3;
			ConstructorInfo constructorInfo;
			for (;;)
			{
				IL_0249:
				jsonDictionaryContract = new JsonDictionaryContract(objectType);
				for (;;)
				{
					IL_023F:
					this.method_6(jsonDictionaryContract);
					for (;;)
					{
						IL_0235:
						JsonContainerAttribute attribute = JsonTypeReflector.GetAttribute<JsonContainerAttribute>(objectType);
						for (;;)
						{
							if (attribute != null)
							{
								goto IL_01FD;
							}
							goto IL_022B;
							IL_0220:
							Type type;
							if (!(type != null))
							{
								goto IL_01E7;
							}
							int num = 0;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 == 0)
							{
								goto IL_0063;
							}
							goto IL_0121;
							do
							{
								IL_0020:
								jsonDictionaryContract.HasParameterizedCreator = false;
								num = 10;
							}
							while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cb7e1ff8cc1348bebf46c510e64a0134 != 0);
							IL_0121:
							DefaultContractResolver.<>c__DisplayClass62_0 CS$<>8__locals1;
							switch (num)
							{
							case 0:
								goto IL_0063;
							case 1:
								goto IL_008E;
							case 2:
								goto IL_007F;
							case 3:
								IL_01FD:
								type = attribute.NamingStrategyType;
								goto IL_0220;
							case 4:
								goto IL_0101;
							case 5:
								goto IL_0020;
							case 6:
								goto IL_025A;
							case 7:
								goto IL_026C;
							case 8:
								goto IL_0289;
							case 9:
								goto IL_00F4;
							case 10:
							case 18:
								goto IL_0274;
							case 11:
								IL_01E7:
								jsonDictionaryContract.DictionaryKeyResolver = new Func<string, string>(this.ResolveDictionaryKey);
								goto IL_01BE;
							case 12:
							case 25:
								goto IL_01BE;
							case 13:
							case 14:
								return jsonDictionaryContract;
							case 15:
							case 26:
								goto IL_0253;
							case 16:
								goto IL_003F;
							case 17:
								IL_0006:
								if (parameters.Length == 0)
								{
									goto IL_0020;
								}
								num = 15;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a == 0)
								{
									goto IL_0020;
								}
								goto IL_0121;
							case 19:
								CS$<>8__locals1.namingStrategy_0 = JsonTypeReflector.GetContainerNamingStrategy(attribute);
								break;
							case 20:
								IL_022B:
								type = null;
								goto IL_0220;
							case 21:
								continue;
							case 22:
								break;
							case 23:
								goto IL_023F;
							case 24:
								goto IL_0249;
							case 27:
								goto IL_0235;
							default:
								goto IL_0063;
							}
							jsonDictionaryContract.DictionaryKeyResolver = new Func<string, string>(CS$<>8__locals1.method_0);
							goto IL_01BE;
							IL_003F:
							Type type2;
							if (jsonDictionaryContract.DictionaryValueType != null)
							{
								type2 = typeof(IEnumerable<>).MakeGenericType(new Type[] { typeof(KeyValuePair<, >).MakeGenericType(new Type[] { jsonDictionaryContract.DictionaryKeyType, jsonDictionaryContract.DictionaryValueType }) });
								goto IL_00DB;
							}
							num = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b != 0)
							{
								goto IL_0063;
							}
							goto IL_0121;
							IL_007F:
							if (!(jsonDictionaryContract.DictionaryKeyType != null))
							{
								goto IL_008E;
							}
							goto IL_003F;
							IL_0063:
							CS$<>8__locals1 = new DefaultContractResolver.<>c__DisplayClass62_0();
							num = 19;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba == 0)
							{
								goto IL_007F;
							}
							goto IL_0121;
							IL_00DB:
							type3 = type2;
							num = 9;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d6c400f349964629bcd869033695bff0 == 0)
							{
								goto IL_0006;
							}
							goto IL_0121;
							IL_008E:
							type2 = typeof(IDictionary);
							goto IL_00DB;
							IL_0101:
							parameters = constructorInfo.GetParameters();
							num = 2;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa != 0)
							{
								goto IL_0063;
							}
							goto IL_0121;
							IL_00F4:
							if (constructorInfo != null)
							{
								goto IL_0101;
							}
							return jsonDictionaryContract;
							IL_01BE:
							constructorInfo = this.method_1(jsonDictionaryContract.NonNullableUnderlyingType);
							num = 9;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_eaded84ad5b14e1ea8d4d97bfed1bb48 == 0)
							{
								goto IL_00F4;
							}
							goto IL_0121;
						}
					}
				}
			}
			IL_0253:
			if (parameters.Length != 1)
			{
				goto IL_0289;
			}
			IL_025A:
			if (!type3.IsAssignableFrom(parameters[0].ParameterType))
			{
				goto IL_0289;
			}
			IL_026C:
			jsonDictionaryContract.HasParameterizedCreator = true;
			IL_0274:
			jsonDictionaryContract.OverrideCreator = JsonTypeReflector.ReflectionDelegateFactory.CreateParameterizedConstructor(constructorInfo);
			return jsonDictionaryContract;
			IL_0289:
			throw new JsonException(Class15.smethod_17(1603814782 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c).FormatWith(CultureInfo.InvariantCulture, jsonDictionaryContract.UnderlyingType, type3));
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x000551E8 File Offset: 0x000533E8
		protected virtual JsonArrayContract CreateArrayContract(Type objectType)
		{
			JsonArrayContract jsonArrayContract;
			Type type;
			for (;;)
			{
				IL_019C:
				jsonArrayContract = new JsonArrayContract(objectType);
				for (;;)
				{
					IL_0192:
					this.method_6(jsonArrayContract);
					for (;;)
					{
						IL_016F:
						ConstructorInfo constructorInfo = this.method_1(jsonArrayContract.NonNullableUnderlyingType);
						int num = 8;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2 != 0)
						{
							for (;;)
							{
								ParameterInfo[] parameters;
								switch (num)
								{
								case 0:
									goto IL_0088;
								case 1:
									return jsonArrayContract;
								case 2:
									parameters = constructorInfo.GetParameters();
									goto IL_00A7;
								case 3:
									if (!type.IsAssignableFrom(parameters[0].ParameterType))
									{
										goto Block_7;
									}
									goto IL_0088;
								case 4:
									goto IL_00C8;
								case 5:
									goto IL_016F;
								case 6:
									goto IL_00A7;
								case 7:
								case 16:
									break;
								case 8:
									if (!(constructorInfo != null))
									{
										return jsonArrayContract;
									}
									num = 2;
									if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bca7529ca324c188cfc0e64eb7d1cdf == 0)
									{
										goto IL_0088;
									}
									continue;
								case 9:
									goto IL_0038;
								case 10:
								case 15:
									goto IL_01A9;
								case 11:
									goto IL_0192;
								case 12:
									goto IL_019C;
								case 13:
									goto IL_0042;
								case 14:
									IL_0033:
									if (parameters.Length == 0)
									{
										goto IL_0038;
									}
									goto IL_0042;
								default:
									goto IL_0088;
								}
								IL_0006:
								jsonArrayContract.OverrideCreator = JsonTypeReflector.ReflectionDelegateFactory.CreateParameterizedConstructor(constructorInfo);
								num = 1;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_991c06e999c744809f5b643cb7d9e7b4 == 0)
								{
									goto Block_1;
								}
								continue;
								IL_0038:
								jsonArrayContract.HasParameterizedCreator = false;
								goto IL_0006;
								IL_00F3:
								Type type2;
								type = type2;
								goto IL_0033;
								IL_00C8:
								type2 = typeof(IEnumerable);
								goto IL_00F3;
								IL_0042:
								if (parameters.Length != 1)
								{
									goto IL_01A9;
								}
								num = 3;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_676b866782704933888a7440512fd4ff != 0)
								{
									goto Block_3;
								}
								continue;
								IL_0088:
								jsonArrayContract.HasParameterizedCreator = true;
								num = 16;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e == 0)
								{
									goto IL_0006;
								}
								continue;
								IL_00A7:
								if (jsonArrayContract.CollectionItemType != null)
								{
									type2 = typeof(IEnumerable<>).MakeGenericType(new Type[] { jsonArrayContract.CollectionItemType });
									goto IL_00F3;
								}
								num = 1;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b == 0)
								{
									goto IL_00C8;
								}
							}
						}
					}
				}
			}
			Block_1:
			Block_3:
			return jsonArrayContract;
			Block_7:
			IL_01A9:
			throw new JsonException(Class15.smethod_17(538833411 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa).FormatWith(CultureInfo.InvariantCulture, jsonArrayContract.UnderlyingType, type));
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x000553D0 File Offset: 0x000535D0
		protected virtual JsonPrimitiveContract CreatePrimitiveContract(Type objectType)
		{
			JsonPrimitiveContract jsonPrimitiveContract;
			for (;;)
			{
				jsonPrimitiveContract = new JsonPrimitiveContract(objectType);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d != 0)
				{
					goto IL_001F;
				}
				do
				{
					IL_0003:
					this.method_6(jsonPrimitiveContract);
					num = 2;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 == 0);
				IL_001F:
				switch (num)
				{
				case 0:
					goto IL_0003;
				case 1:
					break;
				case 2:
					return jsonPrimitiveContract;
				default:
					goto IL_0003;
				}
			}
			return jsonPrimitiveContract;
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x00055430 File Offset: 0x00053630
		protected virtual JsonLinqContract CreateLinqContract(Type objectType)
		{
			JsonLinqContract jsonLinqContract;
			for (;;)
			{
				jsonLinqContract = new JsonLinqContract(objectType);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 != 0)
				{
					goto IL_0003;
				}
				IL_001C:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					return jsonLinqContract;
				}
				IL_0003:
				this.method_6(jsonLinqContract);
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 == 0)
				{
					goto IL_001C;
				}
				break;
			}
			return jsonLinqContract;
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x0005548C File Offset: 0x0005368C
		protected virtual JsonISerializableContract CreateISerializableContract(Type objectType)
		{
			JsonISerializableContract jsonISerializableContract;
			ObjectConstructor<object> objectConstructor;
			for (;;)
			{
				IL_00D5:
				jsonISerializableContract = new JsonISerializableContract(objectType);
				for (;;)
				{
					this.method_6(jsonISerializableContract);
					int num = 6;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f == 0)
					{
						goto IL_0038;
					}
					IL_008A:
					switch (num)
					{
					case 1:
						goto IL_00E3;
					case 2:
						goto IL_0059;
					case 3:
						continue;
					case 4:
						goto IL_00D5;
					case 5:
						goto IL_0038;
					case 6:
						if (jsonISerializableContract.IsInstantiable)
						{
							goto IL_0006;
						}
						break;
					case 7:
						goto IL_0006;
					}
					goto Block_5;
					IL_0006:
					ConstructorInfo constructor = jsonISerializableContract.NonNullableUnderlyingType.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[]
					{
						typeof(SerializationInfo),
						typeof(StreamingContext)
					}, null);
					IL_0038:
					if (!(constructor != null))
					{
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 == 0)
						{
							goto Block_2;
						}
						goto IL_008A;
					}
					IL_0059:
					objectConstructor = JsonTypeReflector.ReflectionDelegateFactory.CreateParameterizedConstructor(constructor);
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_43b8cdd768c545d884bf7ff1c8fefe89 == 0)
					{
						goto Block_3;
					}
					goto IL_008A;
				}
			}
			Block_2:
			return jsonISerializableContract;
			Block_3:
			goto IL_00E3;
			Block_5:
			return jsonISerializableContract;
			IL_00E3:
			jsonISerializableContract.ObjectConstructor_0 = objectConstructor;
			return jsonISerializableContract;
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x00055588 File Offset: 0x00053788
		protected virtual JsonDynamicContract CreateDynamicContract(Type objectType)
		{
			JsonDynamicContract jsonDynamicContract;
			JsonContainerAttribute attribute;
			for (;;)
			{
				jsonDynamicContract = new JsonDynamicContract(objectType);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 == 0)
				{
					goto IL_001F;
				}
				goto IL_0083;
				IL_0053:
				if (attribute == null)
				{
					goto IL_0057;
				}
				num = 8;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a == 0)
				{
					continue;
				}
				goto IL_0083;
				IL_0039:
				attribute = JsonTypeReflector.GetAttribute<JsonContainerAttribute>(objectType);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a == 0)
				{
					goto IL_0053;
				}
				goto IL_0083;
				IL_001F:
				this.method_6(jsonDynamicContract);
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_253407eb812c4aefb734fa1e267fe779 == 0)
				{
					goto IL_0039;
				}
				goto IL_0083;
				IL_0006:
				num = 10;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 == 0)
				{
					goto IL_001F;
				}
				goto IL_0083;
				IL_0058:
				Type type;
				if (type != null)
				{
					goto IL_0006;
				}
				goto IL_0103;
				IL_0057:
				type = null;
				goto IL_0058;
				IL_0083:
				switch (num)
				{
				case 0:
					goto IL_0053;
				case 1:
					goto IL_001F;
				case 2:
					break;
				case 3:
					goto IL_0057;
				case 4:
					return jsonDynamicContract;
				case 5:
					goto IL_00ED;
				case 6:
				case 12:
					goto IL_0117;
				case 7:
					goto IL_0103;
				case 8:
					type = attribute.NamingStrategyType;
					goto IL_0058;
				case 9:
					goto IL_0039;
				case 10:
					goto IL_00DF;
				case 11:
					goto IL_0006;
				default:
					goto IL_0053;
				}
			}
			IL_00DF:
			CS$<>8__locals1.namingStrategy_0 = JsonTypeReflector.GetContainerNamingStrategy(attribute);
			IL_00ED:
			jsonDynamicContract.PropertyNameResolver = new Func<string, string>(CS$<>8__locals1.method_0);
			goto IL_0117;
			IL_0103:
			jsonDynamicContract.PropertyNameResolver = new Func<string, string>(this.ResolveDictionaryKey);
			IL_0117:
			jsonDynamicContract.Properties.AddRange(this.CreateProperties(objectType, MemberSerialization.OptOut));
			return jsonDynamicContract;
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x000556C4 File Offset: 0x000538C4
		protected virtual JsonStringContract CreateStringContract(Type objectType)
		{
			JsonStringContract jsonStringContract;
			for (;;)
			{
				jsonStringContract = new JsonStringContract(objectType);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_cf58136e49114a5691c4a9d0e9788de1 != 0)
				{
					goto IL_0003;
				}
				IL_001C:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					return jsonStringContract;
				}
				IL_0003:
				this.method_6(jsonStringContract);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9bd9937edf9d4ad8bd673dfcb5a5e3cb != 0)
				{
					goto IL_001C;
				}
				break;
			}
			return jsonStringContract;
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x00055720 File Offset: 0x00053920
		protected virtual JsonContract CreateContract(Type objectType)
		{
			Type type;
			for (;;)
			{
				IL_0211:
				type = ReflectionUtils.EnsureNotByRefType(objectType);
				int num = 22;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 == 0)
				{
					goto IL_015A;
				}
				JsonContainerAttribute cachedAttribute;
				for (;;)
				{
					IL_0191:
					switch (num)
					{
					case 1:
						goto IL_010D;
					case 2:
						goto IL_0233;
					case 3:
						goto IL_0271;
					case 4:
						goto IL_00B1;
					case 5:
						goto IL_0257;
					case 6:
						goto IL_0279;
					case 7:
					case 21:
						goto IL_0291;
					case 8:
						goto IL_0260;
					case 9:
						goto IL_0247;
					case 10:
						goto IL_0031;
					case 11:
						goto IL_024F;
					case 12:
						goto IL_023C;
					case 13:
						goto IL_0289;
					case 14:
						goto IL_003D;
					case 15:
						goto IL_0268;
					case 16:
						goto IL_0074;
					case 17:
					case 22:
					case 23:
						goto IL_009B;
					case 18:
						goto IL_00E0;
					case 19:
						goto IL_0068;
					case 20:
						goto IL_007C;
					case 24:
						goto IL_015A;
					case 25:
						goto IL_0211;
					case 26:
						cachedAttribute = JsonTypeReflector.GetCachedAttribute<JsonContainerAttribute>(type);
						goto IL_00E0;
					case 27:
						goto IL_0281;
					case 28:
						goto IL_0006;
					}
					break;
					IL_00E0:
					if (cachedAttribute is JsonObjectAttribute)
					{
						goto IL_024F;
					}
					if (cachedAttribute is JsonArrayAttribute)
					{
						goto IL_0247;
					}
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95 != 0)
					{
						goto IL_010D;
					}
				}
				goto IL_008F;
				IL_0006:
				if (type.IsSubclassOf(typeof(JToken)))
				{
					goto IL_0291;
				}
				num = 8;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a != 0)
				{
					goto IL_0031;
				}
				goto IL_0191;
				IL_010D:
				if (cachedAttribute is JsonDictionaryAttribute)
				{
					num = 11;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ae8c3d3c66a64b57beca0f5360302062 == 0)
					{
						goto Block_8;
					}
					goto IL_0191;
				}
				else
				{
					if (!(type == typeof(JToken)))
					{
						goto IL_0006;
					}
					num = 5;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18 != 0)
					{
						goto Block_10;
					}
					goto IL_0191;
				}
				IL_003D:
				if (typeof(IEnumerable).IsAssignableFrom(type))
				{
					goto IL_0281;
				}
				num = 17;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2e3be65f7cb2480482903dc73ec42f7c == 0)
				{
					goto IL_0068;
				}
				goto IL_0191;
				IL_0031:
				if (!CollectionUtils.IsDictionaryType(type))
				{
					goto IL_003D;
				}
				goto IL_0289;
				IL_00B1:
				if (DefaultContractResolver.IsIConvertible(type))
				{
					goto IL_0268;
				}
				num = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9 != 0)
				{
					break;
				}
				goto IL_0191;
				IL_009B:
				if (!typeof(IDynamicMetaObjectProvider).IsAssignableFrom(type))
				{
					goto IL_00B1;
				}
				goto IL_0271;
				IL_008F:
				if (!JsonTypeReflector.IsSerializable(type))
				{
					goto IL_009B;
				}
				goto IL_0257;
				IL_007C:
				if (typeof(ISerializable).IsAssignableFrom(type))
				{
					goto IL_008F;
				}
				goto IL_009B;
				IL_0074:
				if (!this.IgnoreSerializableInterface)
				{
					goto IL_007C;
				}
				goto IL_009B;
				IL_0068:
				if (!DefaultContractResolver.CanConvertToString(type))
				{
					goto IL_0074;
				}
				goto IL_0279;
				IL_015A:
				if (DefaultContractResolver.IsJsonPrimitiveType(type))
				{
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296 == 0)
					{
						goto IL_010D;
					}
					goto IL_0191;
				}
				else
				{
					type = ReflectionUtils.EnsureNotNullableType(type);
					num = 26;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_bc7a9075386042ad9ce36653fcde3fc3 == 0)
					{
						goto IL_0191;
					}
				}
			}
			goto IL_0260;
			Block_8:
			goto IL_023C;
			Block_10:
			goto IL_0291;
			IL_0233:
			return this.CreatePrimitiveContract(objectType);
			IL_023C:
			return this.CreateDictionaryContract(objectType);
			IL_0247:
			return this.CreateArrayContract(objectType);
			IL_024F:
			return this.CreateObjectContract(objectType);
			IL_0257:
			return this.CreateISerializableContract(objectType);
			IL_0260:
			return this.CreateObjectContract(objectType);
			IL_0268:
			return this.CreatePrimitiveContract(type);
			IL_0271:
			return this.CreateDynamicContract(objectType);
			IL_0279:
			return this.CreateStringContract(objectType);
			IL_0281:
			return this.CreateArrayContract(objectType);
			IL_0289:
			return this.CreateDictionaryContract(objectType);
			IL_0291:
			return this.CreateLinqContract(objectType);
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x000559C8 File Offset: 0x00053BC8
		internal static bool IsJsonPrimitiveType(Type t)
		{
			PrimitiveTypeCode typeCode;
			for (;;)
			{
				typeCode = ConvertUtils.GetTypeCode(t);
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c28a4ed7a58e45aaa9902e336fd60b97 == 0)
				{
					goto IL_0003;
				}
				IL_0018:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					goto IL_004D;
				case 3:
					return false;
				}
				IL_0003:
				if (typeCode != PrimitiveTypeCode.Empty)
				{
					break;
				}
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808 != 0)
				{
					goto IL_0018;
				}
			}
			IL_004D:
			return typeCode != PrimitiveTypeCode.Object;
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x00055A2C File Offset: 0x00053C2C
		internal static bool IsIConvertible(Type t)
		{
			for (;;)
			{
				if (!typeof(IConvertible).IsAssignableFrom(t))
				{
					goto IL_0030;
				}
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0005996a6a494de4880ac2956b2e0112 == 0)
				{
					break;
				}
				IL_0014:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					goto IL_0068;
				case 4:
					IL_0030:
					if (!ReflectionUtils.IsNullableType(t))
					{
						return false;
					}
					num = 2;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a102d6e4dd542a6855b81a93c692545 != 0)
					{
						goto IL_0014;
					}
					goto IL_0067;
				}
				break;
			}
			goto IL_007F;
			IL_0067:
			IL_0068:
			if (!typeof(IConvertible).IsAssignableFrom(Nullable.GetUnderlyingType(t)))
			{
				return false;
			}
			IL_007F:
			return !typeof(JToken).IsAssignableFrom(t);
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x00055AD0 File Offset: 0x00053CD0
		internal static bool CanConvertToString(Type type)
		{
			TypeConverter typeConverter;
			while (!JsonTypeReflector.CanTypeDescriptorConvertString(type, out typeConverter))
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a != 0)
				{
					goto IL_0040;
				}
				IL_0063:
				switch (num)
				{
				case 0:
					goto IL_0040;
				case 1:
					continue;
				case 2:
					break;
				case 3:
				case 5:
					return true;
				case 4:
					return true;
				case 6:
					return false;
				default:
					goto IL_0040;
				}
				IL_001A:
				if (type.IsSubclassOf(typeof(Type)))
				{
					return true;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f == 0)
				{
					return false;
				}
				goto IL_0063;
				IL_0040:
				if (!(type == typeof(Type)))
				{
					goto IL_001A;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d == 0)
				{
					goto IL_0063;
				}
				return true;
			}
			return true;
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x00055B80 File Offset: 0x00053D80
		private static bool smethod_5(object object_0, object object_1, Type type_0, [Nullable(2)] MethodInfo currentCallback, [Nullable(2)] ref Type prevAttributeType)
		{
			IL_01D2:
			while (object_0.IsDefined(type_0, false))
			{
				int num = 12;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_370349efcd7c4959a098549c3d5bf14d == 0)
				{
					goto IL_00AB;
				}
				for (;;)
				{
					IL_017F:
					switch (num)
					{
					case 1:
						goto IL_003E;
					case 2:
						goto IL_005A;
					case 3:
						goto IL_0134;
					case 4:
						return false;
					case 5:
						goto IL_0252;
					case 6:
						goto IL_0221;
					case 7:
						goto IL_01E6;
					case 8:
					case 15:
						goto IL_02BD;
					case 9:
						return true;
					case 10:
						goto IL_0146;
					case 11:
						if (!(object_1[0].ParameterType != typeof(StreamingContext)))
						{
							goto IL_008D;
						}
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_55c1fea936c04e47abbfb2b5f778aff7 != 0)
						{
							continue;
						}
						goto IL_01E5;
					case 12:
						goto IL_00AB;
					case 13:
						goto IL_01D2;
					case 14:
						goto IL_0285;
					case 16:
						goto IL_0020;
					case 17:
						goto IL_0302;
					}
					break;
				}
				goto IL_0119;
				IL_01E5:
				goto IL_01E6;
				IL_0020:
				if (object_1.Length != 2)
				{
					goto IL_02BD;
				}
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1db17fe7bd2442b599c52df89f39e610 == 0)
				{
					goto IL_003E;
				}
				goto IL_017F;
				IL_0146:
				if (object_1 == null)
				{
					goto IL_02BD;
				}
				goto IL_0020;
				IL_0134:
				if (type_0 == typeof(OnErrorAttribute))
				{
					goto IL_0146;
				}
				if (object_1 == null)
				{
					goto IL_01E6;
				}
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_207f975845fc40cdbe6b166fce664cd5 == 0)
				{
					goto IL_0119;
				}
				goto IL_017F;
				IL_005A:
				if (!(object_1[1].ParameterType != typeof(ErrorContext)))
				{
					goto IL_008D;
				}
				num = 13;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_17bdafd603b54a77a2e4a383bd4dcffa == 0)
				{
					goto IL_02BD;
				}
				goto IL_017F;
				IL_003E:
				if (!(object_1[0].ParameterType != typeof(StreamingContext)))
				{
					goto IL_005A;
				}
				goto IL_02BD;
				IL_008D:
				prevAttributeType = type_0;
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 == 0)
				{
					return true;
				}
				goto IL_017F;
				IL_00AB:
				if (currentCallback != null)
				{
					goto IL_0252;
				}
				if (prevAttributeType != null)
				{
					goto IL_0302;
				}
				if (object_0.IsVirtual)
				{
					goto IL_0285;
				}
				if (object_0.ReturnType != typeof(void))
				{
					goto IL_0221;
				}
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4152404f503b492c83d9bc2e44bdd0a7 == 0)
				{
					goto IL_0134;
				}
				goto IL_017F;
				IL_0119:
				if (object_1.Length == 1)
				{
					num = 11;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7ae4da5a55de471eb12dd0de8dd4269c != 0)
					{
						goto IL_0134;
					}
					goto IL_017F;
				}
				IL_01E6:
				throw new JsonException(Class15.smethod_17(1678100660 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a).FormatWith(CultureInfo.InvariantCulture, DefaultContractResolver.GetClrTypeFullName(object_0.DeclaringType), object_0, typeof(StreamingContext)));
				IL_0221:
				throw new JsonException(Class15.smethod_17(124820680 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719).FormatWith(CultureInfo.InvariantCulture, DefaultContractResolver.GetClrTypeFullName(object_0.DeclaringType), object_0));
				IL_0252:
				throw new JsonException(Class15.smethod_17(649978632 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff).FormatWith(CultureInfo.InvariantCulture, object_0, currentCallback, DefaultContractResolver.GetClrTypeFullName(object_0.DeclaringType), type_0));
				IL_0285:
				throw new JsonException(Class15.smethod_17(2008578553 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb).FormatWith(CultureInfo.InvariantCulture, object_0, DefaultContractResolver.GetClrTypeFullName(object_0.DeclaringType), type_0));
				IL_02BD:
				throw new JsonException(Class15.smethod_17(432129279 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2).FormatWith(CultureInfo.InvariantCulture, DefaultContractResolver.GetClrTypeFullName(object_0.DeclaringType), object_0, typeof(StreamingContext), typeof(ErrorContext)));
				IL_0302:
				throw new JsonException(Class15.smethod_17(1788756979 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c).FormatWith(CultureInfo.InvariantCulture, prevAttributeType, type_0, DefaultContractResolver.GetClrTypeFullName(object_0.DeclaringType), object_0));
			}
			return false;
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x00055EC8 File Offset: 0x000540C8
		internal static string GetClrTypeFullName(Type type)
		{
			IL_0038:
			while (!type.IsGenericTypeDefinition())
			{
				while (type.ContainsGenericParameters())
				{
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b3c865ee224546b18f2991d2a8895f6a != 0)
					{
						switch (num)
						{
						default:
							continue;
						case 1:
							break;
						case 2:
						case 3:
							goto IL_0070;
						case 4:
							goto IL_0038;
						}
					}
					return Class15.smethod_17(299931957 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e).FormatWith(CultureInfo.InvariantCulture, type.Namespace, type.Name);
				}
				IL_0070:
				return type.FullName;
			}
			goto IL_0070;
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x00055F4C File Offset: 0x0005414C
		protected virtual IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
		{
			List<MemberInfo> serializableMembers = this.GetSerializableMembers(type);
			if (serializableMembers == null)
			{
				throw new JsonSerializationException(Class15.smethod_17(432129653 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7af5c533f30e4bd1bda86ce6098441d2));
			}
			DefaultJsonNameTable nameTable = this.GetNameTable();
			JsonPropertyCollection jsonPropertyCollection = new JsonPropertyCollection(type);
			foreach (MemberInfo memberInfo in serializableMembers)
			{
				JsonProperty jsonProperty = this.CreateProperty(memberInfo, memberSerialization);
				if (jsonProperty != null)
				{
					DefaultJsonNameTable defaultJsonNameTable = nameTable;
					lock (defaultJsonNameTable)
					{
						jsonProperty.PropertyName = nameTable.Add(jsonProperty.PropertyName);
					}
					jsonPropertyCollection.AddProperty(jsonProperty);
				}
			}
			return jsonPropertyCollection.OrderBy(new Func<JsonProperty, int>(DefaultContractResolver.<>c.<>c_0.method_5)).ToList<JsonProperty>();
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x000048BF File Offset: 0x00002ABF
		internal virtual DefaultJsonNameTable GetNameTable()
		{
			return this.defaultJsonNameTable_0;
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x00056044 File Offset: 0x00054244
		protected virtual IValueProvider CreateMemberValueProvider(MemberInfo member)
		{
			IValueProvider valueProvider;
			for (;;)
			{
				if (!this.DynamicCodeGeneration)
				{
					goto IL_0003;
				}
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff == 0)
				{
					break;
				}
				IL_001C:
				switch (num)
				{
				case 1:
					continue;
				case 2:
				case 3:
					return valueProvider;
				case 4:
					IL_0003:
					valueProvider = new ReflectionValueProvider(member);
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c08ab7af63da4f24a4fa3e9c7a732fae == 0)
					{
						goto IL_001C;
					}
					return valueProvider;
				}
				break;
			}
			valueProvider = new DynamicValueProvider(member);
			return valueProvider;
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x000560B8 File Offset: 0x000542B8
		protected virtual JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
		{
			JsonProperty jsonProperty;
			bool flag;
			for (;;)
			{
				IL_0190:
				jsonProperty = new JsonProperty();
				for (;;)
				{
					IL_016C:
					jsonProperty.PropertyType = ReflectionUtils.GetMemberUnderlyingType(member);
					int num = 11;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d9581c727fcc4f50accd4f5de0d386f5 != 0)
					{
						goto IL_00DA;
					}
					for (;;)
					{
						IL_0119:
						switch (num)
						{
						case 1:
							goto IL_0104;
						case 2:
							goto IL_0108;
						case 3:
							goto IL_0097;
						case 4:
							goto IL_00DA;
						case 5:
							goto IL_00C2;
						case 6:
						case 15:
							return jsonProperty;
						case 7:
							goto IL_016C;
						case 8:
							goto IL_0190;
						case 9:
							goto IL_002A;
						case 10:
							goto IL_004C;
						case 11:
							jsonProperty.DeclaringType = member.DeclaringType;
							goto IL_0067;
						case 12:
							goto IL_0199;
						case 13:
							goto IL_008F;
						case 14:
							goto IL_0067;
						case 17:
							goto IL_0006;
						}
						break;
						IL_0006:
						jsonProperty.AttributeProvider = new ReflectionAttributeProvider(member);
						num = 4;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 == 0)
						{
							break;
						}
						continue;
						IL_0067:
						jsonProperty.ValueProvider = this.CreateMemberValueProvider(member);
						num = 5;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 == 0)
						{
							goto IL_0006;
						}
					}
					goto IL_005C;
					IL_002A:
					if (!this.IgnoreIsSpecifiedMembers)
					{
						goto IL_0199;
					}
					num = 15;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_db7740c6ca7a4f3c8e1aa526bdb0a454 != 0)
					{
						goto IL_0119;
					}
					IL_005C:
					if (this.IgnoreShouldSerializeMembers)
					{
						goto IL_002A;
					}
					IL_004C:
					jsonProperty.ShouldSerialize = this.method_11(member);
					goto IL_002A;
					IL_0097:
					jsonProperty.Writable = true;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e368897ba1744663a6d0bc59b9b65b5f == 0)
					{
						goto IL_005C;
					}
					goto IL_0119;
					IL_008F:
					jsonProperty.Readable = true;
					goto IL_0097;
					IL_0104:
					if (memberSerialization != MemberSerialization.Fields)
					{
						goto IL_0108;
					}
					goto IL_008F;
					IL_00DA:
					this.method_10(jsonProperty, member, member.Name, member.DeclaringType, memberSerialization, out flag);
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 == 0)
					{
						goto IL_0104;
					}
					goto IL_0119;
					IL_00C2:
					jsonProperty.Writable = ReflectionUtils.CanSetMemberValue(member, flag, jsonProperty.HasMemberAttribute);
					goto IL_005C;
					IL_0108:
					jsonProperty.Readable = ReflectionUtils.CanReadMemberValue(member, flag);
					goto IL_00C2;
				}
			}
			IL_0199:
			this.method_12(jsonProperty, member, flag);
			return jsonProperty;
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x0005626C File Offset: 0x0005446C
		private void method_10(JsonProperty jsonProperty_0, object object_0, string string_1, Type type_0, MemberSerialization memberSerialization_0, out bool bool_4)
		{
			for (;;)
			{
				IL_055D:
				bool dataContractAttribute = JsonTypeReflector.GetDataContractAttribute(type_0) != null;
				MemberInfo memberInfo = object_0 as MemberInfo;
				if (!dataContractAttribute)
				{
					goto IL_0531;
				}
				goto IL_0550;
				int num;
				DataMemberAttribute dataMemberAttribute;
				bool flag;
				for (;;)
				{
					IL_045F:
					DefaultValueAttribute attribute;
					switch (num)
					{
					case 1:
					case 21:
						goto IL_0524;
					case 2:
						goto IL_033B;
					case 3:
						goto IL_041E;
					case 4:
					case 12:
						goto IL_03BB;
					case 5:
					case 16:
						goto IL_02FD;
					case 6:
						goto IL_02AE;
					case 7:
						goto IL_03DA;
					case 8:
					case 32:
						goto IL_0376;
					case 9:
						goto IL_0550;
					case 10:
					case 25:
						goto IL_0531;
					case 11:
						goto IL_055D;
					case 13:
						goto IL_031E;
					case 14:
						attribute = JsonTypeReflector.GetAttribute<DefaultValueAttribute>(object_0);
						goto IL_041A;
					case 15:
						goto IL_044D;
					case 17:
						goto IL_0363;
					case 18:
						goto IL_04FE;
					case 19:
						goto IL_0340;
					case 20:
					case 30:
						goto IL_03F5;
					case 22:
						dataMemberAttribute = JsonTypeReflector.GetDataMemberAttribute(memberInfo);
						num = 1;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 != 0)
						{
							continue;
						}
						break;
					case 23:
						goto IL_039B;
					case 24:
					case 35:
						goto IL_02CB;
					case 26:
						goto IL_0006;
					case 27:
						goto IL_0343;
					case 28:
						goto IL_041A;
					case 29:
						goto IL_03F9;
					case 31:
						goto IL_03C1;
					case 33:
						goto IL_02C7;
					case 34:
						goto IL_02D6;
					case 36:
						return;
					}
					break;
					IL_02AE:
					bool_4 = true;
					num = 36;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_57ce3fecb9e64a8f924ea7658e146719 == 0)
					{
						goto IL_02C7;
					}
					continue;
					IL_02CB:
					if (memberSerialization_0 != MemberSerialization.Fields)
					{
						return;
					}
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3cf8a2073cc248c2915ebb05bcd2a099 == 0)
					{
						goto IL_02AE;
					}
					continue;
					IL_02C7:
					bool_4 = true;
					goto IL_02CB;
					IL_03DA:
					if (flag)
					{
						goto IL_02C7;
					}
					num = 24;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d == 0)
					{
						goto Block_21;
					}
					continue;
					IL_03F9:
					if ((this.DefaultMembersSearchFlags & BindingFlags.NonPublic) != BindingFlags.NonPublic)
					{
						goto IL_03DA;
					}
					num = 31;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5f127c3ec2e04c11ab1bd26a8d965f2b == 0)
					{
						goto IL_03C1;
					}
					continue;
					IL_03F5:
					bool_4 = false;
					goto IL_03F9;
					IL_041A:
					if (attribute != null)
					{
						goto IL_041E;
					}
					goto IL_03F5;
					IL_03C1:
					bool_4 = true;
					num = 7;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c == 0)
					{
						goto IL_03DA;
					}
					continue;
					IL_041E:
					jsonProperty_0.DefaultValue = attribute.Value;
					goto IL_03F5;
				}
				goto IL_0393;
				Block_21:
				goto IL_039B;
				IL_02D6:
				bool flag2;
				jsonProperty_0.Ignored = flag2 || !flag;
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f == 0)
				{
					goto IL_02FD;
				}
				goto IL_045F;
				IL_033B:
				if (memberSerialization_0 != MemberSerialization.OptIn)
				{
					goto IL_0340;
				}
				goto IL_02D6;
				IL_02FD:
				jsonProperty_0.Converter = JsonTypeReflector.GetJsonConverter(object_0);
				num = 14;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_832998aae3714af0a1270bf2bb566909 == 0)
				{
					goto IL_031E;
				}
				goto IL_045F;
				IL_0363:
				bool flag3;
				jsonProperty_0.Ignored = flag2 || flag3;
				goto IL_02FD;
				IL_0324:
				bool flag4;
				flag2 = flag4;
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 != 0)
				{
					goto IL_033B;
				}
				goto IL_045F;
				IL_03BB:
				flag4 = true;
				goto IL_0324;
				IL_0393:
				if (JsonTypeReflector.GetAttribute<JsonIgnoreAttribute>(object_0) == null)
				{
					goto IL_039B;
				}
				goto IL_03BB;
				IL_031E:
				flag4 = JsonTypeReflector.IsNonSerializable(object_0);
				goto IL_0324;
				IL_039B:
				if (JsonTypeReflector.GetAttribute<JsonExtensionDataAttribute>(object_0) == null)
				{
					goto IL_031E;
				}
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 != 0)
				{
					goto IL_03BB;
				}
				goto IL_045F;
				IL_0343:
				flag3 = JsonTypeReflector.GetAttribute<IgnoreDataMemberAttribute>(object_0) != null;
				num = 8;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2a74c5ebb7d84adcad853e2eda393dc4 == 0)
				{
					goto IL_0363;
				}
				goto IL_045F;
				IL_0340:
				flag3 = false;
				goto IL_0343;
				IL_0376:
				jsonProperty_0.HasMemberAttribute = flag;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb == 0)
				{
					goto IL_0393;
				}
				goto IL_045F;
				IL_044D:
				flag = true;
				goto IL_0376;
				IL_0006:
				bool attribute2 = JsonTypeReflector.GetAttribute<JsonRequiredAttribute>(object_0) != null;
				JsonPropertyAttribute attribute3;
				string text;
				bool flag5;
				if (attribute3 != null && attribute3.PropertyName != null)
				{
					text = attribute3.PropertyName;
					flag5 = true;
				}
				else if (dataMemberAttribute != null && dataMemberAttribute.Name != null)
				{
					text = dataMemberAttribute.Name;
					flag5 = true;
				}
				else
				{
					text = string_1;
					flag5 = false;
				}
				JsonContainerAttribute attribute4 = JsonTypeReflector.GetAttribute<JsonContainerAttribute>(type_0);
				NamingStrategy namingStrategy;
				if (((attribute3 == null) ? null : attribute3.NamingStrategyType) != null)
				{
					namingStrategy = JsonTypeReflector.CreateNamingStrategyInstance(attribute3.NamingStrategyType, attribute3.NamingStrategyParameters);
				}
				else if (!(((attribute4 != null) ? attribute4.NamingStrategyType : null) != null))
				{
					namingStrategy = this.NamingStrategy;
				}
				else
				{
					namingStrategy = JsonTypeReflector.GetContainerNamingStrategy(attribute4);
				}
				if (namingStrategy == null)
				{
					jsonProperty_0.PropertyName = this.ResolvePropertyName(text);
				}
				else
				{
					jsonProperty_0.PropertyName = namingStrategy.GetPropertyName(text, flag5);
				}
				jsonProperty_0.UnderlyingName = string_1;
				flag = false;
				if (attribute3 != null)
				{
					jsonProperty_0._required = attribute3._required;
					jsonProperty_0.Order = attribute3._order;
					jsonProperty_0.DefaultValueHandling = attribute3._defaultValueHandling;
					flag = true;
					jsonProperty_0.NullValueHandling = attribute3._nullValueHandling;
					jsonProperty_0.ReferenceLoopHandling = attribute3._referenceLoopHandling;
					jsonProperty_0.ObjectCreationHandling = attribute3._objectCreationHandling;
					jsonProperty_0.TypeNameHandling = attribute3._typeNameHandling;
					jsonProperty_0.IsReference = attribute3._isReference;
					jsonProperty_0.ItemIsReference = attribute3._itemIsReference;
					jsonProperty_0.ItemConverter = ((!(attribute3.ItemConverterType != null)) ? null : JsonTypeReflector.CreateJsonConverterInstance(attribute3.ItemConverterType, attribute3.ItemConverterParameters));
					jsonProperty_0.ItemReferenceLoopHandling = attribute3._itemReferenceLoopHandling;
					jsonProperty_0.ItemTypeNameHandling = attribute3._itemTypeNameHandling;
				}
				else
				{
					jsonProperty_0.NullValueHandling = null;
					jsonProperty_0.ReferenceLoopHandling = null;
					jsonProperty_0.ObjectCreationHandling = null;
					jsonProperty_0.TypeNameHandling = null;
					jsonProperty_0.IsReference = null;
					jsonProperty_0.ItemIsReference = null;
					jsonProperty_0.ItemConverter = null;
					jsonProperty_0.ItemReferenceLoopHandling = null;
					jsonProperty_0.ItemTypeNameHandling = null;
					if (dataMemberAttribute != null)
					{
						jsonProperty_0._required = new Required?((!dataMemberAttribute.IsRequired) ? Required.Default : Required.AllowNull);
						jsonProperty_0.Order = ((dataMemberAttribute.Order != -1) ? new int?(dataMemberAttribute.Order) : null);
						jsonProperty_0.DefaultValueHandling = ((!dataMemberAttribute.EmitDefaultValue) ? new DefaultValueHandling?(DefaultValueHandling.Ignore) : null);
						flag = true;
					}
				}
				if (!attribute2)
				{
					goto IL_0376;
				}
				goto IL_04FE;
				IL_0524:
				attribute3 = JsonTypeReflector.GetAttribute<JsonPropertyAttribute>(object_0);
				goto IL_0006;
				IL_0531:
				dataMemberAttribute = null;
				goto IL_0524;
				IL_0550:
				if (!(memberInfo != null))
				{
					goto IL_0531;
				}
				num = 22;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5dadf4f8cc824060ae20e1ee9bbca82a != 0)
				{
					goto IL_044D;
				}
				goto IL_045F;
				IL_04FE:
				jsonProperty_0._required = new Required?(Required.Always);
				num = 10;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0efaea2f67ca4b0aa2880fbd34fc0fff != 0)
				{
					goto IL_044D;
				}
				goto IL_045F;
			}
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x000567EC File Offset: 0x000549EC
		[return: Nullable(new byte[] { 2, 1 })]
		private Predicate<object> method_11(MemberInfo memberInfo_0)
		{
			DefaultContractResolver.<>c__DisplayClass80_0 CS$<>8__locals1 = new DefaultContractResolver.<>c__DisplayClass80_0();
			MethodInfo method = memberInfo_0.DeclaringType.GetMethod(Class15.smethod_17(197559165 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81) + memberInfo_0.Name, ReflectionUtils.EmptyTypes);
			if (!(method == null) && !(method.ReturnType != typeof(bool)))
			{
				CS$<>8__locals1.methodCall_0 = JsonTypeReflector.ReflectionDelegateFactory.CreateMethodCall<object>(method);
				return new Predicate<object>(CS$<>8__locals1.method_0);
			}
			return null;
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x00056870 File Offset: 0x00054A70
		private void method_12(JsonProperty jsonProperty_0, MemberInfo memberInfo_0, bool bool_4)
		{
			MemberInfo memberInfo;
			for (;;)
			{
				DefaultContractResolver.<>c__DisplayClass81_0 CS$<>8__locals1 = new DefaultContractResolver.<>c__DisplayClass81_0();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a == 0)
				{
					goto IL_00E9;
				}
				goto IL_012F;
				IL_00BF:
				jsonProperty_0.GetIsSpecified = new Predicate<object>(CS$<>8__locals1.method_0);
				num = 12;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c367d9ce11cc43b595beeb4524149542 != 0)
				{
					continue;
				}
				goto IL_012F;
				IL_0037:
				if (ReflectionUtils.GetMemberUnderlyingType(memberInfo) != typeof(bool))
				{
					num = 9;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f != 0)
					{
						goto IL_012F;
					}
				}
				else
				{
					CS$<>8__locals1.func_0 = JsonTypeReflector.ReflectionDelegateFactory.CreateGet<object>(memberInfo);
					num = 6;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa49bb51056944098afe92e3a80a544b != 0)
					{
						goto IL_00BF;
					}
					goto IL_012F;
				}
				IL_007D:
				if (!(memberInfo == null))
				{
					goto IL_0037;
				}
				num = 7;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5dadf4f8cc824060ae20e1ee9bbca82a != 0)
				{
					goto IL_008A;
				}
				goto IL_012F;
				IL_0006:
				memberInfo = memberInfo_0.DeclaringType.GetField(memberInfo_0.Name + Class15.smethod_17(1788617052 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
				goto IL_007D;
				IL_008A:
				if (!(memberInfo == null))
				{
					goto IL_007D;
				}
				goto IL_0006;
				IL_012F:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					goto IL_0037;
				case 3:
					goto IL_0199;
				case 4:
				case 10:
					goto IL_007D;
				case 5:
					goto IL_008A;
				case 6:
					return;
				case 7:
				case 9:
					return;
				case 8:
					goto IL_00BF;
				case 11:
					goto IL_0006;
				case 12:
					goto IL_018E;
				}
				IL_00E9:
				memberInfo = memberInfo_0.DeclaringType.GetProperty(memberInfo_0.Name + Class15.smethod_17(1985282482 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f19acd91a8c44846a95d09d7dc3da2ba), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_550a8fe2e5fe4cc19bdfe1a82a7f12b8 == 0)
				{
					goto IL_008A;
				}
				goto IL_012F;
			}
			return;
			IL_018E:
			if (!ReflectionUtils.CanSetMemberValue(memberInfo, bool_4, false))
			{
				return;
			}
			IL_0199:
			jsonProperty_0.SetIsSpecified = JsonTypeReflector.ReflectionDelegateFactory.CreateSet<object>(memberInfo);
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x00056A28 File Offset: 0x00054C28
		protected virtual string ResolvePropertyName(string propertyName)
		{
			while (this.NamingStrategy != null)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0b405dced5e94c80928a74c5773182d9 != 0)
				{
					switch (num)
					{
					case 1:
						continue;
					}
				}
				return this.NamingStrategy.GetPropertyName(propertyName, false);
			}
			return propertyName;
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x00056A74 File Offset: 0x00054C74
		protected virtual string ResolveExtensionDataName(string extensionDataName)
		{
			while (this.NamingStrategy != null)
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
				return this.NamingStrategy.GetExtensionDataName(extensionDataName);
			}
			return extensionDataName;
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x00056AC0 File Offset: 0x00054CC0
		protected virtual string ResolveDictionaryKey(string dictionaryKey)
		{
			while (this.NamingStrategy != null)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 == 0)
				{
					switch (num)
					{
					case 1:
						continue;
					}
				}
				return this.NamingStrategy.GetDictionaryKey(dictionaryKey);
			}
			return this.ResolvePropertyName(dictionaryKey);
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x000048C7 File Offset: 0x00002AC7
		public string GetResolvedPropertyName(string propertyName)
		{
			return this.ResolvePropertyName(propertyName);
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x00056B14 File Offset: 0x00054D14
		static DefaultContractResolver()
		{
			for (;;)
			{
				IL_0109:
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a5994720d09542abb897ebf6ad9b5a19 != 0)
				{
					goto IL_00E9;
				}
				do
				{
					IL_00D4:
					num = 5;
				}
				while (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c == 0);
				for (;;)
				{
					IL_00E9:
					switch (num)
					{
					case 1:
						goto IL_00D4;
					case 2:
						goto IL_0109;
					case 3:
						goto IL_0063;
					case 4:
						goto IL_0010;
					case 5:
						DefaultContractResolver.icontractResolver_0 = new DefaultContractResolver();
						goto IL_0010;
					}
					return;
					IL_0063:
					DefaultContractResolver.jsonConverter_0 = new JsonConverter[]
					{
						new EntityKeyMemberConverter(),
						new ExpandoObjectConverter(),
						new XmlNodeConverter(),
						new BinaryConverter(),
						new DataSetConverter(),
						new DataTableConverter(),
						new DiscriminatedUnionConverter(),
						new KeyValuePairConverter(),
						new BsonObjectIdConverter(),
						new RegexConverter()
					};
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_52d717cd31b74287b67c03ee736a6211 == 0)
					{
						return;
					}
					continue;
					IL_0010:
					DefaultContractResolver.string_0 = new string[]
					{
						Class15.smethod_17(299931749 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e),
						Class15.smethod_17(538834737 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa),
						Class15.smethod_17(1743181336 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8)
					};
					goto IL_0063;
				}
			}
		}

		// Token: 0x040004B3 RID: 1203
		private static readonly IContractResolver icontractResolver_0;

		// Token: 0x040004B4 RID: 1204
		private static readonly string[] string_0;

		// Token: 0x040004B5 RID: 1205
		private static readonly JsonConverter[] jsonConverter_0;

		// Token: 0x040004B6 RID: 1206
		private readonly DefaultJsonNameTable defaultJsonNameTable_0 = new DefaultJsonNameTable();

		// Token: 0x040004B7 RID: 1207
		private readonly ThreadSafeStore<Type, JsonContract> threadSafeStore_0;

		// Token: 0x040004B8 RID: 1208
		[CompilerGenerated]
		private BindingFlags bindingFlags_0;

		// Token: 0x040004B9 RID: 1209
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x040004BA RID: 1210
		[CompilerGenerated]
		private bool bool_1;

		// Token: 0x040004BB RID: 1211
		[CompilerGenerated]
		private bool ysvdGjichr;

		// Token: 0x040004BC RID: 1212
		[CompilerGenerated]
		private bool bool_2;

		// Token: 0x040004BD RID: 1213
		[CompilerGenerated]
		private bool bool_3;

		// Token: 0x040004BE RID: 1214
		[Nullable(2)]
		[CompilerGenerated]
		private NamingStrategy namingStrategy_0;

		// Token: 0x020000E6 RID: 230
		[NullableContext(0)]
		internal class EnumerableDictionaryWrapper<[Nullable(2)] TEnumeratorKey, [Nullable(2)] TEnumeratorValue> : IEnumerable<KeyValuePair<object, object>>, IEnumerable
		{
			// Token: 0x06000929 RID: 2345 RVA: 0x000048D0 File Offset: 0x00002AD0
			public EnumerableDictionaryWrapper([Nullable(new byte[] { 1, 0, 1, 1 })] IEnumerable<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> e)
			{
				ValidationUtils.ArgumentNotNull(e, Class15.smethod_17(1788792309 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_1d8dbb531d7349c0bc15bad339f7815c));
				this.ienumerable_0 = e;
			}

			// Token: 0x0600092A RID: 2346 RVA: 0x000048FC File Offset: 0x00002AFC
			[return: Nullable(new byte[] { 1, 0, 1, 1 })]
			public IEnumerator<KeyValuePair<object, object>> GetEnumerator()
			{
				DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>.<GetEnumerator>d__2 <GetEnumerator>d__ = new DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue>.<GetEnumerator>d__2(0);
				<GetEnumerator>d__.<>4__this = this;
				return <GetEnumerator>d__;
			}

			// Token: 0x0600092B RID: 2347 RVA: 0x0000490B File Offset: 0x00002B0B
			[NullableContext(1)]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x040004C0 RID: 1216
			[Nullable(new byte[] { 1, 0, 1, 1 })]
			private readonly IEnumerable<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> ienumerable_0;
		}
	}
}
