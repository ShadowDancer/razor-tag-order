using Microsoft.AspNetCore.Razor.TagHelpers;

namespace RazorTagOrder
{
    [HtmlTargetElement(Attributes = "href")]
    public class MyTagHelper : TagHelper
    {
        /// <summary>
        ///     Src
        /// </summary>
        [HtmlAttributeName("href")]
        public string Href { get; set; }
        
        //public override int Order => int.MaxValue;

        public override int Order => int.MinValue;

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.SetAttribute("href", "http://localhost:20299" + Href);
        }
    }
}