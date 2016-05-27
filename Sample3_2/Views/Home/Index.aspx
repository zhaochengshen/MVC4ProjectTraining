<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Index</title>
</head>
<body>
    <div>
        我是ViewData
        <%=Html.DropDownList("ViewDataList") %>


        我是ViewBag
        <%=Html.DropDownList("ViewBagList") %> 

    </div>
</body>
</html>
