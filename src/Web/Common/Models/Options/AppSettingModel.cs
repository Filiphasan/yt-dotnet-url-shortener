namespace Web.Common.Models.Options;

public class AppSettingModel
{
    public const string SectionName = "Settings";

    public required AppSettingMongoDbModel MongoDb { get; set; }
    public required AppSettingRedisModel Redis { get; set; }
}

public class AppSettingMongoDbModel
{
    public required string User { get; set; }
    public required string Password { get; set; }
    public required string Host { get; set; }
    public required int Port { get; set; }
    public required string Database { get; set; }
}

public class AppSettingRedisModel
{
    public required string Host { get; set; }
    public required int Port { get; set; }
    public required string Password { get; set; }
    public required int Database { get; set; }
}