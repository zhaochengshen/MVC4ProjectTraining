<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<Sample1_1.Models.HelloPerson>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Hello</title>
</head>
<body>
    <div>
        <% using (Html.BeginForm("SendHello", "HelloWorld"))  
           { %>
          请输入您的名字：<%= Html.TextBoxFor(x=>x.Name)%>
        请输入您说的内容：<%= Html.TextBoxFor(x=>x.Say) %>
        
        
        

        <input name="submit" type="submit" value="提交">
        <%
           } %>
    </div>
</body>
</html>
