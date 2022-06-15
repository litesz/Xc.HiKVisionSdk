# 通用基础包

# 计划功能
 * [ ] 日志记录请求信息及错误信息

# 版本历史
## 1.0.3.220613
### 枚举
 * [新增] 枚举`Marriaged`婚姻状况
### HikVisionApiManager
 * [新增] `Task<HttpResponseMessage> PostAsync(string url, string bodyStr, decimal ver)`方法
### HikVisionApiManagerExtensions
 * [新增] `Task<HttpResponseMessage> PostAsync<T>(this IHikVisionApiManager manager, string url, T body, decimal ver)`方法

======================================