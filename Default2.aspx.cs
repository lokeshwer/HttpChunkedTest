using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.ContentType = "application/json";
        var test = int.Parse(Request.QueryString["count"]);
        var obj = new List<Test>() ;
        for (var i = 0; i < test; i++)
        {
            obj.Add(Test.Create());
        }
        
        var js = new JavaScriptSerializer {MaxJsonLength = int.MaxValue};

        Response.Write(js.Serialize(obj));
        Response.End();
    }
}

public class Test
{
    public static Test Create()
    {
        var t = new Test
                    {
                        Prop1 = Guid.NewGuid().ToString(),
                        Prop2 = Guid.NewGuid().ToString(),
                        Prop3 = Guid.NewGuid().ToString(),
                        Prop4 = Guid.NewGuid().ToString(),
                        Prop5 = Guid.NewGuid().ToString(),
                        Prop6 = Guid.NewGuid().ToString(),
                        Prop7 = Guid.NewGuid().ToString(),
                        Prop8 = Guid.NewGuid().ToString(),
                        Prop9 = Guid.NewGuid().ToString(),
                        Prop10 = Guid.NewGuid().ToString()
                    };
        return t;
    }

    public string Prop1 { get; set; }
    public string Prop2 { get; set; }
    public string Prop3 { get; set; }
    public string Prop4 { get; set; }
    public string Prop5 { get; set; }
    public string Prop6 { get; set; }
    public string Prop7 { get; set; }
    public string Prop8 { get; set; }
    public string Prop9 { get; set; }
    public string Prop10 { get; set; }
}