using Newtonsoft.Json.Linq;

public class Fonction
{
    public static List<PointF> getData()
    {
        List<PointF> resp = new List<PointF>();
        string json = File.ReadAllText("save.json");
        var loadedData = JArray.Parse(json);
        foreach (var item in loadedData)
        {
            string nom = item["Nom"].ToString();
            if (nom.Equals("points"))
            {
                var points = item["points"];
                List<PointF>? list = points.ToObject<List<PointF>>();
                resp.AddRange(list);
            }
        }
        return resp;
    }
}