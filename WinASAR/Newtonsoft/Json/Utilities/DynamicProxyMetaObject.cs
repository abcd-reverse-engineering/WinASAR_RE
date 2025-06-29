using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000094 RID: 148
	[NullableContext(1)]
	[Nullable(0)]
	internal sealed class DynamicProxyMetaObject<[Nullable(2)] T> : DynamicMetaObject
	{
		// Token: 0x0600066B RID: 1643 RVA: 0x00003C66 File Offset: 0x00001E66
		internal DynamicProxyMetaObject(Expression expression, T value, DynamicProxy<T> proxy)
			: base(expression, BindingRestrictions.Empty, value)
		{
			this.dynamicProxy_0 = proxy;
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x00003C83 File Offset: 0x00001E83
		private bool method_0(string string_0)
		{
			return ReflectionUtils.IsMethodOverridden(this.dynamicProxy_0.GetType(), typeof(DynamicProxy<T>), string_0);
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x00046C30 File Offset: 0x00044E30
		public override DynamicMetaObject BindGetMember(GetMemberBinder binder)
		{
			for (;;)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a321d34f24314561b0d80437d5d859e8 == 0)
				{
					goto IL_0003;
				}
				IL_001C:
				switch (num)
				{
				case 1:
					continue;
				case 2:
					goto IL_0054;
				case 3:
					goto IL_005C;
				case 4:
					goto IL_00AF;
				}
				IL_0003:
				GetMemberBinder getMemberBinder_0 = binder;
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e6fac70dd3e841b6925374855ecd7fb1 != 0)
				{
					goto IL_001C;
				}
				break;
			}
			IL_0054:
			CS$<>8__locals1.dynamicProxyMetaObject_0 = this;
			IL_005C:
			if (this.method_0(Class15.smethod_17(974435727 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f)))
			{
				return this.method_1(Class15.smethod_17(1243271262 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95), CS$<>8__locals1.getMemberBinder_0, DynamicProxyMetaObject<T>.smethod_0(), new DynamicProxyMetaObject<T>.Delegate0(CS$<>8__locals1.method_0), null);
			}
			IL_00AF:
			return base.BindGetMember(CS$<>8__locals1.getMemberBinder_0);
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x00046CFC File Offset: 0x00044EFC
		public override DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value)
		{
			for (;;)
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177 != 0)
				{
					goto IL_0003;
				}
				IL_0024:
				switch (num)
				{
				case 1:
					goto IL_0089;
				case 2:
					goto IL_006C;
				case 3:
					goto IL_000B;
				case 4:
				{
					IL_0003:
					SetMemberBinder setMemberBinder_0 = binder;
					goto IL_000B;
				}
				case 5:
					continue;
				case 6:
					goto IL_009E;
				}
				break;
				IL_000B:
				DynamicProxyMetaObject<T> dynamicProxyMetaObject_0 = this;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 != 0)
				{
					goto IL_0024;
				}
				break;
			}
			CS$<>8__locals1.dynamicMetaObject_0 = value;
			IL_006C:
			if (this.method_0(Class15.smethod_17(2071417552 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8db627a8c96145a0afb24deffd2a8808)))
			{
				goto IL_009E;
			}
			IL_0089:
			return base.BindSetMember(CS$<>8__locals1.setMemberBinder_0, CS$<>8__locals1.dynamicMetaObject_0);
			IL_009E:
			return this.method_3(Class15.smethod_17(1603822466 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c), CS$<>8__locals1.setMemberBinder_0, DynamicProxyMetaObject<T>.smethod_1(new DynamicMetaObject[] { CS$<>8__locals1.dynamicMetaObject_0 }), new DynamicProxyMetaObject<T>.Delegate0(CS$<>8__locals1.method_0));
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x00046DEC File Offset: 0x00044FEC
		public override DynamicMetaObject BindDeleteMember(DeleteMemberBinder binder)
		{
			for (;;)
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3bf07bb1c323490cb457eef2b2e78695 == 0)
				{
					goto IL_001F;
				}
				IL_0029:
				switch (num)
				{
				case 1:
				{
					IL_001F:
					DeleteMemberBinder deleteMemberBinder_0 = binder;
					goto IL_0003;
				}
				case 2:
					continue;
				case 3:
					goto IL_007E;
				case 4:
					goto IL_0003;
				}
				break;
				IL_0003:
				DynamicProxyMetaObject<T> dynamicProxyMetaObject_0 = this;
				num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 != 0)
				{
					break;
				}
				goto IL_0029;
			}
			if (this.method_0(Class15.smethod_17(1116147079 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_100d09ce3850492c8356d7fa1e667d54)))
			{
				return this.method_4(Class15.smethod_17(974435447 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f), CS$<>8__locals1.deleteMemberBinder_0, DynamicProxyMetaObject<T>.smethod_0(), new DynamicProxyMetaObject<T>.Delegate0(CS$<>8__locals1.method_0));
			}
			IL_007E:
			return base.BindDeleteMember(CS$<>8__locals1.deleteMemberBinder_0);
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x00046EBC File Offset: 0x000450BC
		public override DynamicMetaObject BindConvert(ConvertBinder binder)
		{
			for (;;)
			{
				IL_0092:
				ConvertBinder convertBinder_0;
				DynamicProxyMetaObject<T> dynamicProxyMetaObject_0;
				for (;;)
				{
					convertBinder_0 = binder;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3dc45d1ecdeb4859b7f470093f5eeed2 != 0)
					{
						goto IL_003A;
					}
					IL_0056:
					switch (num)
					{
					case 0:
						goto IL_003A;
					case 1:
						goto IL_009C;
					case 2:
						goto IL_00D2;
					case 3:
						continue;
					case 4:
						goto IL_0092;
					case 5:
						break;
					default:
						goto IL_003A;
					}
					IL_0006:
					if (!this.method_0(Class15.smethod_17(299940439 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e)))
					{
						goto IL_00D2;
					}
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039 == 0)
					{
						goto Block_2;
					}
					goto IL_0056;
					IL_003A:
					dynamicProxyMetaObject_0 = this;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9a2e459a49464219810a951679aea12e == 0)
					{
						goto IL_0006;
					}
					goto IL_0056;
				}
			}
			Block_2:
			IL_009C:
			return this.method_1(Class15.smethod_17(1176441744 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af), CS$<>8__locals1.convertBinder_0, DynamicProxyMetaObject<T>.smethod_0(), new DynamicProxyMetaObject<T>.Delegate0(CS$<>8__locals1.method_0), null);
			IL_00D2:
			return base.BindConvert(CS$<>8__locals1.convertBinder_0);
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x00046FA8 File Offset: 0x000451A8
		public override DynamicMetaObject BindInvokeMember(InvokeMemberBinder binder, DynamicMetaObject[] args)
		{
			DynamicProxyMetaObject<T>.<>c__DisplayClass7_0 CS$<>8__locals1;
			DynamicProxyMetaObject<T>.Delegate0 @delegate;
			for (;;)
			{
				IL_00CA:
				CS$<>8__locals1 = new DynamicProxyMetaObject<T>.<>c__DisplayClass7_0();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af == 0)
				{
					goto IL_007F;
				}
				for (;;)
				{
					IL_009E:
					switch (num)
					{
					case 1:
						goto IL_00CA;
					case 2:
						goto IL_00E5;
					case 3:
						@delegate = new DynamicProxyMetaObject<T>.Delegate0(CS$<>8__locals1.method_0);
						num = 2;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d == 0)
						{
							goto Block_3;
						}
						continue;
					case 4:
						goto IL_000E;
					case 5:
						goto IL_0028;
					case 6:
						goto IL_0006;
					case 7:
						goto IL_0156;
					}
					goto Block_5;
				}
				IL_0006:
				CS$<>8__locals1.dynamicProxyMetaObject_0 = this;
				goto IL_000E;
				Block_3:
				continue;
				Block_5:
				goto IL_007F;
				IL_0028:
				if (!this.method_0(Class15.smethod_17(2008571749 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_5c76a4eb2c1748d1bee3513c8eaff2eb)))
				{
					goto IL_0156;
				}
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_7dfc957a76cb4c58b17dc74a084c4e4a == 0)
				{
					continue;
				}
				goto IL_009E;
				IL_000E:
				CS$<>8__locals1.dynamicMetaObject_0 = args;
				num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 == 0)
				{
					goto IL_0028;
				}
				goto IL_009E;
				IL_007F:
				CS$<>8__locals1.invokeMemberBinder_0 = binder;
				num = 6;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ca6ac77a767741aa91cb31f8080f093b != 0)
				{
					goto IL_000E;
				}
				goto IL_009E;
			}
			IL_00E5:
			return this.method_2(Class15.smethod_17(926364845 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b2d935deb963472994f6f2321f1a6296), CS$<>8__locals1.invokeMemberBinder_0, DynamicProxyMetaObject<T>.smethod_2(CS$<>8__locals1.dynamicMetaObject_0), this.method_2(Class15.smethod_17(2060597504 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39f35935adc2477fa894750fee078177), new DynamicProxyMetaObject<T>.Class5(CS$<>8__locals1.invokeMemberBinder_0), DynamicProxyMetaObject<T>.smethod_0(), @delegate(null), new DynamicProxyMetaObject<T>.Delegate0(CS$<>8__locals1.method_1)), null);
			IL_0156:
			return base.BindInvokeMember(CS$<>8__locals1.invokeMemberBinder_0, CS$<>8__locals1.dynamicMetaObject_0);
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x00047120 File Offset: 0x00045320
		public override DynamicMetaObject BindCreateInstance(CreateInstanceBinder binder, DynamicMetaObject[] args)
		{
			for (;;)
			{
				IL_0068:
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fd59e876ac704e7eaa7c7a24a9b3a23f == 0)
				{
					goto IL_003E;
				}
				DynamicMetaObject[] dynamicMetaObject_0;
				for (;;)
				{
					IL_0048:
					switch (num)
					{
					case 1:
						goto IL_003E;
					case 2:
						goto IL_0068;
					case 3:
						goto IL_00DF;
					case 4:
						dynamicMetaObject_0 = args;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8f48544341da433d9f954b548c7e9212 != 0)
						{
							continue;
						}
						break;
					case 5:
						goto IL_0003;
					}
					goto Block_3;
				}
				IL_0003:
				DynamicProxyMetaObject<T> dynamicProxyMetaObject_0 = this;
				num = 4;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_01137da6c88c4265bdc0297aacf3340f == 0)
				{
					break;
				}
				goto IL_0048;
				IL_003E:
				CreateInstanceBinder createInstanceBinder_0 = binder;
				goto IL_0003;
			}
			goto IL_00DF;
			Block_3:
			if (this.method_0(Class15.smethod_17(2128245632 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9)))
			{
				return this.method_1(Class15.smethod_17(2128245632 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9), CS$<>8__locals1.createInstanceBinder_0, DynamicProxyMetaObject<T>.smethod_2(CS$<>8__locals1.dynamicMetaObject_0), new DynamicProxyMetaObject<T>.Delegate0(CS$<>8__locals1.method_0), null);
			}
			IL_00DF:
			return base.BindCreateInstance(CS$<>8__locals1.createInstanceBinder_0, CS$<>8__locals1.dynamicMetaObject_0);
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x00047220 File Offset: 0x00045420
		public override DynamicMetaObject BindInvoke(InvokeBinder binder, DynamicMetaObject[] args)
		{
			for (;;)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_8432da17e8384a688cea4636964d3693 != 0)
				{
					goto IL_004E;
				}
				IL_006A:
				switch (num)
				{
				case 0:
					goto IL_004E;
				case 1:
					continue;
				case 2:
					goto IL_00E7;
				case 3:
					goto IL_0044;
				case 4:
					goto IL_00AA;
				case 5:
					goto IL_003A;
				case 6:
					break;
				default:
					goto IL_004E;
				}
				IL_0006:
				if (!this.method_0(Class15.smethod_17(1793869178 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_0361b8eb39074ea88f5257b13904930a)))
				{
					goto IL_00E7;
				}
				num = 3;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_2bd75de9a0b64d6da3a43e57303102f1 != 0)
				{
					break;
				}
				goto IL_006A;
				IL_003A:
				DynamicMetaObject[] dynamicMetaObject_0 = args;
				goto IL_0006;
				IL_0044:
				DynamicProxyMetaObject<T> dynamicProxyMetaObject_0 = this;
				goto IL_003A;
				IL_004E:
				InvokeBinder invokeBinder_0 = binder;
				num = 2;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3a299c01dd4f4a209bdbd1b98e3f1406 != 0)
				{
					goto IL_0044;
				}
				goto IL_006A;
			}
			IL_00AA:
			return this.method_1(Class15.smethod_17(1760324303 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_6bf87ae21d2446cfa7edc53669bb8039), CS$<>8__locals1.invokeBinder_0, DynamicProxyMetaObject<T>.smethod_2(CS$<>8__locals1.dynamicMetaObject_0), new DynamicProxyMetaObject<T>.Delegate0(CS$<>8__locals1.method_0), null);
			IL_00E7:
			return base.BindInvoke(CS$<>8__locals1.invokeBinder_0, CS$<>8__locals1.dynamicMetaObject_0);
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x00047328 File Offset: 0x00045528
		public override DynamicMetaObject BindBinaryOperation(BinaryOperationBinder binder, DynamicMetaObject arg)
		{
			for (;;)
			{
				IL_006A:
				BinaryOperationBinder binaryOperationBinder_0;
				DynamicProxyMetaObject<T> dynamicProxyMetaObject_0;
				DynamicMetaObject dynamicMetaObject_0;
				for (;;)
				{
					binaryOperationBinder_0 = binder;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ad967bb0ba3f44528134c153f7ab1ef6 == 0)
					{
						goto IL_001F;
					}
					goto IL_0029;
					IL_0003:
					dynamicMetaObject_0 = arg;
					num = 6;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_fa29cbda752f45acbe81e7d5285df2ba == 0)
					{
						continue;
					}
					goto IL_0029;
					IL_001F:
					dynamicProxyMetaObject_0 = this;
					goto IL_0003;
					IL_0029:
					switch (num)
					{
					case 0:
						goto IL_001F;
					case 1:
						goto IL_00D6;
					case 2:
						goto IL_0003;
					case 3:
						break;
					case 4:
						goto IL_006A;
					case 5:
						goto IL_0090;
					case 6:
						goto IL_0073;
					default:
						goto IL_001F;
					}
				}
			}
			IL_0073:
			if (!this.method_0(Class15.smethod_17(277621112 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_9f9b31fb7a85497499112abf86cccc98)))
			{
				goto IL_00D6;
			}
			IL_0090:
			return this.method_1(Class15.smethod_17(2048549929 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_e764f065c2fa404a85129e2e957d4f18), CS$<>8__locals1.binaryOperationBinder_0, DynamicProxyMetaObject<T>.smethod_1(new DynamicMetaObject[] { CS$<>8__locals1.dynamicMetaObject_0 }), new DynamicProxyMetaObject<T>.Delegate0(CS$<>8__locals1.method_0), null);
			IL_00D6:
			return base.BindBinaryOperation(CS$<>8__locals1.binaryOperationBinder_0, CS$<>8__locals1.dynamicMetaObject_0);
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x00047420 File Offset: 0x00045620
		public override DynamicMetaObject BindUnaryOperation(UnaryOperationBinder binder)
		{
			for (;;)
			{
				IL_0054:
				UnaryOperationBinder unaryOperationBinder_0;
				DynamicProxyMetaObject<T> dynamicProxyMetaObject_0;
				for (;;)
				{
					unaryOperationBinder_0 = binder;
					int num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_b17e63564ae246399767b60cf4b1528a == 0)
					{
						goto IL_0003;
					}
					IL_001C:
					switch (num)
					{
					case 1:
						goto IL_005E;
					case 2:
						continue;
					case 3:
						goto IL_0054;
					case 4:
						goto IL_00B1;
					}
					IL_0003:
					dynamicProxyMetaObject_0 = this;
					num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_948fa5c193d44e279b41c3a0fab7b5c9 == 0)
					{
						goto IL_001C;
					}
					goto IL_005D;
				}
			}
			IL_005D:
			IL_005E:
			if (this.method_0(Class15.smethod_17(197566581 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_c27e9fccdfcc44999155a4980faa4e81)))
			{
				return this.method_1(Class15.smethod_17(768796634 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_3baf10aa2a73406aa2bb349717d797c7), CS$<>8__locals1.unaryOperationBinder_0, DynamicProxyMetaObject<T>.smethod_0(), new DynamicProxyMetaObject<T>.Delegate0(CS$<>8__locals1.method_0), null);
			}
			IL_00B1:
			return base.BindUnaryOperation(CS$<>8__locals1.unaryOperationBinder_0);
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x000474EC File Offset: 0x000456EC
		public override DynamicMetaObject BindGetIndex(GetIndexBinder binder, DynamicMetaObject[] indexes)
		{
			for (;;)
			{
				IL_0069:
				GetIndexBinder getIndexBinder_0;
				DynamicProxyMetaObject<T> dynamicProxyMetaObject_0;
				DynamicMetaObject[] dynamicMetaObject_0;
				for (;;)
				{
					IL_004D:
					getIndexBinder_0 = binder;
					int num = 1;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_a41eabd4b99f489fb7d86310d3f95ba2 == 0)
					{
						goto Block_3;
					}
					for (;;)
					{
						switch (num)
						{
						case 1:
							dynamicProxyMetaObject_0 = this;
							goto IL_0003;
						case 2:
							goto IL_00D0;
						case 3:
							goto IL_004D;
						case 4:
							goto IL_0069;
						case 5:
							goto IL_0093;
						case 6:
							goto IL_0003;
						}
						goto Block_2;
						IL_0003:
						dynamicMetaObject_0 = indexes;
						num = 0;
						if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 != 0)
						{
							goto Block_1;
						}
					}
				}
			}
			Block_1:
			Block_2:
			Block_3:
			if (!this.method_0(Class15.smethod_17(1603822208 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d5af2cccac2f47ed978e804138a35d1c)))
			{
				goto IL_00D0;
			}
			IL_0093:
			return this.method_1(Class15.smethod_17(1243271488 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_67a271e0ae064fc7a3a74905868add95), CS$<>8__locals1.getIndexBinder_0, DynamicProxyMetaObject<T>.smethod_2(CS$<>8__locals1.dynamicMetaObject_0), new DynamicProxyMetaObject<T>.Delegate0(CS$<>8__locals1.method_0), null);
			IL_00D0:
			return base.BindGetIndex(CS$<>8__locals1.getIndexBinder_0, CS$<>8__locals1.dynamicMetaObject_0);
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x000475E0 File Offset: 0x000457E0
		public override DynamicMetaObject BindSetIndex(SetIndexBinder binder, DynamicMetaObject[] indexes, DynamicMetaObject value)
		{
			for (;;)
			{
				IL_0074:
				SetIndexBinder setIndexBinder_0;
				DynamicProxyMetaObject<T> dynamicProxyMetaObject_0;
				DynamicMetaObject[] dynamicMetaObject_0;
				DynamicMetaObject dynamicMetaObject_1;
				for (;;)
				{
					IL_006A:
					setIndexBinder_0 = binder;
					for (;;)
					{
						IL_0060:
						dynamicProxyMetaObject_0 = this;
						for (;;)
						{
							dynamicMetaObject_0 = indexes;
							int num = 1;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_725e5f82c8704b39b66ebddcee8df7fa != 0)
							{
								goto IL_0003;
							}
							IL_001C:
							switch (num)
							{
							case 1:
								IL_0003:
								dynamicMetaObject_1 = value;
								num = 0;
								if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a == 0)
								{
									goto IL_001C;
								}
								break;
							case 2:
								continue;
							case 3:
								goto IL_0060;
							case 4:
								goto IL_009B;
							case 5:
								goto IL_00DE;
							case 6:
								goto IL_006A;
							case 7:
								goto IL_0074;
							}
							goto Block_1;
						}
					}
				}
			}
			Block_1:
			if (!this.method_0(Class15.smethod_17(486509934 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_39d5fbfa4fe34ed9908db538e5340a6c)))
			{
				goto IL_00DE;
			}
			IL_009B:
			return this.method_3(Class15.smethod_17(2128244972 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_871a407507f34aa3b5bf52517d4f63a9), CS$<>8__locals1.setIndexBinder_0, DynamicProxyMetaObject<T>.smethod_3(CS$<>8__locals1.dynamicMetaObject_0, CS$<>8__locals1.dynamicMetaObject_1), new DynamicProxyMetaObject<T>.Delegate0(CS$<>8__locals1.method_0));
			IL_00DE:
			return base.BindSetIndex(CS$<>8__locals1.setIndexBinder_0, CS$<>8__locals1.dynamicMetaObject_0, CS$<>8__locals1.dynamicMetaObject_1);
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x000476E8 File Offset: 0x000458E8
		public override DynamicMetaObject BindDeleteIndex(DeleteIndexBinder binder, DynamicMetaObject[] indexes)
		{
			for (;;)
			{
				IL_0063:
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_f93c7140125045538ae5c40c6f39a5af == 0)
				{
					break;
				}
				DeleteIndexBinder deleteIndexBinder_0;
				DynamicProxyMetaObject<T> dynamicProxyMetaObject_0;
				DynamicMetaObject[] dynamicMetaObject_0;
				for (;;)
				{
					IL_0043:
					switch (num)
					{
					case 1:
						for (;;)
						{
							deleteIndexBinder_0 = binder;
							num = 5;
							if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_d97e64d0f425406b9649f2b4562a5f0e != 0)
							{
								goto IL_0043;
							}
						}
						break;
					case 2:
						goto IL_0063;
					case 3:
						goto IL_009C;
					case 4:
						goto IL_000B;
					case 5:
						dynamicProxyMetaObject_0 = this;
						goto IL_000B;
					}
					goto Block_3;
					IL_000B:
					dynamicMetaObject_0 = indexes;
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 != 0)
					{
						goto Block_1;
					}
				}
			}
			Block_1:
			Block_3:
			if (this.method_0(Class15.smethod_17(1678109486 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a)))
			{
				return this.method_4(Class15.smethod_17(41434791 ^ <Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_079bd9b874b24353bef46f6c3f5d741d), CS$<>8__locals1.deleteIndexBinder_0, DynamicProxyMetaObject<T>.smethod_2(CS$<>8__locals1.dynamicMetaObject_0), new DynamicProxyMetaObject<T>.Delegate0(CS$<>8__locals1.method_0));
			}
			IL_009C:
			return base.BindDeleteIndex(CS$<>8__locals1.deleteIndexBinder_0, CS$<>8__locals1.dynamicMetaObject_0);
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x00003CA0 File Offset: 0x00001EA0
		private static Expression[] smethod_0()
		{
			return CollectionUtils.ArrayEmpty<Expression>();
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x00003CA7 File Offset: 0x00001EA7
		private static IEnumerable<Expression> smethod_1(params DynamicMetaObject[] args)
		{
			return args.Select(new Func<DynamicMetaObject, Expression>(DynamicProxyMetaObject<T>.<>c.<>c_0.method_0));
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x000477E4 File Offset: 0x000459E4
		private static Expression[] smethod_2(DynamicMetaObject[] dynamicMetaObject_0)
		{
			Expression[] array;
			for (;;)
			{
				array = new NewArrayExpression[] { Expression.NewArrayInit(typeof(object), DynamicProxyMetaObject<T>.smethod_1(dynamicMetaObject_0)) };
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_75738dd4edc84122bfe3748a1ea03d43 != 0)
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
			return array;
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x00047838 File Offset: 0x00045A38
		private static Expression[] smethod_3(DynamicMetaObject[] dynamicMetaObject_0, DynamicMetaObject dynamicMetaObject_1)
		{
			Expression expression;
			for (;;)
			{
				expression = dynamicMetaObject_1.Expression;
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a == 0)
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
			return new Expression[]
			{
				Expression.NewArrayInit(typeof(object), DynamicProxyMetaObject<T>.smethod_1(dynamicMetaObject_0)),
				expression.Type.IsValueType() ? Expression.Convert(expression, typeof(object)) : expression
			};
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x000478B4 File Offset: 0x00045AB4
		private static ConstantExpression smethod_4(DynamicMetaObjectBinder dynamicMetaObjectBinder_0)
		{
			Type type;
			for (;;)
			{
				type = dynamicMetaObjectBinder_0.GetType();
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_11c6824de6514281a8425f6d6ab1a2d5 == 0)
				{
					goto IL_000C;
				}
				IL_0026:
				switch (num)
				{
				case 1:
				case 4:
					goto IL_000C;
				case 2:
					continue;
				case 3:
					goto IL_0003;
				}
				break;
				IL_000C:
				if (type.IsVisible())
				{
					num = 0;
					if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_92ac2a37edba4e2587eb1b9e8af3f63f == 0)
					{
						goto IL_0026;
					}
					break;
				}
				IL_0003:
				type = type.BaseType();
				goto IL_000C;
			}
			return Expression.Constant(dynamicMetaObjectBinder_0, type);
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x00047928 File Offset: 0x00045B28
		private DynamicMetaObject method_1(string string_0, DynamicMetaObjectBinder dynamicMetaObjectBinder_0, IEnumerable<Expression> ienumerable_0, [Nullable(new byte[] { 1, 0 })] DynamicProxyMetaObject<T>.Delegate0 fallback, [Nullable(new byte[] { 2, 0 })] DynamicProxyMetaObject<T>.Delegate0 fallbackInvoke = null)
		{
			DynamicMetaObject dynamicMetaObject = fallback(null);
			return this.method_2(string_0, dynamicMetaObjectBinder_0, ienumerable_0, dynamicMetaObject, fallbackInvoke);
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x0004794C File Offset: 0x00045B4C
		private DynamicMetaObject method_2(string string_0, DynamicMetaObjectBinder dynamicMetaObjectBinder_0, IEnumerable<Expression> ienumerable_0, DynamicMetaObject dynamicMetaObject_0, [Nullable(new byte[] { 2, 0 })] DynamicProxyMetaObject<T>.Delegate0 fallbackInvoke)
		{
			ParameterExpression parameterExpression = Expression.Parameter(typeof(object), null);
			IList<Expression> list = new List<Expression>();
			list.Add(Expression.Convert(base.Expression, typeof(T)));
			list.Add(DynamicProxyMetaObject<T>.smethod_4(dynamicMetaObjectBinder_0));
			list.AddRange(ienumerable_0);
			list.Add(parameterExpression);
			DynamicMetaObject dynamicMetaObject = new DynamicMetaObject(parameterExpression, BindingRestrictions.Empty);
			if (dynamicMetaObjectBinder_0.ReturnType != typeof(object))
			{
				dynamicMetaObject = new DynamicMetaObject(Expression.Convert(dynamicMetaObject.Expression, dynamicMetaObjectBinder_0.ReturnType), dynamicMetaObject.Restrictions);
			}
			if (fallbackInvoke != null)
			{
				dynamicMetaObject = fallbackInvoke(dynamicMetaObject);
			}
			return new DynamicMetaObject(Expression.Block(new ParameterExpression[] { parameterExpression }, new Expression[] { Expression.Condition(Expression.Call(Expression.Constant(this.dynamicProxy_0), typeof(DynamicProxy<T>).GetMethod(string_0), list), dynamicMetaObject.Expression, dynamicMetaObject_0.Expression, dynamicMetaObjectBinder_0.ReturnType) }), this.jyEkkExheH().Merge(dynamicMetaObject.Restrictions).Merge(dynamicMetaObject_0.Restrictions));
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x00047A68 File Offset: 0x00045C68
		private DynamicMetaObject method_3(string string_0, DynamicMetaObjectBinder dynamicMetaObjectBinder_0, IEnumerable<Expression> ienumerable_0, [Nullable(new byte[] { 1, 0 })] DynamicProxyMetaObject<T>.Delegate0 fallback)
		{
			DynamicMetaObject dynamicMetaObject = fallback(null);
			ParameterExpression parameterExpression = Expression.Parameter(typeof(object), null);
			IList<Expression> list = new List<Expression>();
			list.Add(Expression.Convert(base.Expression, typeof(T)));
			list.Add(DynamicProxyMetaObject<T>.smethod_4(dynamicMetaObjectBinder_0));
			list.AddRange(ienumerable_0);
			list[list.Count - 1] = Expression.Assign(parameterExpression, list[list.Count - 1]);
			return new DynamicMetaObject(Expression.Block(new ParameterExpression[] { parameterExpression }, new Expression[] { Expression.Condition(Expression.Call(Expression.Constant(this.dynamicProxy_0), typeof(DynamicProxy<T>).GetMethod(string_0), list), parameterExpression, dynamicMetaObject.Expression, typeof(object)) }), this.jyEkkExheH().Merge(dynamicMetaObject.Restrictions));
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x00047B4C File Offset: 0x00045D4C
		private DynamicMetaObject method_4(string string_0, DynamicMetaObjectBinder dynamicMetaObjectBinder_0, Expression[] expression_0, [Nullable(new byte[] { 1, 0 })] DynamicProxyMetaObject<T>.Delegate0 fallback)
		{
			DynamicMetaObject dynamicMetaObject = fallback(null);
			IList<Expression> list = new List<Expression>();
			list.Add(Expression.Convert(base.Expression, typeof(T)));
			list.Add(DynamicProxyMetaObject<T>.smethod_4(dynamicMetaObjectBinder_0));
			list.AddRange(expression_0);
			return new DynamicMetaObject(Expression.Condition(Expression.Call(Expression.Constant(this.dynamicProxy_0), typeof(DynamicProxy<T>).GetMethod(string_0), list), Expression.Empty(), dynamicMetaObject.Expression, typeof(void)), this.jyEkkExheH().Merge(dynamicMetaObject.Restrictions));
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x00047BE8 File Offset: 0x00045DE8
		private BindingRestrictions jyEkkExheH()
		{
			while (base.Value != null)
			{
				int num = 1;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_4b8a72ce901241b5b52fe60600cb3607 != 0)
				{
					switch (num)
					{
					case 0:
						goto IL_003E;
					case 1:
					case 4:
						break;
					case 2:
						continue;
					case 3:
						IL_0046:
						return BindingRestrictions.GetInstanceRestriction(base.Expression, null);
					default:
						goto IL_003E;
					}
				}
				IL_0053:
				return BindingRestrictions.GetTypeRestriction(base.Expression, base.LimitType);
			}
			IL_003E:
			if (base.HasValue)
			{
				goto IL_0046;
			}
			goto IL_0053;
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x00003CCE File Offset: 0x00001ECE
		public override IEnumerable<string> GetDynamicMemberNames()
		{
			return this.dynamicProxy_0.GetDynamicMemberNames((T)((object)base.Value));
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x00003CE6 File Offset: 0x00001EE6
		internal static bool smethod_5()
		{
			return DynamicProxyMetaObject<T>.object_0 == null;
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x00003CF0 File Offset: 0x00001EF0
		internal static object smethod_6()
		{
			return DynamicProxyMetaObject<T>.object_0;
		}

		// Token: 0x040003D3 RID: 979
		private readonly DynamicProxy<T> dynamicProxy_0;

		// Token: 0x040003D4 RID: 980
		private static object object_0;

		// Token: 0x02000095 RID: 149
		// (Invoke) Token: 0x06000688 RID: 1672
		[NullableContext(0)]
		private delegate DynamicMetaObject Delegate0([Nullable(2)] DynamicMetaObject errorSuggestion);

		// Token: 0x02000096 RID: 150
		[Nullable(0)]
		private sealed class Class5 : GetMemberBinder
		{
			// Token: 0x0600068C RID: 1676 RVA: 0x00047C5C File Offset: 0x00045E5C
			internal Class5(InvokeMemberBinder invokeMemberBinder_0)
				: base(invokeMemberBinder_0.Name, invokeMemberBinder_0.IgnoreCase)
			{
				int num = 0;
				if (<Module>{3dee82c7-727c-4458-89d5-fe2210af08f9}.m_1dfa7ff2d3d1448283f3542c08c99455.m_ee35a23edd8f4998990ec1a2b40fc61a == 0)
				{
					switch (num)
					{
					}
				}
			}

			// Token: 0x0600068D RID: 1677 RVA: 0x00003CF7 File Offset: 0x00001EF7
			public override DynamicMetaObject FallbackGetMember(DynamicMetaObject target, [Nullable(2)] DynamicMetaObject errorSuggestion)
			{
				throw new NotSupportedException();
			}

			// Token: 0x0600068E RID: 1678 RVA: 0x00003CFE File Offset: 0x00001EFE
			internal static bool smethod_0()
			{
				return DynamicProxyMetaObject<T>.Class5.object_0 == null;
			}

			// Token: 0x0600068F RID: 1679 RVA: 0x00003D08 File Offset: 0x00001F08
			internal static object smethod_1()
			{
				return DynamicProxyMetaObject<T>.Class5.object_0;
			}

			// Token: 0x040003D5 RID: 981
			internal static object object_0;
		}
	}
}
