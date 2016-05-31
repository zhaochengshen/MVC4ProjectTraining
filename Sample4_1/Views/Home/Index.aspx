<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<Sample4_1.Models.Student>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Index</title>
</head>
<body>
    <div>
        <length>学生信息</length>
        <br />
        <p><b>姓名：</b><%=Model.Name %></p>
        <p><b>年龄：</b><%=Model.Age %></p>

    </div>
</body>
</html>
