#pragma checksum "E:\VS Working\.net core\ERestaurant\Views\Home\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f703bfca9ba1aa27b3456fa601005e32bb0f26cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Cart), @"mvc.1.0.view", @"/Views/Home/Cart.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f703bfca9ba1aa27b3456fa601005e32bb0f26cb", @"/Views/Home/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8261dcff186f985aa957a0b7558f51356526b46e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\VS Working\.net core\ERestaurant\Views\Home\Cart.cshtml"
  
    ViewData["Title"] = "购物车";
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
                        <span class=""name-address"">我的预订</span>
                    </a>
                </div> »
                &nbsp;
            </div>

            <div class=""span9 order_person dropdown"" style=""text-align:right;"">
                <div style=""text-align:left;padding-top: 5px; "">
                    <ul class=""tlist pull-right"">
                        <li>
                            <button class=""btn btn-success"" ");
            WriteLiteral(@"@click=""submit()"">结算提交</button>
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
                    <th>单价</th>
                    <th>修改</th>
                </tr>
                <tr v-for=""(data, i) in dataList"">
                    <td>{{data.id}}</td>
                    <td>{{data.name}}</td>
                    <td>{{data.price | formatCurrency}}</td>
                    <td>
                        <button class=""btn btn-success"" ");
            WriteLiteral(@"@click=""deleteFromCart(i)"">不要了</button>
                    </td>
                </tr>
                <tr>
                    <td>总额</td>
                    <td></td>
                    <td></td>
                    <td>{{totalPrice | formatCurrency}}</td>
                </tr>
            </table>
        </div>
    </div>
</div>

<script>
    var app = new Vue({
        el: ""#app"",
        data: {
            dataList: [],

            user: '");
#nullable restore
#line 66 "E:\VS Working\.net core\ERestaurant\Views\Home\Cart.cshtml"
              Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"'
        },
        mounted() {
            this.dataList = JSON.parse(localStorage.getItem(""myCart""));
        },

        computed: {
            totalPrice() {
                return (this.dataList || []).
                    reduce((a, x) => a +  (x.price || 0), 0);
            }
        },

        methods: {
            deleteFromCart(index) {
                this.dataList.splice(index, 1);

                var obj = JSON.stringify(this.dataList);
                localStorage.setItem(""myCart"", obj);
            },


            submit() {
                if (!this.user) {
                    alert(""请先登录！"");
                    location.href = ""/Login/Index"";
                    return;
                }
                if (this.dataList.length == 0) {
                    alert(""请先点单！"");
                    return;
                }

                var foodIds = """";
                this.dataList.filter(x => foodIds += x.id + "","");
                var params = `totalPr");
            WriteLiteral(@"ice=${this.totalPrice}&foodIds=${foodIds}`;
                axios.post(""/TakeOut/AddOrder?"" + params).then(res => {
                    if (res.data.status = ""1"") {
                        alert(""下单成功！"");
                        localStorage.setItem(""myCart"", null);
                        location.href=""/Home/Index""
                    }
                    else {
                        alert(""系统出错了！"");
                    }
                });
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
