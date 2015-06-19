# What's CSJSONBacklog

CSJSONBacklog is a library of Backlog API v2 written in C#.

*   http://www.backlog.jp/
*   http://developer.nulab-inc.com/docs/

NuGet package is available! https://www.nuget.org/packages/CSJSONBacklog/

## Features of CSJSONBacklog

Development is in step by step progress.

https://github.com/mtaniuchi/CSJSONBacklog/tree/master

## Sample1 - get project list
```cs
// project list
var projectCommunicator = new ProjectCommunicator(spaceName, apiKey);
var projects = projectCommunicator.GetProjectList().ToList();
foreach (var project in projects)
{
    Debug.WriteLine(project);

    // custom fields
    var customFieldList = projectCommunicator.GetCustomFieldList(project.ProjectKey);
    foreach (var customField in customFieldList)
    {
        Debug.WriteLine(customField);
    }
}
```

## Sample2 - get issue list
```
var param = new QueryIssueParameters
{
    ProjectIds = new List<int> { project.Id },
    ParentChild = ParentChild.All,
    Offset = 0,
    Count = 100,// per 100 max
    Order = Order.Asc,
    Sort = Sort.Created
};
for (param.Offset = 0; param.Offset < count; param.Offset += 100)
{
    var issues = issueCommunicator.GetIssues(param).ToList();
    foreach (var issue in issues)
    {
        Debug.WriteLine(issue);
    }
}
```

## The Author
mtaniuchi
