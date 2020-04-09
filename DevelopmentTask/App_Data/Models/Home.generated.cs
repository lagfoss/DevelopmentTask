//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v8.6.0
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
using Umbraco.ModelsBuilder.Embedded;

namespace Umbraco.Web.PublishedModels
{
	/// <summary>Home</summary>
	[PublishedModel("home")]
	public partial class Home : PublishedContentModel, IBaseContent, IFooter
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.0")]
		public new const string ModelTypeAlias = "home";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Home, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Home(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Product1Items
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.0")]
		[ImplementPropertyType("product1Items")]
		public global::System.Web.IHtmlString Product1Items => this.Value<global::System.Web.IHtmlString>("product1Items");

		///<summary>
		/// Product1Name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.0")]
		[ImplementPropertyType("product1Name")]
		public string Product1Name => this.Value<string>("product1Name");

		///<summary>
		/// Product1Price
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.0")]
		[ImplementPropertyType("product1Price")]
		public string Product1Price => this.Value<string>("product1Price");

		///<summary>
		/// Product2Items
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.0")]
		[ImplementPropertyType("product2Items")]
		public global::System.Web.IHtmlString Product2Items => this.Value<global::System.Web.IHtmlString>("product2Items");

		///<summary>
		/// Product2Name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.0")]
		[ImplementPropertyType("product2Name")]
		public string Product2Name => this.Value<string>("product2Name");

		///<summary>
		/// Product2Price
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.0")]
		[ImplementPropertyType("product2Price")]
		public string Product2Price => this.Value<string>("product2Price");

		///<summary>
		/// Product3Items
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.0")]
		[ImplementPropertyType("product3Items")]
		public global::System.Web.IHtmlString Product3Items => this.Value<global::System.Web.IHtmlString>("product3Items");

		///<summary>
		/// Product3Name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.0")]
		[ImplementPropertyType("product3Name")]
		public string Product3Name => this.Value<string>("product3Name");

		///<summary>
		/// Product3Price
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.0")]
		[ImplementPropertyType("product3Price")]
		public string Product3Price => this.Value<string>("product3Price");

		///<summary>
		/// Product4Items
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.0")]
		[ImplementPropertyType("product4Items")]
		public global::System.Web.IHtmlString Product4Items => this.Value<global::System.Web.IHtmlString>("product4Items");

		///<summary>
		/// Product4Name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.0")]
		[ImplementPropertyType("product4Name")]
		public string Product4Name => this.Value<string>("product4Name");

		///<summary>
		/// Product4Price
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.0")]
		[ImplementPropertyType("product4Price")]
		public string Product4Price => this.Value<string>("product4Price");

		///<summary>
		/// ProductsContactButton
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.0")]
		[ImplementPropertyType("productsContactButton")]
		public string ProductsContactButton => this.Value<string>("productsContactButton");

		///<summary>
		/// ProductsContactText
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.0")]
		[ImplementPropertyType("productsContactText")]
		public global::System.Web.IHtmlString ProductsContactText => this.Value<global::System.Web.IHtmlString>("productsContactText");

		///<summary>
		/// ProductsHeadline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.0")]
		[ImplementPropertyType("productsHeadline")]
		public string ProductsHeadline => this.Value<string>("productsHeadline");

		///<summary>
		/// ProductsText
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.0")]
		[ImplementPropertyType("productsText")]
		public string ProductsText => this.Value<string>("productsText");

		///<summary>
		/// Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.0")]
		[ImplementPropertyType("heroHeadline")]
		public string HeroHeadline => global::Umbraco.Web.PublishedModels.BaseContent.GetHeroHeadline(this);

		///<summary>
		/// Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.0")]
		[ImplementPropertyType("heroText")]
		public string HeroText => global::Umbraco.Web.PublishedModels.BaseContent.GetHeroText(this);

		///<summary>
		/// FooterLogo
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.0")]
		[ImplementPropertyType("footerLogo")]
		public global::Umbraco.Core.Models.PublishedContent.IPublishedContent FooterLogo => global::Umbraco.Web.PublishedModels.Footer.GetFooterLogo(this);

		///<summary>
		/// FooterText
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.0")]
		[ImplementPropertyType("footerText")]
		public global::System.Web.IHtmlString FooterText => global::Umbraco.Web.PublishedModels.Footer.GetFooterText(this);
	}
}
