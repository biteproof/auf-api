namespace AufApi.Data.Queries
{
    public class GitlabQueries
    {
        public const string GetGroupsInfo = @"SELECT
                                                   group_id    AS Id,
                                                   name        AS Name,
                                                   description AS Description,
                                                   url         AS Url
                                            FROM gitlab.groups;";

        public const string GetUsersInfo = @"SELECT id         AS Id,
                                                   name       AS Name,
                                                   username   AS Username,
                                                   icon       AS IconUrl,
                                                   Url        AS Url,
                                                   state      AS State,
                                                   updated_at AS UpdatedAt
                                            FROM gitlab.users;";

        public const string GetProjectsInfo = @"SELECT 
                                                   project_id  AS ProjectId,
                                                   group_id    AS GroupId,
                                                   name        AS Name,
                                                   description AS Description,
                                                   created_at  AS CreatedAt
                                            FROM gitlab.projects;";
    }
}