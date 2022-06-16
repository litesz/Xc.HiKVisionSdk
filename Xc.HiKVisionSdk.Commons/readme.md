# 通用基础包

# 计划功能
 * [ ] 日志记录请求信息及错误信息

# 版本历史
## 1.0.4
### [更新]nuget
* Microsoft.Extensions.Hosting 3.1.22->6.0.1
* Microsoft.Extensions.Http 3.1.22->6.0.0
* Microsoft.Extensions.Options.ConfigurationExtensions 3.1.22->6.0.0

### [新增] Dictionaries
* [新增] `DoorEventSort`
* [新增] `EventCollection`
* [新增] `EventCollectionItem`
* [新增] `InstallLocation`
* [新增] `PlanStatus`
* [新增] `ResourceType`

### [更新] Enums
* [新增] `EventLevel`
* [新增] `HandleStatus`
* [新增] `SubscribeType`


======================================
## 1.0.3.220613
### 枚举
 * [新增] 枚举`Marriaged`婚姻状况
### HikVisionApiManager
 * [新增] `Task<HttpResponseMessage> PostAsync(string url, string bodyStr, decimal ver)`方法
### HikVisionApiManagerExtensions
 * [新增] `Task<HttpResponseMessage> PostAsync<T>(this IHikVisionApiManager manager, string url, T body, decimal ver)`方法

======================================