namespace MRecipes.Storage.Utils;

public static class PathDB
{   
    public static string GetPath()
    {
        const string DB_NAME = "MRecipesDb.db";
        string pathDbSqlite;

        if(DeviceInfo.Platform == DevicePlatform.Android)
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            pathDbSqlite = Path.Combine(path, DB_NAME);
        }
        else if(DeviceInfo.Platform == DevicePlatform.iOS)
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            pathDbSqlite = Path.Combine(path, "..", "Library", DB_NAME);
        }
        else
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            pathDbSqlite = Path.Combine(path, DB_NAME);
        }

        return pathDbSqlite;
    }
}
