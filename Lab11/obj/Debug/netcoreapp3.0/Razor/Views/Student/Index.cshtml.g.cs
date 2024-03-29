#pragma checksum "/home/kotoha/RiderProjects/Lab11/Lab11/Views/Student/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0dfc8dccf08f75a062e920cfdef88547ab901f1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Index), @"mvc.1.0.view", @"/Views/Student/Index.cshtml")]
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
#line 1 "/home/kotoha/RiderProjects/Lab11/Lab11/Views/_ViewImports.cshtml"
using Lab11;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/kotoha/RiderProjects/Lab11/Lab11/Views/_ViewImports.cshtml"
using Lab11.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0dfc8dccf08f75a062e920cfdef88547ab901f1c", @"/Views/Student/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dda7e751298edecef0060f1121330f217a48c396", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Lab11.Models.StudentModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/kotoha/RiderProjects/Lab11/Lab11/Views/Student/Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container"">
    <div class=""col-6"">
        
    </div>
    <div class=""card bg-dark text-white"">
        <div class=""card-body"">
            <h3 class=""card-title"">Please enter the details below.</h3>
            <div>
                <div class=""form-group col-md-5"">
                    <label>Student Name:</label>
                    <input type=""text"" name=""StudentName"" id=""StudentName"" class=""form-control"" placeholder=""Enter student name""");
            BeginWriteAttribute("required", " required=\"", 578, "\"", 589, 0);
            EndWriteAttribute();
            WriteLiteral(@"/>
                </div>
                <div class=""form-group col-md-5"">
                    <label>Student Last Name:</label>
                    <input type=""text"" name=""StudentLastName"" id=""StudentLastName"" class=""form-control"" placeholder=""Enter student lastname""");
            BeginWriteAttribute("required", " required=\"", 860, "\"", 871, 0);
            EndWriteAttribute();
            WriteLiteral(@"/>
                </div>
                <div class=""form-group col-md-5"">
                    <label>Student Address:</label>
                    <input type=""text"" name=""StudentAddress"" id=""StudentAddress"" class=""form-control"" placeholder=""Enter student address""");
            BeginWriteAttribute("required", " required=\"", 1137, "\"", 1148, 0);
            EndWriteAttribute();
            WriteLiteral("/>\n                </div>\n                <div class=\"form-group col-md-5\">\n                    <label>Student Code:</label>\n                    <input type=\"text\" name=\"StudentCode\" id=\"StudentCode\" class=\"form-control\" placeholder=\"Enter student code\"");
            BeginWriteAttribute("required", " required=\"", 1402, "\"", 1413, 0);
            EndWriteAttribute();
            WriteLiteral(@"/>
                </div>
                <div class=""form-group col-md-1"">
                    <div style=""float: right; display:inline-block"">
                        <input class=""btn btn-primary"" name=""submitButton"" id=""btnSave"" value=""Save"" type=""button""/>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<hr/>
<div class=""row"" style=""margin-top:32px; margin-bottom:32px"">
    <div class=""col-lg-3"">
        <div class=""input-group"">
            <input id=""inputSearch"" name=""inputSearch"" type=""text"" class=""form-control"" placeholder=""Search for..."">
            <div class=""input-group-append"">
                <button id=""searchButton"" class=""btn btn-outline-primary"" type=""button"">Go!</button>
            </div>
        </div><!-- /input-group -->
    </div><!-- /.col-lg-6 -->
</div><!-- /.row -->
<table id=""tableStudent"" class=""table table-bordered table-striped table-hover"">
    <thead class=""thead-dark"">
        <tr>
            <th align=""left"" scope=""");
            WriteLiteral(@"col"" class=""productth"">ID</th>
            <th align=""left"" scope=""col"" class=""productth"">Student Name</th>
            <th align=""left"" scope=""col"" class=""productth"">Student Lastname</th>
            <th align=""left"" scope=""col"" class=""productth"">Student Address</th>
            <th align=""left"" scope=""col"" class=""productth"">Student Code</th>
            <th align=""left"" scope=""col"" class=""productth"">Edition</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 63 "/home/kotoha/RiderProjects/Lab11/Lab11/Views/Student/Index.cshtml"
         foreach (var item in Model)
        {
            if (item.IsActive)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td align=\"left\" class=\"prtoducttd\">");
#nullable restore
#line 68 "/home/kotoha/RiderProjects/Lab11/Lab11/Views/Student/Index.cshtml"
                                                   Write(item.StudentId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td align=\"left\" class=\"prtoducttd\">");
#nullable restore
#line 69 "/home/kotoha/RiderProjects/Lab11/Lab11/Views/Student/Index.cshtml"
                                                   Write(item.StudentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td align=\"left\" class=\"prtoducttd\">");
#nullable restore
#line 70 "/home/kotoha/RiderProjects/Lab11/Lab11/Views/Student/Index.cshtml"
                                                   Write(item.StudentLastname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td align=\"left\" class=\"prtoducttd\">");
#nullable restore
#line 71 "/home/kotoha/RiderProjects/Lab11/Lab11/Views/Student/Index.cshtml"
                                                   Write(item.StudentAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td align=\"left\" class=\"prtoducttd\">");
#nullable restore
#line 72 "/home/kotoha/RiderProjects/Lab11/Lab11/Views/Student/Index.cshtml"
                                                   Write(item.StudentCode);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                    <td align=""left"" class=""prtoducttd"">
                        <a class=""btn btn-warning btnEdit text-white mx-1"">
                            <i class=""fas fa-edit""></i> Edit
                        </a>
                        <a class=""btn btn-danger btnDelete text-white mx-1"">
                            <i class=""fas fa-trash-alt""></i> Delete
                        </a>
                    </td>

                </tr>
");
#nullable restore
#line 83 "/home/kotoha/RiderProjects/Lab11/Lab11/Views/Student/Index.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<!-- The modal -->
<div class=""modal fade"" id=""flipFlop"" tabindex=""-1"" role=""dialog"" aria-labelledby=""modalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""modalLabel"">Modal Title</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <input type=""hidden"" id=""inputId""/>
                <div class=""form-group"">
                    <label>Student code:</label>
                    <input class=""form-control"" type=""text"" id=""inputCode"" placeholder=""student code"" readonly/>
                </div>
                <div class=""form-group"">
                        <label>Student Name:</label>
                    <input class=""form-control"" type=""text"" id=""i");
            WriteLiteral(@"nputName"" placeholder=""student name""/>
                    </div>
                    <div class=""form-group"">
                        <label>Student Last name:</label>
                        <input class=""form-control"" type=""text"" id=""inputLastName"" placeholder=""student lastname""/>
                    </div>
                    <div class=""form-group"">
                        <label>Student address:</label>
                        <input class=""form-control"" type=""text"" id=""inputAddress"" placeholder=""student address""/>
                    </div>
                    
                <div class=""form-group"">
                    <button id=""btnUpdateStudent"" class=""btn btn-outline-success"">Update</button>
                </div>
            </div>");
            WriteLiteral("        </div>\n    </div>\n</div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(function () {
            //LoadData();
            $(""#btnUpdateStudent"").click(function() {
              let student = {
                  ""studentId"": parseInt($(""#inputId"").val()),
                  ""studentName"":$(""#inputName"").val(),
                  ""studentLastname"":$(""#inputLastName"").val(),
                  ""studentCode"":parseInt($(""#inputCode"").val()),
                  ""studentAddress"":$(""#inputAddress"").val()
              };
              console.log(""el estudiante a actualizar"");
              console.log(student);
              $.ajax({
                type: ""POST"",
                url: """);
#nullable restore
#line 153 "/home/kotoha/RiderProjects/Lab11/Lab11/Views/Student/Index.cshtml"
                 Write(Url.Action("UpdateStudent"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
                data: JSON.stringify(student),
                dataType: ""json"",
                contentType:""application/json; charset=utf-8"",
                success: function(response) {
                  console.log(response);
                  if (response){
                      $(""#success-alert"").alert();
                      LoadData();
                      $(""#flipFlop"").modal('hide');
                  }
                  $(""#error-alert"").alert();
                },
                error: function() {
                    $(""#error-alert"").alert();
                  alert(""no se pudo actualizar al estudiante"")
                }
              })
            });
            $(document).on(""click"","".deleteBtn"",function() {
              var rowSelected = $(this).closest('tr').index();
              console.log(rowSelected);
              var array = [];
              $(""#tableStudent tr"").find(""td:first-child"").each(function(data) {
                array.push($(this).html());
              });
  ");
                WriteLiteral("            console.log(\"la entidad seleccionada\"+array[rowSelected]);\n              $.ajax({\n              type:\"DELETE\",\n              url: \"");
#nullable restore
#line 182 "/home/kotoha/RiderProjects/Lab11/Lab11/Views/Student/Index.cshtml"
               Write(Url.Action("DeleteStudent"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
              data: JSON.stringify(array[rowSelected]),
              dataType: ""json"",
              contentType:""application/json; charset=utf-8"",
              success: function() {
                  
              },
              error: function() {
                  alert(""no se pudo borrar el usuario"");
              }
              })
            });
            $(document).on(""click"","".btnEdit"",function () {
                $(""#flipFlop"").modal('show');
                var row = $(this).closest('tr').index();
                console.log(row);
                //console.log(Model[0]);
                var array = [];
                $(""#tableStudent tr"").find(""td:first-child"").each(function (data) {
                   // console.log($(this).html())
                    array.push($(this).html());
                });
                console.log(""la entidad id""+array[row]);
                $.ajax({
                    type: ""POST"",
                    url: """);
#nullable restore
#line 207 "/home/kotoha/RiderProjects/Lab11/Lab11/Views/Student/Index.cshtml"
                     Write(Url.Action("GetStudentById"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
                    data: JSON.stringify(array[row]),
                    dataType: ""json"",
                    contentType: ""application/json; charset=utf-8"",
                    success: function (response) {
                        console.log(""gg"");
                        console.log(response);
                        $(""#inputId"").val(response.studentId);
                        $(""#inputName"").val(response.studentName);
                        $(""#inputLastName"").val(response.studentLastname);
                        $(""#inputCode"").val(response.studentCode);
                        $(""#inputAddress"").val(response.studentAddress);
                    },
                    error: function () {
                        alert(""No se encontro al estudiante"");
                    }
                });
                return false;
            });

            $(""#searchButton"").click(function () {
                var studentParam = $(""#inputSearch"").val();
                $.ajax({
                    typ");
                WriteLiteral("e: \"POST\",\n                    url: \"");
#nullable restore
#line 231 "/home/kotoha/RiderProjects/Lab11/Lab11/Views/Student/Index.cshtml"
                     Write(Url.Action("FilterByNameOrLastName"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
                    data: JSON.stringify(studentParam),
                    dataType: ""json"",
                    contentType: ""application/json; charset=utf-8"",
                    success: function (response) {
                        $(""#tableStudent tbody tr"").remove();
                        console.log(response);
                        var items = '';
                    $.each(response, function (i, item) {
                        var rows = ""<tr>""
                            + ""<td class='prtoducttd'>"" + item.studentId + ""</td>""
                            + ""<td class='prtoducttd'>"" + item.studentName + ""</td>""
                            + ""<td class='prtoducttd'>"" + item.studentLastname + ""</td>""
                            + ""<td class='prtoducttd'>"" + item.studentAddress + ""</td>""
                            + ""<td class='prtoducttd'>"" + item.studentCode + ""</td>""
                            + ""<td class='prtoducttd'>"" +
                             ""<a class='btn btn-warning btnEdit text-wh");
                WriteLiteral(@"ite mx-1'>"" +
                              ""<i class='fas fa-edit'></i> Edit"" +
                               ""</a>"" +
                                ""<a class='btn btn-danger btnDelete text-white mx-1'>"" +
                                 ""<i class='fas fa-trash-alt'></i> Delete</a>"" +
                                  ""</td>""
                                  +""</tr>"";
                        $(""#tableStudent tbody"").append(rows);
                    });
                    },
                    error: function () {
                        alert(""No se encontro al estudiante"");
                    }
                });
                return false;
            });

            $(""#btnSave"").click(function () {
                let student = {
                    ""studentName"": $(""#StudentName"").val(),
                    ""studentLastname"": $(""#StudentLastName"").val(),
                    ""studentCode"": $(""#StudentCode"").val(),
                    ""studentAddress"": $(""#StudentAddress"").val()
             ");
                WriteLiteral("   };\n                console.log(student);\n                $.ajax({\n                    type: \"POST\",\n                    url: \'");
#nullable restore
#line 274 "/home/kotoha/RiderProjects/Lab11/Lab11/Views/Student/Index.cshtml"
                     Write(Url.Action("CreateStudent"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                    data: JSON.stringify(student),
                    dataType: ""json"",
                    contentType: ""application/json; charset=utf-8"",
                    success: function (data) {
                        console.log(data);
                        LoadData();
                    },
                    error: function () {
                        alert(""Error while inserting data"");
                    }
                });
                return false;
            });

        });

        function LoadData() {
            $(""#tableStudent tbody tr"").remove();
            $.ajax({
                type: 'GET',
                url: '");
#nullable restore
#line 295 "/home/kotoha/RiderProjects/Lab11/Lab11/Views/Student/Index.cshtml"
                 Write(Url.Action("GetStudents"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                dataType: 'json',
                success: function (data) {
                    var items = '';
                    $.each(data, function (i, item) {
                        var rows = ""<tr>""
                                                    + ""<td class='prtoducttd'>"" + item.studentId + ""</td>""
                                                    + ""<td class='prtoducttd'>"" + item.studentName + ""</td>""
                                                    + ""<td class='prtoducttd'>"" + item.studentLastname + ""</td>""
                                                    + ""<td class='prtoducttd'>"" + item.studentAddress + ""</td>""
                                                    + ""<td class='prtoducttd'>"" + item.studentCode + ""</td>""
                                                    + ""<td class='prtoducttd'>"" +
                                                     ""<a class='btn btn-warning btnEdit text-white mx-1'>"" +
                                                      ""<i class='fas fa");
                WriteLiteral(@"-edit'></i> Edit"" +
                                                       ""</a>"" +
                                                        ""<a class='btn btn-danger btnDelete text-white mx-1'>"" +
                                                         ""<i class='fas fa-trash-alt'></i> Delete</a>"" +
                                                          ""</td>""
                                                          +""</tr>"";
                        $(""#tableStudent tbody"").append(rows);
                    });
                },
                error: function (ex) {
                    var r = jQuery.parseJSON(response.responseText);
                    alert(""Message:"" + r.Message);
                    alert(""StackTrace:"" + r, StackTrace);
                    alert(""ExceptionType:"" + r.ExceptionType);
                }
            });
            return false;
        }
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Lab11.Models.StudentModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
