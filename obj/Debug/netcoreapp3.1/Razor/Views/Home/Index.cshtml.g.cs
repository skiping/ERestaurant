#pragma checksum "E:\VS Working\.net core\ERestaurant\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0862e5a819f29773e765aef6b3cb93adc5883257"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\VS Working\.net core\ERestaurant\Views\_ViewImports.cshtml"
using ERestaurant;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\VS Working\.net core\ERestaurant\Views\_ViewImports.cshtml"
using ERestaurant.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0862e5a819f29773e765aef6b3cb93adc5883257", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8261dcff186f985aa957a0b7558f51356526b46e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("v-for", new global::Microsoft.AspNetCore.Html.HtmlString("item in groups"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\VS Working\.net core\ERestaurant\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "菜单列表";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""app"" style=""margin-top: 50px;"" class=""row-fluid"">
    <div class=""span12"">
        <div class=""well well_condition well-con"" style=""margin-top: 30px; margin-bottom: 13px;position: relative;"">
            <div class=""span3"">
                <div class=""btn-group"">
                    <a class=""btn again-btn taps-p"">
                        <span class=""name-address"">菜单</span>
                    </a>
                </div> »
                &nbsp;
            </div>

            <div class=""span9 order_person dropdown"" style=""text-align:right;"">
                <div style=""text-align:left;padding-top: 5px; "">
                    <ul class=""tlist pull-right"">
                        <li id=""zonghe0"">
                            <select v-model=""type"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0862e5a819f29773e765aef6b3cb93adc58832574761", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0862e5a819f29773e765aef6b3cb93adc58832575911", async() => {
                WriteLiteral("{{item.name}}");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </select>
                        </li>
                        <li id=""yuyue0""><input type=""text"" class=""form-control input-sm"" placeholder=""关键字搜索""
                                               v-model=""keyword"" /></li>
                        <li id=""jiage0""><button class=""btn btn-success"" ");
            WriteLiteral("@click=\"bindData()\">Search</button></li>\r\n                        <li>\r\n                            <button class=\"btn btn-success\" ");
            WriteLiteral(@"@click=""showCart()"">我的预定</button>
                        </li>
                    </ul>
                </div>

                <div style=""clear:both;""></div>
            </div>
            <div style=""clear:both;""></div>
        </div>

        <div class=""well well_person"">
            <table class=""table table-responsive table-bordered table-hover"">
                <tr>
                    <th>序号</th>
                    <th>菜名</th>
                    <th>介绍</th>
                    <th>单价</th>
                    <th>上架时间</th>
                    <th>库存</th>
                    <th>分类</th>
                    <th>图片</th>
                    <th>修改</th>
                </tr>
                <tr v-for=""data in dataList"">
                    <td>{{data.id}}</td>
                    <td>{{data.name}}</td>
                    <td>{{data.description}}</td>
                    <td>{{data.price | formatCurrency}}</td>
                    <td>{{data.createTime | dateFormat}}</td>
 ");
            WriteLiteral(@"                   <td>{{data.stockCount}}</td>
                    <td>{{data.type}}</td>
                    <td><img :src=""data.image"" width=""100"" height=""100"" /></td>
                    <td>
                        <button class=""btn btn-success"" ");
            WriteLiteral("@click=\"add(data)\">预订</button>\r\n                    </td>\r\n                </tr>\r\n            </table>\r\n\r\n            <pagination v-model=\"page\" :total=\"total\" :page-size=\"pageSize\" ");
            WriteLiteral(@"@input=""pageChange()""></pagination>
        </div>
    </div>
</div>

<script>
    var app = new Vue({
        el: ""#app"",
        data: {
            dataList: [],

            pageSize: 2,
            page: 1,
            total: 0,

            type: """",
            keyword: """",

            groups: [],
        },
        mounted() {
            this.getGrops();
            this.bindData();
        },

        methods: {
            bindData() {
                var queryString = `pageNo=${this.page}&pageSize=${this.pageSize}&type=${this.type}&keyword=${this.keyword}`;
                axios.get(`/Food/GetFoodMenus?${queryString}`, {})
                    .then(res => {
                        if (res.data.status == true) {
                            this.dataList = res.data.data;
                            this.total = res.data.total;
                        }
                        else {
                            alert(""获取数据失败！"");
                        }
        ");
            WriteLiteral(@"          })
                  .catch((e) => {
                    console.log('获取数据失败!');
                  });
            },

            getGrops() {
                  axios.get(`/Group/GetGroups`)
                    .then(res => {
                        if (res.data.status == true) {
                            this.groups = res.data.data;
                        }
                  })
            },

            add(data) {              
                var foods = JSON.parse(localStorage.getItem(""myCart""));
                foods = foods || [];
                foods.push(data);
                var obj = JSON.stringify(foods);
                localStorage.setItem(""myCart"", obj);

                alert(""预定成功"");
            },

            showCart() {
                location.href = ""/Home/Cart"";
            },

            pageChange() {
                this.bindData();
            }
        }
    });
</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
