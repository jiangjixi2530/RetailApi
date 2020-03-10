//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由T4模板自动生成
//       生成时间 03/06/2020 14:21:40 By DESKTOP-6T15791
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using SqlSugar;

namespace Retail.DAL.Models
{
	/// <summary>
	/// 供应商信息表
	/// </summary>
	public class retail_provider
	{

		/// <summary>
		/// 主键
		/// </summary>
		[SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
		public System.Int32  Id { get; set;}
		/// <summary>
		/// 供应商编码
		/// </summary>
		public System.String  ProviderCode { get; set;}
		/// <summary>
		/// 供应商名称
		/// </summary>
		public System.String  ProviderName { get; set;}
		/// <summary>
		/// 所在区域
		/// </summary>
		public System.Int32  AreaId { get; set;}=0;
		/// <summary>
		/// 法人
		/// </summary>
		public System.String  LegalPerson { get; set;}=string.Empty;
		/// <summary>
		/// 电话
		/// </summary>
		public System.String  Phone { get; set;}=string.Empty;
		/// <summary>
		/// 传真
		/// </summary>
		public System.String  Fax { get; set;}=string.Empty;
		/// <summary>
		/// 详细地址
		/// </summary>
		public System.String  Address { get; set;}=string.Empty;
		/// <summary>
		/// 联系人
		/// </summary>
		public System.String  Relation { get; set;}
		/// <summary>
		/// 联系人电话
		/// </summary>
		public System.String  RelationPhone { get; set;}
		/// <summary>
		/// 创建日期
		/// </summary>
		public System.DateTime  CreateDate { get; set;}
		/// <summary>
		/// 创建日期
		/// </summary>
		public System.DateTime  ModifyDate { get; set;}
		/// <summary>
		/// 备注
		/// </summary>
		public System.String  Remark { get; set;}=string.Empty;
	}
}

                