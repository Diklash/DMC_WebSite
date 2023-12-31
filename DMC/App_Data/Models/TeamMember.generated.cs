//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.4.0
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>TeamMember</summary>
	[PublishedContentModel("teamMember")]
	public partial class TeamMember : About
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "teamMember";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public TeamMember(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<TeamMember, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// MemberDescription
		///</summary>
		[ImplementPropertyType("memberDescription")]
		public IHtmlString MemberDescription
		{
			get { return this.GetPropertyValue<IHtmlString>("memberDescription"); }
		}

		///<summary>
		/// MemberImage
		///</summary>
		[ImplementPropertyType("memberImage")]
		public string MemberImage
		{
			get { return this.GetPropertyValue<string>("memberImage"); }
		}

		///<summary>
		/// MenberName
		///</summary>
		[ImplementPropertyType("menberName")]
		public string MenberName
		{
			get { return this.GetPropertyValue<string>("menberName"); }
		}

		///<summary>
		/// Profession
		///</summary>
		[ImplementPropertyType("profession")]
		public string Profession
		{
			get { return this.GetPropertyValue<string>("profession"); }
		}
	}
}
