#pragma checksum "E:\VS Working\.net core\ERestaurant\Views\Food\FoodList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5b2cce98240a497df4862c4998eaae40762f3c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Food_FoodList), @"mvc.1.0.view", @"/Views/Food/FoodList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5b2cce98240a497df4862c4998eaae40762f3c8", @"/Views/Food/FoodList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8261dcff186f985aa957a0b7558f51356526b46e", @"/Views/_ViewImports.cshtml")]
    public class Views_Food_FoodList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("v-for", new global::Microsoft.AspNetCore.Html.HtmlString("x in groups"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\VS Working\.net core\ERestaurant\Views\Food\FoodList.cshtml"
  
    ViewData["Title"] = "菜单列表";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""app"" style=""margin-top: 50px;"" class=""row-fluid"">
    <div class=""span12"">
        <div class=""well well_condition well-con"" style=""margin-top: 30px; margin-bottom: 13px;position: relative;"">
            <div class=""span6"">
                <div class=""btn-group"">
                    <a class=""btn again-btn taps-p"">
                        <span class=""name-address"">菜单列表</span>
                    </a>
                </div> »
                &nbsp;
            </div>

            <div class=""span6 order_person dropdown"" style=""text-align:right;"">
                <div style=""text-align:left;padding-top: 5px; "">
                    <ul class=""tlist pull-right"">
                        <li>
                            <button class=""btn btn-success"" ");
            WriteLiteral(@"@click=""add()"">上架新菜品</button>
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
            WriteLiteral("               <td>{{data.stockCount}}</td>\r\n                    <td>{{data.type}}</td>\r\n                    <td><img :src=\"data.image\" width=\"100\" height=\"100\" /></td>\r\n                    <td>\r\n                        <button class=\"btn btn-success\" ");
            WriteLiteral("@click=\"edit(data)\">编辑</button>\r\n                        <button class=\"btn btn-danger\" ");
            WriteLiteral("@click=\"deleteData(data.id)\">删除</button>\r\n                    </td>\r\n                </tr>\r\n            </table>\r\n\r\n            <pagination v-model=\"page\" :total=\"total\" :page-size=\"pageSize\" ");
            WriteLiteral(@"@input=""pageChange()""></pagination>
        </div>

        <div class=""modal fade"" id=""myModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
            <div class=""modal-dialog"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">&times;</button>
                        <h4 class=""modal-title"" id=""myModalLabel"">{{title}}</h4>
                    </div>
                    <div class=""modal-body"">
                        <div class=""form-horizontal"">
                            <div class=""form-group"">
                                <label class=""col-sm-2 control-label"">名称:</label>
                                <div class=""col-sm-4"">
                                    <input type=""text"" class=""form-control input-sm"" v-model=""model.Name"" />
                                </div>
                            </div>
   ");
            WriteLiteral(@"                         <div class=""form-group"">
                                <label class=""col-sm-2 control-label"">介绍:</label>
                                <div class=""col-sm-4"">
                                    <input type=""text"" class=""form-control input-sm"" v-model=""model.Description"" />
                                </div>
                            </div>
                            <div class=""form-group"">
                                <label class=""col-sm-2 control-label"">价格:</label>
                                <div class=""col-sm-4"">
                                    <input type=""text"" class=""form-control input-sm"" v-model=""model.Price"" />
                                </div>
                            </div>
                            <div class=""form-group"">
                                <label class=""col-sm-2 control-label"">库存:</label>
                                <div class=""col-sm-4"">
                                    <input type=""text"" class=""form-c");
            WriteLiteral(@"ontrol input-sm"" v-model=""model.StockCount"" />
                                </div>
                            </div>
                            <div class=""form-group"">
                                <label class=""col-sm-2 control-label"">类别:</label>
                                <div class=""col-sm-4"">
                                    <select class=""form-control input-sm"" v-model=""model.Type"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5b2cce98240a497df4862c4998eaae40762f3c88873", async() => {
                WriteLiteral("{{x.name}}");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </select>
                                </div>
                            </div>
                            <div class=""form-group"">
                                <label class=""col-sm-2 control-label"">图片:</label>
                                <div class=""col-sm-4"">
                                    <img width=""100"" height=""100"" :src=""model.Image"" />
                                </div>
                                <div class=""col-sm-4"">
                                    <label class=""control-label"" style=""cursor: pointer ""
                                           for=""imageUpload"">上传</label>
                                    <div class=""hidden"">
                                        <file-upload ref=""imageUpload""
                                                     name=""imageUpload""
                                                    ");
            WriteLiteral("@change=\"checkFile\"\r\n                                                     :auto-save=\"true\"\r\n                                                     :save-url=\"uploadUrl\"\r\n                                                     ");
            WriteLiteral(@"@complete=""afterUploaded""></file-upload>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-default"" ");
            WriteLiteral("@click=\"close()\">关闭</button>\r\n                        <button type=\"button\" class=\"btn btn-primary\" ");
            WriteLiteral(@"@click=""submit()"">提交</button>
                    </div>
                </div><!-- /.modal-content -->
            </div><!-- /.modal -->
        </div>
    </div>
</div>

<script>
    var app = new Vue({
        el: ""#app"",
        data: {
            dataList: [],

            pageSize: 10,
            page: 1,
            total: 0,

            backup: """",
            title: """",

            model: {
                Id: 0,
                Name: """",
                Description: """",
                Price: 0,
                StockCount: 0,
                Type: """",
                Image: """"
            },

            uploadUrl: ""/Food/UploadFile"",

            groups: []
        },
        mounted() {
            this.getGrops();
            this.bindData();
        },

        methods: {
            bindData() {
                var queryString = `pageNo=${this.page}&pageSize=${this.pageSize}`;
                axios.get(`/Food/GetFoodMenus?${queryString}`, {})
   ");
            WriteLiteral(@"                 .then(res => {
                        if (res.data.status == true) {
                            this.dataList = res.data.data;
                            this.total = res.data.total;
                        }
                        else {
                            alert(""获取数据失败！"");
                        }
                  })
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

            add() {
                this.title = ""添加菜品"";

                $(""#myModal"").modal('show');
            },

            close() {
                this.model = {
                    Id: 0,
                    Name: """",
          ");
            WriteLiteral(@"          Description: """",
                    Price: 0,
                    StockCount: 0,
                    Type: """",
                    Image: """"
                };

                $(""#myModal"").modal('hide');
            },

            edit(data) {
                this.title = ""修改菜品"";
                this.model = {
                    Id: data.id,
                    Name: data.name,
                    Description: data.description,
                    Price: data.price,
                    StockCount: data.stockCount,
                    Type: data.type,
                    Image: data.image,
                };

                $(""#myModal"").modal('show');
            },

            deleteData(id) {
               axios.post(""/Food/Delete?id="" + id).then(res => {
                    if (res.data.status == true) {
                        alert(""操作成功！"");
                        this.bindData();
                    }
                    else {
                        a");
            WriteLiteral(@"lert(""系统出错了！"");
                    }
                });
            },

            submit() {
                if (!this.model.Name || !this.model.Description || !this.model.Price
                    || !this.model.StockCount || !this.model.Type) {
                    alert(""请完成所有信息！"")
                    return;
                }

                if (isNaN(parseFloat(this.model.Price))) {
                    alert(""价格必须是数字！"")
                    return;
                }

                 if (isNaN(parseFloat(this.model.StockCount))) {
                    alert(""库存必须是数字！"")
                    return;
                }

                var model = $.extend(true, {}, this.model);
                var data = {
                    Id: model.Id,
                    Name: model.Name,
                    Description: model.Description,
                    Image: model.Image,
                    Type: model.Type,
                    Price: parseFloat(model.Price),
                    S");
            WriteLiteral(@"tockCount: parseFloat(model.StockCount),
                }

                axios.post(""/Food/AddFood"", data).then(res => {
                    if (res.data.status == true) {
                        alert(""操作成功！"");
                        this.close()
                        this.bindData();
                    }
                    else {
                        alert(""系统出错了！"");
                    }
                });
            },

            afterUploaded(res) {
                if (res.success == true) {
                    this.model.Image = res.fileName;
                }
                else {
                    alert(""系统出错，请重试！"");
                }
            },

            checkFile(evt) {
                let msg = """";

                let imgExt = /(\.|\/)(jpe|jpg|jpeg|bmp|png)$/i;
                let hasError = evt.files.some(x => {
                    if (!imgExt.test(x.extension))
                        msg = ""只能上传后缀为jpe|jpg|jpeg|bmp|png的图片"";
                ");
            WriteLiteral("    return msg.length !== 0;\r\n                });\r\n\r\n                if (hasError) alert(msg);\r\n            },\r\n\r\n            pageChange() {\r\n                this.bindData();\r\n            }\r\n        }\r\n    });\r\n</script>");
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
